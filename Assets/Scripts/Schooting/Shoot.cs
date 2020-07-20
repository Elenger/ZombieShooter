using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private Transform _bulletSpawner;
    [SerializeField] private Gun _gunType;
    private int _bulletCount;
    private int _currentBulletCount;
    private float _shootingSpeed;
    private float _reloadTime;
    private float _delay;
    private Pool<PoolObject> pool;
    public Bullet bulletType;

    private void Start()
    {
        GunChange(_gunType);
        pool = new Pool<PoolObject>(new PrefabFactory<PoolObject>(_bulletPrefab));
    }

    void Update()
    {
        float currentTime = Time.time;
        if (Input.GetButton("Fire1") && currentTime >= _delay)
        {
            GameObject newBullet =  SpawnBullet();
            AccelerateBullet(newBullet);

            _currentBulletCount -= 1;
            if (_currentBulletCount == 0)
            {
                _delay = currentTime + _reloadTime;
                _currentBulletCount = _bulletCount;
            }
            else
            {
                _delay = currentTime + _shootingSpeed;
            }
        }
    }

    public void GunChange(Gun gun)
    {
        _reloadTime = gun.reloadTime;
        _shootingSpeed = gun.shootingSpeed;
        _bulletCount = gun.bulletCount;
        _currentBulletCount = _bulletCount;
    }

    private GameObject SpawnBullet()
    {
        PoolObject poolObject = pool.Take();
        GameObject bullet = poolObject.gameObject;
        bullet.SetActive(true);
        bullet.GetComponent<PoolObject>().pool = pool;

        return bullet;
    }

    private void AccelerateBullet(GameObject bullet)
    {
        Rigidbody rigidbody = bullet.GetComponent<Rigidbody>();
        bullet.transform.position = _bulletSpawner.position;
        bullet.transform.rotation = Quaternion.identity;
        rigidbody.velocity = _bulletSpawner.forward * bulletType.flightSpeed;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private Transform _bulletSpawner;
    [SerializeField] private Gun _gun;
    private int _bulletCount;
    private int _currentBulletCount;
    private float _shootingSpeed;
    private float _reloadTime;
    private float _delay;

    private void Start()
    {
        GunChange(_gun);
    }

    void Update()
    {
        float currentTime = Time.time;
        if (Input.GetButton("Fire1") && currentTime >= _delay)
        {
            Instantiate(_bulletPrefab, _bulletSpawner.position, _bulletSpawner.rotation);
            Debug.Log("Bullet was shooted");
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
}

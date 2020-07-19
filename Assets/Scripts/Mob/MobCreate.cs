using UnityEngine;

public class MobCreate : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private GameObject[] _mobPrefabs;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private BossCreate _bossCreate;
    [SerializeField] private CharacterHealth _characterHealth;
    private Pool<PoolObject> pool;

    private void Start()
    {
        pool = new Pool<PoolObject>(new PrefabFactory<PoolObject>(null, _mobPrefabs));
    }

    public void Create(int mobCountInWave)
    {
        for (int count = 0; count < mobCountInWave; count++)
        {
            Vector3 randomSpawnPoint = _spawnPoints[Random.Range(0, _spawnPoints.Length)].position;

            PoolObject poolObject = pool.Take();
            GameObject mob = poolObject.gameObject;

            mob.SetActive(true);
            mob.transform.position = randomSpawnPoint;
            mob.GetComponent<PoolObject>().pool = pool; //need optimization
            mob.GetComponent<MobNavMesh>().target = _target;
            mob.GetComponent<MobDeath>().bossCreate = _bossCreate;
            MobAttack mobAttack = mob.GetComponent<MobAttack>();
            mobAttack.target = _target;
            mobAttack.characterHealth = _characterHealth;
        }
    }
}

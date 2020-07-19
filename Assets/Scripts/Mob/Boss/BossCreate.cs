using UnityEngine;

public class BossCreate : MonoBehaviour
{
    [SerializeField] private MobCreate _mobCreate;
    [SerializeField] private GameObject[] _bossPrefabs;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private WaveController _waveController;
    [SerializeField] private Transform _target;
    [SerializeField] private CharacterHealth _characterHealth;
    [HideInInspector] public int mobCountInWave;
    [HideInInspector] public int waveNumber;

    public void CheckBossAvailable()
    {
        mobCountInWave -= 1;
        if (mobCountInWave == 0) Create();
    }

    private void Create()
    {
        GameObject currentBoss = _bossPrefabs[waveNumber];
        Vector3 randomSpawnPoint = _spawnPoints[Random.Range(0, _spawnPoints.Length)].position;

        GameObject boss = Instantiate(currentBoss, randomSpawnPoint, Quaternion.identity);

        boss.GetComponent<BossDeath>().waveController = _waveController;
        boss.GetComponent<MobNavMesh>().target = _target;
        MobAttack mobAttack = boss.GetComponent<MobAttack>();
        mobAttack.target = _target;
        mobAttack.characterHealth = _characterHealth;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobCreation : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private GameObject[] _mobPrefabs;
    [SerializeField] private Transform[] _spawnPoints;
    private int _mobCountInWave = 10;
    private int _waveNumber;

    private void Start()
    {
        StartWave();    
    }

    private void StartWave()
    {
        for (int count = 0; count < _mobCountInWave; count++)
        {
            GameObject randomMobPrefab = _mobPrefabs[Random.Range(0, _mobPrefabs.Length)];
            Vector3 randomSpawnPoint = _spawnPoints[Random.Range(0, _spawnPoints.Length)].position;

            GameObject mob = Instantiate(randomMobPrefab, randomSpawnPoint, Quaternion.identity);
            mob.GetComponent<MobNavMesh>().target = _target;
            Debug.Log("Mob spawned");
        }
    }
    
}

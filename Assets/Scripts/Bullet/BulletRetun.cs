using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletRetun : MonoBehaviour
{
    [SerializeField] private PoolObject _poolObject;
    private float _enableTime;
    private const float _bulletLifeTime = 5f;

    private void Update()
    {
        if(_enableTime + _bulletLifeTime > Time.time)
        {
            _poolObject.ReturnToPool();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        _poolObject.ReturnToPool();
    }

    private void OnEnable()
    {
        _enableTime = Time.time;
    }
}

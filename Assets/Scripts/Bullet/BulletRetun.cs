using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletRetun : MonoBehaviour
{
    [SerializeField] PoolObject _poolObject;

    private void OnTriggerEnter(Collider other)
    {
        _poolObject.ReturnToPool();
    }
}

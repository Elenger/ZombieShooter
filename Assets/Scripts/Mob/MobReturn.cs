using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobReturn : MonoBehaviour
{
    [SerializeField] private PoolObject _poolObject;

    private void ReturnToPool()
    {
        _poolObject.ReturnToPool();
    }
}

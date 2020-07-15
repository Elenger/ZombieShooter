using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletAcceleration : MonoBehaviour
{
    [SerializeField] private Bullet _bullet;
    [SerializeField] private Rigidbody _rigidbody;

    void Start()
    {
        _rigidbody.AddRelativeForce(Vector3.forward * _bullet.flightSpeed);
    }
}

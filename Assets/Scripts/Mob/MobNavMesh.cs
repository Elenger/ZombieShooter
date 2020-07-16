using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MobNavMesh : MonoBehaviour
{
    [SerializeField] private NavMeshAgent _navMeshAgent;
    public Transform target;

    private void Update()
    {
        _navMeshAgent.SetDestination(target.position);
    }  
}

using UnityEngine;
using UnityEngine.AI;

public class MobNavMesh : MonoBehaviour
{
    [SerializeField] private MobInfo _mobInfo;
    [SerializeField] private NavMeshAgent _navMeshAgent;
    [HideInInspector] public Transform target;

    private void Start()
    {
        _navMeshAgent.speed = _mobInfo.GetSpeed();
    }
    private void Update()
    {
        _navMeshAgent.SetDestination(target.position);
    }  
}

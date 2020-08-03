using UnityEngine;
using UnityEngine.AI;

public class MobNavMesh : MonoBehaviour
{
    [SerializeField] private MobInfo _mobInfo;
    [SerializeField] private NavMeshAgent _navMeshAgent;
    [SerializeField] private MobAnimation _mobAnimation;
    [HideInInspector] public Transform target;

    private void Start()
    {
        float speed = _mobInfo.GetSpeed();
        _navMeshAgent.speed = speed;
        _navMeshAgent.stoppingDistance = 1.5f;

        _mobAnimation.Move(speed);
    }
    private void Update()
    {
        _navMeshAgent.SetDestination(target.position);

        if (Vector3.Distance(target.position, transform.position) > 1.6f)
        {
            _mobAnimation.MobMoving(true);
        }
        else _mobAnimation.MobMoving(false);
    }  
}

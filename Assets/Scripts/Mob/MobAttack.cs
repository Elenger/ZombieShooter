using UnityEngine;

public class MobAttack : MonoBehaviour
{
    private const float _attackDistance = 5f;
    private const float _attackDelay = 2.5f;
    [SerializeField] private MobInfo _mobInfo;
    private int _damage;
    private float _nextAttackTime;
    [HideInInspector] public Transform target;
    [HideInInspector] public CharacterHealth characterHealth;

    private void Start()
    {
        _damage = _mobInfo.GetDamage();
    }

    private void Update()
    {
        float currentTime = Time.time;
        if (currentTime >= _nextAttackTime)
        {
            Vector3 targetPosition = target.position;
            float _distanceDifference = Vector3.Distance(targetPosition, transform.position);

            if (_distanceDifference <= _attackDistance)
            {
                characterHealth.TakeDamage(_damage);
                _nextAttackTime = currentTime + _attackDelay;
            }
        }
    }
}

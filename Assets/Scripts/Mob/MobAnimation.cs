using UnityEngine;

public class MobAnimation : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    #region MovementAnimation
    public void Move(float speed)
    {
        _animator.SetFloat("MobSpeed", speed);
    }

    public void MobMoving(bool isMoving)
    {
        _animator.SetBool("IsMoving", isMoving);
    }
    #endregion

    #region AttackAnimation
    public void Attack()
    {
        int randomAttack = Random.Range(1, 3);
        _animator.SetInteger("IsAttacking", randomAttack);
    }

    private void AttackClipEnding()
    {
        _animator.SetInteger("IsAttacking", 0);
    }

    private void TargetIsDead()
    {
        _animator.SetBool("TargetIsDead", true);
    }
    #endregion

    public void Death()
    {
        _animator.SetBool("IsDead", true);
    }

    private void OnEnable()
    {
        EventHub.current.CharacterLifeStatusChanged += TargetIsDead;
    }

    private void OnDisable()
    {
        EventHub.current.CharacterLifeStatusChanged -= TargetIsDead;
    }
}

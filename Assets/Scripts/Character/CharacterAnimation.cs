using UnityEngine;

public class CharacterAnimation : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    public void CharacterMoving(bool isMoving)
    {
        _animator.SetBool("IsMoving", isMoving);
    }

    public void Death()
    {
        _animator.SetBool("IsDead", true);
    }
}

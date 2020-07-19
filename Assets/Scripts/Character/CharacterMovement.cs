using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    private const float _speed = 6f;

    private void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if (direction.magnitude >= 0.1f)
        {
            Vector3 move = direction * Time.deltaTime * _speed;
            _rigidbody.MovePosition(transform.position + move);
        }
    }
}
using UnityEngine;

public class CharacterAim : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private LayerMask _layerMask;

    private void Update()
    {
        Ray rayCamera = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(rayCamera, out RaycastHit hit, Mathf.Infinity, _layerMask))
        {
            Vector3 differenceMouseToCharacter = hit.point - transform.position;
            differenceMouseToCharacter.y = 0f;

            Quaternion newRotation = Quaternion.LookRotation(differenceMouseToCharacter);
            _rigidbody.MoveRotation(newRotation);
        }
    }
}

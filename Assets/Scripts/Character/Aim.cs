using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;

    private void Update()
    {
        Ray rayCamera = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(rayCamera, out RaycastHit hit))
        {
            Vector3 differenceMouseToCharacter = hit.point - transform.position;
            differenceMouseToCharacter.y = 0f;

            Quaternion newRotation = Quaternion.LookRotation(differenceMouseToCharacter);
            _rigidbody.MoveRotation(newRotation);

            //transform.rotation = Quaternion.RotateTowards(transform.rotation, newRotation, 10f);
        }
    }
}

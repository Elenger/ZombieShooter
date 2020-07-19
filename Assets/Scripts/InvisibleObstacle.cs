using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisibleObstacle : MonoBehaviour
{
    [SerializeField] private LayerMask _layerMask;
    [SerializeField] Transform _target;

    private void Update()
    {
        Ray rayCamera = Camera.main.ScreenPointToRay(_target.position);

        if (Physics.Raycast(rayCamera, out RaycastHit hit, _layerMask))
        {
            Debug.Log(hit);
            hit.transform.gameObject.GetComponent<MeshRenderer>().material.color = hit.transform.gameObject.GetComponent<MeshRenderer>().material.color * 0.5f;
        }
    }
}

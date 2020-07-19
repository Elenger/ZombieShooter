using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisibleObstacle : MonoBehaviour
{
    [SerializeField] private LayerMask _layerMask;
    [SerializeField] Transform _target;
    [SerializeField] private Transform _mainCamera;
    private GameObject _previousObject;
    private Material _previousMaterial;

    private void Update()
    {
        Vector3 cameraPosition = _mainCamera.position;
        Vector3 directionToCharacter = _target.position - cameraPosition;

        Ray rayToCharacter = new Ray(cameraPosition, directionToCharacter);


        if (Physics.Raycast(rayToCharacter, out RaycastHit hit, Mathf.Infinity))
        {
            if (hit.transform.TryGetComponent(out Renderer renderer))
            {
                if (_previousObject != hit.transform.gameObject && _previousObject != null)
                {
                    _previousMaterial.SetFloat("_Opacity", 1f);

                    _previousObject = hit.transform.gameObject;
                    _previousMaterial = renderer.material;
                    _previousMaterial.SetFloat("_Opacity", 0.8f);
                }
                else if (_previousObject != hit.transform.gameObject)
                {
                    _previousObject = hit.transform.gameObject;
                    _previousMaterial = _previousObject.GetComponent<Renderer>().material;
                    _previousMaterial.SetFloat("_Opacity", 0.8f);
                }
            }
            else if (_previousObject != null && _previousObject != hit.transform.gameObject)
            {
                _previousMaterial.SetFloat("_Opacity", 1f);
            }
        }
    }
}

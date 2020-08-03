using UnityEngine;

public class MobInitialization : MonoBehaviour
{
    [SerializeField] private CapsuleCollider _collider;
    [SerializeField] private MobNavMesh _mobNavMesh;
    [SerializeField] private MobAttack _mobAttack;

    private void OnEnable()
    {
        _mobNavMesh.enabled = true;
        _collider.enabled = true;
        _mobAttack.enabled = true;
    }

    public void Deactivate()
    {
        _mobNavMesh.enabled = false;
        _collider.enabled = false;
        _mobAttack.enabled = false;
    }
}

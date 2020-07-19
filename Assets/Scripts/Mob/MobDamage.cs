using UnityEngine;

public class MobDamage : MonoBehaviour
{
    [SerializeField] MobHealth _mobHealth;

    private void OnTriggerEnter(Collider other)
    {
        int bulletDamage = other.GetComponent<BulletInfo>().damage;
        _mobHealth.TakeDamage(bulletDamage);
    }
}

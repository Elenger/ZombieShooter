using UnityEngine;

public class BulletInfo : MonoBehaviour
{
    [SerializeField] private Bullet _bullet;
    [HideInInspector] public int damage;

    void Start()
    {
        damage = _bullet.damage;
    }
}

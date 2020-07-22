using UnityEngine;

public class MobInfo : MonoBehaviour
{
    [SerializeField] private Mob _mob;
    private int _damage;
    private int _health;
    private float _speed;

    void Start()
    {
        _damage = _mob.damage;
        _health = _mob.health;
        _speed = _mob.speed;
    }

    public int GetDamage()
    {
        return _damage;
    }

    public int GetHealth()
    {
        return _health;
    }

    public float GetSpeed()
    {
        return _speed;
    }
}

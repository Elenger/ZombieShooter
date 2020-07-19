using UnityEngine;

public class MobHealth : MonoBehaviour
{
    [SerializeField] private MobInfo _mobInfo;
    [SerializeField] private Death _death;
    private int _health;

    void Start()
    {
        _health = _mobInfo.GetHealth();
    }

    public void TakeDamage(int damage)
    {
        _health -= damage;

        if (_health < 1) _death.onDeath();
    }

    public void RestoreHealth()
    {
        _health = _mobInfo.GetHealth();
    }
}

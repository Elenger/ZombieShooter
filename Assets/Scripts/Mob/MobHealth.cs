using UnityEngine;

public class MobHealth : MonoBehaviour
{
    [SerializeField] private MobInfo _mobInfo;
    [SerializeField] private Death _death;
    private int _health;

    void Start()
    {
        Intialization();
    }

    public void TakeDamage(int damage)
    {
        _health -= damage;

        if (_health < 1) _death.onDeath();
    }

    public void Intialization()
    {
        _health = _mobInfo.GetHealth();
    }
}

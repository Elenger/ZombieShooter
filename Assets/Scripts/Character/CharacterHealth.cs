using UnityEngine;

public class CharacterHealth : MonoBehaviour
{
    [SerializeField] CharacterDeath _characterDeath;
    private const int _defaultHealth = 100;
    private int _health;

    void Start()
    {
        Intialization();
    }

    public void TakeDamage(int damage)
    {
        _health -= damage;

        if (_health < 1) _characterDeath.Death();
    }

    public void Intialization()
    {
        _health = _defaultHealth;
    }
}

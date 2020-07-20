using UnityEngine;

public class CharacterHealth : MonoBehaviour
{
    [SerializeField] CharacterDeath _characterDeath;
    [SerializeField] private CharacterHealthBar _characterHealthBar;
    private const int _defaultHealth = 500;
    private int _health;

    void Start()
    {
        Intialization();
    }

    public void TakeDamage(int damage)
    {
        _health -= damage;

        _characterHealthBar.SetHealthBarValue(_health);

        if (_health < 1) _characterDeath.Death();
    }

    public void Intialization()
    {
        _health = _defaultHealth;
    }
}

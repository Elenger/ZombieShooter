using UnityEngine;
using UnityEngine.UI;

public class CharacterHealthBar : MonoBehaviour
{
    [SerializeField] Slider _sliderHealthBar;

    public void SetHealthBarValue(int health)
    {
        _sliderHealthBar.value = health;
    }
}

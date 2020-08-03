using TMPro;
using UnityEngine;

public class ShowMobCount : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _mobCount;
    private int _mobCountInWave;
    private int _currentMobCount;

    public void ShowCount()
    {
        _currentMobCount += 1;

        if (_currentMobCount != _mobCountInWave)
        {
            _mobCount.text = "Mob: " + _currentMobCount + "/" + _mobCountInWave;
        }
        else
        {
            _mobCount.text = "Boss coming...";
        }
    }

    public void SetMobCountInWave(int mobCountInWave)
    {
        _currentMobCount = 0;
        _mobCountInWave = mobCountInWave;
        _mobCount.text = "Mob: 0" + "/" + _mobCountInWave;
    }
}

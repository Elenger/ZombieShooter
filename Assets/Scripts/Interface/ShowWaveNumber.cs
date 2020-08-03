using TMPro;
using UnityEngine;

public class ShowWaveNumber : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _waveNumber;
    private int _maxWaveCount;

    public void ShowNumber(int waveNumber)
    {
        _waveNumber.text = "Wave: " + waveNumber + "/" + _maxWaveCount;
    }

    public void SetMaxWaveCount(int maxWaveCount)
    {
        _maxWaveCount = maxWaveCount;
        _waveNumber.text = "Wave: 0/" + maxWaveCount;
    }
}

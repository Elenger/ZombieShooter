using UnityEngine;

public class WaveController : MonoBehaviour
{
    private const int _waveCount = 3;
    private const int _mobCountIncrease = 5;
    [SerializeField] private BossCreate _bossCreate;
    [SerializeField] private MobCreate _mobCreate;
    [SerializeField] private GameObject _victoryPanel;
    private int _mobCountInWave = 10;
    private int _waveNumber = 0;

    private void Start()
    {
        StartWave();
    }

    public void StartWave()
    {
        if (_waveNumber == _waveCount)
        {
            _victoryPanel.SetActive(true);
            return;
        }

        _bossCreate.waveNumber = _waveNumber;
        _bossCreate.mobCountInWave = _mobCountInWave;

        _mobCreate.Create(_mobCountInWave);

        _waveNumber += 1;
        _mobCountInWave += _mobCountIncrease;
    }
}

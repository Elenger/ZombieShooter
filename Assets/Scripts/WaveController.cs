using UnityEngine;

public class WaveController : MonoBehaviour
{
    private const int _waveCount = 3;
    private const int _mobCountIncrease = 5;
    [SerializeField] private BossCreate _bossCreate;
    [SerializeField] private MobCreate _mobCreate;
    [SerializeField] private ShowWinPanel _showWinPanel;
    [SerializeField] private ShowWaveNumber _showWaveNumber;
    [SerializeField] private ShowMobCount _showMobCount;
    private int _mobCountInWave = 10;
    private int _waveNumber = 0;

    private void Start()
    {
        _showWaveNumber.SetMaxWaveCount(_waveCount);
        StartWave();
    }

    public void StartWave()
    {
        if (_waveNumber == _waveCount)
        {
            _showWinPanel.ShowWin();
            return;
        }

        _bossCreate.waveNumber = _waveNumber;
        _bossCreate.mobCountInWave = _mobCountInWave;

        _mobCreate.Create(_mobCountInWave);

        _waveNumber += 1;
        _showWaveNumber.ShowNumber(_waveNumber);

        _showMobCount.SetMobCountInWave(_mobCountInWave);
        _mobCountInWave += _mobCountIncrease;
    }
}

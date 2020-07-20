using UnityEngine;
public class BossDeath : Death
{
    public WaveController waveController;

    public override void onDeath()
    {
        waveController.StartWave();
        Destroy(gameObject);
    }
}

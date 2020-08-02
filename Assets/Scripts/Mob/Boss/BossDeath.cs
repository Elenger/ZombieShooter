using UnityEngine;
public class BossDeath : Death
{
    [SerializeField] private MobAnimation _mobAnimation;
    [SerializeField] private MobSound _mobSound;
    [SerializeField] private MobInitialization _mobInitialization;
    [HideInInspector] public WaveController waveController;

    public override void onDeath()
    {
        waveController.StartWave();

        _mobAnimation.Death();
        _mobSound.MobDeath_Sound();

        _mobInitialization.Deactivate();
    }

    private void Destroy()
    {
        Destroy(gameObject);
    }
}

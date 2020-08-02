using UnityEngine;
public class MobDeath : Death
{
    [SerializeField] private MobAnimation _mobAnimation;
    [SerializeField] private MobSound _mobSound;
    [SerializeField] private MobInitialization _mobInitialization;
    [HideInInspector] public BossCreate bossCreate;
    [HideInInspector] public ShowMobCount showMobCount;

    public override void onDeath()
    {
        bossCreate.CheckBossAvailable();

        _mobAnimation.Death();
        _mobSound.MobDeath_Sound();

        _mobInitialization.Deactivate();

        showMobCount.ShowCount();
    }
}

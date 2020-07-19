using UnityEngine;

public class MobDeath : Death
{
    [SerializeField] private PoolObject _poolObject;
    [HideInInspector] public BossCreate bossCreate;

    public override void onDeath()
    {
        bossCreate.CheckBossAvailable();
        _poolObject.ReturnToPool();
    }
}

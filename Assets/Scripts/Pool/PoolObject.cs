using UnityEngine;

public class PoolObject : MonoBehaviour
{
    public Pool<PoolObject> pool;

    public void ReturnToPool()
    {
        gameObject.SetActive(false);
        pool.Return(this);
    }
}

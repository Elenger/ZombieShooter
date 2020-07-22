using UnityEngine;

[CreateAssetMenu(fileName = "New gun", menuName = "Guns/Gun")]
public class Gun : ScriptableObject
{
    public int bulletCount;
    public float shootingSpeed;
    public float reloadTime;
}
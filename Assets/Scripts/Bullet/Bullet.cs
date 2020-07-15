using UnityEngine;


[CreateAssetMenu(fileName = "New bullet", menuName = "Bullets/Bullet")]
public class Bullet : ScriptableObject
{
    public float damage;
    public float flightSpeed;
}
using UnityEngine;


[CreateAssetMenu(fileName = "New bullet", menuName = "Bullets/Bullet")]
public class Bullet : ScriptableObject
{
    public int damage;
    public float flightSpeed;
}
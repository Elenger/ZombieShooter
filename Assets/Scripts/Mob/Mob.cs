using UnityEngine;

[CreateAssetMenu(fileName = "New mob", menuName = "Mobs/Mob")]
public class Mob : ScriptableObject
{
    public int health;
    public int damage;
    public float speed;
}
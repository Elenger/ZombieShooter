using UnityEngine;

public class MobSound : MonoBehaviour
{
    [SerializeField] private AudioSource _mobDeath_Sound;
    [SerializeField] private AudioSource _mobAttack_Sound;

    public void MobDeath_Sound()
    {
        if (!_mobDeath_Sound.isPlaying) _mobDeath_Sound.Play();
    }

    public void MobAttack_Sound()
    {
        _mobAttack_Sound.Play();
    }

}

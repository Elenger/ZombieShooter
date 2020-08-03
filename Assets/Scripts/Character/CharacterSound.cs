using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSound : MonoBehaviour
{
    [SerializeField] private AudioSource _characterDeath_Sound;
    [SerializeField] private AudioSource _characterShot_Sound;

    public void CharacterDeath_Sound()
    {
        if (!_characterDeath_Sound.isPlaying) _characterDeath_Sound.Play();
    }

    public void CharacterShot_Sound()
    {
        _characterShot_Sound.Play();
    }
}

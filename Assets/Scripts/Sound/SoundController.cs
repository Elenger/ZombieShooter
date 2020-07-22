using UnityEngine;
using UnityEngine.Audio;

public class SoundController : MonoBehaviour
{
    [SerializeField] private AudioSource _characterDeath_Sound;
    [SerializeField] private AudioMixerGroup _mixerGroup;

    public void CharacterDeath_Sound()
    {
        if (!_characterDeath_Sound.isPlaying) _characterDeath_Sound.Play();
    }

    public void ChangeSoundVolume(float volume)
    {
        _mixerGroup.audioMixer.SetFloat("MasterVolume", Mathf.Log10(volume)*20);
        PlayerPrefs.SetFloat("MasterVolume", enabled ? 1 : 0);
    }
}

using UnityEngine;
using UnityEngine.Audio;

public class SoundVolume : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _mixerGroup;

    public void ChangeSoundVolume(float volume)
    {
        _mixerGroup.audioMixer.SetFloat("MasterVolume", Mathf.Log10(volume)*20);
        PlayerPrefs.SetFloat("MasterVolume", enabled ? 1 : 0);
    }
}

using UnityEngine;
using UnityEngine.Audio;

public class AudioSetting : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _mixer;
    [SerializeField] private string _nameMixer;

    public void ChangeVolume(float volume)
    {
        _mixer.audioMixer.SetFloat(_nameMixer, Mathf.Log10(volume) * 20);
    }
}
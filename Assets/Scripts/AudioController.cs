using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioController : MonoBehaviour
{
    private const string MasterVolumeParam = "MasterVolume";
    private const string MusicVolumeParam = "MusicVolume";
    private const string ButtonVolumeParam = "ButtonsVolume";
    private const float MaxVolume = 0;
    private const float MinVolume = -80;

    [SerializeField] private AudioMixerGroup _mixer;
    [SerializeField] private List<AudioClip> _audioClips;
    private AudioSource _audioSource;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void ToggleMaster(bool isMuted)
    {
        ChangeVolume(MasterVolumeParam, isMuted ? MaxVolume : MinVolume);
    }

    public void MasterChangeVolume(float volume)
    {
        ChangeVolume(MasterVolumeParam, volume);
    }

    public void MusicChangeVolume(float volume)
    {
        ChangeVolume(MusicVolumeParam, volume);
    }

    public void ButtonChangeVolume(float volume)
    {
        ChangeVolume(ButtonVolumeParam, volume);
    }

    public void PlaySoundButton(int index)
    {
        _audioSource.clip = _audioClips[index];
        _audioSource.Play();
    }

    private void ChangeVolume(string paramName, float volume)
    {
        _mixer.audioMixer.SetFloat(paramName, Mathf.Log10(volume) * 20);
    }
}
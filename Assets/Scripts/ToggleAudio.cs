using UnityEngine;
using UnityEngine.Audio;

public class ToggleAudio : MonoBehaviour
{
    private const float MaxVolume = 0;
    private const float MinVolume = -80;
    
    [SerializeField] private AudioMixerGroup _mixer;
    [SerializeField] private string _nameMixer;
    
    public void ChangeVolume(bool isMuted)
    {
        _mixer.audioMixer.SetFloat(_nameMixer, Mathf.Log10(isMuted ? MaxVolume : MinVolume) * 20);
    }
}

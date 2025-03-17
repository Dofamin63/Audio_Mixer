using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class AudioSetting : MonoBehaviour
{
    private const float DecibelMultiplier = 20;
    private const float MinVolume = -80;
    private const float ZeroVolume = 0f;
    
    private Slider _slider;
    [SerializeField] private AudioMixerGroup _mixer;
    [SerializeField] private string _nameMixer;

    public void Awake()
    {
        _slider = GetComponent<Slider>();
        _slider?.onValueChanged.AddListener(ChangeVolume);
    }

    private void ChangeVolume(float volume)
    {
        if (Mathf.Approximately(volume, ZeroVolume))
            _mixer.audioMixer.SetFloat(_nameMixer, MinVolume);
        else 
            _mixer.audioMixer.SetFloat(_nameMixer, Mathf.Log10(volume) * DecibelMultiplier);
    }
}
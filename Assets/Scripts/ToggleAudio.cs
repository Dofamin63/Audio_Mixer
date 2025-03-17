using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

[RequireComponent(typeof(Toggle))]
public class ToggleAudio : MonoBehaviour
{
    private const float MaxVolume = 0;
    private const float MinVolume = -80;
    private const float DecibelMultiplier = 20;
    
    private Toggle _toggle;
    [SerializeField] private AudioMixerGroup _mixer;
    [SerializeField] private string _nameMixer;

    public void Awake()
    {
        _toggle = GetComponent<Toggle>();
        _toggle?.onValueChanged.AddListener(ChangeVolume);
    }
    
    private void ChangeVolume(bool isMuted)
    {
        _mixer.audioMixer.SetFloat(_nameMixer, Mathf.Log10(isMuted ? MaxVolume : MinVolume) * DecibelMultiplier);
    }
}

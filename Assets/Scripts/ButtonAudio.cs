using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class ButtonAudio : MonoBehaviour
{
    [SerializeField] private List<AudioClip> _audioClips;
    private AudioSource _audioSource;
    
    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }
    
    public void PlaySound(int index)
    {
        _audioSource.clip = _audioClips[index];
        _audioSource.Play();
    }
}

using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class ButtonAudio : MonoBehaviour
{
    private AudioSource _audioSource;
    [SerializeField] private List<AudioClip> _audioClips;
    
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

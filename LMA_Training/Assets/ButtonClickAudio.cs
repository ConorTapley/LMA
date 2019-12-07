using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClickAudio : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip ButtonPressClip;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();

        audioSource.clip = ButtonPressClip;
    }

    public void PlayButtonSFX()
    {
        audioSource.Play();
    }
}

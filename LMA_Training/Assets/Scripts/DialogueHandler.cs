using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueHandler : MonoBehaviour
{

    public AudioSource _audioSource;
    public AudioClip StepOne;
    public AudioClip StepTwo;
    //public AudioClip StepThree;
    public AudioClip StepFour;
    public AudioClip StepFive;
    public AudioClip StepSix;
    public AudioClip StepSeven;
    public AudioClip StepEight;
    public AudioClip StepNine;
    public AudioClip StepTen;
    //public AudioClip StepEleven;
    public AudioClip StepTwelve;

    private void Start()
    {
        _audioSource = GameObject.Find("Dialogue Handler").GetComponent<AudioSource>();

        //_audioSource = GetComponent<AudioSource>().
    }

    private void Update()
    {
        
    }

    public void Clip(AudioClip DialogueClip)
    {
        _audioSource.PlayOneShot(DialogueClip);
    }
}

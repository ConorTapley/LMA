using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TTS : MonoBehaviour
{
    private void Awake()
    {
        AudioTrigger();
    }
    public int DialogIndex = 0;
    public AudioSource _audio;
    [TextArea]
    public string[] dialog;


    private void Start()
    {
//_audio = gameObject.GetComponent<AudioSource>();
        _audio = GameObject.Find("Nurse").GetComponent<AudioSource>();
        Debug.Log("Found Nurse, attaching AudioSource to TTS");
    }

    private void Update()
    {
        
    }

    IEnumerator DownloadAudio()
    {
        string url = "https://translate.google.com/translate_tts?ie=UTF-8&total=1&idx=0&textlen=32&client=tw-ob&q="+ dialog[DialogIndex] +"&tl=En-gb";
        WWW www = new WWW(url);

        yield return www;

        _audio.clip = www.GetAudioClip(false, true, AudioType.MPEG);
        _audio.Play();
        Debug.Log("Coroutine End");
    }

    public void AudioTrigger()
    {
        StartCoroutine(DownloadAudio());
        Debug.Log("Started Coroutine, Audio Triggered");
    }
}

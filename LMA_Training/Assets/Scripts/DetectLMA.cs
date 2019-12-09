using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectLMA : MonoBehaviour
{
    public AudioClip dingSound;

    void Start()
    {
        
    }
    
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("LMABottom"))
        {
            Debug.Log("IN MOUTH");
            GetComponent<AudioSource>().PlayOneShot(dingSound);
            //VibrationManager.singleton.TriggerVibration(dingSound, OVRInput.Controller.LTouch);
            //VibrationManager.singleton.TriggerVibration(dingSound, OVRInput.Controller.RTouch);
            OVRInput.SetControllerVibration(1, 1, OVRInput.Controller.Active);
        }
    }
}

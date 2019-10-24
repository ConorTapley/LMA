using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncertLMA : MonoBehaviour
{
    private OVRGrabbable ovrGrabbable;
    public OVRInput.Button grabButton;
    public AudioClip dingSound;

    void Start()
    {
        ovrGrabbable = GetComponent<OVRGrabbable>();
    }

    
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Mouth"))
        {
            Debug.Log("IN MOUTH");
            GetComponent<AudioSource>().PlayOneShot(dingSound);
            //VibrationManager.singleton.TriggerVibration(2, OVRInput.Controller.RTouch);
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        OVRInput.SetControllerVibration(1, 1, OVRInput.Controller.Active);
    }
}

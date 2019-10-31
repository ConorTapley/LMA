using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncertLMA : MonoBehaviour
{
    private OVRGrabbable ovrGrabbable;
    public OVRInput.Button grabButton;
    public AudioClip dingSound;
    public bool inMouth = false;

    void Start()
    {
        ovrGrabbable = GetComponent<OVRGrabbable>();
    }

    
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Mouth"))
        {
            Debug.Log("IN MOUTH");
            GetComponent<AudioSource>().PlayOneShot(dingSound);
            VibrationManager.singleton.TriggerVibration(dingSound, OVRInput.Controller.LTouch);
            VibrationManager.singleton.TriggerVibration(dingSound, OVRInput.Controller.RTouch);
            inMouth = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        OVRInput.SetControllerVibration(1, 1, OVRInput.Controller.Active);
        inMouth = false;
    }
}

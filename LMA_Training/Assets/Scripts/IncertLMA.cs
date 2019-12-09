using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncertLMA : MonoBehaviour
{
    private OVRGrabbable ovrGrabbable;
    public OVRInput.Button grabButton;
    public AudioClip dingSound;
    public bool aroundMouth = false;
    public bool inMouth = false;
    private Rigidbody rb;

    void Start()
    {
        ovrGrabbable = GetComponent<OVRGrabbable>();
        rb = this.gameObject.GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        if (aroundMouth)
            rb.constraints = RigidbodyConstraints.FreezeAll;
        else
            rb.constraints = RigidbodyConstraints.None;
    }

    void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Mouth"))
        {
            //Debug.Log("IN MOUTH");
            aroundMouth = true;
        }
        //if the lma hits the sound trigger it is in the patients mouth
        if(other.CompareTag("Sound"))
        {
            inMouth = true;
        }
    }
    /*
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Sound"))
        {
            GetComponent<AudioSource>().PlayOneShot(dingSound);
            VibrationManager.singleton.TriggerVibration(dingSound, OVRInput.Controller.LTouch);
            VibrationManager.singleton.TriggerVibration(dingSound, OVRInput.Controller.RTouch);
        }
    }
    */
    void OnTriggerExit(Collider other)
    {
        //OVRInput.SetControllerVibration(1, 1, OVRInput.Controller.Active);
        aroundMouth = false;
        inMouth = false;
    }
    
}

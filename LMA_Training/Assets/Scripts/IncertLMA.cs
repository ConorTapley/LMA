using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncertLMA : MonoBehaviour
{
    private OVRGrabbable ovrGrabbable;
    public OVRInput.Button grabButton;

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
            VibrationManager.singleton.TriggerVibration(2, OVRInput.Controller.All);
        }
    }
}

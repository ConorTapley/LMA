using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //each part of the game can only be played if the bool for it is true
    [SerializeField] private bool step1 = true, step2 = false, step3 = false, step4 = false, step5 = false, step6 = false, step7 = false, step8 = false;
    [SerializeField] private Animator patientAnimator;

    void Start()
    {
        
    }
    
    void Update()
    {
        if(OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger) || OVRInput.Get(OVRInput.Button.SecondaryIndexTrigger))
        {
            patientAnimator.Play("Patient Head Tilt");
            //Debug.Log("Trigger");
        }
    }
}

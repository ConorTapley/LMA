using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    //each part of the game can only be played if the bool for it is true
    [SerializeField] public bool step1 = true, step2 = false, step3 = false, step4 = false, step5 = false, step6 = false, step7 = false, step8 = false;

    [SerializeField] private Animator patientAnimator;
    [SerializeField] private Animator LubeLMAAnimator;
    [SerializeField] private Animator LubeCaseAnimator;
    [SerializeField] private Animator removeCaseAnimator;

    [SerializeField] private GameObject tiltHeadButton;
    [SerializeField] private GameObject removeCaseButton;
    [SerializeField] private GameObject lubeLMAButton;
    [SerializeField] private GameObject lubeCaseButton;

    void Start()
    {
        
    }
    
    void Update()
    {
        /*
        if(OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger) || OVRInput.Get(OVRInput.Button.SecondaryIndexTrigger))
        {
            patientAnimator.Play("Patient Head Tilt");
            //Debug.Log("Trigger");
        }
        */
    }

    public void TiltPatientsHead()
    {
        patientAnimator.Play("Patient Head Tilt");
        tiltHeadButton.SetActive(false);
    }

    public void RemoveCase()
    {
        removeCaseAnimator.Play("RomoveCase");
        removeCaseButton.SetActive(false);
    }

    public void LubeLMA()
    {
        LubeLMAAnimator.Play("AddLubeToLMA");
        lubeLMAButton.SetActive(false);
    }

    public void LubeCase()
    {
        LubeCaseAnimator.Play("AddLubeToCase");
        lubeCaseButton.SetActive(false);
    }
}

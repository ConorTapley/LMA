using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    //each part of the game can only be played if the bool for it is true
    [SerializeField] private bool step1 = true, step2 = false, step3 = false, step4 = false, step5 = false, step6 = false, step7 = false, step8 = false;
    [SerializeField] private GameObject stepObj1, stepObj2, stepObj3, stepObj4, stepObj5, stepObj6, stepObj7, stepObj8;

    //Select the LMA
    [SerializeField] private GameObject selectLMA1, selectLMA2, selectLMA3, selectLMA5;

    //NextStepArrows
    [SerializeField] private GameObject nextStepArrow2, nextStepArrow3, nextStepArrow4;

    [SerializeField] private Animator patientAnimator;
    [SerializeField] private Animator LubeLMAAnimator;
    [SerializeField] private Animator LubeCaseAnimator;
    [SerializeField] private Animator removeCaseAnimator;

    [SerializeField] private GameObject tiltHeadButton;
    [SerializeField] private GameObject pickLMAButton, removeCaseButton, lubeCaseButton, lubeLMAButton; 

    void Start()
    {
        stepObj2.SetActive(true);

        nextStepArrow2.SetActive(false);
        stepObj3.SetActive(false);
        nextStepArrow3.SetActive(false);
        stepObj4.SetActive(false);
        nextStepArrow4.SetActive(false);
        stepObj5.SetActive(false);
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

    //1
    public void Clipboard()
    {

    }

    //////////////////////NEXT STEP/////////////////////
    public void NextStep1()
    {

    }




    //2
    public void PickLMA()
    {
        selectLMA1.SetActive(false);
        selectLMA2.SetActive(false);
        selectLMA3.SetActive(false);
        selectLMA5.SetActive(false);

        nextStepArrow2.SetActive(true);
        pickLMAButton.SetActive(false);
    }

    //////////////////////NEXT STEP/////////////////////
    public void NextStep2()
    {
        stepObj2.SetActive(false);
        stepObj3.SetActive(true);
    }




    //3
    public void RemoveCase()
    {
        removeCaseAnimator.Play("RomoveCase");
        removeCaseButton.SetActive(false);
        nextStepArrow3.SetActive(true);
    }

    //////////////////////NEXT STEP/////////////////////
    public void NextStep3()
    {
        stepObj3.SetActive(false);
        stepObj4.SetActive(true);
    }




    //4
    public void LubeCase()
    {
        LubeCaseAnimator.Play("AddLubeToCase");
        lubeCaseButton.SetActive(false);
        nextStepArrow4.SetActive(true);
    }

    //////////////////////NEXT STEP/////////////////////
    public void NextStep4()
    {
        stepObj4.SetActive(false);
        stepObj5.SetActive(true);
    }




    //5
    public void LubeLMA()
    {
        LubeLMAAnimator.Play("AddLubeToLMA");
        lubeLMAButton.SetActive(false);
    }

    //////////////////////NEXT STEP/////////////////////
    public void NextStep5()
    {

    }




    //6
    public void TiltPatientsHead()
    {
        patientAnimator.Play("Patient Head Tilt");
        tiltHeadButton.SetActive(false);
    }

    //////////////////////NEXT STEP/////////////////////
    public void NextStep6()
    {

    }




    //7
    public void IncertLMA()
    {

    }

    //////////////////////NEXT STEP/////////////////////
    public void NextStep7()
    {

    }




    //8
    public void TieLMA()
    {

    }

    

    
    
    /*
     * Step 1 = Pick up Clipboard
     * Step 2 = Pick LMA
     * Step 3 = Take LMA out of case
     * Step 4 = Put Lube on LMA case
     * Step 5 = put Lube on LMA
     * Step 6 = Tilt patient Head back
     * Step 7 = Put LMA in patients mouth
     * Step 8 = Tie the LMA
    */
}

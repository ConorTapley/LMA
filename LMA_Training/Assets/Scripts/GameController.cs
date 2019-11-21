using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    //each part of the game can only be played if the bool for it is true
    [SerializeField] private bool step1 = true, step2 = false, step3 = false, step4 = false, step5 = false, step6 = false, step7 = false, step8 = false;
    [SerializeField] private GameObject startTVScreen, stepObj1, stepObj2, stepObj3, stepObj4, stepObj5, stepObj6, stepObj7, stepObj8;

    //Select the LMA
    [SerializeField] private GameObject selectLMA1, selectLMA2, selectLMA3, selectLMA5;

    //NextStepArrows
    [SerializeField] private GameObject nextStepArrow2, nextStepArrow3, nextStepArrow4;
    [SerializeField] private bool nextStepbool2 = false, nextStepbool3 = false, nextStepbool4 = false;
    /////Animatiors//////
    [SerializeField] private Animator patientAnimator;
    [SerializeField] private Animator LubeLMAAnimator;
    [SerializeField] private Animator LubeCaseAnimator;
    [SerializeField] private Animator removeCaseAnimator;

    ///////Action Buttons////////
    [SerializeField] private GameObject tiltHeadButton;
    [SerializeField] private GameObject tvStartButton, pickLMAButton, removeCaseButton, lubeCaseButton, lubeLMAButton;

    /////Audio/////
    [SerializeField] AudioSource robotNurseAudioSource;
    [SerializeField] AudioClip lubeCaseAudio, lubeLMAAudio, PickLMAAudio, RemoveCaseAudio;


    void Start()
    {
        startTVScreen.SetActive(true);
        tvStartButton.SetActive(true);

        stepObj2.SetActive(false);
        nextStepArrow2.SetActive(false);
        stepObj3.SetActive(false);
        nextStepArrow3.SetActive(false);
        stepObj4.SetActive(false);
        nextStepArrow4.SetActive(false);
        stepObj5.SetActive(false);
    }

    void Update()
    {
        //When you pick the LMA let the audio be finished playing before the arrow appears to let you move to the next step
        if(nextStepbool2 && !robotNurseAudioSource.isPlaying)
            nextStepArrow2.SetActive(true); //<---activating the arrow button from picking the LMA to removing the LMA from its case

        if (nextStepbool3 && !robotNurseAudioSource.isPlaying)
            nextStepArrow3.SetActive(true); //<---activating the arrow button from removing the LMA from its case to lubricating the case

        if (nextStepbool4 && !robotNurseAudioSource.isPlaying)
            nextStepArrow4.SetActive(true); //<---activating the arrow button from lubricating the case to lubricating the LMA

    }


    //Start TV//
    public void StartTV()
    {
        startTVScreen.SetActive(false);
        tvStartButton.SetActive(false);
        stepObj2.SetActive(true);

        robotNurseAudioSource.PlayOneShot(PickLMAAudio);
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

        
        pickLMAButton.SetActive(false);
        nextStepbool2 = true;
    }

    //////////////////////NEXT STEP/////////////////////     from picking the lma to removing the case
    public void NextStep2()
    {
        stepObj2.SetActive(false);
        stepObj3.SetActive(true);

        robotNurseAudioSource.PlayOneShot(RemoveCaseAudio);
    }




    //3
    public void RemoveCase()
    {
        removeCaseAnimator.Play("RomoveCase");
        removeCaseButton.SetActive(false);
        nextStepbool3 = true;
    }

    //////////////////////NEXT STEP/////////////////////    from removing the case to lubricating the case
    public void NextStep3()
    {
        stepObj3.SetActive(false);
        stepObj4.SetActive(true);

        robotNurseAudioSource.PlayOneShot(lubeCaseAudio);
    }




    //4
    public void LubeCase()
    {
        LubeCaseAnimator.Play("AddLubeToCase");
        lubeCaseButton.SetActive(false);
        nextStepbool4 = true;
    }

    //////////////////////NEXT STEP/////////////////////    from lubricating the case to lubricating the LMA
    public void NextStep4()
    {
        stepObj4.SetActive(false);
        stepObj5.SetActive(true);

        robotNurseAudioSource.PlayOneShot(lubeLMAAudio);
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
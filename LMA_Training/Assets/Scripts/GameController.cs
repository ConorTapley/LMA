using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public LMARespawn LMARespawn;
    //each part of the game can only be played if the bool for it is true
    [SerializeField] private GameObject startTVScreen, stepObj1, stepObj2, stepObj3, stepObj4, stepObj5, stepObj6, stepObj7, stepObj8, LMABinding, changeHeightScreen, changeHeightContinueButton;

    //Select the LMA
    [SerializeField] private GameObject selectLMA1, selectLMA2, selectLMA3, selectLMA5;

    //NextStepArrows
    [SerializeField] private GameObject nextStepArrow2, nextStepArrow3, nextStepArrow4;
    private bool nextStepbool2 = false, nextStepbool3 = false, nextStepbool4 = false;
    /////Animatiors//////
    [SerializeField] private Animator patientAnimator;
    [SerializeField] private Animator LubeLMAAnimator;
    [SerializeField] private Animator LubeCaseAnimator;
    [SerializeField] private Animator removeCaseAnimator;
    [SerializeField] private Animator ghostLMAAnimator;

    ///////Action Buttons////////
    [SerializeField] private GameObject tiltHeadButton;
    [SerializeField] private GameObject tvStartButton, pickLMAButton, removeCaseButton, lubeCaseButton, lubeLMAButton, tieLMAButton;

    /////Audio/////
    [SerializeField] AudioSource robotNurseAudioSource;
    [SerializeField] AudioClip startAudio, lubeCaseAudio, lubeLMAAudio, PickLMAAudio, RemoveCaseAudio, clipboardAudio, checkLMAForLubeInsideAudio, tiltHeadAudio, grabLMAAudio, IncertLMAAudio, SscopeAudio, completedTutorialAudio;
    private bool hasPlayedIntro = false, hasPlayedClipboard = false, hasPlayedLubeLMA = false, hasPlayedCheckLMA = false, hasPlayedHeadTilt = false, hasPlayedGrabLMA = false, hasPlayedIncertLMA = false, hasPlayedSscope = false, tieLMAButtonPressed = false;
    private bool playGrabLMA = false;

    public IncertLMA incertLMAScript;
    private bool patientHeadTilted = false;

    void Start()
    {
        changeHeightScreen.SetActive(true);

        LMABinding.SetActive(false);
        tieLMAButton.SetActive(false);

        tvStartButton.SetActive(false);

        stepObj7.SetActive(false);
        stepObj2.SetActive(false);
        nextStepArrow2.SetActive(false);
        stepObj3.SetActive(false);
        nextStepArrow3.SetActive(false);
        stepObj4.SetActive(false);
        nextStepArrow4.SetActive(false);
        stepObj5.SetActive(false);
        tiltHeadButton.SetActive(false);

        if(!hasPlayedIntro)
        {
            robotNurseAudioSource.PlayOneShot(startAudio);
            hasPlayedIntro = true;
        }

        
    }

    void Update()
    {
        if (hasPlayedIntro && !hasPlayedClipboard && !robotNurseAudioSource.isPlaying)
        {
            robotNurseAudioSource.PlayOneShot(clipboardAudio);
            hasPlayedClipboard = true;
        }

        //wait till the robot finishes talking at the start of the scene before you can use the tv
        if (!robotNurseAudioSource.isPlaying)
            tvStartButton.SetActive(true);



        //When you pick the LMA let the audio be finished playing before the arrow appears to let you move to the next step
        if (nextStepbool2 && !robotNurseAudioSource.isPlaying)
            nextStepArrow2.SetActive(true); //<---activating the arrow button from picking the LMA to removing the LMA from its case

        if (nextStepbool3 && !robotNurseAudioSource.isPlaying)
            nextStepArrow3.SetActive(true); //<---activating the arrow button from removing the LMA from its case to lubricating the case

        if (nextStepbool4 && !robotNurseAudioSource.isPlaying)
            nextStepArrow4.SetActive(true); //<---activating the arrow button from lubricating the case to lubricating the LMA


        if(!hasPlayedCheckLMA && hasPlayedLubeLMA && !robotNurseAudioSource.isPlaying)
        {
            robotNurseAudioSource.PlayOneShot(checkLMAForLubeInsideAudio); //<------- play the audio to check if there is lube inside the lma
            hasPlayedCheckLMA = true;
            stepObj5.SetActive(false); //make the last tv animation stop
            changeHeightScreen.SetActive(true); //make the adjust height show up
            changeHeightContinueButton.SetActive(false);
        }

        if(!hasPlayedHeadTilt && hasPlayedCheckLMA && !robotNurseAudioSource.isPlaying)
        {
            robotNurseAudioSource.PlayOneShot(tiltHeadAudio); //<-------------------- play the audio to tilt the patients head
            hasPlayedHeadTilt = true;
            tiltHeadButton.SetActive(true);
        }

        //7
        if (LMARespawn.LMAOnTable == true && patientHeadTilted && !incertLMAScript.inMouth)
        {
            stepObj7.SetActive(true);
            ghostLMAAnimator.Play("GhostLMA");
            //IncertLMA();
        }
        else if(LMARespawn.LMAOnTable == false)
        {
            stepObj7.SetActive(false);
        }

        if (playGrabLMA && !hasPlayedGrabLMA && !robotNurseAudioSource.isPlaying)
        {
            robotNurseAudioSource.PlayOneShot(grabLMAAudio); //<----------------------pick up the LMA audio
            hasPlayedGrabLMA = true;
        }

        if(!hasPlayedIncertLMA && hasPlayedGrabLMA && !robotNurseAudioSource.isPlaying)
        {
            robotNurseAudioSource.PlayOneShot(IncertLMAAudio);
            hasPlayedIncertLMA = true;
        }

        //check if the lma is in the mouth
        if(incertLMAScript.inMouth && !hasPlayedSscope && !robotNurseAudioSource.isPlaying && hasPlayedIncertLMA) //<------check if the LMA is in the patients mouth
        {
            robotNurseAudioSource.PlayOneShot(SscopeAudio);
            hasPlayedSscope = true;
        }

        //tie LMA
        if(hasPlayedSscope && !robotNurseAudioSource.isPlaying && !tieLMAButtonPressed)
        {
            tieLMAButton.SetActive(true); //<----------------------activate the tie LMA button
        }
        
    }


    //Start TV//
    public void StartTV()
    {
        startTVScreen.SetActive(false);
        tvStartButton.SetActive(false);
        stepObj2.SetActive(true);
        changeHeightScreen.SetActive(false);

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
        hasPlayedLubeLMA = true;
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

        playGrabLMA = true;
        patientHeadTilted = true;
    }

    //////////////////////NEXT STEP/////////////////////
    public void NextStep6()
    {

    }




    //7
    public void IncertLMA()
    {
        //if the lma is on the table play ghost animation
        if (LMARespawn.LMAOnTable == false)
            stepObj7.SetActive(false);
        else
        {
            stepObj7.SetActive(true); //if the lma is not on the table dont play ghost animation
            ghostLMAAnimator.Play("GhostLMA");
        }
    }
    
    
    //////////////////////NEXT STEP/////////////////////
    public void NextStep7()
    {
        
    }




    //8
    public void TieLMA()
    {
        LMABinding.SetActive(true);
        tieLMAButton.SetActive(false);
        tieLMAButtonPressed = true;
        robotNurseAudioSource.PlayOneShot(completedTutorialAudio);
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
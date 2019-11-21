using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public NurseManager nurseManager;
    public AudioSource m_AudioSource;

    public AudioClip m_DialogueStep1,
    m_DialogueStep2,
    m_DialogueStep4,
    m_DialogueStep5_Size1,
    m_DialogueStep5_Size2,
    m_DialogueStep5_Size3,
    m_DialogueStep5_size4,
    m_DialogueStep5_Size5,
    m_DialogueStep6,
    m_DialogueStep7,
    m_DialogueStep8,
    m_DialogueStep9,
    m_DialogueStep10,
    m_DialogueStep12,
    m_DialogueStep14,
    m_DialogueStep16;
      

    private void Start()
    {
        m_AudioSource = GetComponent<AudioSource>();
        nurseManager = GameObject.Find("NurseManager").GetComponent<NurseManager>();
    }

    private void Update()
    {
        if(nurseManager.step1 == true)
        {
            //Debug.LogError("[Audio Manager] Nurse Manager Step 1 is true... Continuing");
            if (m_AudioSource.clip == null && nurseManager.step1 == true)
            {
                //Debug.LogError("[Audio Manager] Clip slot is empty at Step1 - Inserting DialogueStep1 Clip.");
                m_AudioSource.clip = m_DialogueStep1;
                //Debug.LogError("[Audio Manager] Attempting to play DialogueStep1 audio...");
                m_AudioSource.Play();
                nurseManager.step1 = false;
                Debug.LogError("Step1 is now false");
                if (nurseManager.step1 == false)
                {
                    Debug.LogError("[Audio Manager] Removing Audio clip in " + m_AudioSource.clip.length);
                    Invoke("RemoveAudioClip", m_AudioSource.clip.length);
                    nurseManager.step2 = true;
                }
            }
            else
            {
                Debug.LogError("[Audio Manager] Clip slot is NOT empty at Step1 - What to do now?");
                nurseManager.step2 = true;
                nurseManager.step1 = false;
            }
        }

        if (nurseManager.step2 == true)
        {
            //Debug.LogError("[Audio Manager] Nurse Manager Step 1 is true... Continuing");
            if (m_AudioSource.clip == null && nurseManager.step2 == true)
            {
                //Insert Dialogue Clip into the Audio source.
                m_AudioSource.clip = m_DialogueStep2;

                //Play the Clip and change the step to false to trigger the next steps dialogue.
                m_AudioSource.Play();
                nurseManager.step2 = false;
                Debug.LogError("Step2 is now false");

                //When the current step is false - which it has been changed to just previously - it will trigger the Invoke to change the audio clip
                //for the next part of the Dialogue.
                //This will also trigger the Boolean for the next step.
                if (nurseManager.step2 == false && nurseManager.chinButtonClicked == true)
                {
                    Debug.LogError("[Audio Manager] Removing Audio clip in " + m_AudioSource.clip.length);
                    Invoke("RemoveAudioClip", m_AudioSource.clip.length);
                    nurseManager.step3 = true;
                }
            }
            else
            {
                Debug.LogError("Audio Manager currently has nothing to do...");
            }
        }

        if (nurseManager.step3 == true)
        {
            /////
            /// There is no Dialogue for this step
            /////
            
            nurseManager.step4 = true;
            //nurseManager.step3 = false;
        }

        if (nurseManager.step4 == true)
        {
            //Debug.LogError("[Audio Manager] Nurse Manager Step 1 is true... Continuing");
            if (m_AudioSource.clip == null && nurseManager.step4 == true)
            {
                //Insert Dialogue Clip into the Audio source.
                m_AudioSource.clip = m_DialogueStep4;

                //Play the Clip and change the step to false to trigger the next steps dialogue.
                m_AudioSource.Play();
                nurseManager.step4 = false;

                Debug.LogError("Step4 is now false");

                //When the current step is false - which it has been changed to just previously - it will trigger the Invoke to change the audio clip
                //for the next part of the Dialogue.
                //This will also trigger the Boolean for the next step.
                if (nurseManager.step4 == false)
                {
                    Debug.LogError("[Audio Manager] Removing Audio clip in " + m_AudioSource.clip.length);
                    Invoke("RemoveAudioClip", m_AudioSource.clip.length);

                    nurseManager.step5 = true;
                }
            }
            else
            {
                Debug.LogError("Audio Manager currently has nothing to do...");
            }
        }

        if (nurseManager.step5 == true)
        {
            //Debug.LogError("[Audio Manager] Nurse Manager Step 1 is true... Continuing");
            if (m_AudioSource.clip == null && nurseManager.step5 == true)
            {
                //Insert Dialogue Clip into the Audio source.
                m_AudioSource.clip = m_DialogueStep5_Size1;

                //Play the Clip and change the step to false to trigger the next steps dialogue.
                m_AudioSource.Play();
                nurseManager.step5 = false;

                Debug.LogError("Step5 is now false");

                //When the current step is false - which it has been changed to just previously - it will trigger the Invoke to change the audio clip
                //for the next part of the Dialogue.
                //This will also trigger the Boolean for the next step.
                if (nurseManager.step5 == false)
                {
                    Debug.LogError("[Audio Manager] Removing Audio clip in " + m_AudioSource.clip.length);
                    Invoke("RemoveAudioClip", m_AudioSource.clip.length);

                    nurseManager.step6 = true;
                }
            }
            else
            {
                Debug.LogError("Audio Manager currently has nothing to do...");
            }
        }
    }

    public void RemoveAudioClip()
    {
        m_AudioSource.clip = null;
    }
}

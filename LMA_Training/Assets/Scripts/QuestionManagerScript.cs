using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class QuestionManagerScript : MonoBehaviour
{
    private GameObject button;
    private GameObject[] buttonSet;

    public int testScore;

    

    void Start()
    {
        testScore = 0;
    }

    

    void Update()
    {
        
    }

    public void OnCorrectClick()
    {
        testScore += 1;
        button = EventSystem.current.currentSelectedGameObject;
        buttonSet = GameObject.FindGameObjectsWithTag(button.tag);
        for (int i = 0; i < buttonSet.Length; i++)
        {
            buttonSet[i].SetActive(false);
        }
    }

    public void OnWrongClick()
    {
        button = EventSystem.current.currentSelectedGameObject;
        buttonSet = GameObject.FindGameObjectsWithTag(button.tag);
        for (int i = 0; i < buttonSet.Length; i++)
        {
            buttonSet[i].SetActive(false);
        }
    }
}


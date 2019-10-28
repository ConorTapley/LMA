using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ClipBoardScript : MonoBehaviour
{
    public Text weightRng;
    public Text scoreTxt;

    private int weightNum;

    public GameObject testPg1;
    public GameObject testPg2;
    public GameObject finishPg;

    private GameObject detailsPg;
    private GameObject clipBoard;

    private GameObject button;
    private GameObject [] buttonSet;

    private int testScore;

    void Start()
    {
        weightNum = Random.Range(30, 100);
        weightRng.text = "Weight: "+ weightNum + "kg";
        testScore = 0;

        detailsPg = GameObject.FindGameObjectWithTag("DetailsPage");
        clipBoard = GameObject.FindGameObjectWithTag("ClipBoard");
        
    }

    
    void Update()
    {
        scoreTxt.text = testScore.ToString();
    }

    public void OnClick()
    {
        var tstPg1 = Instantiate(testPg1);
        tstPg1.transform.position = detailsPg.transform.position;
        tstPg1.transform.parent = clipBoard.transform.parent;

        GameObject.Destroy(detailsPg);
    }

    public void OnClick_2()
    {
        var tstPg2 = Instantiate(testPg2);
        tstPg2.transform.position = testPg1.transform.position;
        tstPg2.transform.parent = clipBoard.transform.parent;

        GameObject.Destroy(testPg1);
    }

    public void OnClick_3()
    {
        var finPg = Instantiate(finishPg);
        finishPg.transform.position = testPg2.transform.position;
        finishPg.transform.parent = clipBoard.transform.parent;

        GameObject.Destroy(testPg2);
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

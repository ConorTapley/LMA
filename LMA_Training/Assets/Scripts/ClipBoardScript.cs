using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ClipBoardScript : MonoBehaviour
{
    public Text weightRng;

    private int weightNum;

    public GameObject testPg1;
    public GameObject finishPg;

    private GameObject detailsPg;
    private GameObject clipBoard;

    private GameObject button;
    private GameObject [] buttonSet;

    public int testScore;

    void Start()
    {
        weightNum = Random.Range(30, 100);
        weightRng.text = "Weight: "+ weightNum + "kg";
        testScore = 0;

        detailsPg = GameObject.FindGameObjectWithTag("DetailsPage");
        //clipBoard = GameObject.FindGameObjectWithTag("ClipBoard"); //<-----console error saying "Clipboard" tag is not defined
        
    }

    
    void Update()
    {
        
    }

    public void OnClick()
    {
        /*var tstPg1 = Instantiate(testPg1);
        tstPg1.transform.position = detailsPg.transform.position;
        tstPg1.transform.SetParent(clipBoard.transform);*/

        //GameObject.Destroy(detailsPg);
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

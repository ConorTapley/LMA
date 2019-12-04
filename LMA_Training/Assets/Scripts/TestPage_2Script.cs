using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestPage_2Script : MonoBehaviour
{
    public GameObject finishPg;
    private GameObject clipBoard;
    private GameObject testPg2;
    private GameObject cBManager;

    private Text scoreTxt;
    private ClipBoardScript cBScript;
    private int tScore;

    void Start()
    {
        testPg2 = this.gameObject;
        //clipBoard = GameObject.FindGameObjectWithTag("ClipBoard");
        cBManager = GameObject.FindGameObjectWithTag("ClipBoardManager");
        cBScript = cBManager.GetComponent<ClipBoardScript>();
        
    }

    
    void Update()
    {
        tScore = cBScript.testScore;
    }

    public void OnClick_3()
    {
        /*var finPg = Instantiate(finishPg);
        finPg.transform.SetParent(clipBoard.transform);
        finPg.transform.position = testPg2.transform.position;*/

        scoreTxt = GameObject.FindGameObjectWithTag("Score").GetComponent<Text>();
        scoreTxt.text = tScore.ToString();

        GameObject.Destroy(testPg2);
    }

    public void OnCorrectClick()
    {
        cBScript.OnCorrectClick();
    }

    public void OnWrongClick()
    {
        cBScript.OnWrongClick();
    }
}

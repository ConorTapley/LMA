using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestPage_2Script : MonoBehaviour
{
    //public GameObject finishPg;
    //private GameObject clipBoard;
    private GameObject testPg2;

    private Text scoreTxt;
    private GameObject qManager;
    private QuestionManagerScript qMScript;
    private int tScore;

    void Start()
    {
        testPg2 = this.gameObject;
        //clipBoard = GameObject.FindGameObjectWithTag("ClipBoard");
        qManager = GameObject.FindGameObjectWithTag("QuestionManager");
        qMScript = qManager.GetComponent<QuestionManagerScript>();
        
    }

    
    void Update()
    {
        tScore = qMScript.testScore;
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
        qMScript.OnCorrectClick();
    }

    public void OnWrongClick()
    {
        qMScript.OnWrongClick();
    }
}

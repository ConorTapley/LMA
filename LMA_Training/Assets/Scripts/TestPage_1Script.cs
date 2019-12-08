using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPage_1Script : MonoBehaviour
{
    private GameObject testPg1;

    //public GameObject testPg2;
    //private GameObject clipBoard;

    private GameObject qManager;
    private QuestionManagerScript qMScript;

    void Start()
    {
        testPg1 = this.gameObject;
        //clipBoard = GameObject.FindGameObjectWithTag("ClipBoard");

        qManager = GameObject.FindGameObjectWithTag("QuestionManager");
        qMScript = qManager.GetComponent<QuestionManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick_2()
    {
        /*var tstPg2 = Instantiate(testPg2);
        tstPg2.transform.SetParent(clipBoard.transform);
        tstPg2.transform.position = testPg1.transform.position;*/

        

        GameObject.Destroy(testPg1);
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

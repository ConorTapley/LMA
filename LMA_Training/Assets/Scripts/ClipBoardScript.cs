using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClipBoardScript : MonoBehaviour
{
    public Text weightRng;
    private int weightNum;
    public GameObject testPg1;
    public GameObject testPg2;
    private GameObject detailsPg;
    private GameObject clipBoard;

    void Start()
    {
        weightNum = Random.Range(30, 100);
        weightRng.text = "Weight: "+ weightNum + "kg";

        detailsPg = GameObject.FindGameObjectWithTag("DetailsPage");
        clipBoard = GameObject.FindGameObjectWithTag("ClipBoard");
        
    }

    
    void Update()
    {
        
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
}

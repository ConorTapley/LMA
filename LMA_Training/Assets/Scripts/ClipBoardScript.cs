using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClipBoardScript : MonoBehaviour
{
    public Text weightRng;
    private int weightNum;

    void Start()
    {
        weightNum = Random.Range(30, 100);
        weightRng.text = "Weight: "+ weightNum + "kg";
    }

    
    void Update()
    {
        
    }
}

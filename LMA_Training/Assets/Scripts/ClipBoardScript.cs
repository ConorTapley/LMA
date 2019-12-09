using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ClipBoardScript : MonoBehaviour
{
    public int minWeight = 50, maxWeight = 90;

    public Text weightRng;

    private int weightNum;


    void Start()
    {
        weightNum = Random.Range(minWeight, maxWeight);
        weightRng.text = "Weight: "+ weightNum + "kg";
        
    }

    
    void Update()
    {
        
    }

}

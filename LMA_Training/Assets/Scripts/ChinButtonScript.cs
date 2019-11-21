using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChinButtonScript : MonoBehaviour
{
    private NurseManager nMS;

    void Start()
    {
        nMS = GameObject.FindGameObjectWithTag("NurseManager").GetComponent<NurseManager>();
    }

    
    void Update()
    {
        
    }

    public void ButtonPress()
    {
        nMS.chinButtonClicked = true;
    }
}

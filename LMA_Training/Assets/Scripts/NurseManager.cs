using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NurseManager : MonoBehaviour
{
    private TextBoxScript tBS;

    public GameObject tBoxStep2;
    public GameObject ChinButton;
    private GameObject cButtonSpawn;

    public bool chinButtonClicked;

    private bool step1;
    private bool step2;
    private bool step3;
    private bool step4;
    private bool step5;
    private bool step6;

    void Start()
    {
        tBS = GameObject.FindGameObjectWithTag("TextBoxSpawn").GetComponent<TextBoxScript>();
        cButtonSpawn = GameObject.FindGameObjectWithTag("ChinButtonSpawn");
        step1 = true;
    }

    
    void Update()
    {
        if (step1 == true)
        {
            //Speech goes here or whatever calls it

            step1 = false;
            step2 = true;
        }

        if (step2 == true)
        {
            //Speech goes here or whatever calls it

            tBS.TextBox(tBoxStep2);
            Instantiate(ChinButton, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            ChinButton.transform.parent = cButtonSpawn.transform;
            step2 = false;           
        }

        if (chinButtonClicked == true)
        {
            step3 = true;
            GameObject tBoxS2 = GameObject.FindGameObjectWithTag("TextBoxStep2");
            Destroy(tBoxS2);
        }
    }
}

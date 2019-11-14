using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NurseManager : MonoBehaviour
{
    private TextBoxScript tBS;

    public GameObject tBoxStep2;
    public GameObject tBoxStep5;
    public GameObject tBoxStep6;
    public GameObject tBoxStep7;
    public GameObject tBoxStep8;
    public GameObject tBoxStep9;
    public GameObject tBoxStep12;

    public GameObject ChinButton;
    private GameObject cButtonSpawn;

    public bool chinButtonClicked;

    private bool step1;
    private bool step2;
    private bool step3;
    private bool step4;
    private bool step5;
    private bool step6;
    private bool step7;
    private bool step8;
    private bool step9;
    private bool step10;
    private bool step11;
    private bool step12;
    private bool step13;
    private bool step14;

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
            //Speech here or whatever calls it

            step1 = false;
            step2 = true;
        }

        if (step2 == true)
        {
            //Speech here or whatever calls it

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

        if (step3 == true)
        {
            //nurse animation here or whatevers calls it

            step3 = false;
            step4 = true;
        }

        if (step4 == true)
        {
            //speech here or whatever calls it

            step4 = false;
            step5 = true;
        }

        if (step5 == true)
        {
            //speech here or whatever calls it

            tBS.TextBox(tBoxStep5);
            step5 = false;
            step6 = true;
        }

        if (step6 == true )
        {
            //speech here or whatever calls it

            tBS.TextBox(tBoxStep6);
            step6 = false;
            step7 = true;
        }

        if (step7 == true)
        {
            //speech here or whatever calls it

            tBS.TextBox(tBoxStep7);
            step7 = false;
            step8 = true; 
        }

        if (step8 == true)
        {
            //speech here or whatever calls it

            tBS.TextBox(tBoxStep8);
            step8 = false;
            step9 = true;
        }

        if (step9 == true)
        {
            //speech here or whatever calls it
            //animation here or whatever calls it

            tBS.TextBox(tBoxStep9);
            step9 = false;
            step10 = true;
        }

        if (step10 == true)
        {
            //speech here or whatever calls it

            step10 = false;
            step11 = true;
        }

        if (step11 == true)
        {
            //animation here or whatever calls it

            step11 = false;
            step12 = true;
        }

        if (step12 == true)
        {
            //speech here or whatever calls it

            tBS.TextBox(tBoxStep12);
            step12 = false;
            step13 = true;
        }
           
    }
}

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
    public GameObject tBoxStep14;
    public GameObject tBoxStep15;

    public GameObject ChinButton;
    private GameObject cButtonSpawn;

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
    private bool step15;
    private bool step16;

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

        if (step3 == true)
        {
            //nurse animation here or whatevers calls it

            GameObject tBoxS2 = GameObject.FindGameObjectWithTag("TextBoxStep2");
            Destroy(tBoxS2);

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
            GameObject tBoxS5 = GameObject.FindGameObjectWithTag("TextBoxStep5");
            Destroy(tBoxS5);

            //speech here or whatever calls it

            tBS.TextBox(tBoxStep6);
            step6 = false;
            step7 = true;
        }

        if (step7 == true)
        {
            GameObject tBoxS6 = GameObject.FindGameObjectWithTag("TextBoxStep6");
            Destroy(tBoxS6);

            //speech here or whatever calls it

            tBS.TextBox(tBoxStep7);
            step7 = false;
            step8 = true; 
        }

        if (step8 == true)
        {
            GameObject tBoxS7 = GameObject.FindGameObjectWithTag("TextBoxStep7");
            Destroy(tBoxS7);

            //speech here or whatever calls it

            tBS.TextBox(tBoxStep8);
            step8 = false;
            step9 = true;
        }

        if (step9 == true)
        {
            GameObject tBoxS8 = GameObject.FindGameObjectWithTag("TextBoxStep8");
            Destroy(tBoxS8);

            //speech here or whatever calls it
            //animation here or whatever calls it

            tBS.TextBox(tBoxStep9);
            step9 = false;
            step10 = true;
        }

        if (step10 == true)
        {
            GameObject tBoxS9 = GameObject.FindGameObjectWithTag("TextBoxStep9");
            Destroy(tBoxS9);

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

        if (step13 == true)
        {
            GameObject tBoxS12 = GameObject.FindGameObjectWithTag("TextBoxStep12");
            Destroy(tBoxS12);

            //animation here or whatever calls it

            step13 = false;
            step14 = true;
        }

        if (step14 == true)
        {
            GameObject tBoxS13 = GameObject.FindGameObjectWithTag("TextBoxStep13");
            Destroy(tBoxS13);
            //speech here or whatever calls it

            tBS.TextBox(tBoxStep14);
            step12 = false;
            step15 = true;
        }

        if (step15 == true)
        {
            GameObject tBoxS14 = GameObject.FindGameObjectWithTag("TextBoxStep14");
            Destroy(tBoxS14);

            //animation here or whatever calls it

            tBS.TextBox(tBoxStep15);
            step15 = false;
            step16 = true;
        }

        if (step16 == false)
        {
            GameObject tBoxS15 = GameObject.FindGameObjectWithTag("TextBoxStep15");
            Destroy(tBoxS15);

            //speech here or whatever calls it

            step16 = false;
        }
           
    }

    public void chinButtonClick()
    {

        step3 = true;
        ChinButton.SetActive(false);
    }
}

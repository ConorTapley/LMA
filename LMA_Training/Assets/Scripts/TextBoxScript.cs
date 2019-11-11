using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBoxScript : MonoBehaviour
{
    public Text popUpText;

    private GameObject tSpawn;

    void Start()
    {
        tSpawn = GameObject.FindGameObjectWithTag("TextBoxSpawn");
    }



    void Update()
    {

    }

    public void TextBox()
    {
        Instantiate(popUpText, new Vector3(transform.position.x,transform.position.y,transform.position.z),Quaternion.identity );
        popUpText.transform.parent = tSpawn.transform; 
        
    }
}

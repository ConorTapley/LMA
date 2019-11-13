using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LMARespawn : MonoBehaviour
{
    private GameObject LMA;
    private Vector3 LMASpawnPos;
    private Vector3 LMASpawnRot;
    private bool onGround = false;

    void Start()
    {
        LMA = this.gameObject;
        LMASpawnPos = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
        LMASpawnRot = LMA.transform.eulerAngles;
    }

    
    void Update()
    {
        if(onGround)
        {
            LMA.transform.position = LMASpawnPos;
            LMA.transform.eulerAngles = LMASpawnRot;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Ground"))
        {
            //Debug.Log("ON Ground!!");
            onGround = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        onGround = false;
    }
}

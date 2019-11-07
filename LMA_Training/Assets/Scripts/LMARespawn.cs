using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LMARespawn : MonoBehaviour
{
    [SerializeField] private GameObject LMA;
    [SerializeField] private Transform LMAStartTrans;
    [SerializeField] private Vector3 LMASpawnPos;
    [SerializeField] private Vector3 LMASpawnRot;
    [SerializeField] private bool onGround = false;
   // [SerializeField]

    void Start()
    {
        LMA = this.gameObject;
        LMAStartTrans = LMA.transform;
        LMASpawnPos = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
        LMASpawnRot = new Vector3(this.transform.rotation.x, this.transform.rotation.y, this.transform.rotation.z);
    }

    
    void Update()
    {
        if(onGround)
        {
            LMA.transform.position = LMASpawnPos;
            LMA.transform.rotation = LMAStartTrans.rotation;
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

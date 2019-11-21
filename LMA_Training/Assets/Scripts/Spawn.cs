using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject spawn;
    private Vector3 spawnPosition;
    private Vector3 spawnRotaion;
    private bool inSpawn;

    void Start()
    {
        spawnPosition = spawn.transform.position;
        spawnRotaion = spawn.transform.eulerAngles;

        
        //SpawnPoint();
    }

    void Update()
    {
        if(!inSpawn)
        {
            SpawnPoint();
        }
    }

    private void SpawnPoint()
    {
        this.transform.position = spawnPosition;
        this.transform.eulerAngles = spawnRotaion;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Spawn"))
        {
            Debug.Log("Spawn");
            inSpawn = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //SpawnPoint();
        inSpawn = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameObject player;
    private Vector3 startPosition;
    private Vector3 startRotaion;
    

    void Start()
    {
        player = this.gameObject;
        startPosition = player.transform.position;
        startRotaion = player.transform.eulerAngles;

        player.transform.position = startPosition;
        player.transform.eulerAngles = startRotaion;
    }

    void Update()
    {
        
    }
}

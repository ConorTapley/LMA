using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAfterAnim : MonoBehaviour
{
    public GameObject loadingBar;
    public int waitTime;

    // Start is called before the first frame update
    void Start()
    {
        loadingBar.SetActive(false);
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(waitTime);
        Debug.Log("Wait Time Over");

        loadingBar.SetActive(true);
        
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleSceneManager : MonoBehaviour
{
    public int loadSceneIndex;
    public int WaitTime;

    public void Start()
    {
        StartCoroutine(loadNextScene());
    }


    public void Update()
    {
        
    }

   IEnumerator loadNextScene()
    {
        yield return new WaitForSeconds(WaitTime);
        SceneManager.LoadScene(loadSceneIndex);

    }

    
}
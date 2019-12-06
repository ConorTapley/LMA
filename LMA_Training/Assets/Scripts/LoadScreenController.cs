using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadScreenController : MonoBehaviour
{

    public GameObject LoadBar;
    public Slider m_slider;

    public float LoadBarFakeTimer = 0.5f;
    public float fillQuantity = 0.1f;

    public void Start()
    {
        StartCoroutine(FillSlider());
    }
    public IEnumerator FillSlider()
    {
        yield return new WaitForSeconds(LoadBarFakeTimer);
        m_slider.value += fillQuantity;

        if(m_slider.value >= 0.9f)
        {
            SceneManager.LoadScene(1);
        }
        StartCoroutine(FillSlider());
    }
}


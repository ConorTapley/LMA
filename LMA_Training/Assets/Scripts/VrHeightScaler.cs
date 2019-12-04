using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VrHeightScaler : MonoBehaviour
{
    [SerializeField] private float defaultHeight = 1f;

    private void Start()
    {
        this.transform.localScale = new Vector3(this.transform.localScale.x, defaultHeight, this.transform.localScale.z);
    }

    private void Update()
    {
        this.transform.localScale = new Vector3(this.transform.localScale.x, defaultHeight, this.transform.localScale.z);
    }

    public void IncreseHeightButton()
    {
        defaultHeight += .1f;
    }

    public void DecreseHeightButton()
    {
        defaultHeight -= .1f;
    }
}

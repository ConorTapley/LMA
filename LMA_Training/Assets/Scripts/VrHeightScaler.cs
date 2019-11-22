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
}

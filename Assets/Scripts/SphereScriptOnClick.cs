using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScriptOnClick : MonoBehaviour
{
    public GameObject sphereTextOnHover;
    // Start is called before the first frame update
    void Start()
    {
        sphereTextOnHover.SetActive(false);
    }

    void OnMouseDown()
    {
        // Destroy the gameObject after clicking on it
        if (sphereTextOnHover.activeSelf == true)
        {
            sphereTextOnHover.SetActive(false);
        } else
        {
            sphereTextOnHover.SetActive(true);
        }
    }
}

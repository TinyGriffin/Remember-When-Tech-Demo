using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour
{
    public GameObject sphereText;
    // Start is called before the first frame update
    void Start()
    {
        sphereText.SetActive(false);
    }

    void OnMouseOver()
    {
        sphereText. SetActive(true);
    }

    void OnMouseExit()
    {
        sphereText. SetActive(false);
    }
}

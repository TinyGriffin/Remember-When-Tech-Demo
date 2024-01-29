using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleObjectScript : MonoBehaviour
{
    public GameObject textOnHover;
    public GameObject textOnClick;
    
    void Start()
    {
        textOnHover.SetActive(false);
        textOnClick.SetActive(false);
    }
    
    void OnMouseOver()
    {
        textOnHover.SetActive(true);
    }

    void OnMouseExit()
    {
        textOnHover.SetActive(false);
    }
    
    void OnMouseDown()
    {
        if (textOnClick.activeSelf == false)
        {
            textOnClick.SetActive(true);
            Invoke(nameof(DisappearText), 5f);
        } 
    }

    private void DisappearText()
    {
        textOnClick.SetActive(false);
    }
}

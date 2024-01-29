using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleDoorScript : MonoBehaviour
{
    private PuzzleTrackerScript _puzzleTracker;
    public GameObject textOnHover;
    public GameObject textOnClick;
    void Start()
    {
        _puzzleTracker = GameObject.Find("PuzzleTracker").GetComponent<PuzzleTrackerScript>();
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
        if (_puzzleTracker.PuzzleSolved())
        {
            textOnHover.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            textOnClick.SetActive(true);
            Invoke(nameof(DisappearText), 3f);
        }
    }
    
    private void DisappearText()
    {
        textOnClick.SetActive(false);
    }
}

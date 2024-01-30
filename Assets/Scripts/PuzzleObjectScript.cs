using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleObjectScript : MonoBehaviour
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
        if (gameObject.name == "PUZZLE_radiator") 
            _puzzleTracker.ClickedRadiator();
        else if (gameObject.name == "PUZZLE_chest")
            _puzzleTracker.ClickedChest();
        else if (gameObject.name == "PUZZLE_nightstand")
            _puzzleTracker.ClickedNightstand();
        
        if (textOnClick.activeSelf == false)
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

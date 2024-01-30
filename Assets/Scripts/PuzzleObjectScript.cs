using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleObjectScript : MonoBehaviour
{
    private PuzzleTrackerScript _puzzleTracker;
    
    public GameObject textOnHover;
    public GameObject textOnClick;


    private void Awake()
    {
        textOnHover.SetActive(false);
        textOnClick.SetActive(false);
    }

    void Start()
    {
        _puzzleTracker = GameObject.Find("PuzzleTracker").GetComponent<PuzzleTrackerScript>();
        // textOnHover.SetActive(false);
        // textOnClick.SetActive(false);
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
        // yeah this is very temp. and very jank >.> should be improved when we make the final project
        
        if (gameObject.name == "PUZZLE_radiator") 
            _puzzleTracker.ClickedRadiator();
        else if (gameObject.name == "PUZZLE_chest")
            _puzzleTracker.ClickedChest();
        else if (gameObject.name == "PUZZLE_nightstand")
            _puzzleTracker.ClickedNightstand();
        else if (gameObject.name == "PUZZLE_chest_ghost")
            _puzzleTracker.ClickedGhostChest();
        else if (gameObject.name == "PUZZLE_mattress_ghost")
            _puzzleTracker.ClickedGhostMattress();
        else if (gameObject.name == "PUZZLE_key_ghost")
            _puzzleTracker.ClickedGhostKey();
        
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

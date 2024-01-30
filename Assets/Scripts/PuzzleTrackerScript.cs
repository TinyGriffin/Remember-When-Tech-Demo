using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleTrackerScript : MonoBehaviour
{
    public bool radiatorClicked = false;
    public bool chestClicked = false;
    public bool nightstandClicked = false;
    public bool ghostKeyClicked = false;
    public bool ghostMattressClicked = false;
    public bool ghostChestClicked = false;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void ClickedRadiator()
    {
        radiatorClicked = true;
    }
    
    public void ClickedChest()
    {
        chestClicked = true;
    }
    
    public void ClickedNightstand()
    {
        nightstandClicked = true;
    }
    
    public void ClickedGhostKey()
    {
        ghostKeyClicked = true;
    }
    
    public void ClickedGhostMattress()
    {
        ghostMattressClicked = true;
    }
    
    public void ClickedGhostChest()
    {
        ghostChestClicked = true;
    }

    public bool PuzzleSolved()
    {
        return ghostMattressClicked && ghostKeyClicked && ghostChestClicked && radiatorClicked && chestClicked && nightstandClicked;
    }
}

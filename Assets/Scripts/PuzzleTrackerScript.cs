using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleTrackerScript : MonoBehaviour
{
    public bool radiatorClicked = false;
    public bool chestClicked = false;
    public bool nightstandClicked = false;
    
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

    public bool PuzzleSolved()
    {
        return radiatorClicked && chestClicked && nightstandClicked;
    }
}

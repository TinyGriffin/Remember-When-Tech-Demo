using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool user;

    public Transform cameraPos;

    public Transform orientation;
    
    private Players _allPlayers;

    private void Awake()
    {
        _allPlayers = GetComponentInParent<Players>();
    }

    public void UserBrain()
    {
        user = true;
        var lastPlayer = _allPlayers._currentPlayer;
        _allPlayers._currentPlayer = this;
        if (lastPlayer != null)
            lastPlayer.user = false;
    }
    public void DummyBrain()
    {
        // This will be when we start having the playwer do other things
        // when not in use. Like idles
        user = false;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwitching : MonoBehaviour
{
    public KeyCode switchKey = KeyCode.Q;
    private Players _allPlayers;
    public GameObject SpiritRealm;

    private void Awake()
    {
        _allPlayers = GetComponent<Players>();
    }

    private void Start()
    {
        SelectPlayerOnStart();
    }

    private void Update()
    {
        if (Input.GetKeyDown(switchKey))
        {
            Debug.Log("Clicked");
            SwitchPlayer();
        }
    }

    void FixedUpdate()
    {

    }
    private void SwitchPlayer()
    {
        // This is kind of jank but I will fix it later
        if (_allPlayers._allPlayers[0] != _allPlayers._currentPlayer)
        {
            if (_allPlayers._allPlayers[0] != null)
                _allPlayers._allPlayers[0].UserBrain();
            SpiritRealm.SetActive(false);

        }
        else if (_allPlayers._allPlayers[1] != _allPlayers._currentPlayer)
        {
            if (_allPlayers._allPlayers[1] != null)
                _allPlayers._allPlayers[1].UserBrain();
                SpiritRealm.SetActive(true);

        }     
        
    }

    private void SelectPlayerOnStart(){
        if (_allPlayers._allPlayers[0] != null)
            _allPlayers._allPlayers[0].UserBrain();
    }
}
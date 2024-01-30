using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players : MonoBehaviour
{
    public List<Player> _allPlayers;
    public Player _currentPlayer;

    private void Awake(){
        _allPlayers = new List<Player>(GetComponentsInChildren<Player>());
    }
}
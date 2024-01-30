using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    private Players _allPlayers;

    void Awake()
    {
         _allPlayers = GetComponentInParent<Players>();
    }
    

    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = _allPlayers._currentPlayer.cameraPos.position;
    }
}

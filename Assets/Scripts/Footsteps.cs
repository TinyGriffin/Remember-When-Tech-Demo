using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Footsteps : MonoBehaviour
{
    public AudioSource footstepsSound;
    
    void Start()
    {
        footstepsSound = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (Input.GetKey((KeyCode.W)) || Input.GetKey((KeyCode.A)) || Input.GetKey((KeyCode.S)) || Input.GetKey((KeyCode.D)))
        {
            footstepsSound.enabled = true;
        }
        else
        {
            footstepsSound.enabled = false;
        }
    }
}

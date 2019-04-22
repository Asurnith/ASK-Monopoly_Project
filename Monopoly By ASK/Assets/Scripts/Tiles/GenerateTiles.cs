using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Audio.Google;

public class GenerateTiles : MonoBehaviour
{

    public enum TileType
    {
        Property,
        CommunityChest,
        Chance,
        Tax,
        FreeParking,
        Go,
        GoToJail,
        Jail
    }


    public Tile[] tiles = new Tile[40];
    
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
}

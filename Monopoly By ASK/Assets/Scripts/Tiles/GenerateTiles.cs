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

    public void Generate(Tile[] tiles)
    {
        foreach (var tile in tiles)
        {
            tile.GenerateBasicTile(tile);
            tile.tileIndex = Array.IndexOf(tiles, tile);
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
       Generate(tiles);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Audio.Google;

public class GenerateTiles : MonoBehaviour
{

    public enum TileType
    {
        property,
        communityChest,
        chance,
        tax,
        freeParking,
        go,
        goToJail,
        jail
    }

    
    public Tile[] tiles;
   
    
    
    // Start is called before the first frame update
    void Start()
    {
        foreach (var tile in tiles)
        {
            tile.tileIndex = tiles.tileInxe
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
}

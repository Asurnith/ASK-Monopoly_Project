using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardBehavior : Tile
{
    private bool _isChance;

    public override void TileEffect(GameObject player)
    {
        if (_isChance)
        {
            //dequeue from Chance Queue
        }
        else
        {
            //dequeue from CC Queue 
        }
    }
    
    
}


using System.Collections;
using System.Collections.Generic;
using Player;
using UnityEngine;

public static class GameLoop
{
    public static List<GameObject> _players;
    public static int currentPlayer;
    
    private static GameObject _tileManager;


    // Start is called before the first frame update

    private static void Round()
   
    {
    }
    
    public static void Turn(GameObject player, int rollValue)
    {
        player.GetComponent<Position>().MovePlayer(rollValue);
       //Trading and other stuff
    }

    public static void CheckTileEffect(GameObject player)
    {
        _tileManager.GetComponent<GenerateTiles>().tiles[player.GetComponent<Position>().CurrentIndex].TileEffect(player);
    }
}


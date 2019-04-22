using System.Collections;
using System.Collections.Generic;
using Player;
using UnityEngine;

public static class GameLoop
{
    [SerializeField] public static List<GameObject> _players;
    [SerializeField] private static GameObject _dice;

    [SerializeField] private static GameObject _tileManager;


    // Start is called before the first frame update

    private static void Round()
    {
        foreach (var player in _players)
            Turn(player);
    }
    
    private static void Turn(GameObject player)
    {
        player.GetComponent<Position>().MovePlayer(_dice.GetComponent<Dice>().Roll());
       //Trading and other stuff
    }

    public static void CheckTileEffect(GameObject player)
    {
        _tileManager.GetComponent<GenerateTiles>().tiles[player.GetComponent<Position>().CurrentIndex].TileEffect(player);
    }
}


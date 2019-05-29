using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] public static List<GameObject> players;
    [SerializeField] private static GameObject _tileManager;
    
    public static int currentPlayer;
    private static void Round()
    {
        
    }
    
    public static void Turn(GameObject player, int rollValue)
    {
        player.GetComponent<Position>().MovePlayer(rollValue);
    }

    public static void CheckTileEffect(GameObject player)
    {
        _tileManager.GetComponent<GenerateTiles>().tiles[player.GetComponent<Position>().CurrentIndex].TileEffect(player);
    }
    
    
}

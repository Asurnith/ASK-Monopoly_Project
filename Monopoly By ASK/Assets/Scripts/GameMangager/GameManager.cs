using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private PlayerManager _playerManager;
    [SerializeField] private static GameObject _tileManager;

    [SerializeField] private static Dice _dice;
    
    public static int currentPlayer;

    [SerializeField] public Player currentPiece;
    
    private static void Round(Player currentPlayer)
    {
        
    }
    
    public static void Turn(Player player, int rollValue)
    {
        player.GetComponent<Position>().MovePlayer(rollValue, player);
    }

    public static void CheckTileEffect(Player player)
    {
        _tileManager.GetComponent<GenerateTiles>().tiles[player.GetComponent<Position>().CurrentIndex].TileEffect(player);
    }

    private void Start()
    {
        _dice.Roll(currentPiece);
    }
}

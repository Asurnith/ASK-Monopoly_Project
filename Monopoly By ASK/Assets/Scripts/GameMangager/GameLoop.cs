using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameLoop
{
    [SerializeField] public static List<GameObject> _players;
    [SerializeField] private static GameObject _dice;

    [SerializeField] private static GameObject _tileManager;


    // Start is called before the first frame update

    private static void Round()
    {
        foreach (var player in players)
            Turn(player);
    }
    
    private static void Turn(GameObject player)
    {
        player.GetComponent<Position>().MovePlayer(_dice.GetComponent<Dice>().Roll());
       _tileManager.GetComponent<GenerateTiles>().tiles[player.GetComponent<Position>().currentIndex].TileEffect(player);
       //Trading and other stuff
    }
}

//Main Menu 
// Have a start button that starts the game and a quit button (during the game only)
// Have a list that has the option of adding or subtracting players (Min players -2, Max players -8)
// Have the option of giving each player a name (OPTIONAL)
// Add a "RULES" button to accommodate for new players (OPTIONAL)

//What a game should have
//Main Menu (DONE)
//
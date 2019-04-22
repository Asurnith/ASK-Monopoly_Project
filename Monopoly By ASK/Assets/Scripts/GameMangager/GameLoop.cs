using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoop : MonoBehaviour
{
    [SerializeField] public List<GameObject> players;
    [SerializeField] private GameObject _dice, 
                                        _tileManager;
    
  
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Round()
    {
        foreach (var player in players)
            Turn(player);
    }
    
    private void Turn(GameObject player)
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
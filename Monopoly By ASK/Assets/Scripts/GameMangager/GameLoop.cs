using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoop : MonoBehaviour
{
    [SerializeField] public List<GameObject> _players;
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
        foreach (var player in _players)
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
// Have a start button that starts the game
// 
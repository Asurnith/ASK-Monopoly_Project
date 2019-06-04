using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{    
    [SerializeField] private GameObject[] inputFields = new GameObject[8];
    [SerializeField] private static PlayerManager _playerManager;
    public String names;

    private int activePlayers = 2;

    public void PlayGame(List<String> names)
    {
        for (int i = 0; i < activePlayers; ++i)
        {
           _playerManager.players[i] = gameObject.AddComponent<Player>(); 
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    
    }
}

//Main Menu 
// Have a start button that starts the game and a quit button (during the game only)
// Have a list that has the option of adding or subtracting players (Min players -2, Max players -8)
// Have the option of giving each player a name (OPTIONAL)
// Add a "RULES" button to accommodate for new players (OPTIONAL)
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{    
    [SerializeField] private GameObject[] inputFields = new GameObject[8];
    private List<String> names;

    private int totalPlayers = 2;

    public void getPlayerCount(GameObject[] inputFields)
    {
        foreach (var inputField in inputFields)
        {
            if (inputField.GetComponent(GameObject.SetActive(true)))
            {
                
                
            }
        }
    }

    public void genNameList(int totalPlayers, String name)
    {

        for (int i = 0; i < names.Count; ++i)
        {
            GameManager.players.Add(new GameObject(name));
        }
        
    }

    public void PlayGame()
    {
        
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
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> players;
    
    // Start is called before the first frame update
    void Start()
    {
        GameLoop._players = players;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Audio.Google;

public class GenerateBoard : MonoBehaviour
{
    public GameObject tile = new GameObject();
    public GameObject cornerTile = new GameObject();
    public GameObject[] tiles = new GameObject[36];
    public GameObject[] cornerTiles = new GameObject[4];
    
    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i < tiles.Length; ++i)
        {

            GameObject gameTile = Instantiate(tile);
            gameTile.transform.position = transform.position;

        }

        for (int i = 0; i < cornerTiles.Length; ++i)
        {
            
            
            
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

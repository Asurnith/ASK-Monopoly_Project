using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Audio.Google;

public class GenerateBoard : MonoBehaviour
{

    public GameObject[] basicTiles;
    public GameObject[] cornerTiles;
    
    // Start is called before the first frame update
    void Start()
    {
        
        basicTiles = new GameObject[36];
        basicTiles = Resources.LoadAll("/Prefab/Tile") as GameObject[];

        for (int i = 0; i < basicTiles.Length; ++i)
        {

            basicTiles[i] = Instantiate(basicTiles[i]) as GameObject;

        }
        
        cornerTiles = new GameObject[4];
        cornerTiles = Resources.LoadAll("/Prefab/Corner Tile") as GameObject[];

        for (int i = 0; i < cornerTiles.Length; ++i)
        {
            
            cornerTiles[i] = Instantiate(cornerTiles[i]) as GameObject;

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

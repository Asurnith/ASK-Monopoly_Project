using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Tile : MonoBehaviour
{

    [SerializeField]private GenerateTiles.TileType tileType;
    public int tileIndex { get; set; }
        
        
    public Vector3 tileLocation;
    public String tileName;

    // Start is called before the first frame update
    void Start()
    {
        tileLocation = transform.position;
        tileName = name;
        tie
       
    }

    // Update is called once per frame
    void Update()
    {

    }
}

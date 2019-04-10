using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


public abstract class Tile : MonoBehaviour
{

    [SerializeField]private GenerateTiles.TileType tileType;        
        
    public int tileIndex;
    public String tileName;
    public Vector3 tileLocation;

    public abstract void TileEffect(GameObject player);

    public void GenerateBasicTile(Tile tile)
    {
        this.tileName = this.name;
        this.tileLocation = this.transform.position;
        this.tileType = (GenerateTiles.TileType) Enum.Parse(typeof(GenerateTiles.TileType), tag);

    }
    
    

}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PropertyBehavior: Tile
{
    
    public int tileMortgage;
    public int tilePrice;
    public GameObject owner; 
    public int tileRent => CaluclateRent();

    protected abstract int CaluclateRent();


}

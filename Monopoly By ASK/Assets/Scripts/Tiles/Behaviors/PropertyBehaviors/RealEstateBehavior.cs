using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealEstateBehavior : PropertyBehavior
{
    public bool monopoly;
    public int houseCost;
    public int hotelCost;
    public int houseCount;
    public bool hasHotel;
    
    public int[] rentValues = new int[7];
    
    public override void TileEffect(GameObject player)
    {
        
        
    }

    protected override int CaluclateRent()
    {
        return rentValues[(monopoly ? 1 : 0) + houseCount + (hasHotel ? 1 : 0)];
    }
}

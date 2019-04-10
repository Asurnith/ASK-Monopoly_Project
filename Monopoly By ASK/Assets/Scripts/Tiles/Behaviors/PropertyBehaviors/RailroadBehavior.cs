using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RailroadBehavior : PropertyBehavior
{
  
    private int _railroadsOwned;
    private int[] rentValues = {25, 50, 100, 200};

    public override void TileEffect(GameObject player)
    {
       _railroadsOwned = CheckOwnedRailroads(player);

    }

    private int CheckOwnedRailroads(GameObject player)
    {
        //Incomplete Method
        return 2;
        
    }
    
    protected override int CaluclateRent()
    {
        return rentValues[_railroadsOwned];
    }

}

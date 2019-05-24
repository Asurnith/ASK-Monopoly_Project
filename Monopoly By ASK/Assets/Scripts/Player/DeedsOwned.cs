using System.Collections.Generic;
using UnityEngine;


    public class DeedsOwned : Player
    {
        public void BuyProperties(Tile property)
        {
            GetComponent<AmountOfMoney>().ChangeBalance(-property.GetComponent<PropertyBehavior>().tilePrice);
            propertiesOwned.Add(property);
        }
    
        public int getOutOfJailCards = 0; 

    }


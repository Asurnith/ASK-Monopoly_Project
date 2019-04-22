using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class DeedsOwned : MonoBehaviour
    {
        public List<Tile> propertiesOwned = new List<Tile>();

        public void BuyProperties(Tile property)
        {
            GetComponent<AmountOfMoney>().ChangeBalence(-property.GetComponent<PropertyBehavior>().tilePrice);
            propertiesOwned.Add(property);
        }
    
        public int getOutOfJailCards = 0; 


    }
}

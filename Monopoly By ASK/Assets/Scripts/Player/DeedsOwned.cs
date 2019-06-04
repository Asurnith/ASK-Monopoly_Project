using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;


    public class DeedsOwned : Piece
    {
        
        public List<Tile> propertiesOwned = new List<Tile>();

        public void BuyProperties(Tile property)
        {
            GetComponent<AmountOfMoney>().ChangeBalance(-property.GetComponent<PropertyBehavior>().tilePrice);
            propertiesOwned.Add(property);
        }
    
        public int getOutOfJailCards = 0;

        public int getGOOJNum()
        {
            return getOutOfJailCards;
        }

    }


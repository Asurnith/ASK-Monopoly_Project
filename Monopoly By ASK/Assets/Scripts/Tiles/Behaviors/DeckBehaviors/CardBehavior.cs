using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class CardBehavior : Tile
{
    [SerializeField] private GameObject _deck;
    public override void TileEffect(GameObject player)
    {
        GameObject card = _deck.GetComponent<Deck>().deck.Dequeue();
        
        switch (card.GetComponent<Transform>().name)
        {
            case "consultancyFee":
                player.GetComponent<AmountOfMoney>().ChangeBalence(25);
                break;
            case 
        }
            
    }

    public void PayPlayer(int value, GameObject player)
    {
        GetComponent<AmountOfMoney>().Pay(value, player); 
    }

    public void PayBank(int value)
    {
        GetComponent<AmountOfMoney>().ChangeBalence(-value);
    }

    public void ReciveMoney(int value)
    {
        GetComponent<AmountOfMoney>().ChangeBalence(value);
    }

    public void GoTo(int index, bool doWePassGo)
    {
        GetComponent<Position>().MoveToTile(index, doWePassGo);
    }
    
    
}


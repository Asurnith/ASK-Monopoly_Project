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
            case "streetRepairs":
                //wait for house system, houses owned x 40, hotels owned x 115
                break;
            case "schoolFee":
                player.GetComponent<AmountOfMoney>().ChangeBalence(-50);
                break;
            case "getOutOfJail":
                //jail cards counter ++ in "deeds owned" 
                break;
            case "lifeInsuranceMature":
                player.GetComponent<AmountOfMoney>().ChangeBalence(100);
                break;
            case "wonBeautyContest":
                player.GetComponent<AmountOfMoney>().ChangeBalence(10);
                break;
            case "birthdayGift":
                //foreach player in the player list, pays card holder $10
                break;
            case "incomeTaxRefund":
                player.GetComponent<AmountOfMoney>().ChangeBalence(20);
                break;
            case "doctorsFee":
                player.GetComponent<AmountOfMoney>().ChangeBalence(-50);
                break;
            case "goToJail" :
                player.GetComponent<Position>().MoveToTile(41, true);
                break;
            case "stocks" :
                player.GetComponent<AmountOfMoney>().ChangeBalence(50);
                break;
            case "Go" :
                player.GetComponent<Position>().MoveToTile(0, false);
                break;
            case "holidayFundMature" :
                player.GetComponent<AmountOfMoney>().ChangeBalence(100);
                break; 
            case "inherit" :
                player.GetComponent<AmountOfMoney>().ChangeBalence(100);
                break;
            case "bankError" :
                player.GetComponent<AmountOfMoney>().ChangeBalence(200);
                break; 
            case "hospitalFee" :
                player.GetComponent<AmountOfMoney>().ChangeBalence(-100);
                break;
            case "goToJailTwo" :
                player.GetComponent<Position>().MoveToTile(40, true);
                break;
            case "buildingLoanMature" :
                player.GetComponent<AmountOfMoney>().ChangeBalence(150);
                break;
            case "payedByBank" :
                player.GetComponent<AmountOfMoney>().ChangeBalence(50);
                break; 
            case "boardWalk" :
                player.GetComponent<Position>().MoveToTile(39,false );
                break;
            case ""
                
                
                
            

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


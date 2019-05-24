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
                player.GetComponent<AmountOfMoney>().ChangeBalance(25);
                break;
            case "streetRepairs":
                //wait for house system, houses owned x 40, hotels owned x 115
                break;
            case "schoolFee":
                player.GetComponent<AmountOfMoney>().ChangeBalance(-50);
                break;
            case "getOutOfJail":
                player.GetComponent<DeedsOwned>().getOutOfJailCards++;   
                break;
            case "lifeInsuranceMature":
                player.GetComponent<AmountOfMoney>().ChangeBalance(100);
                break;
            case "wonBeautyContest":
                player.GetComponent<AmountOfMoney>().ChangeBalance(10);
                break;
            case "birthdayGift":
                foreach (var otherPLayers in GameManager.players)
                {
                    otherPLayers.GetComponent<AmountOfMoney>().Pay(10, player);
                }
                break;
            case "incomeTaxRefund":
                player.GetComponent<AmountOfMoney>().ChangeBalance(20);
                break;
            case "doctorsFee":
                player.GetComponent<AmountOfMoney>().ChangeBalance(-50);
                break;
            case "goToJail" :
                player.GetComponent<Position>().MoveToTile(-1, true);
                break;
            case "stocks" :
                player.GetComponent<AmountOfMoney>().ChangeBalance(50);
                break;
            case "Go" :
                player.GetComponent<Position>().MoveToTile(0, false);
                break;
            case "holidayFundMature" :
                player.GetComponent<AmountOfMoney>().ChangeBalance(100);
                break; 
            case "inherit" :
                player.GetComponent<AmountOfMoney>().ChangeBalance(100);
                break;
            case "bankError" :
                player.GetComponent<AmountOfMoney>().ChangeBalance(200);
                break; 
            case "hospitalFee" :
                player.GetComponent<AmountOfMoney>().ChangeBalance(-100);
                break;
            case "goToJailTwo" :
                player.GetComponent<Position>().MoveToTile(-1, true);
                break;
            case "buildingLoanMature" :
                player.GetComponent<AmountOfMoney>().ChangeBalance(150);
                break;
            case "payedByBank" :
                player.GetComponent<AmountOfMoney>().ChangeBalance(50);
                break; 
            case "boardWalk" :
                player.GetComponent<Position>().MoveToTile(39,false );
                break;
            case "GoTwo" :
                player.GetComponent<Position>().MoveToTile(0, false);
                break; 
            case "generalPropertyRepairs" :
                //house system, houses owned x 25, hotels owned x 100
                break;
            case "getOutOfJailTwo" :
                player.GetComponent<DeedsOwned>().getOutOfJailCards++;
                break;
            case "st.CharlesPLace" :
                player.GetComponent<Position>().MoveToTile(11, false);
                break;
            case "illinois" :
                player.GetComponent<Position>().MoveToTile(24, false);
                break;
            case "backThreeSpaces" :
                player.GetComponent<Position>().MovePlayer(-3);
                break;
            case "speeding" :
                player.GetComponent<AmountOfMoney>().ChangeBalance(-15);
                break;
            case "readingRailRoad" :
                player.GetComponent<Position>().MoveToTile(5, false);
                break;
            case "electedChairMan" :
                foreach (var otherPlayers in GameManager.players)
                    player.GetComponent<AmountOfMoney>().Pay(50, otherPlayers);
                break;
            case "nearestRailRoad" :
                int index = player.GetComponent<Position>().CurrentIndex;
                if (35 < index && index < 25)
                    player.GetComponent<Position>().MoveToTile(35, false);
                else if(25 < index && index < 15)
                    player.GetComponent<Position>().MoveToTile(25, false);
                else if(15 < index && index < 5)
                    player.GetComponent<Position>().MoveToTile(15, false);
                else
                    player.GetComponent<Position>().MoveToTile(5, false);
                break;
            case "nearestRailRoadTwo" :
                int index2 = player.GetComponent<Position>().CurrentIndex;
                if (35 < index2 && index2 < 25)
                    player.GetComponent<Position>().MoveToTile(35, false);
                else if(25 < index2 && index2 < 15)
                    player.GetComponent<Position>().MoveToTile(25, false);
                else if(15 < index2 && index2 < 5)
                    player.GetComponent<Position>().MoveToTile(15, false);
                else
                    player.GetComponent<Position>().MoveToTile(5, false);
                break;
            case "nearestUtility" :
                int index3 = player.GetComponent<Position>().CurrentIndex;
                if (28 < index3 && index3 < 12)
                    player.GetComponent<Position>().MoveToTile(28, false);
                else
                    player.GetComponent<Position>().MoveToTile(12, false);
                break;
            
                    
                
             
            

        }
            
    }

  
    
}


﻿using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Player;
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
                player.GetComponent<DeedsOwned>().getOutOfJailCards++;   
                break;
            case "lifeInsuranceMature":
                player.GetComponent<AmountOfMoney>().ChangeBalence(100);
                break;
            case "wonBeautyContest":
                player.GetComponent<AmountOfMoney>().ChangeBalence(10);
                break;
            case "birthdayGift":
                foreach (var otherPLayers in GameLoop._players)
                {
                    otherPLayers.GetComponent<AmountOfMoney>().Pay(10, player);
                }
                break;
            case "incomeTaxRefund":
                player.GetComponent<AmountOfMoney>().ChangeBalence(20);
                break;
            case "doctorsFee":
                player.GetComponent<AmountOfMoney>().ChangeBalence(-50);
                break;
            case "goToJail" :
                player.GetComponent<Position>().MoveToTile(40, true);
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
                player.GetComponent<AmountOfMoney>().ChangeBalence(-15);
                break;
            case "readingRailRoad" :
                player.GetComponent<Position>().MoveToTile(5, false);
                break;
            case "electedChairMan" :
                foreach (var otherPlayers in GameLoop._players)
                    player.GetComponent<AmountOfMoney>().Pay(50, otherPlayers);
                break;
                
                
                
            

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


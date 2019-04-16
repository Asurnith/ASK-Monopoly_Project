using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChanceBehavior : CardBehavior
{
    [SerializeField] private List<GameObject> ChanceCards;

    private void Start()
    {
        Queue<GameObject> ChanceDeck  = new Queue<GameObject>(ChanceCards); 
    }
    
}

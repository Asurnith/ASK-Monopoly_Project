using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    [SerializeField] private List<GameObject> _deck;
    public Queue<GameObject> deck { get; set; }

    private void Start()
    {
        for (int i = 0; i < 16; i++)
        {
            int index = Random.Range(0, _deck.Count);
            deck.Enqueue(_deck[index]);
            _deck.RemoveAt(index);
        }
    } 
}


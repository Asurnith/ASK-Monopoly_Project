using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] protected int[] _totalBills;
    
    [SerializeField] protected GameObject tileManager;

    public int CurrentIndex { get; set; }

    protected List<Tile> propertiesOwned = new List<Tile>();
    
  void Start()
    {
        _totalBills = new int[]
        {
            2,
            4,
            1,
            1,
            2,
            1,
            5
        };     
    }

}

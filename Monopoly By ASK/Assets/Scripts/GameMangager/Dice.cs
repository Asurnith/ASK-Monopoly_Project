using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    private int _totalValue;
    private int _diceOneValue, _diceTwoValue;
    [SerializeField] private GameObject dieOne, dieTwo;
    [SerializeField] private List<Sprite> _dieFaces;

    
    public int Roll()
    {
        StartCoroutine(RollAnim());
        return _totalValue;
    }

    private IEnumerator RollAnim()
    {         
        for (int i = 0; i < Random.Range(10, 21); i++)
        {
            _diceOneValue = Random.Range(0, 6) + 1;
            dieOne.GetComponent<SpriteRenderer>().sprite = _dieFaces[_diceOneValue - 1]; 
            _diceTwoValue = Random.Range(0, 6) + 1;
            dieTwo.GetComponent<SpriteRenderer>().sprite = _dieFaces[_diceTwoValue - 1];
            yield return new WaitForSeconds(.25f);
        }

        _totalValue = _diceOneValue + _diceTwoValue;
    }
}

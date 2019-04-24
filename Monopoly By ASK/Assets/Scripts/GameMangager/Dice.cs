using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dice : MonoBehaviour
{
    private int _totalValue;
    private int _diceOneValue, _diceTwoValue;
    [SerializeField] private GameObject dieOne, dieTwo;
    [SerializeField] private List<Sprite> _dieFaces;

    public void Roll()
    {
        StartCoroutine(RollAnim());
    }

    private IEnumerator RollAnim()
    {         
        for (int i = 0; i < Random.Range(15, 26); i++)
        {
            _diceOneValue = Random.Range(0, 6) + 1;
            dieOne.GetComponent<Image>().sprite = _dieFaces[_diceOneValue - 1]; 
            _diceTwoValue = Random.Range(0, 6) + 1;
            dieTwo.GetComponent<Image>().sprite = _dieFaces[_diceTwoValue - 1];
            yield return new WaitForSeconds(.05f);
        }

        _totalValue = _diceOneValue + _diceTwoValue;
        GameLoop.Turn(GameLoop._players[GameLoop.currentPlayer], _totalValue);
    }
}

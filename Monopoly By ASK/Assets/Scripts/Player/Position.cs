using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position : MonoBehaviour
{
    public int currentIndex { get; set; }
    public void MovePlayer(int spaces)
    {
        currentIndex += spaces;
        CheckGo(false);
    }

    public void MoveToTile(int tile, bool doNotPassGo)
    {
        if (currentIndex > tile)
            currentIndex = 40 + tile;
        else
            currentIndex = tile;
        CheckGo(doNotPassGo);
    }

    private void CheckGo(bool doNotPassGo)
    {
        if (currentIndex >= 40 && !doNotPassGo)
            GetComponent<AmountOfMoney>().ChangeBalence(200);
        currentIndex %= 40;
    }
}

using System.Collections;
using UnityEngine;

    public class Position : Piece
    {
        [SerializeField] protected GameObject tileManager;
        
        public int CurrentIndex { get; set; }

        private IEnumerator MoveAnim(int spaces, Player player)
        {
            for (var i = 0; i < spaces; ++i)
            {
                CurrentIndex++;
                CheckGo(false);
                this.transform.position = tileManager.GetComponent<GenerateTiles>().tiles[CurrentIndex].tileLocation;
                yield return new WaitForSeconds(0.75f);
            }
            GameManager.CheckTileEffect(player);
        }

        public void MovePlayer(int spaces, Player player)
        {
            StartCoroutine(MoveAnim(spaces, player));
        }

        public void MoveToTile(int tile, bool doNotPassGo, Player player)
        {
            if (CurrentIndex > tile)
                CurrentIndex = 40 + tile;
            else
                CurrentIndex = tile;
            CheckGo(doNotPassGo);
        GameManager.CheckTileEffect(player);
        }

        private void CheckGo(bool doNotPassGo)
        {
            if (CurrentIndex >= 40 && !doNotPassGo )
                GetComponent<AmountOfMoney>().ChangeBalance(200);
            if(CurrentIndex != 999)
                CurrentIndex %= 40;
        }
    }

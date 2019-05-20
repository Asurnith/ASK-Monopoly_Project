using System.Collections;
using UnityEngine;

namespace Player
{
    public class Position : MonoBehaviour
    {

        [SerializeField] private GameObject tileManager;
        public int CurrentIndex { get; private set; }

        private IEnumerator MoveAnim(int spaces)
        {
            for (int i = 0; i < spaces; ++i)
            {
                CurrentIndex++;
                CheckGo(false);
                this.transform.position = tileManager.GetComponent<GenerateTiles>().tiles[CurrentIndex].tileLocation;
                yield return new WaitForSeconds(0.75f);
            }
            GameManager.CheckTileEffect(gameObject);
        }

        public void MovePlayer(int spaces)
        {
            StartCoroutine(MoveAnim(spaces));
        }

        public void MoveToTile(int tile, bool doNotPassGo)
        {
            if (CurrentIndex > tile)
                CurrentIndex = 40 + tile;
            else
                CurrentIndex = tile;
            CheckGo(doNotPassGo);
        GameManager.CheckTileEffect(gameObject);
        }

        private void CheckGo(bool doNotPassGo)
        {
            if (CurrentIndex >= 40 && !doNotPassGo )
                GetComponent<AmountOfMoney>().ChangeBalence(200);
            if(CurrentIndex != 999)
                CurrentIndex %= 40;
        }
    }
}

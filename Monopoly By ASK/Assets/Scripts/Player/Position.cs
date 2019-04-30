using UnityEngine;

namespace Player
{
    public class Position : MonoBehaviour
    {

        [SerializeField] private GameObject tileManager;
        public int CurrentIndex { get; private set; }

        public void MovePlayer(int spaces)
        {
            CurrentIndex += spaces;
            CheckGo(false);
            this.transform.position = tileManager.GetComponent<GenerateTiles>().tiles[CurrentIndex].tileLocation;
            GameLoop.CheckTileEffect(gameObject);
        }

        public void MoveToTile(int tile, bool doNotPassGo)
        {
            if (CurrentIndex > tile)
                CurrentIndex = 40 + tile;
            else
                CurrentIndex = tile;
            CheckGo(doNotPassGo);
            GameLoop.CheckTileEffect(gameObject);
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

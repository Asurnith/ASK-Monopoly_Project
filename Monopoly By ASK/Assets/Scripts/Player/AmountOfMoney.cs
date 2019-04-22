using UnityEngine;

namespace Player
{
    public class AmountOfMoney : MonoBehaviour
    {
        [SerializeField] private int[] _totalBills;

        private int[] _billDenominations = new int[]
        {
            500,
            100,
            50,
            20,
            10,
            5,
            1
        };
    
        public int totalMoney
        {
            get { return CalculateMoney(); }
            set { SplitMoney(value); }
        }

        // Start is called before the first frame update
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

        private int CalculateMoney()
        {
            int total = 0;
        
            for (int i = 0; i < 7; i++)
                total += _totalBills[i] * _billDenominations[i];
        
            return total;
        }

        private void SplitMoney(int value)
        {
            for (int i = 0; i < 7; i++)
            {
                while (value >= _billDenominations[i])
                {
                    _totalBills[i]++;
                    value -= _billDenominations[i];
                }
            }      
        }

        public void ChangeBalence(int value)
        {
            totalMoney = value;
        }

        public void Pay(int value, GameObject player)
        {
            ChangeBalence(-value);
            player.GetComponent<AmountOfMoney>().ChangeBalence(value);
        }
    }
}

using UnityEngine;


    public class AmountOfMoney : Piece
    {
        
        [SerializeField] public int[] _totalBills;

        private readonly int[] _billDenominations = new int[]
        {
            500,
            100,
            50,
            20,
            10,
            5,
            1
        };
    
        private int TotalMoney
        {
            get { return CalculateMoney(); }
            set { SplitMoney(value); }
        }

        

        private int CalculateMoney()
        {
            var total = 0;
        
            for (var i = 0; i < 7; i++)
                total += _totalBills[i] * _billDenominations[i];
        
            return total;
        }

        private void SplitMoney(int value)
        {
            for (var i = 0; i < 7; i++)
            {
                while (value >= _billDenominations[i])
                {
                    _totalBills[i]++;
                    value -= _billDenominations[i];
                }
            }      
        }

        public void ChangeBalance(int value)
        {
            TotalMoney = value;
        }

        public void Pay(int value, GameObject player)
        {
            ChangeBalance(-value);
            player.GetComponent<AmountOfMoney>().ChangeBalance(value);
        }
        
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


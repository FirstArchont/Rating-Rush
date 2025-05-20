using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rating_Rush.Domain
{
    public class Player
    {
        public const int BestFame = 100;
        public const int WorstFame = -100;

        private int fame = 0;
        public int Money { get; set; }
        public int Fame { get => fame; set
            {
                if (value <= BestFame && value >= WorstFame)
                    fame = value;
            }
        }

        public bool HasPlayerLostDueToMoney()
        {
            if (Money < 0) 
                return true;
            return false;
        }

        public bool HasPlayerLostDueToFame()
        {
            if (Fame == -100) 
                return true;
            return false;
        }

        public void CountTaxes(Scenario scenario)
        {
            Money -= scenario.Tax;
            scenario.Tax += scenario.TaxDifference;
        }

        public void CountIncome((int fame, int money) results)
        {
            Fame += results.fame;
            Money += results.money;
        }
    }
}

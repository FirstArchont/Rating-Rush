using Rating_Rush.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace Rating_Rush.Domain
{
    public class Game
    {
        public int AmountOfDays { get; }
        public int AmountOfPassedDays { get; set; }
        public List<Day> Days { get; }
        public bool IsGameWined { get; set; }

        public Game(int scenario)
        {
            Days = new Scenario(scenario).Days;
            AmountOfDays = Days.Count;
            AmountOfPassedDays = 0;
            IsGameWined = false;
        }

        public void EndTheDay()
        {
            if (Days.Count > 0)
            {
                AmountOfPassedDays++;
                Days.RemoveAt(0);
            }
        }

        public bool IsGameEnded()
        {
            if (AmountOfPassedDays == AmountOfDays)
                return true;
            return false;
        }
    }
}

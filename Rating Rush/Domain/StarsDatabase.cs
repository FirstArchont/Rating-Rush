using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;
using System.Windows.Forms;

namespace Rating_Rush.Domain
{
    public class StarsDatabase
    {
        private Dictionary<string, int> Database;

        public StarsDatabase(Dictionary<string, int> database)
        {
            Database = database;
        }

        public KeyValuePair<string, int> FindCoincidence(string input)
        {
            return Database.FirstOrDefault(pair => pair.Key.ToLower().Replace(" ", "") == input.ToLower().Replace(" ", ""));
        }
    }
}

using NAudio.Utils;
using Rating_Rush.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Rating_Rush.Views
{
    public partial class DayResults : UserControl
    {
        private MainForm MainForm;
        private Gameplay CurrentGameplay;

        public DayResults(MainForm mainForm, Gameplay currentGameplay)
        {
            MainForm = mainForm;
            CurrentGameplay = currentGameplay;
            InitializeComponent();
            PlaceInformation();
        }

        private void PlaceInformation()
        {
            dayEnded.Text = CurrentGameplay.Game.AmountOfPassedDays.ToString() + " день окончен";
            moneyIncome.Text = (CurrentGameplay.Player.Money - CurrentGameplay.startMoney).ToString() + "$";
            fameIncome.Text = (CurrentGameplay.Player.Fame - CurrentGameplay.startFame).ToString() + "%";
            moviesRated.Text = CurrentGameplay.Day.RatedMovies.ToString() + "/" + CurrentGameplay.Day.AmountOfMovies.ToString();
            taxes.Text = string.Format("{0}$ - {1}$ = {2}$", CurrentGameplay.Player.Money, CurrentGameplay.Scenario.Tax, CurrentGameplay.Player.Money - CurrentGameplay.Scenario.Tax);
            CurrentGameplay.Player.CountTaxes(CurrentGameplay.Scenario);
            CurrentGameplay.UpdatePlayerInformation();
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainForm.Stage = GameStage.Gameplay;
            CurrentGameplay.Timer.Start();
            MainForm.Controls.Remove(this);
        }
    }
}

using NAudio.MediaFoundation;
using Rating_Rush.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rating_Rush.Views
{
    public partial class MainForm : Form
    {
        public GameStage Stage = GameStage.MainMenu;
        public float MusicVolume { get; set; } = 0.5f;
        public float SoundsVolume { get; set; } = 0.5f;
        public int SelectedScenario;
        int ScreenWidth = Screen.PrimaryScreen.Bounds.Width;
        int ScreenHeight = Screen.PrimaryScreen.Bounds.Height;
        //private const int ScreenWidth = 960;
        //private const int ScreenHeight = 540;
        private const int OriginalWidth = 1920;
        private const int OriginalHeight = 1080;

        public MainForm()
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
            ChangeStage();
            this.KeyPreview = true;
        }

        public void ChangeStage()
        {
            if (Stage == GameStage.MainMenu)
                ShowMainMenu();
            else if (Stage == GameStage.Gameplay)
                ShowGameplay();
            else if (Stage == GameStage.GameMenu)
                ShowGameMenu();
            else if (Stage == GameStage.RatingResult)
                ShowRatingResult();
            else if (Stage == GameStage.DayResults)
                ShowDayResults();
            else if (Stage == GameStage.Tutorial)
                ShowTutorial();
        }

        private void ShowTutorial()
        {
            var tutorial = new Tutorial(this, SelectedScenario);
            Controls.Add(tutorial);
            this.Focus();
        }

        private void ShowDayResults()
        {
            var dayResults = new DayResults(this, Controls.OfType<Gameplay>().First());
            Controls.Add(dayResults);
            dayResults.Location = new Point((int)(650 * ScreenWidth / OriginalWidth), (int)(200 * ScreenHeight / OriginalHeight));
            dayResults.BringToFront();
        }

        private void ShowRatingResult()
        {
            var ratingResult = new RatingResult(this, Controls.OfType<Gameplay>().First());
            Controls.Add(ratingResult);
            ratingResult.Location = new Point((int)(650 * ScreenWidth / OriginalWidth), (int)(200 * ScreenHeight / OriginalHeight));
            ratingResult.BringToFront();
        }

        private void ShowGameMenu()
        {
            var gameMenu = new GameMenu(this);
            Controls.Add(gameMenu);
            gameMenu.BringToFront();
        }

        private void ShowMainMenu()
        {
            var mainMenu = new mainMenu(this);
            Controls.Add(mainMenu);
        }

        private void ShowGameplay()
        {
            var gameplay = new Gameplay(this, SelectedScenario);
            Controls.Add(gameplay);
            this.Focus();
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Escape && (this.Controls.OfType<Gameplay>().FirstOrDefault() != null 
                || this.Controls.OfType<Tutorial>().FirstOrDefault() != null)
                && this.Controls.OfType<GameMenu>().Count() == 0 && this.Controls.OfType<RatingResult>().Count() == 0
                && this.Controls.OfType<DayResults>().Count() == 0)
            {
                Stage = GameStage.GameMenu;
                if (this.Controls.OfType<Gameplay>().FirstOrDefault() != null)
                {
                    this.Controls.OfType<Gameplay>().First().Timer.Stop();
                    this.Controls.OfType<Gameplay>().First().MusicPlayer.Pause();
                }
                else
                    this.Controls.OfType<Tutorial>().First().MusicPlayer.Pause();
                ChangeStage();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using Rating_Rush.Domain;

namespace Rating_Rush.Views
{
    public partial class mainMenu : UserControl
    {
        private WaveOutEvent MusicPlayer;
        private WaveOutEvent SoundsPlayer = new WaveOutEvent();
        private AudioFileReader MusicFile;
        private MainForm MainForm;

        public mainMenu(MainForm mainForm)
        {
            string solutionDir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string generationDir = Path.Combine(solutionDir, "Rating Rush", "For Generation");
            MusicFile = new AudioFileReader(Path.Combine(solutionDir, "Rating Rush", "Audio", "Menu", "Relaxing By The Sea.MP3"));
            MusicPlayer = new WaveOutEvent();
            MusicPlayer.Init(MusicFile);
            MainForm = mainForm;
            MusicPlayer.Volume = MainForm.MusicVolume;
            MusicPlayer.Play();
            InitializeComponent();
            MusicPlayer.PlaybackStopped += (sender, args) =>
            {
                if (MusicFile != null)
                {
                    MusicFile.Position = 0;
                    MusicPlayer.Play();
                }
            };
            SoundsPlayer.PlaybackStopped += SoundsPlayer_PlaybackStopped;
        }

        private void SoundsPlayer_PlaybackStopped(object sender, StoppedEventArgs args)
        {
            if (SoundsPlayer.PlaybackState == PlaybackState.Stopped)
                MusicPlayer.Volume = MainForm.MusicVolume;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            this.Controls.Add(settings);
            SetPosition(settings, 1920, 1080, 0, 0);
            settings.Controls.Add(this.musicVolume);
            musicVolume.Value = (int) (MainForm.MusicVolume * 10);
            settings.Controls.Add(soundsVolume);
            soundsVolume.Value = (int) (MainForm.SoundsVolume * 10);
            settings.Controls.Add(this.backSettingsButton);
            settings.BringToFront();
        }

        private void MusicVolume_Scroll(object sender, EventArgs e)
        {
            MainForm.MusicVolume = (float)musicVolume.Value / 10;
            MusicPlayer.Volume = MainForm.MusicVolume;
        }

        private void SoundsVolume_Scroll(object sender, EventArgs e)
        {
            MainForm.SoundsVolume = (float)soundsVolume.Value / 10;
            if (MainForm.SoundsVolume != 0)
            {
                SoundsPlayer.Volume = MainForm.SoundsVolume;
                ChooseSound("Box Office.mp3");
            }
        }

        private void ChooseSound(string sound)
        {
            SoundsPlayer.Dispose();
            string solutionDir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            var soundsFile = new AudioFileReader(Path.Combine(solutionDir, "Rating Rush", "Audio", "Sounds", Path.GetFileName(sound)));
            SoundsPlayer.Init(soundsFile);
            SoundsPlayer.Play();
        }

        private void BackSettingsButton_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(settings);
        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            this.Controls.Add(gameModMenu);
            gameModMenu.Controls.Add(backGameModButton);
            gameModMenu.Controls.Add(classicMode);
            gameModMenu.BringToFront();
        }

        private void BackGameModButton_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(gameModMenu);
        }

        private void ClassicMode_Click(object sender, EventArgs e)
        {
            gameModMenu.Controls.Add(difficultyLevels);
            difficultyLevels.BringToFront();
            difficultyLevels.Controls.Add(easyLevelButton);
            difficultyLevels.Controls.Add(middleLevelButton);
            difficultyLevels.Controls.Add(hardLevelButton);
            difficultyLevels.Controls.Add(backDifficultyButton);
        }

        private void TutorialButton_Click(object sender, EventArgs e)
        {
            MainForm.Stage = Domain.GameStage.Tutorial;
            MusicPlayer.Dispose();
            MusicFile = null;
            MainForm.SelectedScenario = Scenario.TutorialScenario;
            this.ParentForm.Controls.Remove(this);
            MainForm.ChangeStage();
        }

        private void InfinityGameModButton_Click(object sender, EventArgs e)
        {
            MainForm.Stage = Domain.GameStage.Gameplay;
            MusicPlayer.Dispose();
            MusicFile = null;
            MainForm.SelectedScenario = Scenario.InfinityScenario;
            this.ParentForm.Controls.Remove(this);
            MainForm.ChangeStage();
        }

        private void BackDifficultyButton_Click(object sender, EventArgs e)
        {
            gameModMenu.Controls.Remove(difficultyLevels);
        }

        private void EasyLevelButton_Click(object sender, EventArgs e)
        {
            MainForm.SelectedScenario = Scenario.EasyScenario;
            StartGame();
        }

        private void MiddleLevelButton_Click(object sender, EventArgs e)
        {
            MainForm.SelectedScenario = Scenario.MiddleScenario;
            StartGame();
        }

        private void HardLevelButton_Click(object sender, EventArgs e)
        {
            MainForm.SelectedScenario = Scenario.HardScenario;
            StartGame();
        }

        private void StartGame()
        {
            MainForm.Stage = Domain.GameStage.Gameplay;
            MusicPlayer.Dispose();
            MusicFile = null;
            this.ParentForm.Controls.Remove(this);
            MainForm.ChangeStage();
        }
    }
}

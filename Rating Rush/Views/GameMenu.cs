using NAudio.Wave;
using Rating_Rush.Domain;
using Rating_Rush.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio;

namespace Rating_Rush.Views
{
    public partial class GameMenu : UserControl
    {
        private Control Gameplay;
        private MainForm MainForm;
        private WaveOutEvent MusicPlayer;
        private AudioFileReader MusicFile;

        public GameMenu(MainForm mainForm)
        {
            MainForm = mainForm;
            InitializeComponent();
            string solutionDir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string generationDir = Path.Combine(solutionDir, "Rating Rush", "For Generation");
            MusicFile = new AudioFileReader(Path.Combine(solutionDir, "Rating Rush", "Audio", "Menu", "Relaxing By The Sea.MP3"));
            MusicPlayer = new WaveOutEvent();
            MusicPlayer.Init(MusicFile);
            MusicPlayer.Volume = MainForm.MusicVolume;
            MusicPlayer.Play();
            MusicPlayer.PlaybackStopped += (sender, args) =>
            {
                if (MusicFile != null)
                {
                    MusicFile.Position = 0;
                    MusicPlayer.Play();
                }
            };
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MusicPlayer.Dispose();
            MusicFile = null;
            if (MainForm.Controls.OfType<Gameplay>().FirstOrDefault() != null)
            {
                MainForm.Controls.OfType<Gameplay>().First().MusicPlayer.Play();
                MainForm.Controls.OfType<Gameplay>().First().Timer.Start();
                MainForm.Stage = GameStage.Gameplay;
            }
            else
            {
                MainForm.Controls.OfType<Tutorial>().First().MusicPlayer.Play();
                MainForm.Stage = GameStage.Tutorial;
            }
            MainForm.Controls.Remove(this);
        }

        private void BackToMainMenuButton_Click(object sender, EventArgs e)
        {
            MainForm.Stage = GameStage.MainMenu;
            MusicPlayer.Dispose();
            MusicFile = null;
            MainForm.Controls.Remove(this);
            if (MainForm.Controls.OfType<Gameplay>().FirstOrDefault() != null)
                MainForm.Controls.Remove(MainForm.Controls.OfType<Gameplay>().First());
            else
                MainForm.Controls.Remove(MainForm.Controls.OfType<Tutorial>().First());
            MainForm.ChangeStage();
        }

        private void SettingButton_Click(object sender, EventArgs e)
        {
            settings.Controls.Add(this.musicVolume);
            musicVolume.Value = (int) (MainForm.MusicVolume * 10);
            settings.Controls.Add(soundsVolume);
            soundsVolume.Value = (int) (MainForm.SoundsVolume * 10);
            settings.Controls.Add(this.backSettingsButton);
            mainGameMenuScreen.Controls.Add(settings);
            settings.BringToFront();
        }

        private void BackSettingsButton_Click(object sender, EventArgs e)
        {
            mainGameMenuScreen.Controls.Remove(settings);
        }

        private void MusicVolume_Scroll(object sender, EventArgs e)
        {
            MainForm.MusicVolume = (float)musicVolume.Value / 10;
            MusicPlayer.Volume = MainForm.MusicVolume;
        }

        private void SoundsVolume_Scroll(object sender, EventArgs e)
        {
            MainForm.SoundsVolume = (float)soundsVolume.Value / 10;
        }
    }
}

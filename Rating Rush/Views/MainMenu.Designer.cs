using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

namespace Rating_Rush.Views
{
    partial class mainMenu
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        /// 
        int ScreenWidth = Screen.PrimaryScreen.Bounds.Width;
        int ScreenHeight = Screen.PrimaryScreen.Bounds.Height;
        //private const int ScreenWidth = 960;
        //private const int ScreenHeight = 540;
        private const int OriginalWidth = 1920;
        private const int OriginalHeight = 1080;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainMenu));
            this.gameModMenu = new System.Windows.Forms.PictureBox();
            this.tutorialButton = new System.Windows.Forms.Button();
            this.infinityGameModButton = new System.Windows.Forms.Button();
            this.startScreen = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.startGameButton = new System.Windows.Forms.Button();
            this.difficultyLevels = new System.Windows.Forms.PictureBox();
            this.easyLevelButton = new System.Windows.Forms.Button();
            this.middleLevelButton = new System.Windows.Forms.Button();
            this.hardLevelButton = new System.Windows.Forms.Button();
            this.backDifficultyButton = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.PictureBox();
            this.musicVolume = new System.Windows.Forms.TrackBar();
            this.soundsVolume = new System.Windows.Forms.TrackBar();
            this.backSettingsButton = new System.Windows.Forms.Button();
            this.backGameModButton = new System.Windows.Forms.Button();
            this.classicMode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gameModMenu)).BeginInit();
            this.gameModMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startScreen)).BeginInit();
            this.startScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.difficultyLevels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundsVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // gameModMenu
            // 
            this.gameModMenu.Controls.Add(this.tutorialButton);
            this.gameModMenu.Controls.Add(this.infinityGameModButton);
            this.gameModMenu.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Views", "Visual", "game Mod Menu.png"));
            this.gameModMenu.Location = new System.Drawing.Point(0, 0);
            this.gameModMenu.Name = "gameModMenu";
            this.gameModMenu.Size = new System.Drawing.Size(1920, 1080);
            this.gameModMenu.TabIndex = 1;
            this.gameModMenu.TabStop = false;
            this.gameModMenu.Width = (int)(1920 * ScreenWidth / OriginalWidth);
            this.gameModMenu.Height = (int)(1080 * ScreenHeight / OriginalHeight);
            this.gameModMenu.Left = (int)(0 * ScreenWidth / OriginalWidth);
            this.gameModMenu.Top = (int)(0 * ScreenHeight / OriginalHeight);
            this.gameModMenu.SizeMode = PictureBoxSizeMode.Zoom;
            // 
            // tutorialButton
            // 
            this.tutorialButton.BackColor = System.Drawing.Color.Transparent;
            this.tutorialButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tutorialButton.FlatAppearance.BorderSize = 0;
            this.tutorialButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.tutorialButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.tutorialButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tutorialButton.Location = new System.Drawing.Point(839, 361);
            this.tutorialButton.Name = "tutorialButton";
            this.tutorialButton.Size = new System.Drawing.Size(249, 41);
            this.tutorialButton.TabIndex = 2;
            this.tutorialButton.UseVisualStyleBackColor = false;
            this.tutorialButton.Click += new System.EventHandler(this.TutorialButton_Click);
            this.tutorialButton.Width = (int)(249 * ScreenWidth / OriginalWidth);
            this.tutorialButton.Height = (int)(41 * ScreenHeight / OriginalHeight);
            this.tutorialButton.Left = (int)(839 * ScreenWidth / OriginalWidth);
            this.tutorialButton.Top = (int)(361 * ScreenHeight / OriginalHeight);
            // 
            // infinityGameModButton
            // 
            this.infinityGameModButton.BackColor = System.Drawing.Color.Transparent;
            this.infinityGameModButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infinityGameModButton.FlatAppearance.BorderSize = 0;
            this.infinityGameModButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.infinityGameModButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.infinityGameModButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infinityGameModButton.Location = new System.Drawing.Point(811, 677);
            this.infinityGameModButton.Name = "infinityGameModButton";
            this.infinityGameModButton.Size = new System.Drawing.Size(305, 46);
            this.infinityGameModButton.TabIndex = 1;
            this.infinityGameModButton.UseVisualStyleBackColor = false;
            this.infinityGameModButton.Click += new System.EventHandler(this.InfinityGameModButton_Click);
            this.infinityGameModButton.Width = (int)(305 * ScreenWidth / OriginalWidth);
            this.infinityGameModButton.Height = (int)(46 * ScreenHeight / OriginalHeight);
            this.infinityGameModButton.Left = (int)(811 * ScreenWidth / OriginalWidth);
            this.infinityGameModButton.Top = (int)(677 * ScreenHeight / OriginalHeight);
            // 
            // startScreen
            // 
            this.startScreen.Controls.Add(this.exitButton);
            this.startScreen.Controls.Add(this.settingsButton);
            this.startScreen.Controls.Add(this.startGameButton);
            this.startScreen.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Views", "Visual", "Main Menu.png"));
            this.startScreen.Location = new System.Drawing.Point(0, 0);
            this.startScreen.Name = "startScreen";
            this.startScreen.SizeMode = PictureBoxSizeMode.Zoom;
            this.startScreen.Size = new System.Drawing.Size(1920, 1080);
            this.startScreen.Width = (int)(1920 * ScreenWidth / 1920f);
            this.startScreen.Height = (int)(1080 * ScreenHeight / 1080f);
            this.startScreen.Left = (int)(0 * ScreenWidth / 1920f);
            this.startScreen.Top = (int)(0 * ScreenHeight / 1080f);
            this.startScreen.Left = 0;
            this.startScreen.Top = 0;
            this.startScreen.TabIndex = 0;
            this.startScreen.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(873, 675);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(178, 48);
            this.exitButton.Width = (int)(178 * ScreenWidth / 1920f);
            this.exitButton.Height = (int)(48 * ScreenHeight / 1080f);
            this.exitButton.Left = (int)(873 * ScreenWidth / 1920f);
            this.exitButton.Top = (int)(675 * ScreenHeight / 1080f);
            this.exitButton.TabIndex = 1;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.Transparent;
            this.settingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.settingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Location = new System.Drawing.Point(820, 509);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(290, 53);
            this.settingsButton.TabIndex = 1;
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            SetPosition(settingsButton, 285, 53, 820, 509);
            // 
            // startGameButton
            // 
            this.startGameButton.BackColor = System.Drawing.Color.Transparent;
            this.startGameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startGameButton.FlatAppearance.BorderSize = 0;
            this.startGameButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.startGameButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.startGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startGameButton.Location = new System.Drawing.Point(804, 363);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(312, 40);
            this.startGameButton.TabIndex = 1;
            this.startGameButton.UseVisualStyleBackColor = false;
            this.startGameButton.Click += new System.EventHandler(this.StartGameButton_Click);
            SetPosition(startGameButton, 312, 40, 804, 363);
            // 
            // difficultyLevels
            // 
            this.difficultyLevels.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Views", "Visual", "Difficulty.png"));
            this.difficultyLevels.SizeMode = PictureBoxSizeMode.Zoom;
            this.difficultyLevels.Location = new System.Drawing.Point(0, 0);
            this.difficultyLevels.Name = "difficultyLevels";
            this.difficultyLevels.Size = new System.Drawing.Size(1920, 1080);
            this.difficultyLevels.TabIndex = 1;
            this.difficultyLevels.TabStop = false;
            SetPosition(difficultyLevels, 1920, 1080, 0, 0);
            // 
            // easyLevelButton
            // 
            this.easyLevelButton.BackColor = System.Drawing.Color.Transparent;
            this.easyLevelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.easyLevelButton.FlatAppearance.BorderSize = 0;
            this.easyLevelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.easyLevelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.easyLevelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.easyLevelButton.Location = new System.Drawing.Point(825, 371);
            this.easyLevelButton.Name = "easyLevelButton";
            this.easyLevelButton.Size = new System.Drawing.Size(283, 40);
            this.easyLevelButton.TabIndex = 2;
            this.easyLevelButton.UseVisualStyleBackColor = false;
            this.easyLevelButton.Click += new System.EventHandler(this.EasyLevelButton_Click);
            SetPosition(easyLevelButton, 283, 40, 825, 371);
            // 
            // middleLevelButton
            // 
            this.middleLevelButton.BackColor = System.Drawing.Color.Transparent;
            this.middleLevelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.middleLevelButton.FlatAppearance.BorderSize = 0;
            this.middleLevelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.middleLevelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.middleLevelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.middleLevelButton.Location = new System.Drawing.Point(840, 530);
            this.middleLevelButton.Name = "middleLevelButton";
            this.middleLevelButton.Size = new System.Drawing.Size(263, 40);
            this.middleLevelButton.TabIndex = 3;
            this.middleLevelButton.UseVisualStyleBackColor = false;
            this.middleLevelButton.Click += new System.EventHandler(this.MiddleLevelButton_Click);
            SetPosition(middleLevelButton, 263, 40, 840, 530);
            // 
            // hardLevelButton
            // 
            this.hardLevelButton.BackColor = System.Drawing.Color.Transparent;
            this.hardLevelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hardLevelButton.FlatAppearance.BorderSize = 0;
            this.hardLevelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.hardLevelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.hardLevelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hardLevelButton.Location = new System.Drawing.Point(877, 684);
            this.hardLevelButton.Name = "hardLevelButton";
            this.hardLevelButton.Size = new System.Drawing.Size(192, 44);
            this.hardLevelButton.TabIndex = 4;
            this.hardLevelButton.UseVisualStyleBackColor = false;
            this.hardLevelButton.Click += new System.EventHandler(this.HardLevelButton_Click);
            SetPosition(hardLevelButton, 192, 44, 877, 684);
            // 
            // backDifficultyButton
            // 
            this.backDifficultyButton.BackColor = System.Drawing.Color.Transparent;
            this.backDifficultyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backDifficultyButton.FlatAppearance.BorderSize = 0;
            this.backDifficultyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.backDifficultyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.backDifficultyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backDifficultyButton.Location = new System.Drawing.Point(762, 318);
            this.backDifficultyButton.Name = "backDifficultyButton";
            this.backDifficultyButton.Size = new System.Drawing.Size(57, 39);
            this.backDifficultyButton.TabIndex = 5;
            this.backDifficultyButton.UseVisualStyleBackColor = false;
            this.backDifficultyButton.Click += new System.EventHandler(this.BackDifficultyButton_Click);
            SetPosition(backDifficultyButton, 57, 39, 762, 318);
            // 
            // settings
            // 
            this.settings.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Views", "Visual", "Settings.png"));
            this.settings.SizeMode = PictureBoxSizeMode.Zoom;
            //this.settings.Location = new System.Drawing.Point(0, 0);
            this.settings.Name = "settings";
            //this.settings.Size = new System.Drawing.Size(1920, 1080);
            this.settings.TabIndex = 1;
            this.settings.TabStop = false;
            SetPosition(settings, 1920, 1080, 0, 0);
            // 
            // musicVolume
            // 
            this.musicVolume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.musicVolume.LargeChange = 1;
            this.musicVolume.Location = new System.Drawing.Point(824, 481);
            this.musicVolume.Name = "musicVolume";
            this.musicVolume.Size = new System.Drawing.Size(266, 45);
            this.musicVolume.TabIndex = 2;
            this.musicVolume.TickFrequency = 100;
            this.musicVolume.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.musicVolume.Value = 5;
            this.musicVolume.Scroll += new System.EventHandler(this.MusicVolume_Scroll);
            SetPosition(musicVolume, 266, 45, 824, 481);
            // 
            // soundsVolume
            // 
            this.soundsVolume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.soundsVolume.LargeChange = 1;
            this.soundsVolume.Location = new System.Drawing.Point(824, 678);
            this.soundsVolume.Name = "soundsVolume";
            this.soundsVolume.Size = new System.Drawing.Size(266, 45);
            this.soundsVolume.TabIndex = 3;
            this.soundsVolume.TickFrequency = 100;
            this.soundsVolume.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.soundsVolume.Value = 5;
            this.soundsVolume.Scroll += new System.EventHandler(this.SoundsVolume_Scroll);
            SetPosition(soundsVolume, 266, 45, 824, 678);
            // 
            // backSettingsButton
            // 
            this.backSettingsButton.BackColor = System.Drawing.Color.Transparent;
            this.backSettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backSettingsButton.FlatAppearance.BorderSize = 0;
            this.backSettingsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.backSettingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.backSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backSettingsButton.Location = new System.Drawing.Point(754, 310);
            this.backSettingsButton.Name = "backSettingsButton";
            this.backSettingsButton.Size = new System.Drawing.Size(53, 39);
            this.backSettingsButton.TabIndex = 4;
            this.backSettingsButton.UseVisualStyleBackColor = false;
            this.backSettingsButton.Click += new System.EventHandler(this.BackSettingsButton_Click);
            SetPosition(backSettingsButton, 53, 39, 754, 310);
            // 
            // backGameModButton
            // 
            this.backGameModButton.BackColor = System.Drawing.Color.Transparent;
            this.backGameModButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backGameModButton.FlatAppearance.BorderSize = 0;
            this.backGameModButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.backGameModButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.backGameModButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backGameModButton.Location = new System.Drawing.Point(754, 310);
            this.backGameModButton.Name = "backGameModButton";
            this.backGameModButton.Size = new System.Drawing.Size(48, 38);
            this.backGameModButton.TabIndex = 2;
            this.backGameModButton.UseVisualStyleBackColor = false;
            this.backGameModButton.Click += new System.EventHandler(this.BackGameModButton_Click);
            SetPosition(backGameModButton, 48, 38, 754, 310);
            // 
            // classicMode
            // 
            this.classicMode.BackColor = System.Drawing.Color.Transparent;
            this.classicMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.classicMode.FlatAppearance.BorderSize = 0;
            this.classicMode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.classicMode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.classicMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.classicMode.Location = new System.Drawing.Point(841, 524);
            this.classicMode.Name = "classicMode";
            this.classicMode.Size = new System.Drawing.Size(249, 38);
            this.classicMode.TabIndex = 3;
            this.classicMode.UseVisualStyleBackColor = false;
            this.classicMode.Click += new System.EventHandler(this.ClassicMode_Click);
            SetPosition(classicMode, 249, 38, 841, 524);
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.startScreen);
            this.Name = "mainMenu";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.Size = new Size((int)(1920 * ScreenWidth / OriginalWidth), (int)(1080 * ScreenHeight / OriginalHeight));
            ((System.ComponentModel.ISupportInitialize)(this.gameModMenu)).EndInit();
            this.gameModMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.startScreen)).EndInit();
            this.startScreen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.difficultyLevels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundsVolume)).EndInit();
            foreach (Control childControl in this.Controls)
            {
                var a = childControl.Name;
            }
            this.ResumeLayout(false);
        }

        private void SetPosition(Control control, int width, int height, int left, int top)
        {
            control.Size = new Size((int)(width * ScreenWidth / OriginalWidth), (int)(height * ScreenHeight / OriginalHeight));
            control.Location = new Point((int)(left * ScreenWidth / OriginalWidth), (int)(top * ScreenHeight / OriginalHeight));
        }

        #endregion

        private System.Windows.Forms.PictureBox startScreen;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.PictureBox settings;
        private System.Windows.Forms.TrackBar musicVolume;
        private System.Windows.Forms.TrackBar soundsVolume;
        private System.Windows.Forms.Button backSettingsButton;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.PictureBox gameModMenu;
        private System.Windows.Forms.Button backGameModButton;
        private System.Windows.Forms.Button classicMode;
        private System.Windows.Forms.Button tutorialButton;
        private System.Windows.Forms.Button infinityGameModButton;
        private System.Windows.Forms.PictureBox difficultyLevels;
        private System.Windows.Forms.Button easyLevelButton;
        private System.Windows.Forms.Button middleLevelButton;
        private System.Windows.Forms.Button hardLevelButton;
        private System.Windows.Forms.Button backDifficultyButton;
    }
}
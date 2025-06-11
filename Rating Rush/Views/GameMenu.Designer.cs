using System.Drawing;
using System.Windows.Forms;
using System;
using System.IO;

namespace Rating_Rush.Views
{
    partial class GameMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameMenu));
            this.mainGameMenuScreen = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.Button();
            this.backToMainMenuButton = new System.Windows.Forms.Button();
            this.settingButton = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.PictureBox();
            this.backSettingsButton = new System.Windows.Forms.Button();
            this.musicVolume = new System.Windows.Forms.TrackBar();
            this.soundsVolume = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.mainGameMenuScreen)).BeginInit();
            this.mainGameMenuScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundsVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // mainGameMenuScreen
            // 
            this.mainGameMenuScreen.Controls.Add(this.backButton);
            this.mainGameMenuScreen.Controls.Add(this.backToMainMenuButton);
            this.mainGameMenuScreen.Controls.Add(this.settingButton);
            this.mainGameMenuScreen.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Views", "Visual", "GameMenu.png"));
            this.mainGameMenuScreen.SizeMode = PictureBoxSizeMode.Zoom;
            this.mainGameMenuScreen.Location = new System.Drawing.Point(0, 0);
            this.mainGameMenuScreen.Name = "mainGameMenuScreen";
            this.mainGameMenuScreen.Size = new System.Drawing.Size(1920, 1080);
            SetPosition(mainGameMenuScreen, 1920, 1080, 0, 0);
            this.mainGameMenuScreen.TabIndex = 0;
            this.mainGameMenuScreen.TabStop = false;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Location = new System.Drawing.Point(824, 365);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(270, 37);
            SetPosition(backButton, 270, 37, 824, 365);
            this.backButton.TabIndex = 1;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // backToMainMenuButton
            // 
            this.backToMainMenuButton.BackColor = System.Drawing.Color.Transparent;
            this.backToMainMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backToMainMenuButton.FlatAppearance.BorderSize = 0;
            this.backToMainMenuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.backToMainMenuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.backToMainMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToMainMenuButton.Location = new System.Drawing.Point(781, 679);
            this.backToMainMenuButton.Name = "backToMainMenuButton";
            this.backToMainMenuButton.Size = new System.Drawing.Size(360, 37);
            SetPosition(backToMainMenuButton, 360, 37, 781, 679);
            this.backToMainMenuButton.TabIndex = 1;
            this.backToMainMenuButton.UseVisualStyleBackColor = false;
            this.backToMainMenuButton.Click += new System.EventHandler(this.BackToMainMenuButton_Click);
            // 
            // settingButton
            // 
            this.settingButton.BackColor = System.Drawing.Color.Transparent;
            this.settingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingButton.FlatAppearance.BorderSize = 0;
            this.settingButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.settingButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.settingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingButton.Location = new System.Drawing.Point(842, 512);
            this.settingButton.Name = "settingButton";
            this.settingButton.Size = new System.Drawing.Size(252, 50);
            SetPosition(settingButton, 252, 50, 842, 512);
            this.settingButton.TabIndex = 2;
            this.settingButton.UseVisualStyleBackColor = false;
            this.settingButton.Click += new System.EventHandler(this.SettingButton_Click);
            // 
            // settings
            // 
            this.settings.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Views", "Visual", "Settings.png"));
            this.settings.SizeMode = PictureBoxSizeMode.Zoom;
            this.settings.Location = new System.Drawing.Point(0, 0);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(1920, 1080);
            SetPosition(settings, 1920, 1080, 0, 0);
            this.settings.TabIndex = 1;
            this.settings.TabStop = false;
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
            SetPosition(backSettingsButton, 53, 39, 754, 310);
            this.backSettingsButton.TabIndex = 4;
            this.backSettingsButton.UseVisualStyleBackColor = false;
            this.backSettingsButton.Click += new System.EventHandler(this.BackSettingsButton_Click);
            // 
            // musicVolume
            // 
            this.musicVolume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.musicVolume.LargeChange = 1;
            this.musicVolume.Location = new System.Drawing.Point(824, 481);
            this.musicVolume.Name = "musicVolume";
            this.musicVolume.Size = new System.Drawing.Size(266, 45);
            SetPosition(musicVolume, 266, 45, 824, 481);
            this.musicVolume.TabIndex = 3;
            this.musicVolume.TickFrequency = 100;
            this.musicVolume.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.musicVolume.Value = 5;
            this.musicVolume.Scroll += new System.EventHandler(this.MusicVolume_Scroll);
            // 
            // soundsVolume
            // 
            this.soundsVolume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.soundsVolume.LargeChange = 1;
            this.soundsVolume.Location = new System.Drawing.Point(824, 671);
            this.soundsVolume.Name = "soundsVolume";
            this.soundsVolume.Size = new System.Drawing.Size(266, 45);
            SetPosition(soundsVolume, 266, 45, 824, 671);
            this.soundsVolume.TabIndex = 4;
            this.soundsVolume.TickFrequency = 100;
            this.soundsVolume.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.soundsVolume.Value = 5;
            this.soundsVolume.Scroll += new System.EventHandler(this.SoundsVolume_Scroll);
            // 
            // GameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainGameMenuScreen);
            this.Name = "GameMenu";
            this.Size = new Size((int)(1920 * ScreenWidth / OriginalWidth), (int)(1080 * ScreenHeight / OriginalHeight));
            ((System.ComponentModel.ISupportInitialize)(this.mainGameMenuScreen)).EndInit();
            this.mainGameMenuScreen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundsVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void SetPosition(Control control, int width, int height, int left, int top)
        {
            control.Size = new Size((int)(width * ScreenWidth / OriginalWidth), (int)(height * ScreenHeight / OriginalHeight));
            control.Location = new Point((int)(left * ScreenWidth / OriginalWidth), (int)(top * ScreenHeight / OriginalHeight));
        }

        private void ScaleFont(Control control, float originalFontSize)
        {
            float scaleFactor = Math.Min((float)ScreenWidth / OriginalWidth, (float)ScreenHeight / OriginalHeight);
            float newSize = originalFontSize * scaleFactor;
            //newSize = Math.Max(8, Math.Min(newSize, 36));
            control.Font = new Font(control.Font.FontFamily, newSize, control.Font.Style);
        }

        #endregion

        private System.Windows.Forms.PictureBox mainGameMenuScreen;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button backToMainMenuButton;
        private System.Windows.Forms.Button settingButton;
        private System.Windows.Forms.PictureBox settings;
        private System.Windows.Forms.Button backSettingsButton;
        private System.Windows.Forms.TrackBar musicVolume;
        private System.Windows.Forms.TrackBar soundsVolume;
    }
}
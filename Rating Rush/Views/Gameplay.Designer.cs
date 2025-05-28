using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

namespace Rating_Rush.Views
{
    partial class Gameplay
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gameplay));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.background = new System.Windows.Forms.PictureBox();
            this.famePointer = new System.Windows.Forms.PictureBox();
            this.timeLeft = new System.Windows.Forms.Label();
            this.currentDay = new System.Windows.Forms.Label();
            this.money = new System.Windows.Forms.Label();
            this.ratedMoviesBar = new System.Windows.Forms.PictureBox();
            this.ratedMovies = new System.Windows.Forms.Label();
            this.ratedMoviesCounter = new System.Windows.Forms.Label();
            this.ratedText = new System.Windows.Forms.Label();
            this.starsDatabaseButton = new System.Windows.Forms.Button();
            this.cinemaAnalyticsButton = new System.Windows.Forms.Button();
            this.ratingReminderButton = new System.Windows.Forms.Button();
            this.starsDatabaseLine = new System.Windows.Forms.PictureBox();
            this.cinemaAnalyticsTape = new System.Windows.Forms.PictureBox();
            this.closeRatingReminderButton = new System.Windows.Forms.Button();
            this.ratingReminder = new System.Windows.Forms.PictureBox();
            this.ratingBoard = new System.Windows.Forms.PictureBox();
            this.sendingZone = new System.Windows.Forms.PictureBox();
            this.endGameScreen = new System.Windows.Forms.PictureBox();
            this.mainMenuButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.famePointer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratedMoviesBar)).BeginInit();
            this.ratedMoviesBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.starsDatabaseLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaAnalyticsTape)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingReminder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendingZone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endGameScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // background
            // 
            this.background.Controls.Add(this.famePointer);
            this.background.Controls.Add(this.timeLeft);
            this.background.Controls.Add(this.currentDay);
            this.background.Controls.Add(this.money);
            this.background.Controls.Add(this.ratedMoviesBar);
            this.background.Controls.Add(this.ratedMoviesCounter);
            this.background.Controls.Add(this.ratedText);
            this.background.Controls.Add(this.starsDatabaseButton);
            this.background.Controls.Add(this.cinemaAnalyticsButton);
            this.background.Controls.Add(this.ratingReminderButton);
            string solutionDir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            //this.background.Image = ((System.Drawing.Image)(resources.GetObject("background.Image")));
            this.background.Image = Image.FromFile(Path.Combine(solutionDir, "rating Rush", "Views", "Visual", "Interface.png"));
            this.background.SizeMode = PictureBoxSizeMode.Zoom;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(1920, 1080);
            this.background.TabIndex = 0;
            this.background.TabStop = false;
            SetPosition(background, 1920, 1080, 0, 0);
            // 
            // famePointer
            // 
            this.famePointer.BackColor = System.Drawing.Color.Transparent;
            this.famePointer.Image = ((System.Drawing.Image)(resources.GetObject("famePointer.Image")));
            this.famePointer.SizeMode = PictureBoxSizeMode.Zoom;
            this.famePointer.Location = new System.Drawing.Point(940, 17);
            this.famePointer.Name = "famePointer";
            this.famePointer.Size = new System.Drawing.Size(18, 19);
            this.famePointer.TabIndex = 1;
            this.famePointer.TabStop = false;
            SetPosition(famePointer, 18, 18, 940, 17);
            // 
            // timeLeft
            // 
            this.timeLeft.AutoSize = true;
            this.timeLeft.BackColor = System.Drawing.Color.Transparent;
            this.timeLeft.Font = new System.Drawing.Font("Uni Sans Heavy CAPS", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeLeft.ForeColor = System.Drawing.Color.Cornsilk;
            this.timeLeft.Location = new System.Drawing.Point(46, 0);
            this.timeLeft.Name = "timeLeft";
            this.timeLeft.Size = new System.Drawing.Size(149, 56);
            this.timeLeft.TabIndex = 1;
            this.timeLeft.Text = "00:00";
            SetPosition(timeLeft, 149, 56, 46, 0);
            ScaleFont(timeLeft, 35.25F);
            // 
            // currentDay
            // 
            this.currentDay.AutoSize = true;
            this.currentDay.BackColor = System.Drawing.Color.Transparent;
            this.currentDay.Font = new System.Drawing.Font("Uni Sans Heavy CAPS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentDay.ForeColor = System.Drawing.Color.Cornsilk;
            this.currentDay.Location = new System.Drawing.Point(50, 1019);
            this.currentDay.Name = "currentDay";
            this.currentDay.Size = new System.Drawing.Size(117, 38);
            this.currentDay.TabIndex = 1;
            this.currentDay.Text = "День: ";
            SetPosition(currentDay, 117, 38, 50, 1019);
            ScaleFont(currentDay, 24F);
            // 
            // money
            // 
            this.money.AutoSize = true;
            this.money.BackColor = System.Drawing.Color.Transparent;
            this.money.Font = new System.Drawing.Font("Uni Sans Heavy CAPS", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.money.ForeColor = System.Drawing.Color.Cornsilk;
            this.money.Location = new System.Drawing.Point(1149, 8);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(94, 40);
            this.money.TabIndex = 1;
            this.money.Text = "300$";
            SetPosition(money, 94, 40, 1149, 8);
            ScaleFont(money, 24.75F);
            // 
            // ratedMoviesBar
            // 
            this.ratedMoviesBar.BackColor = System.Drawing.Color.Transparent;
            this.ratedMoviesBar.Controls.Add(this.ratedMovies);
            this.ratedMoviesBar.Image = ((System.Drawing.Image)(resources.GetObject("ratedMoviesBar.Image")));
            this.ratedMoviesBar.SizeMode = PictureBoxSizeMode.CenterImage;
            this.ratedMoviesBar.Location = new System.Drawing.Point(24, 972);
            this.ratedMoviesBar.Name = "ratedMoviesBar";
            this.ratedMoviesBar.Size = new System.Drawing.Size(200, 37);
            this.ratedMoviesBar.TabIndex = 1;
            this.ratedMoviesBar.TabStop = false;
            SetPosition(ratedMoviesBar, 200, 37, 24, 972);
            // 
            // ratedMovies
            // 
            this.ratedMovies.AutoSize = true;
            this.ratedMovies.BackColor = System.Drawing.Color.Transparent;
            this.ratedMovies.Font = new System.Drawing.Font("Uni Sans Heavy CAPS", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ratedMovies.ForeColor = System.Drawing.Color.Cornsilk;
            this.ratedMovies.Location = new System.Drawing.Point(69, 0);
            this.ratedMovies.Name = "ratedMovies";
            this.ratedMovies.Size = new System.Drawing.Size(59, 34);
            this.ratedMovies.TabIndex = 1;
            this.ratedMovies.Text = "3/7";
            SetPosition(ratedMovies, 59, 34, 69, 0);
            ScaleFont(ratedMovies, 21F);
            // 
            // ratedMoviesCounter
            // 
            this.ratedMoviesCounter.AutoSize = true;
            this.ratedMoviesCounter.BackColor = System.Drawing.Color.Transparent;
            this.ratedMoviesCounter.Font = new System.Drawing.Font("Uni Sans Heavy CAPS", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ratedMoviesCounter.ForeColor = System.Drawing.Color.Cornsilk;
            this.ratedMoviesCounter.Location = new System.Drawing.Point(93, 972);
            this.ratedMoviesCounter.Name = "ratedMoviesCounter";
            this.ratedMoviesCounter.Size = new System.Drawing.Size(59, 34);
            this.ratedMoviesCounter.TabIndex = 1;
            this.ratedMoviesCounter.Text = "3/7";
            SetPosition(ratedMoviesCounter, 59, 34, 93, 972);
            ScaleFont(ratedMoviesCounter, 21F);
            // 
            // ratedText
            // 
            this.ratedText.AutoSize = true;
            this.ratedText.BackColor = System.Drawing.Color.Transparent;
            this.ratedText.Font = new System.Drawing.Font("Uni Sans Heavy CAPS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ratedText.ForeColor = System.Drawing.Color.Cornsilk;
            this.ratedText.Location = new System.Drawing.Point(32, 920);
            this.ratedText.Name = "ratedText";
            this.ratedText.Size = new System.Drawing.Size(186, 38);
            this.ratedText.TabIndex = 1;
            this.ratedText.Text = "Оценено";
            SetPosition(ratedText, 186, 38, 32, 920);
            ScaleFont(ratedText, 24F);
            // 
            // starsDatabaseButton
            // 
            this.starsDatabaseButton.BackColor = System.Drawing.Color.Transparent;
            this.starsDatabaseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.starsDatabaseButton.FlatAppearance.BorderSize = 0;
            this.starsDatabaseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.starsDatabaseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.starsDatabaseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.starsDatabaseButton.Location = new System.Drawing.Point(1296, 0);
            this.starsDatabaseButton.Name = "starsDatabaseButton";
            this.starsDatabaseButton.Size = new System.Drawing.Size(90, 108);
            this.starsDatabaseButton.TabIndex = 1;
            this.starsDatabaseButton.UseVisualStyleBackColor = false;
            this.starsDatabaseButton.Click += new System.EventHandler(this.StarsDatabaseButton_Click);
            SetPosition(starsDatabaseButton, 90, 108, 1296, 0);
            // 
            // cinemaAnalyticsButton
            // 
            this.cinemaAnalyticsButton.BackColor = System.Drawing.Color.Transparent;
            this.cinemaAnalyticsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cinemaAnalyticsButton.FlatAppearance.BorderSize = 0;
            this.cinemaAnalyticsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cinemaAnalyticsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cinemaAnalyticsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cinemaAnalyticsButton.Location = new System.Drawing.Point(1517, 0);
            this.cinemaAnalyticsButton.Name = "cinemaAnalyticsButton";
            this.cinemaAnalyticsButton.Size = new System.Drawing.Size(90, 108);
            this.cinemaAnalyticsButton.TabIndex = 2;
            this.cinemaAnalyticsButton.UseVisualStyleBackColor = false;
            this.cinemaAnalyticsButton.Click += new System.EventHandler(this.CinemaAnalyticsButton_Click);
            SetPosition(cinemaAnalyticsButton, 90, 108, 1517, 0);
            // 
            // ratingReminderButton
            // 
            this.ratingReminderButton.BackColor = System.Drawing.Color.Transparent;
            this.ratingReminderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ratingReminderButton.FlatAppearance.BorderSize = 0;
            this.ratingReminderButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ratingReminderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ratingReminderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ratingReminderButton.Location = new System.Drawing.Point(1405, 0);
            this.ratingReminderButton.Name = "ratingReminderButton";
            this.ratingReminderButton.Size = new System.Drawing.Size(90, 108);
            this.ratingReminderButton.TabIndex = 3;
            this.ratingReminderButton.UseVisualStyleBackColor = false;
            this.ratingReminderButton.Click += new System.EventHandler(this.RatingReminderButton_Click);
            SetPosition(ratingReminderButton, 90, 108, 1405, 0);
            // 
            // starsDatabaseLine
            // 
            this.starsDatabaseLine.BackColor = System.Drawing.Color.Transparent;
            this.starsDatabaseLine.Location = new System.Drawing.Point(1296, -10);
            this.starsDatabaseLine.Name = "starsDatabaseLine";
            this.starsDatabaseLine.Size = new System.Drawing.Size(100, 118);
            this.starsDatabaseLine.TabIndex = 1;
            this.starsDatabaseLine.TabStop = false;
            this.starsDatabaseLine.SizeMode = PictureBoxSizeMode.Zoom;
            SetPosition(starsDatabaseLine, 100, 118, 1290, -10);
            // 
            // cinemaAnalyticsTape
            // 
            this.cinemaAnalyticsTape.BackColor = System.Drawing.Color.Transparent;
            this.cinemaAnalyticsTape.Image = ((System.Drawing.Image)(resources.GetObject("cinemaAnalyticsTape.Image")));
            this.cinemaAnalyticsTape.Location = new System.Drawing.Point(1519, -10);
            this.cinemaAnalyticsTape.Name = "cinemaAnalyticsTape";
            this.cinemaAnalyticsTape.Size = new System.Drawing.Size(85, 150);
            this.cinemaAnalyticsTape.TabIndex = 1;
            this.cinemaAnalyticsTape.TabStop = false;
            this.cinemaAnalyticsTape.SizeMode = PictureBoxSizeMode.Zoom;
            SetPosition(cinemaAnalyticsTape, 85, 150, 1519, -10);
            // 
            // closeRatingReminderButton
            // 
            this.closeRatingReminderButton.BackColor = System.Drawing.Color.Transparent;
            this.closeRatingReminderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeRatingReminderButton.FlatAppearance.BorderSize = 0;
            this.closeRatingReminderButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.closeRatingReminderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.closeRatingReminderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeRatingReminderButton.Location = new System.Drawing.Point(1193, 144);
            this.closeRatingReminderButton.Name = "closeRatingReminderButton";
            this.closeRatingReminderButton.Size = new System.Drawing.Size(50, 52);
            this.closeRatingReminderButton.TabIndex = 5;
            this.closeRatingReminderButton.UseVisualStyleBackColor = false;
            this.closeRatingReminderButton.Click += new System.EventHandler(this.CloseRatingReminderButton_Click);
            SetPosition(closeRatingReminderButton, 50, 52, 1193, 144);
            // 
            // ratingReminder
            // 
            //this.ratingReminder.Image = ((System.Drawing.Image)(resources.GetObject("ratingReminder.Image")));
            this.ratingReminder.Image = Image.FromFile(Path.Combine(solutionDir, "Rating Rush", "Views", "Visual", "Reminder.png"));
            this.ratingReminder.SizeMode = PictureBoxSizeMode.Zoom;
            this.ratingReminder.Location = new System.Drawing.Point(656, 144);
            this.ratingReminder.Name = "ratingReminder";
            this.ratingReminder.Size = new System.Drawing.Size(587, 772);
            this.ratingReminder.TabIndex = 4;
            this.ratingReminder.TabStop = false;
            SetPosition(ratingReminder, 587, 772, 656, 144);
            // 
            // ratingBoard
            // 
            this.ratingBoard.BackColor = System.Drawing.Color.Transparent;
            this.ratingBoard.Image = ((System.Drawing.Image)(resources.GetObject("ratingBoard.Image")));
            this.ratingBoard.Location = new System.Drawing.Point(488, 687);
            this.ratingBoard.Name = "ratingBoard";
            this.ratingBoard.Size = new System.Drawing.Size(940, 344);
            this.ratingBoard.TabIndex = 1;
            this.ratingBoard.TabStop = false;
            this.ratingBoard.SizeMode = PictureBoxSizeMode.Zoom;
            SetPosition(ratingBoard, 940, 344, 488, 687);
            // 
            // sendingZone
            // 
            this.sendingZone.BackColor = System.Drawing.Color.Transparent;
            this.sendingZone.Image = ((System.Drawing.Image)(resources.GetObject("sendingZone.Image")));
            this.sendingZone.Location = new System.Drawing.Point(1486, 667);
            this.sendingZone.Name = "sendingZone";
            this.sendingZone.Size = new System.Drawing.Size(434, 413);
            this.sendingZone.TabIndex = 1;
            this.sendingZone.TabStop = false;
            this.sendingZone.SizeMode = PictureBoxSizeMode.Zoom;
            SetPosition(sendingZone, 434, 413, 1486, 667);
            // 
            // endGameScreen
            // 
            this.endGameScreen.BackColor = System.Drawing.SystemColors.Control;
            this.endGameScreen.Image = ((System.Drawing.Image)(resources.GetObject("endGameScreen.Image")));
            this.endGameScreen.Location = new System.Drawing.Point(650, 333);
            this.endGameScreen.Name = "endGameScreen";
            this.endGameScreen.Size = new System.Drawing.Size(609, 339);
            this.endGameScreen.TabIndex = 1;
            this.endGameScreen.TabStop = false;
            this.endGameScreen.SizeMode = PictureBoxSizeMode.Zoom;
            SetPosition(endGameScreen, 609, 339, 650, 333);
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.BackColor = System.Drawing.Color.Transparent;
            this.mainMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainMenuButton.FlatAppearance.BorderSize = 0;
            this.mainMenuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.mainMenuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.mainMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainMenuButton.Location = new System.Drawing.Point(750, 560);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(376, 89);
            this.mainMenuButton.TabIndex = 2;
            this.mainMenuButton.UseVisualStyleBackColor = false;
            this.mainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
            SetPosition(mainMenuButton, 376, 89, 750, 560);
            // 
            // Gameplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.background);
            this.Name = "Gameplay";
            this.Size = new Size((int)(1920 * ScreenWidth / OriginalWidth), (int)(1080 * ScreenHeight / OriginalHeight));
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.background.ResumeLayout(false);
            this.background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.famePointer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratedMoviesBar)).EndInit();
            this.ratedMoviesBar.ResumeLayout(false);
            this.ratedMoviesBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.starsDatabaseLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaAnalyticsTape)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingReminder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendingZone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endGameScreen)).EndInit();
            this.ResumeLayout(false);

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

        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.Label currentDay;
        private System.Windows.Forms.Label money;
        private System.Windows.Forms.PictureBox famePointer;
        private System.Windows.Forms.Label timeLeft;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox ratedMoviesBar;
        private System.Windows.Forms.Label ratedMovies;
        private System.Windows.Forms.Label ratedMoviesCounter;
        private System.Windows.Forms.Label ratedText;
        private System.Windows.Forms.PictureBox ratingBoard;
        private System.Windows.Forms.PictureBox sendingZone;
        private System.Windows.Forms.PictureBox endGameScreen;
        private System.Windows.Forms.Button mainMenuButton;
        private System.Windows.Forms.Button starsDatabaseButton;
        private System.Windows.Forms.PictureBox starsDatabaseLine;
        private System.Windows.Forms.Button cinemaAnalyticsButton;
        private System.Windows.Forms.PictureBox cinemaAnalyticsTape;
        private System.Windows.Forms.Button ratingReminderButton;
        private System.Windows.Forms.PictureBox ratingReminder;
        private System.Windows.Forms.Button closeRatingReminderButton;
    }
}

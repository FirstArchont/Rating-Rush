using System.Drawing;
using System.Windows.Forms;
using System;

namespace Rating_Rush.Views
{
    partial class CinemaAnalyticsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CinemaAnalyticsControl));
            this.background = new System.Windows.Forms.PictureBox();
            this.badPopularityButton = new System.Windows.Forms.Button();
            this.middlePopularityButton = new System.Windows.Forms.Button();
            this.highPopularityButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.highPopularity = new System.Windows.Forms.PictureBox();
            this.middlePopularity = new System.Windows.Forms.PictureBox();
            this.badPopularity = new System.Windows.Forms.PictureBox();
            this.genre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.highPopularity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.middlePopularity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.badPopularity)).BeginInit();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.Transparent;
            this.background.Controls.Add(this.badPopularityButton);
            this.background.Controls.Add(this.middlePopularityButton);
            this.background.Controls.Add(this.highPopularityButton);
            this.background.Controls.Add(this.closeButton);
            this.background.Image = ((System.Drawing.Image)(resources.GetObject("background.Image")));
            this.background.SizeMode = PictureBoxSizeMode.Zoom;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(393, 559);
            SetPosition(background, 393, 559, 0, 0);
            this.background.TabIndex = 0;
            this.background.TabStop = false;
            // 
            // badPopularityButton
            // 
            this.badPopularityButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.badPopularityButton.FlatAppearance.BorderSize = 0;
            this.badPopularityButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.badPopularityButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.badPopularityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.badPopularityButton.Location = new System.Drawing.Point(20, 294);
            this.badPopularityButton.Name = "badPopularityButton";
            this.badPopularityButton.Size = new System.Drawing.Size(51, 50);
            SetPosition(badPopularityButton, 51, 50, 20, 294);
            this.badPopularityButton.TabIndex = 3;
            this.badPopularityButton.UseVisualStyleBackColor = true;
            this.badPopularityButton.Click += new System.EventHandler(this.BadPopularityButton_Click);
            // 
            // middlePopularityButton
            // 
            this.middlePopularityButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.middlePopularityButton.FlatAppearance.BorderSize = 0;
            this.middlePopularityButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.middlePopularityButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.middlePopularityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.middlePopularityButton.Location = new System.Drawing.Point(20, 219);
            this.middlePopularityButton.Name = "middlePopularityButton";
            this.middlePopularityButton.Size = new System.Drawing.Size(51, 51);
            SetPosition(middlePopularityButton, 51, 51, 20, 219);
            this.middlePopularityButton.TabIndex = 2;
            this.middlePopularityButton.UseVisualStyleBackColor = true;
            this.middlePopularityButton.Click += new System.EventHandler(this.MiddlePopularityButton_Click);
            // 
            // highPopularityButton
            // 
            this.highPopularityButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.highPopularityButton.FlatAppearance.BorderSize = 0;
            this.highPopularityButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.highPopularityButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.highPopularityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.highPopularityButton.Location = new System.Drawing.Point(20, 145);
            this.highPopularityButton.Name = "highPopularityButton";
            this.highPopularityButton.Size = new System.Drawing.Size(51, 52);
            SetPosition(highPopularityButton, 51, 51, 20, 145);
            this.highPopularityButton.TabIndex = 1;
            this.highPopularityButton.UseVisualStyleBackColor = true;
            this.highPopularityButton.Click += new System.EventHandler(this.HighPopularityButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(30, 454);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(94, 102);
            SetPosition(closeButton, 94, 102, 30, 454);
            this.closeButton.TabIndex = 1;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // highPopularity
            // 
            this.highPopularity.BackColor = System.Drawing.Color.White;
            this.highPopularity.Image = ((System.Drawing.Image)(resources.GetObject("highPopularity.Image")));
            this.highPopularity.SizeMode = PictureBoxSizeMode.Zoom;
            this.highPopularity.Location = new System.Drawing.Point(22, 144);
            this.highPopularity.Name = "highPopularity";
            this.highPopularity.Size = new System.Drawing.Size(49, 55);
            SetPosition(highPopularity, 49, 55, 22, 144);
            this.highPopularity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.highPopularity.TabIndex = 1;
            this.highPopularity.TabStop = false;
            // 
            // middlePopularity
            // 
            this.middlePopularity.BackColor = System.Drawing.Color.White;
            this.middlePopularity.Image = ((System.Drawing.Image)(resources.GetObject("middlePopularity.Image")));
            this.middlePopularity.SizeMode = PictureBoxSizeMode.Zoom;
            this.middlePopularity.Location = new System.Drawing.Point(22, 215);
            this.middlePopularity.Name = "middlePopularity";
            this.middlePopularity.Size = new System.Drawing.Size(49, 55);
            SetPosition(middlePopularity, 49, 55, 22, 217);
            this.middlePopularity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.middlePopularity.TabIndex = 2;
            this.middlePopularity.TabStop = false;
            // 
            // badPopularity
            // 
            this.badPopularity.BackColor = System.Drawing.Color.White;
            this.badPopularity.Image = ((System.Drawing.Image)(resources.GetObject("badPopularity.Image")));
            this.badPopularity.SizeMode = PictureBoxSizeMode.Zoom;
            this.badPopularity.Location = new System.Drawing.Point(22, 291);
            this.badPopularity.Name = "badPopularity";
            this.badPopularity.Size = new System.Drawing.Size(49, 55);
            SetPosition(badPopularity, 49, 55, 22, 291);
            this.badPopularity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.badPopularity.TabIndex = 3;
            this.badPopularity.TabStop = false;
            // 
            // genre
            // 
            this.genre.AutoSize = true;
            this.genre.BackColor = System.Drawing.Color.Transparent;
            this.genre.Font = new System.Drawing.Font("Gilroy Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genre.Location = new System.Drawing.Point(110, 140);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(121, 33);
            SetPosition(genre, 121, 33, 110, 140);
            ScaleFont(genre, 20.25F);
            this.genre.TabIndex = 1;
            this.genre.Text = "Вестерн";
            // 
            // CinemaAnalytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.background);
            this.Name = "CinemaAnalytics";
            this.Size = new Size((int)(392 * ScreenWidth / OriginalWidth), (int)(559 * ScreenHeight / OriginalHeight));
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.background.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.highPopularity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.middlePopularity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.badPopularity)).EndInit();
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
        private System.Windows.Forms.Button highPopularityButton;
        private System.Windows.Forms.Button middlePopularityButton;
        private System.Windows.Forms.Button badPopularityButton;
        private System.Windows.Forms.PictureBox highPopularity;
        private System.Windows.Forms.PictureBox middlePopularity;
        private System.Windows.Forms.PictureBox badPopularity;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label genre;
    }
}

using System.Drawing;
using System.Windows.Forms;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Rating_Rush.Views
{
    partial class StarsDatabaseControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StarsDatabaseControl));
            this.background = new System.Windows.Forms.PictureBox();
            this.findButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.resultStars = new System.Windows.Forms.PictureBox();
            this.inputLine = new System.Windows.Forms.TextBox();
            this.resultText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultStars)).BeginInit();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.Controls.Add(this.findButton);
            this.background.Controls.Add(this.closeButton);
            this.background.Image = ((System.Drawing.Image)(resources.GetObject("background.Image")));
            this.background.SizeMode = PictureBoxSizeMode.Zoom;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(396, 557);
            SetPosition(background, 396, 557, 0, 0);
            this.background.TabIndex = 0;
            this.background.TabStop = false;
            // 
            // findButton
            // 
            this.findButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.findButton.FlatAppearance.BorderSize = 0;
            this.findButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.findButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.findButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findButton.Location = new System.Drawing.Point(117, 254);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(133, 52);
            SetPosition(findButton, 133, 52, 117, 254);
            this.findButton.TabIndex = 4;
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(259, 452);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(93, 105);
            SetPosition(closeButton, 93, 105, 259, 452);
            this.closeButton.TabIndex = 2;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // resultStars
            // 
            this.resultStars.Image = ((System.Drawing.Image)(resources.GetObject("resultStars.Image")));
            this.resultStars.SizeMode = PictureBoxSizeMode.Zoom;
            this.resultStars.Location = new System.Drawing.Point(100, 371);
            this.resultStars.Name = "resultStars";
            this.resultStars.Size = new System.Drawing.Size(165, 54);
            SetPosition(resultStars, 165, 54, 100, 371);
            this.resultStars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.resultStars.TabIndex = 3;
            this.resultStars.TabStop = false;
            // 
            // inputLine
            // 
            this.inputLine.BackColor = System.Drawing.Color.Black;
            this.inputLine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputLine.Font = new System.Drawing.Font("Gilroy Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputLine.ForeColor = System.Drawing.Color.White;
            this.inputLine.Location = new System.Drawing.Point(49, 193);
            this.inputLine.Name = "inputLine";
            this.inputLine.Size = new System.Drawing.Size(268, 34);
            ScaleFont(inputLine, 20.25F);
            SetPosition(inputLine, 268, 34, 49, 193);
            this.inputLine.TabIndex = 1;
            // 
            // resultText
            // 
            this.resultText.AutoSize = true;
            this.resultText.Font = new System.Drawing.Font("Gilroy Black", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultText.ForeColor = System.Drawing.Color.White;
            this.resultText.Location = new System.Drawing.Point(30, 327);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(50, 60);
            ScaleFont(resultText, 24.75F);
            SetPosition(resultText, 50, 60, 30, 327);
            this.resultText.TabIndex = 2;
            this.resultText.Text = "Клинт Иствуд";
            // 
            // StarsDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.inputLine);
            this.Controls.Add(this.background);
            this.Name = "StarsDatabase";
            this.Size = new Size((int)(395 * ScreenWidth / OriginalWidth), (int)(556 * ScreenHeight / OriginalHeight));
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.background.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultStars)).EndInit();
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

        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.TextBox inputLine;
        private System.Windows.Forms.Label resultText;
        private System.Windows.Forms.PictureBox resultStars;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Button closeButton;
    }
}

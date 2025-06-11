using System.Drawing;
using System.Windows.Forms;
using System;

namespace Rating_Rush.Views
{
    partial class DayResults
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DayResults));
            this.background = new System.Windows.Forms.PictureBox();
            this.dayEnded = new System.Windows.Forms.Label();
            this.moviesRated = new System.Windows.Forms.Label();
            this.moneyIncome = new System.Windows.Forms.Label();
            this.fameIncome = new System.Windows.Forms.Label();
            this.taxes = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.background.SuspendLayout();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.Controls.Add(this.dayEnded);
            this.background.Controls.Add(this.moviesRated);
            this.background.Controls.Add(this.moneyIncome);
            this.background.Controls.Add(this.fameIncome);
            this.background.Controls.Add(this.taxes);
            this.background.Controls.Add(this.backButton);
            this.background.Image = ((System.Drawing.Image)(resources.GetObject("background.Image")));
            this.background.SizeMode = PictureBoxSizeMode.Zoom;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(609, 642);
            SetPosition(background, 609, 642, 0, 0);
            this.background.TabIndex = 0;
            this.background.TabStop = false;
            // 
            // dayEnded
            // 
            this.dayEnded.AutoSize = true;
            this.dayEnded.BackColor = System.Drawing.Color.Transparent;
            this.dayEnded.Font = new System.Drawing.Font("Uni Sans Heavy CAPS", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            ScaleFont(dayEnded, 35.25F);
            this.dayEnded.ForeColor = System.Drawing.Color.Moccasin;
            this.dayEnded.Location = new System.Drawing.Point(105, 12);
            this.dayEnded.Name = "dayEnded";
            this.dayEnded.Size = new System.Drawing.Size(368, 56);
            SetPosition(dayEnded, 368, 56, 105, 12);
            this.dayEnded.TabIndex = 1;
            this.dayEnded.Text = "день окончен";
            // 
            // moviesRated
            // 
            this.moviesRated.AutoSize = true;
            this.moviesRated.BackColor = System.Drawing.Color.Transparent;
            this.moviesRated.Font = new System.Drawing.Font("Uni Sans Heavy CAPS", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moviesRated.ForeColor = System.Drawing.Color.Coral;
            this.moviesRated.Location = new System.Drawing.Point(460, 214);
            this.moviesRated.Name = "moviesRated";
            this.moviesRated.Size = new System.Drawing.Size(83, 48);
            ScaleFont(moviesRated, 30F);
            SetPosition(moviesRated, 83, 48, 460, 214);
            this.moviesRated.TabIndex = 2;
            this.moviesRated.Text = "3/7";
            // 
            // moneyIncome
            // 
            this.moneyIncome.AutoSize = true;
            this.moneyIncome.BackColor = System.Drawing.Color.Transparent;
            this.moneyIncome.Font = new System.Drawing.Font("Uni Sans Heavy CAPS", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moneyIncome.ForeColor = System.Drawing.Color.Green;
            this.moneyIncome.Location = new System.Drawing.Point(450, 119);
            this.moneyIncome.Name = "moneyIncome";
            this.moneyIncome.Size = new System.Drawing.Size(82, 48);
            ScaleFont(moneyIncome, 30F);
            SetPosition(moneyIncome, 82, 48, 450, 119);
            this.moneyIncome.TabIndex = 3;
            this.moneyIncome.Text = "10$";
            // 
            // fameIncome
            // 
            this.fameIncome.AutoSize = true;
            this.fameIncome.BackColor = System.Drawing.Color.Transparent;
            this.fameIncome.Font = new System.Drawing.Font("Uni Sans Heavy CAPS", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fameIncome.ForeColor = System.Drawing.Color.Goldenrod;
            this.fameIncome.Location = new System.Drawing.Point(450, 307);
            this.fameIncome.Name = "fameIncome";
            this.fameIncome.Size = new System.Drawing.Size(96, 48);
            ScaleFont(fameIncome, 30F);
            SetPosition(fameIncome, 96, 48, 450, 307);
            this.fameIncome.TabIndex = 3;
            this.fameIncome.Text = "30%";
            // 
            // taxes
            // 
            this.taxes.AutoSize = true;
            this.taxes.BackColor = System.Drawing.Color.Transparent;
            this.taxes.Font = new System.Drawing.Font("Uni Sans Heavy CAPS", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taxes.ForeColor = System.Drawing.Color.Moccasin;
            this.taxes.Location = new System.Drawing.Point(164, 443);
            this.taxes.Name = "taxes";
            this.taxes.Size = new System.Drawing.Size(309, 48);
            ScaleFont(taxes, 30F);
            SetPosition(taxes, 309, 48, 164, 443);
            this.taxes.TabIndex = 4;
            this.taxes.Text = "100$ - 50$ = 50$";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Location = new System.Drawing.Point(172, 528);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(263, 89);
            SetPosition(backButton, 263, 89, 172, 528);
            this.backButton.TabIndex = 1;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // DayResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.background);
            this.Name = "DayResults";
            this.Size = new Size((int)(608 * ScreenWidth / OriginalWidth), (int)(641 * ScreenHeight / OriginalHeight));
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.background.ResumeLayout(false);
            this.background.PerformLayout();
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
        private System.Windows.Forms.Label dayEnded;
        private System.Windows.Forms.Label moviesRated;
        private System.Windows.Forms.Label moneyIncome;
        private System.Windows.Forms.Label fameIncome;
        private System.Windows.Forms.Label taxes;
        private System.Windows.Forms.Button backButton;
    }
}

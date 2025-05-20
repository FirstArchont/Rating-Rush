using System.Drawing;
using System.Windows.Forms;
using System;

namespace Rating_Rush.Views
{
    partial class RatingResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RatingResult));
            this.background = new System.Windows.Forms.PictureBox();
            this.movieName = new System.Windows.Forms.Label();
            this.moneyIncome = new System.Windows.Forms.Label();
            this.fameArrow = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fameArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.Controls.Add(this.movieName);
            this.background.Controls.Add(this.moneyIncome);
            this.background.Controls.Add(this.fameArrow);
            this.background.Image = ((System.Drawing.Image)(resources.GetObject("background.Image")));
            this.background.SizeMode = PictureBoxSizeMode.Zoom;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(607, 642);
            SetPosition(background, 607, 642, 0, 0);
            this.background.TabIndex = 0;
            this.background.TabStop = false;
            // 
            // movieName
            // 
            this.movieName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.movieName.AutoSize = true;
            this.movieName.BackColor = System.Drawing.Color.Transparent;
            this.movieName.Font = new System.Drawing.Font("Gilroy Black", 36.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.movieName.ForeColor = System.Drawing.Color.Moccasin;
            this.movieName.Location = new System.Drawing.Point(50, 5);
            this.movieName.Name = "movieName";
            this.movieName.Size = new System.Drawing.Size(509, 62);
            SetPosition(movieName, 507, 62, 50, 5);
            ScaleFont(this.movieName, 36.75F);
            this.movieName.TabIndex = 1;
            this.movieName.Text = "Оценка отправлена!";
            this.movieName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // moneyIncome
            // 
            this.moneyIncome.AutoSize = true;
            this.moneyIncome.BackColor = System.Drawing.Color.Transparent;
            this.moneyIncome.Font = new System.Drawing.Font("Gilroy Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moneyIncome.ForeColor = System.Drawing.Color.Green;
            this.moneyIncome.Location = new System.Drawing.Point(390, 458);
            this.moneyIncome.Name = "moneyIncome";
            this.moneyIncome.Size = new System.Drawing.Size(108, 50);
            SetPosition(moneyIncome, 108, 50, 390, 458);
            ScaleFont(moneyIncome, 30F);
            this.moneyIncome.TabIndex = 1;
            this.moneyIncome.Text = "+10$";
            // 
            // fameArrow
            // 
            this.fameArrow.BackColor = System.Drawing.Color.Transparent;
            this.fameArrow.Image = ((System.Drawing.Image)(resources.GetObject("fameArrow.Image")));
            this.fameArrow.SizeMode = PictureBoxSizeMode.Zoom;
            this.fameArrow.Location = new System.Drawing.Point(212, 460);
            this.fameArrow.Name = "fameArrow";
            this.fameArrow.Size = new System.Drawing.Size(32, 43);
            SetPosition(fameArrow, 32, 43, 212, 460);
            this.fameArrow.TabIndex = 1;
            this.fameArrow.TabStop = false;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(176, 530);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(257, 85);
            SetPosition(closeButton, 257, 85, 176, 530);
            this.closeButton.TabIndex = 1;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // RatingResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            background.Controls.Add(this.closeButton);
            this.Controls.Add(this.background);
            this.Name = "RatingResult";
            this.Size = new Size((int)(607 * ScreenWidth / OriginalWidth), (int)(640 * ScreenHeight / OriginalHeight));
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.background.ResumeLayout(false);
            this.background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fameArrow)).EndInit();
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
        private System.Windows.Forms.Label movieName;
        private System.Windows.Forms.Label moneyIncome;
        private System.Windows.Forms.PictureBox fameArrow;
        private System.Windows.Forms.Button closeButton;
    }
}

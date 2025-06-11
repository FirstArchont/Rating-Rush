using NAudio.CoreAudioApi;
using Rating_Rush.Domain;
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

namespace Rating_Rush.Views
{
    public partial class StarsDatabaseControl : UserControl
    {
        private StarsDatabase StarsDatabase;

        public StarsDatabaseControl(Dictionary<string, int> database)
        {
            StarsDatabase = new StarsDatabase(database);
            InitializeComponent();
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            var results = StarsDatabase.FindCoincidence(inputLine.Text);
            if (results.Key != null)
                PlaceResultText(results.Key, results.Value);
            else
            {
                resultText.Text = "Ничего не найдено";
                background.Controls.Add(resultText);
                background.Controls.Remove(resultStars);
            }
        }

        private void PlaceResultText(string name, int stars)
        {
            if (name.Length > 16)
                resultText.Text = name.Substring(0, 16) + "...";
            else
                resultText.Text = name;
            background.Controls.Add(resultText);
            PlaceStars(stars);
        }

        private void PlaceStars(int stars)
        {
            string solutionDir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            background.Controls.Add(resultStars);
            if (stars == 1)
            {
                resultStars.Image = Image.FromFile(Path.Combine(solutionDir, "Rating Rush", "Views", "Visual", "1 star.png"));
                resultStars.Size = new Size(41, 35);
                resultStars.Location = new Point(162, 381);
                SetPosition(resultStars, 41, 35, 162, 381);
            }
            else if (stars == 2)
            {
                resultStars.Image = Image.FromFile(Path.Combine(solutionDir, "Rating Rush", "Views", "Visual", "2 stars.png"));
                resultStars.Size = new Size(87, 35);
                resultStars.Location = new Point(139, 381);
                SetPosition(resultStars, 87, 35, 139, 381);
            }
            else if (stars == 3)
            {
                resultStars.Image = Image.FromFile(Path.Combine(solutionDir, "Rating Rush", "Views", "Visual", "3 stars.png"));
                resultStars.Size = new Size(113, 35);
                resultStars.Location = new Point(125, 381);
                SetPosition(resultStars, 113, 35, 125, 381);
            }
            else if (stars == 4)
            {
                resultStars.Image = Image.FromFile(Path.Combine(solutionDir, "Rating Rush", "Views", "Visual", "4 stars.png"));
                resultStars.Size = new Size(142, 46);
                resultStars.Location = new Point(112, 374);
                SetPosition(resultStars, 142, 46, 112, 374);
            }
            else
            {
                resultStars.Image = Image.FromFile(Path.Combine(solutionDir, "Rating Rush", "Views", "Visual", "5 stars.png"));
                resultStars.Size = new Size(165, 54);
                resultStars.Location = new Point(100, 371);
                SetPosition(resultStars, 165, 54, 100, 371);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this.Parent.Controls.OfType<PictureBox>().First(picture => picture.Name == "starsDatabaseLine"));
            this.Parent.Controls.Remove(this);
        }
    }
}

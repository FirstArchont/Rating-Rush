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
    public partial class CinemaAnalyticsControl : UserControl
    {
        private List<(PictureBox, Label)> Genres = new List<(PictureBox, Label)>();
        private CinemaAnalytics CinemaAnalytics;

        public CinemaAnalyticsControl(Rating_Rush.Domain.Day day)
        {
            CinemaAnalytics = new CinemaAnalytics(day);
            InitializeComponent();
        }

        private void PlaceGenres(Popularity popularity)
        {
            foreach (var pair in Genres)
            {
                background.Controls.Remove(pair.Item1);
                background.Controls.Remove(pair.Item2);
            }
            Genres.Clear();
            int counter = 0;
            var genres = CinemaAnalytics.FindGenres(popularity);
            foreach (var style in genres)
            {
                var circle = new PictureBox();
                circle.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Views", "Visual", "Ellipse.png"));
                circle.SizeMode = PictureBoxSizeMode.Zoom;
                circle.BackColor = Color.Transparent;
                circle.Location = new Point((int)(93 * ScreenWidth / OriginalWidth), (int)(150 + 40 * counter * ScreenHeight / OriginalHeight));
                circle.Size = new Size(14, 14);
                SetPosition(circle, 14, 14, 93, 150 + 40 * counter);
                var genre = new Label();
                genre.Text = style.Item1.Split()[0];
                genre.Location = new Point(110, 140 + 40 * counter);
                genre.Font = new System.Drawing.Font("Gilroy Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                ScaleFont(genre, 20F);
                genre.Size = new Size(300, 30);
                SetPosition(genre, 300, 30, 110, 140 + 40 * counter);
                genre.BackColor = Color.Transparent;
                background.Controls.Add(genre);
                background.Controls.Add(circle);
                Genres.Add((circle, genre));
                counter++;
            }
        }

        private void HighPopularityButton_Click(object sender, EventArgs e)
        {
            background.Controls.Add(highPopularity);
            background.Controls.Remove(middlePopularity);
            background.Controls.Remove(badPopularity);
            highPopularity.BringToFront();
            PlaceGenres(Popularity.High);
        }

        private void MiddlePopularityButton_Click(object sender, EventArgs e)
        {
            background.Controls.Add(middlePopularity);
            background.Controls.Remove(highPopularity);
            background.Controls.Remove(badPopularity);
            middlePopularity.BringToFront();
            PlaceGenres(Popularity.Medium);
        }

        private void BadPopularityButton_Click(object sender, EventArgs e)
        {
            background.Controls.Add(badPopularity);
            background.Controls.Remove(middlePopularity);
            background.Controls.Remove(highPopularity);
            badPopularity.BringToFront();
            PlaceGenres(Popularity.Low);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this.Parent.Controls.OfType<PictureBox>().First(picture => picture.Name == "cinemaAnalyticsTape"));
            this.Parent.Controls.Remove(this);
        }
    }
}
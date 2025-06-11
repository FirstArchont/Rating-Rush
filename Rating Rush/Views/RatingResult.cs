using NAudio.CoreAudioApi;
using NAudio.Utils;
using Rating_Rush.Domain;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rating_Rush.Views
{
    public partial class RatingResult : UserControl
    {
        private Gameplay CurrentGameplay { get; set; }
        private MainForm MainForm { get; set; }

        public RatingResult(MainForm mainForm, Gameplay gameplay)
        {
            MainForm = mainForm;
            CurrentGameplay = gameplay;
            InitializeComponent();
            PlaceInformation();
        }

        private void PlaceInformation()
        {
            var playerRatingSquare = CreateRatingSquare(CurrentGameplay.Rating.TotalRating);
            SetPosition(playerRatingSquare, 150, 150, 80, 190);
            var movieName = CurrentGameplay.MovieParameters.First(label => label.Name == "movieName").Text;
            var movie = CurrentGameplay.Day.Movies.First(cinema => cinema.Title == movieName);
            var usersRatingSquare = CreateRatingSquare(movie.UsersRating.TotalRating);
            SetPosition(usersRatingSquare, 150, 150, 355, 90);
            var results = RatingsComparer.CompareRatings(CurrentGameplay.Rating, movie.UsersRating, CurrentGameplay.Player.Fame, CurrentGameplay.Scenario.MaxReward);
            CurrentGameplay.Player.CountIncome(results);
            CurrentGameplay.UpdatePlayerInformation();
            CurrentGameplay.Day.RatedMovies++;
            CurrentGameplay.UpdateProgressBar();
            moneyIncome.Text = "+" + results.Money.ToString() + "$";
            PlaceFameArrow(results);
        }

        private void PlaceFameArrow((int fame, int money) results)
        {
            if (results.fame > 0)
            {
                fameArrow.Location = new Point((int)(215 * ScreenWidth / OriginalWidth), (int)(460 * ScreenHeight / OriginalHeight));
                fameArrow.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Views", "Visual", "FamePlus.png"));
            }
            else if (results.fame < 0)
            {
                fameArrow.Location = new Point((int)(215 * ScreenWidth / OriginalWidth), (int)(460 * ScreenHeight / OriginalHeight));
                fameArrow.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Views", "Visual", "FameMinus.png"));
            }
            else
            {
                fameArrow.Location = new Point((int)(215 * ScreenWidth / OriginalWidth), (int)(460 * ScreenHeight / OriginalHeight));
                fameArrow.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Views", "Visual", "FameDontChange.png"));
            }
        }

        private PictureBox CreateRatingSquare(int totalRating)
        {
            var rating = new Label();
            rating.Font = new Font("Uni Sans Heavy CAPS", 60F, FontStyle.Bold);
            ScaleFont(rating, 60F);
            rating.Size = new Size((int)(200 * ScreenWidth / OriginalWidth), (int)(200 * ScreenHeight / OriginalHeight));
            rating.ForeColor = Color.Black;
            rating.BackColor = Color.Transparent;
            rating.Text = totalRating.ToString();
            var ratingSquare = new PictureBox();
            ratingSquare.Controls.Add(rating);
            ratingSquare.BackColor = System.Drawing.Color.Transparent;
            FillTotalRatingSquare(totalRating, ratingSquare);
            ratingSquare.SizeMode = PictureBoxSizeMode.Zoom;
            background.Controls.Add(ratingSquare);
            ratingSquare.BringToFront();
            return ratingSquare;
        }

        private void FillTotalRatingSquare(int rating, PictureBox square)
        {
            if (rating <= 30)
            {
                square.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Views", "Visual", "BadTotalRating.png"));
                if (CurrentGameplay.Rating.TotalRating <= 9)
                    square.Controls.OfType<Label>().First().Location = new Point((int)(39 * ScreenWidth / OriginalWidth), (int)(29 * ScreenHeight / OriginalHeight));
            }
            else if (rating >= 70)
            {
                square.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Views", "Visual", "GoodTotalRating.png"));
                if (CurrentGameplay.Rating.TotalRating == 100)
                    square.Controls.OfType<Label>().First().Location = new Point((int)(0 * ScreenWidth / OriginalWidth), (int)(29 * ScreenHeight / OriginalHeight));
            }
            else
                square.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Views", "Visual", "MiddleTotalRating.png"));
            if (CurrentGameplay.Rating.TotalRating > 9 && CurrentGameplay.Rating.TotalRating < 100)
                square.Controls.OfType<Label>().First().Location = new Point((int)(15 * ScreenWidth / OriginalWidth), (int)(29 * ScreenHeight / OriginalHeight));
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            MainForm.Stage = GameStage.Gameplay;
            CurrentGameplay.Timer.Start();
            if (CurrentGameplay.MovieTapes.Count == 0)
            {
                MainForm.Stage = GameStage.DayResults;
                CurrentGameplay.EndTheDay();
            }
            MainForm.Controls.Remove(this);
        }
    }
}


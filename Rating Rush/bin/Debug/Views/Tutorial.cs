using NAudio.Wave;
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
using Rating_Rush.Domain;
using System.Drawing.Drawing2D;
using System.Diagnostics;
using System.Security.Policy;
using NAudio.CoreAudioApi;
//using System.Reflection.Emit;

namespace Rating_Rush.Views
{
    public partial class Tutorial : UserControl
    {
        public WaveOutEvent MusicPlayer;
        private AudioFileReader MusicFile;
        private MainForm MainForm;
        public Game Game;
        public Rating_Rush.Domain.Day Day;
        public Player Player;
        public List<PictureBox> MovieTapes = new List<PictureBox>();
        public List<Label> MovieParameters = new List<Label>();
        private PictureBox Poster = new PictureBox();
        private PictureBox PlotRatingCircle = new PictureBox();
        private PictureBox QualityRatingCircle = new PictureBox();
        public PictureBox TotalRatingSquare = new PictureBox();
        private PictureBox RatingBoard = new PictureBox();
        public Rating Rating;
        public int counter = 0;
        public int startMoney;
        public int startFame;
        public Scenario Scenario;
        public Dictionary<string, int> Database = new Dictionary<string, int>();
        private int Counter = 0;

        public Tutorial(MainForm mainForm, int scenarioNumber)
        {
            Player = new Player();
            InitializeComponent();
            MainForm = mainForm;
            MusicPlayer = new WaveOutEvent();
            MusicPlayer.Volume = MainForm.MusicVolume;
            Scenario = new Scenario(scenarioNumber);
            ChooseSong();
            MusicPlayer.PlaybackStopped += (sender, args) =>
            {
                if (MusicFile != null)
                    ChooseSong();
            };
            Game = new Game(scenarioNumber);
            UpdateGameInformation();
            Day = Game.Days.First();
            UpdateDayInformation();
            UpdatePlayerInformation();
            UpdateProgressBar();
            slide.BringToFront();
            ChangeSlide();
        }

        private void ChangeSlide()
        {
            Counter++;
            string solutionDir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            if (Counter == 49)
            {
                MainForm.Stage = GameStage.MainMenu;
                this.Parent.Controls.Remove(this);
                MusicFile = null;
                MusicPlayer.Dispose();
                MainForm.ChangeStage();
                return;
            }
            slide.Image = Image.FromFile(Path.Combine(solutionDir, "Rating Rush", "Views", "Visual", "Tutorial", string.Format("slide{0}.png", Counter).ToString()));
            slide.Controls.Add(continueButton);
            continueButton.Location = new Point((int)(0 * ScreenWidth / OriginalWidth), (int)(240 * ScreenHeight / OriginalHeight));
            if (Counter == 14 || Counter == 25 || Counter == 26 || Counter == 32 || Counter == 35 
                || Counter == 38 || Counter == 39 || Counter == 44 || Counter == 46)
                background.Controls.Remove(slide);
            if (Counter == 14)
            {
                MovieTapes[0].Cursor = System.Windows.Forms.Cursors.Hand;
                MovieTapes[0].Click += new System.EventHandler(this.ChooseMovie_Click);
                MovieTapes[0].Controls.OfType<Label>().First().Click += new System.EventHandler(this.ChooseMovie_Click);
                MovieTapes[0].Cursor = System.Windows.Forms.Cursors.Hand;
            }
            if (Counter == 17)
                background.Controls.Add(ratingReminderButton);
            if (Counter == 25)
                background.Controls.Add(cinemaAnalyticsButton);
            if (Counter == 38)
                background.Controls.Add(starsDatabaseButton);
            if (Counter == 46)
            {
                ControlExtension.Draggable(Poster, true);
                Poster.Cursor = Cursors.SizeAll;
                Poster.MouseUp += Poster_MouseUp;
            }
        }

        private void Poster_MouseUp(object sender, MouseEventArgs e)
        {
            var rectangle = new Rectangle(sendingZone.Location.X, sendingZone.Location.Y,
                    sendingZone.Location.X + sendingZone.Size.Width, sendingZone.Location.Y + sendingZone.Size.Height);
            if (!rectangle.Contains(MousePosition))
                Poster.Location = new Point((int)(351 * ScreenWidth / OriginalWidth), (int)(90 * ScreenHeight / OriginalHeight));
            else
            {
                var movieTitle = background.Controls.OfType<Label>().First(label => label.Name == "movieName").Text;
                var movieTape = MovieTapes.First(tape => tape.Controls.OfType<Label>().First().Name == movieTitle);
                background.Controls.Remove(movieTape);
                MovieTapes.Remove(movieTape);
                RemoveMovieInformation();
                if (Counter == 46)
                {
                    background.Controls.Add(slide);
                    slide.BringToFront();
                }
            }
        }

        private void RemoveMovieInformation()
        {
            background.Controls.Remove(sendingZone);
            background.Controls.Remove(Poster);
            background.Controls.Remove(RatingBoard);
            foreach (var parameter in MovieParameters)
                background.Controls.Remove(parameter);
            MovieParameters.Clear();
        }

        public void UpdateProgressBar()
        {
            ratedMoviesCounter.Text = Day.RatedMovies.ToString() + "/" + Day.AmountOfMovies.ToString();
            ratedMovies.Text = Day.RatedMovies.ToString() + "/" + Day.AmountOfMovies.ToString();
            ratedMoviesBar.Size = new Size((int)(200 / Day.AmountOfMovies * Day.RatedMovies * ScreenWidth / OriginalWidth), (int)(37 * ScreenHeight / OriginalHeight));
        }

        private void UpdateDayInformation()
        {
            foreach (var tape in MovieTapes)
                background.Controls.Remove(tape);
            MovieTapes.Clear();
            timeLeft.Text = Day.TimeLeft.ToString().Substring(3, Day.TimeLeft.ToString().Length - 3);
            for (int i = 0; i < Day.AmountOfMovies; i++)
                PlaceMovieTape(i);
            UpdateProgressBar();
        }

        private void PlaceMovieTape(int index)
        {
            var movieTape = new PictureBox();
            var movieTitle = new Label();
            if (Day.Movies[index].Title.Length > 14)
                movieTitle.Text = Day.Movies[index].Title.Substring(0, 15) + "...";
            else
                movieTitle.Text = Day.Movies[index].Title;
            movieTitle.Name = Day.Movies[index].Title;
            movieTape.BackColor = System.Drawing.Color.Transparent;
            movieTape.Controls.Add(movieTitle);
            movieTitle.BackColor = System.Drawing.Color.Transparent;
            movieTitle.Font = new System.Drawing.Font("Gilroy Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            movieTitle.ForeColor = System.Drawing.Color.Cornsilk;
            SetPosition(movieTitle, 293, 40, 0, 10);
            ScaleFont(movieTitle, 24F);
            string solutionDir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            movieTape.Image = Image.FromFile(Path.Combine(solutionDir, "Rating Rush", "Views", "Visual", "MovieTape.png"));
            movieTape.SizeMode = PictureBoxSizeMode.Zoom;
            background.Controls.Add(movieTape);
            MovieTapes.Add(movieTape);
            SetPosition(movieTape, 309, 79, 0, 65 + index * 79);
        }

        private void ChooseMovie_Click(object sender, EventArgs e)
        {
            RemoveMovieInformation();
            background.Controls.Add(sendingZone);
            sendingZone.BringToFront();
            string movieTitle;
            if (sender is PictureBox)
                movieTitle = (sender as PictureBox).Controls.OfType<Label>().First().Name;
            else
                movieTitle = (sender as Label).Name;
            var movie = Day.Movies.First(film => film.Title == movieTitle);
            string solutionDir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            Poster.Image = Image.FromFile(movie.PosterName);
            SetPosition(Poster, 340, 510, 351, 90);
            Poster.SizeMode = PictureBoxSizeMode.Zoom;
            background.Controls.Add(Poster);
            for (int i = 0; i < 9; i++)
                CreateLabelForMovieParameters();
            PlaceMovieParameters(movie);
            Database[movie.Company.Name] = movie.Company.Stars;
            Database[movie.Director.Name] = movie.Director.Stars;
            Database[movie.MainActor.Name] = movie.MainActor.Stars;
            PlaceRatingBoard();
            Poster.BringToFront();
            if (Counter == 14)
            {
                background.Controls.Add(slide);
                slide.BringToFront();
            }
        }

        private void PlaceMovieParameters(Movie movie)
        {
            MovieParameters[0].Text = movie.Title;
            MovieParameters[0].Name = "movieName";
            SetPosition(MovieParameters[0], 1000, 50, 760, 100);
            MovieParameters[0].Font = new System.Drawing.Font("Gilroy Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            ScaleFont(MovieParameters[0], 30F);
            MovieParameters[1].Text = movie.Country;
            SetPosition(MovieParameters[1], 550, 50, 940, 180);
            MovieParameters[2].Text = movie.Genre;
            SetPosition(MovieParameters[2], 550, 50, 940, 295);
            MovieParameters[3].Text = movie.Budget.ToString() + "$";
            SetPosition(MovieParameters[3], 550, 50, 940, 407);
            MovieParameters[4].Text = movie.AgeRate.ToString() + "+";
            SetPosition(MovieParameters[4], 550, 50, 940, 522);
            MovieParameters[5].Text = movie.Company.Name;
            if (MovieParameters[5].Text.Length > 19)
                SetPosition(MovieParameters[5], 370, 100, 1486, 160);
            else
                SetPosition(MovieParameters[5], 550, 50, 1486, 180);
            MovieParameters[6].Text = movie.Director.Name;
            SetPosition(MovieParameters[6], 550, 50, 1486, 295);
            MovieParameters[7].Text = movie.MainActor.Name;
            SetPosition(MovieParameters[7], 550, 50, 1486, 407);
            MovieParameters[8].Text = movie.Time.ToString();
            SetPosition(MovieParameters[8], 550, 50, 1486, 522);
        }

        private void CreateLabelForMovieParameters()
        {
            var label = new Label();
            label.BackColor = System.Drawing.Color.Transparent;
            label.Font = new System.Drawing.Font("Gilroy Black", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            ScaleFont(label, 28F);
            label.ForeColor = System.Drawing.Color.Cornsilk;
            label.Size = new System.Drawing.Size(550, 50);
            background.Controls.Add(label);
            MovieParameters.Add(label);
        }

        private Label CreateLabelForRating(int size)
        {
            var rating = new Label();
            rating.Font = new Font("Uni Sans Heavy CAPS", 70F, FontStyle.Bold);
            ScaleFont(rating, 70F);
            rating.Size = new Size((int)(size * ScreenWidth / OriginalWidth), (int)(size * ScreenHeight / OriginalHeight));
            rating.ForeColor = Color.Black;
            rating.BackColor = Color.Transparent;
            return rating;
        }

        private void CreateCircleForRating(PictureBox ratingCircle)
        {
            string solutionDir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            ratingCircle.BackColor = Color.Transparent;
            ratingCircle.Image = Image.FromFile(Path.Combine(solutionDir, "Rating Rush", "Views", "Visual", "MiddleRating.png"));
            ratingCircle.SizeMode = PictureBoxSizeMode.Zoom;
            ratingCircle.Controls.OfType<Label>().First().Text = Rating.Plot.ToString();
            RatingBoard.Controls.Add(ratingCircle);
        }

        private Button CreateButtonForRating()
        {
            var button = new Button();
            button.BackColor = Color.Transparent;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            button.Cursor = System.Windows.Forms.Cursors.Hand;
            RatingBoard.Controls.Add(button);
            return button;
        }

        private void PlaceRatingBoard()
        {
            Rating = new Rating();
            string solutionDir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            PlotRatingCircle.Controls.Add(CreateLabelForRating(150));
            CreateCircleForRating(PlotRatingCircle);
            SetPosition(PlotRatingCircle, 150, 150, 322, 0);
            QualityRatingCircle.Controls.Add(CreateLabelForRating(150));
            CreateCircleForRating(QualityRatingCircle);
            SetPosition(QualityRatingCircle, 150, 150, 319, 192);
            TotalRatingSquare.Controls.Add(CreateLabelForRating(200));
            CreateCircleForRating(TotalRatingSquare);
            TotalRatingSquare.Image = Image.FromFile(Path.Combine(solutionDir, "Rating Rush", "Views", "Visual", "MiddleTotalRating.png"));
            SetPosition(TotalRatingSquare, 173, 171, 764, 89);
            TotalRatingSquare.Controls.OfType<Label>().First().Text = Rating.TotalRating.ToString();
            RatingBoard.BackColor = Color.Transparent;
            RatingBoard.Image = Image.FromFile(Path.Combine(solutionDir, "Rating Rush", "Views", "Visual", "RatingBoard.png"));
            RatingBoard.SizeMode = PictureBoxSizeMode.Zoom;
            SetPosition(RatingBoard, 940, 344, 488, 687);
            background.Controls.Add(RatingBoard);
            PlaceRatingButtons();
            UpdatePlotRating();
            UpdateQualityRating();
            UpdateTotalRating();
        }

        private void PlaceRatingButtons()
        {
            var plusPlotButton = CreateButtonForRating();
            SetPosition(plusPlotButton, 55, 55, 252, 15);
            var minusPlotButton = CreateButtonForRating();
            SetPosition(minusPlotButton, 55, 55, 252, 79);
            var plusQualityButton = CreateButtonForRating();
            SetPosition(plusQualityButton, 55, 55, 251, 209);
            var minusQualityButton = CreateButtonForRating();
            SetPosition(minusQualityButton, 55, 55, 251, 273);
            plusPlotButton.Click += new System.EventHandler(this.PlusPlotButton_Click);
            minusPlotButton.Click += new System.EventHandler(this.MinusPlotButton_Click);
            plusQualityButton.Click += new System.EventHandler(this.PlusQualityButton_Click);
            minusQualityButton.Click += new System.EventHandler(this.MinusQualityButton_Click);
        }

        private void MinusQualityButton_Click(object sender, EventArgs e)
        {
            Rating.Quality--;
            UpdateQualityRating();
            UpdateTotalRating();
            if (Counter == 32 && Rating.Quality == 4)
            {
                background.Controls.Add(slide);
                slide.BringToFront();
            }
            if (Counter == 39 && Rating.Quality == 3)
            {
                background.Controls.Add(slide);
                slide.BringToFront();
            }
        }

        private void PlusQualityButton_Click(object sender, EventArgs e)
        {
            Rating.Quality++;
            UpdateQualityRating();
            UpdateTotalRating();
        }

        private void PlusPlotButton_Click(object sender, EventArgs e)
        {
            Rating.Plot++;
            UpdatePlotRating();
            UpdateTotalRating();
            if (Counter == 26 && Rating.Plot == 6)
            {
                background.Controls.Add(slide);
                slide.BringToFront();
            }
            if (Counter == 35 && Rating.Plot == 7)
            {
                background.Controls.Add(slide);
                slide.BringToFront();
            }
        }

        private void MinusPlotButton_Click(object sender, EventArgs e)
        {
            Rating.Plot--;
            UpdatePlotRating();
            UpdateTotalRating();
            if (Counter == 44 && Rating.Plot == 6)
            {
                background.Controls.Add(slide);
                slide.BringToFront();
            }
        }

        private void UpdateQualityRating()
        {
            QualityRatingCircle.Controls.OfType<Label>().First().Text = Rating.Quality.ToString();
            UpdateRating(QualityRatingCircle);
        }

        private void UpdatePlotRating()
        {
            PlotRatingCircle.Controls.OfType<Label>().First().Text = Rating.Plot.ToString();
            UpdateRating(PlotRatingCircle);
        }

        private void UpdateRating(PictureBox ratingCircle)
        {
            string solutionDir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            if (int.Parse(ratingCircle.Controls.OfType<Label>().First().Text) <= 3)
                ratingCircle.Image = Image.FromFile(Path.Combine(solutionDir, "Rating Rush", "Views", "Visual", "BadRating.png"));
            else if (int.Parse(ratingCircle.Controls.OfType<Label>().First().Text) >= 7)
                ratingCircle.Image = Image.FromFile(Path.Combine(solutionDir, "Rating Rush", "Views", "Visual", "GoodRating.png"));
            else
                ratingCircle.Image = Image.FromFile(Path.Combine(solutionDir, "Rating Rush", "Views", "Visual", "MiddleRating.png"));
            if (Rating.Plot == 10)
                ratingCircle.Controls.OfType<Label>().First().Location = new Point((int)(10 * ScreenWidth / OriginalWidth), (int)(10 * ScreenHeight / OriginalHeight));
            else
                ratingCircle.Controls.OfType<Label>().First().Location = new Point((int)(30 * ScreenWidth / OriginalWidth), (int)(20 * ScreenHeight / OriginalHeight));
        }

        private void UpdateTotalRating()
        {
            TotalRatingSquare.Controls.OfType<Label>().First().Text = Rating.TotalRating.ToString();
            string solutionDir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            if (Rating.TotalRating <= 30)
            {
                TotalRatingSquare.Image = Image.FromFile(Path.Combine(solutionDir, "Rating Rush", "Views", "Visual", "BadTotalRating.png"));
                if (Rating.TotalRating <= 9)
                    TotalRatingSquare.Controls.OfType<Label>().First().Location = new Point((int)(42 * ScreenWidth / OriginalWidth), (int)(29 * ScreenHeight / OriginalHeight));
            }
            else if (Rating.TotalRating >= 70)
            {
                TotalRatingSquare.Image = Image.FromFile(Path.Combine(solutionDir, "Rating Rush", "Views", "Visual", "GoodTotalRating.png"));
                if (Rating.TotalRating == 100)
                    TotalRatingSquare.Controls.OfType<Label>().First().Location = new Point((int)(0 * ScreenWidth / OriginalWidth), (int)(29 * ScreenHeight / OriginalHeight));
            }
            else
                TotalRatingSquare.Image = Image.FromFile(Path.Combine(solutionDir, "Rating Rush", "Views", "Visual", "MiddleTotalRating.png"));
            if (Rating.TotalRating > 9 && Rating.TotalRating < 100)
                TotalRatingSquare.Controls.OfType<Label>().First().Location = new Point((int)(15 * ScreenWidth / OriginalWidth), (int)(29 * ScreenHeight / OriginalHeight));
        }

        public void UpdatePlayerInformation()
        {
            money.Text = Player.Money.ToString() + "$";
            famePointer.Location = new Point((int)(Player.Fame * 1.1 + 937 * ScreenWidth / OriginalWidth), (int)(17 * ScreenHeight / OriginalHeight));
        }

        private void UpdateGameInformation()
        {
            currentDay.Text = "День: " + (Game.AmountOfPassedDays + 1).ToString();
        }

        private void ChooseSong()
        {
            string solutionDir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            var songs = Directory.GetFiles(Path.Combine(solutionDir, "Rating Rush", "Audio", "Gameplay"));
            var random = new Random();
            MusicFile = new AudioFileReader(Path.Combine(solutionDir, solutionDir, "Rating Rush", "Audio", "Gameplay", Path.GetFileName(songs[random.Next(songs.Length)])));
            MusicPlayer.Init(MusicFile);
            MusicPlayer.Play();
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            MainForm.Stage = GameStage.MainMenu;
            MusicPlayer.Dispose();
            MusicFile = null;
            MainForm.ChangeStage();
            MainForm.Controls.Remove(this);
        }

        private void StarsDatabaseButton_Click_1(object sender, EventArgs e)
        {
            string solutionDir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            var starsDatabase = new StarsDatabaseControl(Database);
            background.Controls.Add(starsDatabaseLine);
            starsDatabaseLine.Image = Image.FromFile(Path.Combine(solutionDir, "rating Rush", "Views", "Visual", "Stars Database Tape.png"));
            starsDatabaseLine.BringToFront();
            background.Controls.Add(starsDatabase);
            starsDatabase.BringToFront();
            starsDatabase.Location = new Point((int)(1035 * ScreenWidth / OriginalWidth), (int)(82 * ScreenHeight / OriginalHeight));
            if (Counter == 38)
            {
                background.Controls.Add(slide);
                slide.BringToFront();
            }
        }

        private void RatingReminderButton_Click_1(object sender, EventArgs e)
        {
            background.Controls.Add(ratingReminder);
            ratingReminder.Controls.Add(closeRatingReminderButton);
            closeRatingReminderButton.Location = new Point((int)(535 * ScreenWidth / OriginalWidth), (int)(0 * ScreenHeight / OriginalHeight));
            background.Controls.Remove(ratingReminderButton);
            ratingReminder.BringToFront();
        }

        private void CinemaAnalyticsButton_Click_1(object sender, EventArgs e)
        {
            var cinemaAnalytics = new CinemaAnalyticsControl(Day);
            background.Controls.Add(cinemaAnalyticsTape);
            cinemaAnalyticsTape.BringToFront();
            background.Controls.Add(cinemaAnalytics);
            cinemaAnalytics.BringToFront();
            cinemaAnalytics.Location = new Point((int)(1480 * ScreenWidth / OriginalWidth), (int)(80 * ScreenHeight / OriginalHeight));
            if (Counter == 25)
            {
                background.Controls.Add(slide);
                slide.BringToFront();
            }
        }

        private void CloseRatingReminderButton_Click_1(object sender, EventArgs e)
        {
            background.Controls.Remove(ratingReminder);
            background.Controls.Add(ratingReminderButton);
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            ChangeSlide();
        }
    }
}
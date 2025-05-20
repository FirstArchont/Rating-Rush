using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Rating_Rush.Domain
{
    public class Scenario
    {
        public const int TutorialScenario = 0;
        public const int EasyScenario = 1;
        public const int MiddleScenario = 2;
        public const int HardScenario = 3;
        public const int InfinityScenario = 4;

        public List<Day> Days { get; }
        public int AmountOfDays { get; }
        public int Tax { get; set; }
        public int TaxDifference { get; set; }
        public int MaxReward { get; set; }

        public Scenario(int scenarioNumber)
        {
            if (scenarioNumber == TutorialScenario)
                Days = GenerateDaysWithScenarioTutorial();
            else if (scenarioNumber == InfinityScenario)
                Days = GenerateDaysWithInfinityScenario();
            else if (scenarioNumber == EasyScenario)
                Days = GenerateDaysWithEasyScenario();
            else if (scenarioNumber == HardScenario)
                Days = GenerateDaysWithHardScenario();
            else
                Days = GenerateDaysWithMiddleScenario();
        }

        private List<Day> GenerateDaysWithHardScenario()
        {
            Tax = 30;
            TaxDifference = 20;
            MaxReward = 10;
            var days = new List<Day>();
            days.Add(new Day(4, TimeSpan.FromMinutes(2)));
            days.Add(new Day(4, TimeSpan.FromMinutes(1.5)));
            days.Add(new Day(4, TimeSpan.FromMinutes(1)));
            days.Add(new Day(5, TimeSpan.FromMinutes(1.5)));
            days.Add(new Day(5, TimeSpan.FromMinutes(1)));
            days.Add(new Day(5, TimeSpan.FromMinutes(0.5)));
            days.Add(new Day(6, TimeSpan.FromMinutes(1)));
            return days;
        }

        private List<Day> GenerateDaysWithMiddleScenario()
        {
            Tax = 20;
            TaxDifference = 15;
            MaxReward = 10;
            var days = new List<Day>();
            days.Add(new Day(3, TimeSpan.FromMinutes(3)));
            days.Add(new Day(3, TimeSpan.FromMinutes(2.5)));
            days.Add(new Day(3, TimeSpan.FromMinutes(2)));
            days.Add(new Day(4, TimeSpan.FromMinutes(2.5)));
            days.Add(new Day(4, TimeSpan.FromMinutes(2)));
            days.Add(new Day(4, TimeSpan.FromMinutes(1.5)));
            days.Add(new Day(5, TimeSpan.FromMinutes(2)));
            return days;
        }

        private List<Day> GenerateDaysWithEasyScenario()
        {
            Tax = 10;
            TaxDifference = 10;
            MaxReward = 10;
            var days = new List<Day>();
            days.Add(new Day(2, TimeSpan.FromMinutes(4)));
            days.Add(new Day(2, TimeSpan.FromMinutes(3.5)));
            days.Add(new Day(2, TimeSpan.FromMinutes(3)));
            days.Add(new Day(3, TimeSpan.FromMinutes(3.5)));
            days.Add(new Day(3, TimeSpan.FromMinutes(3)));
            days.Add(new Day(3, TimeSpan.FromMinutes(2.5)));
            days.Add(new Day(4, TimeSpan.FromMinutes(3)));
            return days;
        }

        private List<Day> GenerateDaysWithInfinityScenario()
        {
            Tax = 30;
            TaxDifference = 0;
            MaxReward = 10;
            var random = new Random();
            var days = new List<Day>();
            for (int i = 0; i < 1000; i++)
                days.Add(new Day(random.Next(2, 5), TimeSpan.FromMinutes(random.Next(1, 4))));
            return days;
        }

        private List<Day> GenerateDaysWithScenarioTutorial()
        {
            Tax = 0;
            TaxDifference = 0;
            var days = new List<Day>();
            var genresPopularity = new List<(string, Popularity)>();
            genresPopularity.Add(("Нуар", Popularity.High));
            genresPopularity.Add(("Вестерн", Popularity.High));
            genresPopularity.Add(("Мюзикл", Popularity.Medium));
            genresPopularity.Add(("Комедия", Popularity.Medium));
            genresPopularity.Add(("Боевик", Popularity.Medium));
            genresPopularity.Add(("Роуд-муви", Popularity.Medium));
            genresPopularity.Add(("Триллер", Popularity.Low));
            genresPopularity.Add(("Драма", Popularity.Low));
            genresPopularity.Add(("Хоррор", Popularity.Low));
            genresPopularity.Add(("Мелодрама", Popularity.Low));
            genresPopularity.Add(("Фантастика", Popularity.Low));
            string solutionDir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            days.Add(new Day(1, TimeSpan.FromMinutes(59), genresPopularity, "Drifter: Blood and Dust", "Вестерн",
            Path.Combine(solutionDir, "Rating Rush", "For Generation", "Posters", "RoadMovies", "RoadMovie8.png"), 
            "Блю-Ривер", 12000000, 18, new Company("Tower of The Leader Production", 5), new Human("Ширли Тимминс", 1), new Human("Адам Рассел", 2), TimeSpan.FromMinutes(210)));
            return days;
        }
    }
}

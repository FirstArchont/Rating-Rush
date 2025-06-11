using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rating_Rush.Domain
{
    public class Company : IRatedEntity
    {
        public string Name { get; }
        public int Stars { get; }
        private static Random Random { get; } = new Random();

        public Company(string name, int stars)
        {
            Name = name;
            Stars = stars;
        }

        public Company(Popularity quality)
        {
            Name = GenerateName();
            Stars = GenerateAmountOfStars(quality);
        }

        private int GenerateAmountOfStars(Popularity quality)
        {
            int starsRange = 0;
            if ((int)quality == 0 || (int)quality == 2)
            {
                int starsChance = Random.Next(10);
                if (starsChance < 7)
                    starsRange = quality == Popularity.High ? 2 : 0;
                else
                    starsRange = 1;
            }
            else
            {
                int starsChance = Random.Next(20);
                if (starsChance < 14)
                    starsRange = 1;
                else if (starsChance < 17)
                    starsRange = 0;
                else
                    starsChance = 2;
            }

            if (starsRange == 0)
                return Random.Next(3);
            else if (starsRange == 1)
                return 3;
            else
                return Random.Next(4, 6);
        }

        private string GenerateName()
        {
            var names = File.ReadAllLines(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "For Generation", "Companies.txt"));
            return names[Random.Next(names.Length)];
        }
    }
}
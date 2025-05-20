using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rating_Rush.Domain
{
    public class Rating
    {
        public const int MaxRating = 10;
        public const int MinRating = 0;

        private int plot = 5;
        private int quality = 5;
        public int TotalRating { get; set; }
        private int ErrorRate { get; } = 0;
        private static Random Random { get; } = new Random();

        public int Plot { get => plot; set
            {
                if (value >= MinRating && value <= MaxRating)
                {
                    plot = value;
                    CountTotalRating();
                }
            } 
        }

        public int Quality {  get => quality; set
            {
                if (value >= MinRating && value <= MaxRating)
                {
                    quality = value;
                    CountTotalRating();
                }
            }
        }

        public Rating()
        {
            CountTotalRating();
        }

        public Rating(int errorRate)
        {
            CountTotalRating();
            ErrorRate = errorRate;
        }

        private void CountTotalRating()
        {
            TotalRating = (Plot + Quality) * 10 / 2 + Random.Next(-ErrorRate , ErrorRate + 1);
        }
    }
}

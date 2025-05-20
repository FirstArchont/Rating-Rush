using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rating_Rush.Domain
{
    public class CinemaAnalytics
    {
        private Rating_Rush.Domain.Day Day;

        public CinemaAnalytics(Rating_Rush.Domain.Day day)
        {
            Day = day;
        }

        public List<(string, Popularity)> FindGenres(Popularity popularity)
        {
            return Day.GenresPopularity.Where(style => style.Item2 == popularity).ToList();
        }
    }
}

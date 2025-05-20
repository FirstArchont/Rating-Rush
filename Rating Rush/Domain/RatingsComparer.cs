using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rating_Rush.Domain
{
    public class RatingsComparer
    {
        public const int FameReward = 10;

        public static (int Fame, int Money) CompareRatings(Rating playerRating, Rating UsersRating, 
            int fame, int maxReward)
        {
            var mediumReward = maxReward / 2;
            var minReward = mediumReward / 2;
            int moneyReward = 0;
            int fameReward = 0;
            if (Math.Abs(playerRating.TotalRating - UsersRating.TotalRating) <= 5)
            {
                moneyReward += maxReward;
                fameReward += FameReward;
            }
            else if (Math.Abs(playerRating.TotalRating - UsersRating.TotalRating) <= 10)
                moneyReward += mediumReward;
            else
                fameReward -= FameReward;
            if (playerRating.Plot == UsersRating.Plot)
                moneyReward += mediumReward;
            else if (Math.Abs(playerRating.Plot - UsersRating.Plot) <= 1)
                moneyReward += minReward;
            if (playerRating.Quality == UsersRating.Quality)
                moneyReward += mediumReward;
            else if (Math.Abs(playerRating.Quality - UsersRating.Quality) <= 1)
                moneyReward += minReward;
            return (fameReward, (int) Math.Round((moneyReward * ((double) fame / 100 + 1))));
        }
    }
}

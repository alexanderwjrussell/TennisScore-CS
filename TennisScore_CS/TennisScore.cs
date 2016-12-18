using System;

namespace TennisScore_CS
{
	class TennisScore
	{
		public string Get(string score)
		{
			score = score.Replace("40 - 40", "Deuce");
			score = score.Replace("0", "Love");
			return score;
		}
	}
}
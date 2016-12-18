using System;
using System.Collections.Generic;

namespace TennisScore_CS
{
	class TennisScore
	{
		Dictionary<string, string> scores = new Dictionary<string, string>
		{
			{"0", "Love"},
			{"15", "15"},
			{"30", "30"},
			{"40", "40"}
		};

		public string Get(string score1, string score2)
		{
			var score = $"{scores[score1]} - {scores[score2]}";
			return score.Replace("40 - 40", "Deuce");
		}
	}
}
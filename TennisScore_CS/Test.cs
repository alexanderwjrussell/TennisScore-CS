using NUnit.Framework;

namespace TennisScore_CS
{
	[TestFixture]
	public class TennisScoreTest
	{
		[TestCase("0", "0", "Love - Love")]
		[TestCase("15", "15", "15 - 15")]
		[TestCase("30", "30", "30 - 30")]
		[TestCase("40", "40", "Deuce")]
	
		public void Should_ReturnCorrectScore(string score1, string score2, string result)
		{
			Assert.That(TennisScore.Get(score1, score2), Is.EqualTo(result));
		}
	}
}

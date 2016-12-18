using NUnit.Framework;
using System;
namespace TennisScore_CS
{
	[TestFixture]
	public class TennisScoreTest
	{
		[Test]
		public void Should_ReturnLove_When0()
		{
			var score = new TennisScore();
			Assert.That(score.Get("0", "0"), Is.EqualTo("Love - Love"));
		}

		[Test]
		public void Should_ReturnNormalScore_When15to15()
		{
			var score = new TennisScore();
			Assert.That(score.Get("15", "15"), Is.EqualTo("15 - 15"));
		}

		[Test]
		public void Should_ReturnDeuce_When40All()
		{
			var score = new TennisScore();
			Assert.That(score.Get("40", "40"), Is.EqualTo("Deuce"));
		}

		[Test]
		public void Should_ReturnEdgeCases_When30to30()
		{
			var score = new TennisScore();
			Assert.That(score.Get("30", "30"), Is.EqualTo("30 - 30"));
		}
	}
}

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
			Assert.That(score.Get("0 - 0"), Is.EqualTo("Love - Love"));
		}
	}
}

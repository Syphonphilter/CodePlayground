using System;
using Xunit;
namespace Playground.Tests
{
	public class LongestCommonPrefixTests
	{
		[Fact]
		public void LongestCommonPrefixTester()
		{
			string[] array = { "bala", "bana", "balaa", "bolaji" };

			string commonPrefix = LongestCommonPrefix.LongestCommonPrefix_v1(array);
			Assert.Equal("x", commonPrefix);
		}
	}
}


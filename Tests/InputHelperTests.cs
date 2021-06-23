using AdventOfCode.Helpers;
using FluentAssertions;
using Xunit;

namespace AdventOfCode.Tests
{
    public class InputHelperTests
    {
        [Theory]
        [InlineData(1, null, false, "Day1.txt")]
        [InlineData(2, 1, false, "Day2Part1.txt")]
        [InlineData(3, null, true, "Day3_ex.txt")]
        [InlineData(4, 1, true, "Day4Part1_ex.txt")]
        public void GetInputFilename__Should_Return_Correct_Filename(int day, int? part, bool example, string expected)
        {
            // ARRANGE & ACT
            var actual = InputHelper.GetInputFilename(day, part, example);

            // ASSERT
            actual.Should().Be(expected);
        }
    }
}

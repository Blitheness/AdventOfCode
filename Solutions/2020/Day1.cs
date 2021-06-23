using AdventOfCode.Helpers;
using FluentAssertions;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace AdventOfCode.Solutions._2020
{
    public class Day1
    {
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public async Task Part1__Should_Find_Two_Entries_That_Sum_To_2020(bool? example)
        {
            // ARRANGE
            var expected = 2020;
            var input = await InputHelper.GetInputs(day: 1, null, example);
            var integers = input.Select(x => int.Parse(x));
            var result = new int[2];

            // ACT
            foreach(var value1 in integers)
            foreach(var value2 in integers)
            {
                if(value1 + value2 == expected)
                {
                    result[0] = value1;
                    result[1] = value2;
                    break;
                }
            }

            // ASSERT
            result.Sum(x => x).Should().Be(expected);

            Console.WriteLine($"{result[0]} + {result[1]} = {expected}");
            Console.WriteLine($"The product of the two values that sum to {expected} is {result[0] * result[1]}.");
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public async Task Part2__Should_Find__Three_Entries_That_Sum_To_2020(bool? example)
        {
            // ARRANGE
            var expected = 2020;
            var input = await InputHelper.GetInputs(day: 1, null, example);
            var integers = input.Select(x => int.Parse(x));
            var result = new int[3];

            // ACT
            foreach (var value1 in integers)
            foreach (var value2 in integers)
            foreach (var value3 in integers)
            {
                if (value1 + value2 + value3 == expected)
                {
                    result[0] = value1;
                    result[1] = value2;
                    result[2] = value3;
                    break;
                }
            }

            // ASSERT
            result.Sum(x => x).Should().Be(expected);

            Console.WriteLine($"{result[0]} + {result[1]} + {result[2]} = {expected}");
            Console.WriteLine($"The product of the three values that sum to {expected} is {result[0] * result[1] * result[2]}.");
        }
    }
}

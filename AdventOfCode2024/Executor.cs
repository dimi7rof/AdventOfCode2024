﻿using Microsoft.Extensions.Primitives;

namespace AdventOfCode2024;

public static class Executor
{
    public static (int, int) Day1(StringValues input)
    {
        var values = input.First()!
            .Split(Environment.NewLine)
            .Select(x => x.Split(' ', StringSplitOptions.RemoveEmptyEntries));

        var firstList = values
            .Select(x => int.Parse(x.First()))
            .Order();

        var secondList = values
            .Select(x => int.Parse(x.Last()))
            .Order();

        var partOne = firstList.Zip(secondList, (x, y) => Math.Abs(x - y)).Sum();

        var countDictionary = secondList
            .GroupBy(x => x)
            .ToDictionary(g => g.Key, g => g.Count());

        var partTwo = firstList
            .Select(item => item * (countDictionary.TryGetValue(item, out int value) ? value : 0))
            .Sum();

        return (partOne, partTwo);
        //3246517
        //29379307
    }

    public static (int, int) Day2(StringValues input)
    {
        var values = input.First()!.Split(Environment.NewLine);

        return (0, 0);
    }
}

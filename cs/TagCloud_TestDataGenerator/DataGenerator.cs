﻿using System;
using System.Collections.Generic;
using System.Drawing;

namespace TagCloud_TestDataGenerator
{
    public static class DataGenerator
    {
        private const int MinSize = 15;
        private const int MaxSize = 150;

        private static readonly Random Rnd;

        static DataGenerator()
        {
            Rnd = new Random();
        }

        public static IEnumerable<Size> GetNextNSizes(int n)
        {
            for (var i = 0; i < n; i++)
            {
                var width = Rnd.Next(MinSize, MaxSize);
                var height = Rnd.Next(MinSize, MaxSize);
                yield return new Size(width, height);
            }
        }
    }
}
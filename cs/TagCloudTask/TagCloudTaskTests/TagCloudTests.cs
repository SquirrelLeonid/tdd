﻿using System;
using System.Drawing;
using FluentAssertions;
using NUnit.Framework;
using TagCloudTask;
using TagCloudTask.Layouting;

namespace TagCloudTaskTests
{
    public class TagCloudTests
    {
        [Test]
        public void SaveToBitmap_ShouldThrow_WhenNoOneRectangleWasPut()
        {
            var tagCloud = new TagCloud(new CircularLayouter(Point.Empty),
                null, null);

            Action act = () => tagCloud.SaveBitmap(true, true, false);
            act
                .Should()
                .Throw<ArgumentException>()
                .WithMessage("image width and height can't be lower than 1");
        }
    }
}
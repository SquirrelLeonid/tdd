﻿using System;
using System.Drawing;

namespace TagCloud.Geometry
{
    public class DirectingArrow
    {
        private readonly Point startPoint;
        private double angleRadian;

        private int radiusVectorLength;

        public DirectingArrow(Point startPoint)
        {
            this.startPoint = startPoint;
            angleRadian = 0;
            radiusVectorLength = 0;
        }

        public void Rotate()
        {
            var rotationAngle = Math.PI / (6 + radiusVectorLength);
            angleRadian += rotationAngle;

            if (angleRadian >= 2 * Math.PI)
            {
                angleRadian -= 2 * Math.PI;
                radiusVectorLength += 1;
            }
        }

        public Point GetEndPoint()
        {
            var x = (int)(startPoint.X + radiusVectorLength * Math.Cos(angleRadian));
            var y = (int)(startPoint.Y + radiusVectorLength * Math.Sin(angleRadian));

            return new Point(x, y);
        }
    }
}
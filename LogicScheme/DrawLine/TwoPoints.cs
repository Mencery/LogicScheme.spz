﻿
using System;
using System.Drawing;


namespace LogicScheme
{
    [Serializable]
    public class TwoPoints
    {
        public Point pointStart { get; set; }
        public Point pointEnd { get; set; }

       public TwoPoints(Point pointStart, Point pointEnd)
        {
            this.pointStart = pointStart;
            this.pointEnd = pointEnd;
        }
        public TwoPoints()
        {
           
        }

    }
}

﻿using System;

namespace lab_4_2
{
    class Rectangle : Figure
    {
        public Rectangle(float X, float Y) : base(X, Y)
        {

        }

        public override void Draw()
        {
            Console.WriteLine("Rectangle");
        }
    }
}

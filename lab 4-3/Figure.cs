using System;

namespace lab_4_3
{
    class Figure
    {
        public float X { get; private set; }
        public float Y { get; private set; }

        public Figure(float X, float Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public virtual void Draw()
        {
            Console.WriteLine("Figure");
        }
    }
}

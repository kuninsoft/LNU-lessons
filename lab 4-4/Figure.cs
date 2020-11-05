using System;

namespace lab_4_4
{
    class Figure : IDrawable
    {
        public float X { get; private set; }
        public float Y { get; private set; }

        public Figure(float X, float Y)
        {
            this.X = X;
            this.Y = Y;
        }

        void IDrawable.Draw()
        {
            Console.WriteLine("Figure");
        }
    }
}

using System;

namespace lab_4_4
{
    class Figure : IDrawable
    {
        public float X { get; private set; }
        public float Y { get; private set; }

        public Figure(float x, float y)
        {
            this.X = x;
            this.Y = y;
        }

        void IDrawable.Draw()
        {
            Console.WriteLine("Figure");
        }
    }
}

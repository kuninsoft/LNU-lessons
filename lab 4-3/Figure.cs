using System;

namespace lab_4_3
{
    class Figure
    {
        public float X { get; private set; }
        public float Y { get; private set; }

        public Figure(float x, float y)
        {
            this.X = x;
            this.Y = y;
        }

        public virtual void Draw()
        {
            Console.WriteLine("Figure");
        }
    }
}

using System;

namespace lab_4_2
{
    class Square : Figure
    {
        public Square(float x, float y) : base(x, y)
        {

        }
        public override void Draw()
        {
            Console.WriteLine("Square");
        }
    }
}

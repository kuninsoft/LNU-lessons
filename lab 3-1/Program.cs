using System;

namespace lab_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input;
            double[] inputVertex = new double[4];

            Rectangle rect;
            Vertex leftTop;
            Vertex rightBottom;

            Console.Write("Enter coordinates of left-top vertex and right-bottom vertex of rectangle, separated by spaces.\n(e.g. 2 3 2 1): ");

            input = Console.ReadLine().Split(' ');
            
            for (int i = 0; i < 4; i++)
            {
                inputVertex[i] = double.Parse(input[i]);
            }

            leftTop = new Vertex(inputVertex[0], inputVertex[1]);
            rightBottom = new Vertex(inputVertex[2], inputVertex[3]);

            rect = new Rectangle(leftTop, rightBottom);

            Console.WriteLine($"Rectangle area is: {rect.GetArea()} \nRectangle perimeter is: {rect.GetPerimeter()}");

            Console.ReadKey();
        }
    }
}

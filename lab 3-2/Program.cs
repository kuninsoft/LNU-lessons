using System;

namespace lab_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] inputVertex = new double[4];

            Console.Write("Enter coordinates of left-top vertex and right-bottom vertex of rectangle, separated by spaces.\n(e.g. 2 3 2 1): ");

            var input = Console.ReadLine().Split(' ');
            
            for (int i = 0; i < 4; i++)
            {
                inputVertex[i] = double.Parse(input[i]);
            }

            var leftTop = new Vertex(inputVertex[0], inputVertex[1]);
            var rightBottom = new Vertex(inputVertex[2], inputVertex[3]);

            var rect = new Rectangle(leftTop, rightBottom);

            Console.WriteLine($"Rectangle area is: {rect.Area} \nRectangle perimeter is: {rect.Perimeter}");

            Console.ReadKey();
        }
    }
}

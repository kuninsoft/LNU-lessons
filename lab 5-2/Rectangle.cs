namespace lab_5_2
{
    struct Rectangle : ISize, ICoordinates
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double X { get; set; }
        public double Y { get; set; }

        public Rectangle(double width, double height, double x, double y)
        {
            Width = width;
            Height = height;
            X = x;
            Y = y;
        }
        public double Perimeter()
        {
            return 2 * Width + 2 * Height;
        }
    }
}

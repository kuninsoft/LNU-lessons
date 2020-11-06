namespace lab_5_2
{
    interface ISize
    {
        double Width { get; set; }
        double Height { get; set; }

        double Perimeter();
    }
}

namespace lab_4_2
{
    abstract class Figure
    {
        public float X { get; private set; }
        public float Y { get; private set; }

        protected Figure(float X, float Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public abstract void Draw();
    }
}

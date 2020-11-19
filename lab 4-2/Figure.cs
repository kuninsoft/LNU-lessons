namespace lab_4_2
{
    abstract class Figure
    {
        public float X { get; private set; }
        public float Y { get; private set; }

        protected Figure(float x, float y)
        {
            this.X = x;
            this.Y = y;
        }

        public abstract void Draw();
    }
}

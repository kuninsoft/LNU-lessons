namespace lab_3_2
{
    class Rectangle
    {
        private Vertex leftTopVertex;
        private Vertex rightBottomVertex;

        // For calculating edge lengths so we can calculate area and perimeter.
        private double verticalEdge;
        private double horizontalEdge;

        public double Area { get; private set; }
        public double Perimeter { get; private set; }

        public Rectangle(Vertex leftTopVertex, Vertex rightBottomVertex)
        {
            this.leftTopVertex = leftTopVertex;
            this.rightBottomVertex = rightBottomVertex;

            verticalEdge = leftTopVertex.Y - rightBottomVertex.Y;
            horizontalEdge = rightBottomVertex.X - leftTopVertex.X;

            Area = verticalEdge * horizontalEdge;
            Perimeter = verticalEdge * 2 + horizontalEdge * 2;
        }
    }
}

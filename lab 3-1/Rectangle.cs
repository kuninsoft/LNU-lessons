namespace lab_3_1
{
    class Rectangle
    {
        private Vertex leftTopVertex;
        private Vertex rightBottomVertex;

        // For calculating edge lengths so we can calculate area and perimeter.
        private double verticalEdge;
        private double horizontalEdge;

        public Rectangle(Vertex leftTopVertex, Vertex rightBottomVertex)
        {
            this.leftTopVertex = leftTopVertex;
            this.rightBottomVertex = rightBottomVertex;

            verticalEdge = leftTopVertex.Y - rightBottomVertex.Y;
            horizontalEdge = rightBottomVertex.X - leftTopVertex.X;
        }

        public double GetArea()
        {
            return verticalEdge * horizontalEdge;
        }

        public double GetPerimeter()
        {
            return verticalEdge * 2 + horizontalEdge * 2;
        }
    }
}

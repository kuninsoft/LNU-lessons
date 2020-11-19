namespace lab_3_1
{
    class Rectangle
    {
        private Vertex _leftTopVertex;
        private Vertex _rightBottomVertex;

        // For calculating edge lengths so we can calculate area and perimeter.
        private double _verticalEdge;
        private double _horizontalEdge;

        public Rectangle(Vertex leftTopVertex, Vertex rightBottomVertex)
        {
            this._leftTopVertex = leftTopVertex;
            this._rightBottomVertex = rightBottomVertex;

            _verticalEdge = leftTopVertex.Y - rightBottomVertex.Y;
            _horizontalEdge = rightBottomVertex.X - leftTopVertex.X;
        }

        public double GetArea()
        {
            return _verticalEdge * _horizontalEdge;
        }

        public double GetPerimeter()
        {
            return _verticalEdge * 2 + _horizontalEdge * 2;
        }
    }
}

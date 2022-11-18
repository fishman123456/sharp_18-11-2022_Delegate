
    public class Triangle : Employe
    {
        public int x;
        public int y;
        public int radius;


        public Triangle()
        {
            this.x = 0;
            this.y = 0;
            this.radius = 0;
            this._figure = "Треугольник";

        }
        public Triangle(int x1, int y1, int radius1, string figure)
        {
            x = x1;
            y = y1;
            radius = radius1;
            _figure = "Класс Triangle ";

        }
        public double area()
        {
            _area = x*y*radius;
            return _area;
        }
    }


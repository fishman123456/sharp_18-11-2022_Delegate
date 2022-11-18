
    public class Rectangle : Employe
    {
        public int x;
        public int y;
        public int radius;


        public Rectangle()
        {
            this.x = 0;
            this.y = 0;
            this.radius = 0;
            this._figure = "Прямоугольник";

        }
        public Rectangle(int x1, int y1, int radius1, string figure)
        {
            x = x1;
            y = y1;
            radius = radius1;
            _figure = "Класс Rectangle ";

        }
        public double area()
        {
            _area = x*y;
            return _area;
        }
    }


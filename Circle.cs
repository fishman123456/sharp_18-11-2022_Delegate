

    public class Circle : Employe
    {
        public int x;
        public int y;
        public int radius;
       

        public Circle()
        {
            this.x = 0;
            this.y = 0;
            this.radius = 0;
            this._figure = "Окружность";

        }
        public Circle (int x1, int y1, int radius1,string figure)
        {
            x = x1; 
            y = y1;
            radius = radius1;
            _figure = "Класс Circle ";
            
        }
        public double area()
        {
            _area = 3.14 * (radius*radius);
            return _area;
        }
      
    }
  


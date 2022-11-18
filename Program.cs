// Создать делегат, который возвращает одно значение типа double.
// Создать класс Геометрическая фигура, которая будет иметь
// методы по расчету площади равностороннего треугольника, квадрата и круга.
// Использовать вызов всех функций через делегат



    

    Circle f = new Circle(3,2,9,"окружность");
//f.Print();


// CalcDelegate one = s.area();
CalcDelegate one = f.area;
Console.WriteLine(one());






public delegate double CalcDelegate();


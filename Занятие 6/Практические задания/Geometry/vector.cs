namespace Geometry
{
    public class Vector
    {
        // Публичные поля X и Y
        public double X { get; set; }
        public double Y { get; set; }

        // Конструктор для инициализации вектора
        public Vector(double x, double y)
        {
            X = x;
            Y = y;
        }

        // Метод для вычисления длины вектора
        public double GetLength()
        {
            return Geometry.GetLength(this);  // Используем метод из класса Geometry
        }

        // Метод для сложения двух векторов
        public Vector Add(Vector v)
        {
            return Geometry.Add(this, v);  // Используем метод из класса Geometry
        }

        // Метод для проверки, принадлежит ли вектор отрезку
        public bool Belongs(Segment segment)
        {
            return Geometry.IsVectorInSegment(this, segment);  // Используем метод из класса Geometry
        }
    }
}

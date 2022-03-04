namespace labrab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №2-Наследование");
            Console.WriteLine("Выполнила - Иванова Валерия");

            Rectangle a = new Rectangle()
            {
                name = "Прямоугольник A",width = 15.2,height = 13.7
            };

            Rectangle b = new Rectangle()
            {
                name = "Прямоугольник B",width = 5.1,height = 2.8
            };
            Console.WriteLine();
            Console.WriteLine("Название фигуры:{0}",a.name);
            Console.WriteLine("Площадь:{0}", a.getArea());
            Console.WriteLine();
            Console.WriteLine("Название фигуры:{0}", b.name);
            Console.WriteLine("Площадь:{0}", b.getArea());

            Circle c = new Circle()
            {
                name="Круг", R=3.1

            };
            Console.WriteLine();
            Console.WriteLine("Название фигуры:{0}", c.name);
            Console.WriteLine("Площадь:{0}", c.getArea());

            Square d = new Square()
            {
                name="Квадрат",
                a=4.4

            };
            Console.WriteLine();
            Console.WriteLine("Название фигуры:{0}", d.name);
            Console.WriteLine("Площадь:{0}", d.getArea());
            Triangle e = new Triangle()
            {
                name="Треугольник",
                b=3.2,
                h=3.5

            };
            Console.WriteLine();
            Console.WriteLine("Название фигуры:{0}", e.name);
            Console.WriteLine("Площадь:{0}", e.getArea());

            Trapeze f = new Trapeze()
            {
                name="Трапеция",
                a=3.1,
                b=3.2,
                h=3.5

            };
            Console.WriteLine();
            Console.WriteLine("Название фигуры:{0}", f.name);
            Console.WriteLine("Площадь:{0}", f.getArea());

            Rhombus g = new Rhombus()
            {
                name="Ромб",
                a=2.1,
                h=4.8

            };
            Console.WriteLine();
            Console.WriteLine("Название фигуры:{0}", g.name);
            Console.WriteLine("Площадь:{0}", g.getArea());

            Parallelogram h = new Parallelogram()
            {
                name="Параллелограмм",
                a=2.9,
                h=5.8

            };
            Console.WriteLine();
            Console.WriteLine("Название фигуры:{0}", h.name);
            Console.WriteLine("Площадь:{0}", h.getArea());

            Pentagon i = new Pentagon()
            {
                name="Пятиугольник",
                a=5.8,
                

            };
            Console.WriteLine();
            Console.WriteLine("Название фигуры:{0}", i.name);
            Console.WriteLine("Площадь:{0}", i.getArea());

            Decagon j = new Decagon()
            {
                name="Десятиугольник",
                a=4.9,


            };
            Console.WriteLine();
            Console.WriteLine("Название фигуры:{0}", j.name);
            Console.WriteLine("Площадь:{0}", j.getArea());

        }

}
}
using System;
using System.Collections.Generic;

namespace prim_abstract_class_01
{
    // Абстрактный класс Figure - содержит абстрактный метод Area()
    // и абстрактное свойство Area2
    abstract class Figure
    {
        // 1. Скрытое поле класса
        private string name; // Название фигуры

        // 2. Конструктор класса
        public Figure(string name)
        {
            this.name = name;
        }

        // 3. Свойство доступа к полю класса
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // 4. Абстрактное свойство, возвращающее площадь фигуры
        public abstract double Area2 { get; }

        // 5. Абстрактный метод, возвращающий площадь фигуры
        //   Метод не имеет тела метода
        public abstract double Area();

        // 6. Виртуальный метод, который выводит значение полей класса
        public virtual void Print()
        {
            Console.WriteLine("name = {0}", name);
        }
    }

    // Класс, который реализует треугольник. В классе нет абстрактных методов,
    // поэтому слово abstract не ставится перед объявлением класса.
    class Triangle : Figure
    {
        // 1. Внутренние поля класса
        double a, b, c;

        // 2. Конструктор класса
        public Triangle(string name, double a, double b, double c)
                    : base(name)
        {
            // Проверка на корректность значений a, b, c
            if (((a + b) > c) && ((b + c) > a) && ((a + c) > b))
            {
                this.a = a; this.b = b; this.c = c;
            }
            else
            {
                Console.WriteLine("Incorrect values a, b, c.");
                Console.WriteLine("By default: a=1, b=1, c=1.");
                this.a = this.b = this.c = 1;
            }
        }

        // 3. Реализация методов доступа к скрытым полям a, b, c
        // 3.1. Установление значений полей a, b, c
        public void SetABC(double a, double b, double c)
        {
            if (((a + b) > c) && ((b + c) > a) && ((a + c) > b))
            {
                this.a = a; this.b = b; this.c = c;
            }
            else
            {
                this.a = this.b = this.c = 1;
            }
        }

        // 3.2. Чтение значений полей - обратить внимание на модификатор out
        public void GetABC(out double a, out double b, out double c)
        {
            a = this.a; b = this.b; c = this.c;
        }

        // 4. Переопределение абстрактного свойства Area2 класса Figure,
        //   ключевое слово override обязательно
        public override double Area2
        {
            get
            {
                // 1. Провести вычисления
                double p, s;
                p = (a + b + c) / 2;
                s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

                // 2. Вывести результат в свойстве - для контроля
                Console.WriteLine("Property Triangle.Area2: s = {0:f3}", s);

                // 3. Вернуть результат
                return s;
            }
        }

        // 5. Реализация метода Area(), который в классе Figure
        //   объявлен как абстрактный
        public override double Area()
        {
            // 1. Провести вычисления
            double p, s;
            p = (a + b + c) / 2;
            s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            // 2. Вывести результат в свойстве - для контроля
            Console.WriteLine("Method Triangle.Area(): s = {0:f3}", s);

            // 3. Вернуть результат
            return s;
        }

        // 6. Виртуальный метод Print
        public override void Print()
        {
            base.Print();
            Console.WriteLine("a = {0:f2}", a);
            Console.WriteLine("b = {0:f2}", b);
            Console.WriteLine("c = {0:f2}", c);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Демонстрация полиморфизма с использованием
            // абстрактного класса.
            // 1. Объявить ссылку на базовый класс
            Figure refFg;

            // 2. Объявить экземпляр класса Figure
            // 2.1. Невозможно создать экземпляр абстрактного класса
            // Figure objFg = new Figure("Figure"); - ошибка!

            // 2.2. Объявить экземпляр класса Triangle
            Triangle Tr = new Triangle("Triangle", 2, 3, 2);

            // 3. Вызов метода Print() с помощью ссылки на базовый класс
            refFg = Tr;
            refFg.Print();

            // 4. Вызов метода Area() с помощью ссылки на базовый класс
            refFg = Tr;
            refFg.Area(); // вызывается метод Triangle.Area()

            // 5. Использование свойства Area2 с помощью ссылки на базовый класс
            refFg = Tr;
            double area = refFg.Area2; // свойство Triangle.Area2
            Console.WriteLine("area = {0:f3}", area);

            Console.ReadKey();

        }
    }
}



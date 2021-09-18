/*Напишите объявление класса Rectangle (прямоугольник), который является производным от Square (квадрат), который, 
 * в свою очередь – производный от Shape(фигура). В классе Shape объявите следующие защищенные члены-данные : 
 * цвет линий фигуры и толщина ее линий  и напишите 2 конструктора - по умолчанию и с параметрами. В классах Square и Rectangle 
 * объявите закрытые (защищенные)  члены-данные для хранения размеров каждой из фигур, несколько конструкторов, вызывающих
 * конструкторы базового класса, а также методы для вычисления площади и периметра фигур. В классе Rectangle обязательно используйте
 * перекрывание методов базового класса Square. При необходимости добавьте в классы  методы доступа. Напишите главную программу,
 * в которой выполните создание объектов-фигур различных типов и их обработку.*/

using System;

namespace Lab12_1
{
    class Shape //Main Class Shape
    {
        protected string Color;
        protected int Thickness;

        public virtual void SetValue(string Color, int Thickness)
        {
            this.Color = Color;
            this.Thickness = Thickness;
        }

        public virtual void SetValue()
        {

        }

        public virtual void Input()  //Input
        {
            Console.WriteLine("Enter color of your shape: ");
            Color = Console.ReadLine();
            Console.WriteLine("Enter thickness of your shape: ");
            Thickness = int.Parse(Console.ReadLine());
        }

        public virtual void GetValue()  //Output
        {
            Console.Write("Color is: " + Color + ", thickness is: " + Thickness);
        }

        public virtual void Area()
        {

        }

        public virtual void Perimeter()
        {

        }
    }

    class Square : Shape //class Square : Shape 
    {
        private int Width;
        private int Length;

        public override void SetValue()
        {
            base.SetValue();
        }

        public virtual void SetValue(string Color, int Thickness, int Width, int Length)
        {
            base.SetValue(Color, Thickness);
            this.Width = Width;
            this.Length = Length;
        }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Enter width: ");
            Width = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter length: ");
            Length = int.Parse(Console.ReadLine());
        }

        public override void GetValue()  //Output : Shape
        {
            base.GetValue();
            Console.WriteLine(", width is: " + Width + ", length is: " + Length);
        }

        public override void Area()
        {
            Console.WriteLine("Area of this shape is: " + Width * Length);
            
        }

        public override void Perimeter ()
        {
            Console.WriteLine("Perimeter of this shape is: " + (Width + Length) * 2);
        }
    }

    class Rectangle : Square //class Rectangle : Square
    {
        private int Width;
        private int Length;

        public override void SetValue()
        {
            base.SetValue();
        }

        public override void SetValue(string Color, int Thickness, int Width, int Length)
        {
            base.SetValue(Color, Thickness, Width, Length);
        }

        public override void Input()  //Input : Square
        {
            base.Input();
        }

        public override void GetValue()  //Output : Shape
        {
            base.GetValue();
        }

        public override void Area()
        {
            base.Area();
        }

        public override void Perimeter()
        {
            base.Perimeter();
        }
    }





    class MainProgramm   // Programm class
    {
        public static void Main(string[] args)
        {
            string Answer;

            Console.WriteLine("Do you want to create a square or rectangle? ");
            Answer = Console.ReadLine();

            if (Answer == "Square")
            {
                Square square = new Square();
                square.Input();
                square.GetValue();
                square.Area();
                square.Perimeter();
            }

            else if(Answer == "Rectangle")
            {
                Rectangle rectangle = new Rectangle();
                rectangle.Input();
                rectangle.GetValue();
                rectangle.Area();
                rectangle.Perimeter();
            }

            else
            {
                Console.WriteLine("Error");
            }

        }

    }
}
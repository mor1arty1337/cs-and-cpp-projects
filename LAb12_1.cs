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
        protected float Thickness;

        public virtual void SetValue(string Color, float Thickness)
        {
            this.Color = Color;
            this.Thickness = Thickness;
        }

        public virtual void SetValue()
        {

        }
    }

    class Square : Shape //class Square : Shape 
    {
        private float Width;
        private float Length;

        public override void SetValue()
        {
            base.SetValue();
        }

        public override void SetValue(string Color, float Thickness)
        {
            base.SetValue(Color, Thickness);
        }

        public virtual void SetValue(string Color, float Thickness, float Width, float Length)
        {
            this.Color = Color;
            this.Thickness = Thickness;
            this.Width = Width;
            this.Length = Length;
        }

        public virtual void GetValue()
        {
            Console.WriteLine("It`s Square.");
            Console.WriteLine("Color is: " + Color + ", thickness is: " + Thickness + ",size is: " + Width + " and " + Length);
        }

        public virtual void Area()
        {
            Console.WriteLine("Area of this shape is: " + Width * Length);
        }

        public virtual void Perimeter ()
        {
            Console.WriteLine("Perimeter of this shape is: " + (Width + Length) * 2);
        }


    }

    class Rectangle : Square //class Rectangle : Square
    {
        private float Width;
        private float Length;

        public override void SetValue()
        {
            base.SetValue();
        }

        public override void SetValue(string Color, float Thickness)
        {
            base.SetValue(Color, Thickness);
        }

        public override void SetValue(string Color, float Thickness, float Width, float Length)
        {
            base.SetValue(Color, Thickness, Width, Length);
        }

        public override void GetValue()
        {
            Console.WriteLine("It`s Rectangle.");
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
            Square square = new Square();
            square.SetValue("Red", 0.5f,3.1f,3.1f);
            square.GetValue();
            square.Area();
            square.Perimeter();
         

            Rectangle rectangle = new Rectangle();
            rectangle.SetValue("Blue", 1f, 2f, 3f);
            rectangle.GetValue();
            rectangle.Area();
            rectangle.Perimeter();
        }

    }
}
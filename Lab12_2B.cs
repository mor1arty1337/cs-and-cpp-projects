using System;

/*Напишите объявления для следующих диаграмм классов, включив в него члены-данные, конструкторы по умолчанию и с параметрами ,
 * методы доступа, методы ввода-вывода для клавиатуры и экрана и т.д. :
 * Транспорт : номер, год выпуска, марка --> Автомобиль : максимальная скорость
                                         --> Автобус : число посадочных мест*/

class Transport  //Transport main class
{
    private string Number;
    private int YearOfIssue;
    private string Brand;

    public virtual void SetValue()
    {

    }

    public virtual void SetValue(string Number,int YearOfIssue,string Brand)
    {
        this.Number = Number;
        this.YearOfIssue = YearOfIssue;
        this.Brand = Brand;
    }

    public virtual void Input()  //Input
    {
        Console.WriteLine("Input Data: ");

        Console.WriteLine("Input number of the car: ");
        Number =Console.ReadLine();

        Console.WriteLine("Input year of issue: ");
        YearOfIssue = int.Parse(Console.ReadLine());

        Console.WriteLine("Input brand: ");
        Brand = Console.ReadLine();
    }

    public virtual void GetValue()  //Output
    {
        Console.Write("Number is: " + Number + ", year of issue is: " + YearOfIssue + ", brand is: " + Brand);
    }
}

class Automobile : Transport  //Automobile class : Transport
{
    private float MaxSpeed;

    public override void SetValue()
    {
        base.SetValue();
    }

    public override void SetValue(string Number, int YearOfIssue, string Brand)
    {
        base.SetValue(Number, YearOfIssue, Brand);
    }

    public void SetValue(string Number,int YearOfIssue, string Brand, float MaxSpeed)
    {
        base.SetValue(Number, YearOfIssue, Brand);
        this.MaxSpeed = MaxSpeed;
    }

    public override void Input() //Input : Transport
    {
        base.Input();

        Console.WriteLine("Input the maximum speed of the car: ");
        MaxSpeed = float.Parse(Console.ReadLine());
    }

    public override void GetValue()  //Output : Transport
    {
        base.GetValue();
        Console.Write(" and max speed is: " + MaxSpeed);
    }
}

class Bus : Transport  // Bus class : Transport
{
    private int NumberOfSeats;

    public override void SetValue()
    {
        base.SetValue();
    }

    public override void SetValue(string Number, int YearOfIssue, string Brand)
    {
        base.SetValue(Number, YearOfIssue, Brand);
    }

    public void SetValue(string Number, int YearOfIssue, string Brand,int NumberOfSeats)
    {
        base.SetValue(Number, YearOfIssue, Brand);
        this.NumberOfSeats = NumberOfSeats;
    }

    public override void Input()
    {
        base.Input();

        Console.WriteLine("Input number of seats: ");
        NumberOfSeats = int.Parse(Console.ReadLine());
    }

    public override void GetValue()
    {
        base.GetValue();
        Console.WriteLine(" and number of seats is: " + NumberOfSeats);
    }
}



namespace Lab12_2B //Main Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string Answer;

            Automobile auto = new Automobile();
            Bus bus = new Bus();

            Console.WriteLine("This is a car or a bus?");
            Answer = Console.ReadLine();

            if (Answer == "Car")
            {
                auto.Input();
                auto.GetValue();
            }

            else if (Answer == "Bus")
            {
                bus.Input();
                bus.GetValue();
            }

            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}

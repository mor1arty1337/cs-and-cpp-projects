/*3.	Напишите программу, в которой классы Car и Bus будут производными от класса Transport, а MicroBus – производным от
 * Car и Bus. Сделайте Transport абстрактным типом данных с двумя чисто виртуальными функциями. Классы Car и Bus
 * не должны быть ADT. Проверьте программу, путем создания объектов разных типов.
4.	Модифицируйте программу п.3 так, чтобы Car был ADT, и выведите из Car классы SportsCar, Wagon, Coupe.
Реализуйте в классах простейшие функции.
5.	Напишите программу обработки различных средств транспорта c использование массива указателей типа Transport.
При обработке  используйте как виртуальные методы, так и средства RTTI.
*/

using System;

abstract class Transport  //Main Transport class
{
    protected int NumberOfWheels;

    public Transport()
    {

    }

    public Transport(int NumberOfWheels)
    {
        this.NumberOfWheels = NumberOfWheels;
    }

    public virtual void Input()
    {
        Console.WriteLine("Enter the number of wheels in your vehicle: ");
        NumberOfWheels = int.Parse(Console.ReadLine());
    }

    public virtual void Show()
    {
        Console.WriteLine("");
        Console.WriteLine("Number of wheels this vehicle: " + NumberOfWheels);
    }
}

abstract class Car : Transport  //Car:Transport
{
    protected int MaxSpeed;

    public Car()
    {

    }

    public Car(int NumberOfWheels, int MaxSpeed) : base(NumberOfWheels)
    {
        this.MaxSpeed = MaxSpeed;
    }

    public override void Input()
    {
        base.Input();
        Console.WriteLine("Enter the maximum speed of your vehicle: ");
        MaxSpeed = int.Parse(Console.ReadLine());
    }

    public override void Show()
    {
        base.Show();
        Console.WriteLine("Max speed in your vehicle is: " + MaxSpeed);
    }

}

class Sportcar : Car  //Sportcar : Car
{
    private string Answer;
    private bool Spoiler;
    public Sportcar()
    {

    }

    public Sportcar(int NumberOfWheels, int MaxSpeed, bool Spoiler) : base(NumberOfWheels, MaxSpeed)
    {
        this.Spoiler = Spoiler;
    }

    public override void Input()
    {
        base.Input();
        Console.WriteLine("Is there a spoiler? (Yes/No): ");
        Answer = Console.ReadLine();

        while (Answer != "Yes" & Answer !="No")
        {
            Console.WriteLine("You have to enter the answer!");
            Console.WriteLine("Is there a spoiler? (Yes/No): ");
            Answer = Console.ReadLine();
        }

        if (Answer == "Yes")
        {
            Spoiler = true;
        }
        else if (Answer == "No")
        {
            Spoiler = false;
        }
    }

    public override void Show()
    {
        base.Show();

        if (Spoiler == true)
        {
            Console.WriteLine("Spoiler present.");
            Console.WriteLine("");

        }

        else
        {
            Console.WriteLine("No spoiler.");
            Console.WriteLine("");
        }
        
    }
}

class Wagon : Car  //Wagon : Car
{

    private int TrunkCapacity;
    public Wagon()
    {

    }

    public Wagon(int NumberOfWheels,int MaxSpeed,int TrunkCapacity):base (NumberOfWheels,MaxSpeed)
    {
        this.TrunkCapacity = TrunkCapacity;
    }

    public override void Input()
    {
        base.Input();
        Console.WriteLine("Enter trunk capacity: ");
        TrunkCapacity = int.Parse(Console.ReadLine());
    }

    public override void Show()
    {
        base.Show();
        Console.WriteLine("Trunk capacity is: " + TrunkCapacity);
        Console.WriteLine("");
    }
}

class Coupe : Car //Coupe : Car
{
    private int NumberOfDoors;

    public Coupe()
    {

    }

    public Coupe(int NumberOfWheels, int MaxSpeed,int NumberOfDoors) : base(NumberOfWheels,MaxSpeed)
    {
        this.NumberOfDoors = NumberOfDoors;
    }

    public override void Input()
    {
        base.Input();
        Console.WriteLine("Enter the number of doors: ");
        NumberOfDoors = int.Parse(Console.ReadLine());
    }

    public override void Show()
    {
        base.Show();
        Console.WriteLine("Number of doors in your vehicle: " + NumberOfDoors);
        Console.WriteLine("");
    }
}

class Bus : Car  //Bus:Car
{
    private int Seats;

    public Bus()
    {

    }

    public Bus(int NumberOfWheels, int MaxSpeed,int Seats) : base(NumberOfWheels,MaxSpeed)
    {
        this.Seats = Seats;
    }

    public override void Input()
    {
        base.Input();
        Console.WriteLine("Enter the number of seats in your vehicle: ");
        Seats = int.Parse(Console.ReadLine());
    }

    public override void Show()
    {
        base.Show();
        Console.WriteLine("Max seats: " + Seats);
        Console.WriteLine("");
    }
}






namespace Lab13_2  // Main programm
{
    class Lab13_2
    {
        static void Main(string[] args)
        {
            string Answer;
            string TypeOfCar;

            Console.WriteLine("Do you want to create new car? (Yes/No)");
            Answer =  Console.ReadLine();

            if (Answer == "Yes")
            {
                while(Answer == "Yes")
                {
                    Console.WriteLine("What type of car do you want to build? (Bus/Sportcar/Wagod/Coupe)");
                    TypeOfCar = Console.ReadLine();

                    if (TypeOfCar == "Bus")
                    {
                        Bus bus = new Bus();
                        bus.Input();
                        bus.Show();
                    }
                    else if (TypeOfCar == "Sportcar")
                    {
                        Sportcar sportcar = new Sportcar();
                        sportcar.Input();
                        sportcar.Show();
                    }
                    else if (TypeOfCar == "Wagon")
                    {
                        Wagon wagon = new Wagon();
                        wagon.Input();
                        wagon.Show();
                    }
                    else if (TypeOfCar == "Coupe")
                    {
                        Coupe coupe = new Coupe();
                        coupe.Input();
                        coupe.Show();
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                    Console.WriteLine("Do you want to create new car? (Yes/No)");
                    Answer = Console.ReadLine();
                }
            }
            else if (Answer == "No")
            {
                Console.WriteLine("Ok,bye.");
            }
            else
            {
                Console.WriteLine("Error!");
            }

            
        }
    }
}

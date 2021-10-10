/*1.	Напишите объявление класса JetPlane, который наследуется от Rocket и AirPlane
2.	Напишите объявление для B747, который является производным от класса JetPlane
*/
using System;

class Rocket  //Rocekt
{
    protected int Speed;

    public Rocket()
    {

    }

    public Rocket(int Speed)
    {
        this.Speed = Speed;
    }

}

class AirPlane : Rocket  //AirPlane : Rocket
{
    protected int WingSize;

    public AirPlane()
    {

    }

    public AirPlane(int Speed,int WingSize): base(Speed)
    {
        this.WingSize = WingSize;
    }
    
}


class JetPlane : AirPlane  //JetPlane : AirPlane
{
    private string Name;
    public JetPlane()
    {

    }

    public JetPlane(int Speed, int WingSize, string Name) : base(Speed, WingSize)
    {
        this.Name = Name;
    }

    public void Input()
    {
        Console.WriteLine("Input jetplane`s speed: ");
        Speed = int.Parse(Console.ReadLine());
        Console.WriteLine("Input jetplane`s wing size: ");
        WingSize = int.Parse(Console.ReadLine());
        Console.WriteLine("Input jetplane`s name: ");
        Name = Console.ReadLine();
    }

    public void Show()
    {
        Console.WriteLine(Name + " with max speed " + Speed + " and wings size " + WingSize);
    }

}


namespace Lab13  //Main Programm
{
    class Program
    {
        static void Main(string[] args)
        {
            JetPlane jetplane = new JetPlane();
            jetplane.Input();
            jetplane.Show();
        }
    }
}

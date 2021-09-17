using System;

/*Напишите объявления для следующих диаграмм классов, включив в него члены-данные, конструкторы по умолчанию и с параметрами ,
 * методы доступа, методы ввода-вывода для клавиатуры и экрана и т.д. :
 * Студент : номер,  фамилия, пол --> Заочник : место работы, должность*/

class Student    //Main Student Class
{
    protected int Number;
    protected string Surname;
    protected string Gender;
    public void SetValue()
    {

    }

    public virtual void SetValue(int Number, string Surname, string Gender)
    {
        this.Number = Number;
        this.Surname = Surname;
        this.Gender = Gender;
    }

    public virtual void Input()  //Input
    {
        Console.Write("Input student`s number: ");
        Number = int.Parse(Console.ReadLine());

        Console.Write("Input student`s surname: ");
        Surname = Console.ReadLine();

        Console.Write("Input student`s gender: ");
        Gender = Console.ReadLine();
    }
    public virtual void GetValue() //Output
    {
        Console.WriteLine("Data output... ");
        Console.Write("Student`s number: " + Number + ", his/her surname: " + Surname + ", his/her gender: " + Gender);
    }
}

class CorrespondenceStudent : Student   //Correspondence Student Class : Student
{
    protected string PlaceOfWork;
    protected string Position;


    public override void SetValue(int Number, string Surname, string Gender)
    {
        base.SetValue(Number, Surname, Gender);
    }
    
    public void SetValue(string PlaceOfWork, string Position)
    {
        this.PlaceOfWork = PlaceOfWork;
        this.Position = Position;
    }

    public override void Input() //Input : Student
    {
        base.Input();
        Console.Write("Input student`s place of work: ");
        PlaceOfWork = Console.ReadLine();

        Console.Write("Input student`s position: ");
        Position = Console.ReadLine();
    }


    public override void GetValue() //Output : Student
    {
        base.GetValue();
        Console.WriteLine(", his/her place of work: " + PlaceOfWork + " and his/her position: " + Position);
    }

}


namespace Lab12_2A  //Main Programm
{
    class Program
    {
        static void Main(string[] args)
        {
            CorrespondenceStudent corstudent = new CorrespondenceStudent();

            corstudent.Input();
            corstudent.GetValue();
        }
    }
}

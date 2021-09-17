using System;

class Human //Class Human
{
    protected int Age;
    protected string Name;
    protected string Surname;

    public virtual void SetValue()
    {

    }

    public virtual void SetValue(int Age, string Name,string Surname)
    {
        this.Age = Age;
        this.Name = Name;
        this.Surname = Surname;
    }

    public virtual void Input()  //Input
    {
        Console.Write("Enter age: ");
        Age = int.Parse(Console.ReadLine());

        Console.Write("Enter name: ");
        Name = Console.ReadLine();

        Console.Write("Enter surname: ");
        Surname = Console.ReadLine();
    }

    public virtual void GetValue()
    {
        Console.WriteLine("Age is: " + Age + ", full name is: " + Name + " " + Surname + " ");
    }
}

class Student: Human  //Class Student : Human
{
    private int Number;
    private string Speciality;
    private int Grade;

    public override void SetValue()
    {
        base.SetValue();
    }

    public void SetValue(int Number,int Age, string Name, string Surname,string Speciality,int Grade)
    {
        this.Number = Number;
        this.Speciality = Speciality;
        this.Grade = Grade;
        base.SetValue(Age, Name, Surname);
    }

    public override void Input()  //Input : Human
    {
        base.Input();

        Console.Write("Enter student`s number: ");
        Number = int.Parse(Console.ReadLine());

        Console.Write("Enter student`s speciality: ");
        Speciality = Console.ReadLine();

        Console.Write("Enter student`s grade: ");
        Grade = int.Parse(Console.ReadLine());

        Console.WriteLine();
    }

    public override void GetValue()  //Output : Human
    {
        base.GetValue();
        Console.WriteLine("Student`s number is: " + Number + ", speciality is: " + Speciality + "and grade is: " + Grade);
        Console.WriteLine();
    }
}

class Teacher : Human  //Class Teacher : Human
{
    private string Faculty;
    private string Address;

    public override void SetValue()
    {
        base.SetValue();
    }

    public void SetValue(int Age, string Name, string Surname, string Faculty,string Address)
    {
        this.Faculty = Faculty;
        this.Address = Address;
        base.SetValue(Age, Name, Surname);
    }

    public override void Input()  //Input : Human
    {
        base.Input();
        Console.Write("Enter teacher`s faculty: ");
        Faculty = Console.ReadLine();

        Console.Write("Enter teacher`s address: ");
        Address = Console.ReadLine();

        Console.WriteLine();
    }

    public override void GetValue()  //Output : Human
    {
        base.GetValue();
        Console.WriteLine("Teacher`s faculty is: " + Faculty + ", teacher`s address is: " + Address);

        Console.WriteLine();
    }
}


namespace Lecture_assignment_Human_  //Main Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string Answer;

            Console.WriteLine("Do you want to announce a new student or a new teacher?");
            Answer = Console.ReadLine();

             if (Answer == "Student")
            {
                Student student = new Student();

                student.Input();
                student.GetValue();
            }
            else if (Answer == "Teacher")
            {
                Teacher teacher = new Teacher();

                teacher.Input();
                teacher.GetValue();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Error");
            }

        }
    }
}

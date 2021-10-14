using System;
using System.Collections.Generic;
abstract class Human
{
    protected int age;
    protected string name;
    protected string surname;

    public int Age
    {
        get
        {
            return age;
        }
        set
        {
            age = value;
        }
    }
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
    public string Surname
    {
        get
        {
            return surname;
        }
        set
        {
            surname = value;
        }
    }
    public Human()
    {

    }
    public Human(int Age, string Name, string Surname)
    {
        this.age = Age;
        this.name = Name;
        this.surname = Surname;
    }

    public virtual void Input()
    {
        Console.Write("Enter age: ");
        age = int.Parse(Console.ReadLine());

        Console.Write("Enter name: ");
        name = Console.ReadLine();

        Console.Write("Enter surname: ");
        surname = Console.ReadLine();
    }

    public virtual void GetValue()
    {
        Console.WriteLine("Age is: " + age + ", full name is: " + name + " " + surname + " ");
    }
}

class Student : Human
{
    private int number;
    private string speciality;
    private int grants;
    private string type;
    private int[] grades = new int[5];

    public int Number
    {
        get
        {
            return number;
        }
        set
        {
            number = value;
        }
    }
    public string Speciality
    {
        get
        {
            return speciality;
        }
        set
        {
            speciality = value;
        }
    }
    public int Grants
    {
        get
        {
            return grants;
        }
        set
        {
            grants = value;
        }
    }
    public Student()
    {

    }

    public Student(int Number, int Age, string Name, string Surname, string Speciality, int Grants, string Type)
        : base(Age, Name, Surname)
    {
        this.number = Number;
        this.speciality = Speciality;
        this.grants = Grants;
        this.type = Type;
    }

    public override void Input()
    {
        base.Input();

        Console.Write("Enter student`s number: ");
        number = int.Parse(Console.ReadLine());

        Console.Write("Enter student`s speciality: ");
        speciality = Console.ReadLine();

        Console.Write("Enter student`s grant: ");
        grants = int.Parse(Console.ReadLine());

        Console.WriteLine();
    }

    public override void GetValue()
    {
        base.GetValue();
        Console.WriteLine("Student`s number: " + number + "\nSpeciality: " + speciality + "\nGrants: " + grants);
        Console.WriteLine();
    }
    private List<Teacher> _teachers = new List<Teacher>();
    public void AddTeacher(Teacher teacher)
    {
        _teachers.Add(teacher);
    }

    public void RemoveTeacher(Teacher teacher)
    {
        _teachers.Remove(teacher);
    }

    public void PrintStudentList()
    {
        foreach (var item in _teachers)
        {
            Console.WriteLine(item);
        }
    }

    public void Grades_Generator()
    {
        Random rand = new Random();
        for (int i = 0; i < 5; i++)
        {
            grades[i] = rand.Next(1, 5);
        }
    }
    public void Get_Type()
    {
        int sum = 0, average;
        for (int i = 0; i < 5; i++)
        {
            sum += grades[i];
        }
        average = sum / 5;
        switch (average)
        {
            case 1:
                type = "'E'-student";
                break;
            case 2:
                type = "'D'-student";
                break;
            case 3:
                type = "'C'-student";
                break;
            case 4:
                type = "'B'-student";
                break;
            case 5:
                type = "'A'-student";
                break;
            default:
                type = "'unknow'-student";
                break;
        }

    }
    public override string ToString()
    {
        return $"{"\t" + name + " " + surname + " " + number + " " + type}"; ;
    }
}

class Teacher : Human
{
    private string faculty;

    public string Faculty
    {
        get
        {
            return faculty;
        }
        set
        {
            faculty = value;
        }
    }
    public Teacher()
    {

    }

    public Teacher(int Age, string Name, string Surname, string Faculty)
        : base(Age, Name, Surname)
    {
        this.faculty = Faculty;
    }

    public override void Input()
    {
        base.Input();
        Console.Write("Enter teacher`s faculty: ");
        faculty = Console.ReadLine();

        Console.WriteLine();
    }

    public override void GetValue()
    {
        base.GetValue();
        Console.WriteLine("Teacher`s faculty: " + faculty);

        Console.WriteLine();
    }
    private List<Student> _students = new List<Student>();

    public void AddStudent(Student student)
    {
        _students.Add(student);
    }

    public void RemoveStudent(Student student)
    {
        _students.Remove(student);
    }

    public void PrintStudentList()
    {
        foreach (var item in _students)
        {
            Console.WriteLine(item);
        }
    }
    public override string ToString()
    {
        return $"{name + " " + surname}";
    }
}

namespace Lecture_assignment_Human_
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher[] teacher = new Teacher[2];
            Student[] student = new Student[4];
            Console.WriteLine("Add 2 teachers: ");
            for (int i = 0; i < 2; i++)
            {
                teacher[i] = new Teacher();
                teacher[i].Input();
                teacher[i].GetValue();
                for (int j = 0; j < 4; j++)
                {
                    student[j] = new Student();
                    student[j].AddTeacher(teacher[i]);
                }
            }
            Console.WriteLine("Add 4 Students: ");
            for (int i = 0; i < 2; i++)
            {
                switch (i)
                {
                    case 0:
                        for (int j = 0; j < 2; j++)
                        {
                            student[j].Input();
                            student[j].Grades_Generator();
                            student[j].Get_Type();
                            teacher[i].AddStudent(student[j]);
                        }
                        break;
                    case 1:
                        for (int j = 2; j < 4; j++)
                        {
                            student[j].Input();
                            student[j].Grades_Generator();
                            student[j].Get_Type();
                            teacher[i].AddStudent(student[j]);
                        }
                        break;
                }
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Teacher - " + teacher[i].Name + " " + teacher[i].Surname);
                teacher[i].PrintStudentList();
                Console.WriteLine();
            }
        }
    }
}

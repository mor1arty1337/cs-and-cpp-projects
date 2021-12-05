using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture_assignment_Human_
{
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
}

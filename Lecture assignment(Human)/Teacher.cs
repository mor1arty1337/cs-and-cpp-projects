using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture_assignment_Human_
{
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
}

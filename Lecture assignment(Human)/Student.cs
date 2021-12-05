using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture_assignment_Human_
{
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
    }
}

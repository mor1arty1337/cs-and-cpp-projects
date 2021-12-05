using System;
using System.Collections.Generic;

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


            for (int i = 0; i < teacher.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        for (int j = 0; j < student.Length/2; j++)
                        {
                            student[j].Input();
                            student[j].Grades_Generator();
                            student[j].Get_Type();
                            teacher[i].AddStudent(student[j]);
                        }
                        break;
                    case 1:
                        for (int j = 2; j < student.Length; j++)
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_15
{
    public abstract class Human
    {
        private string first_Name;
        private string last_Name;
        private int Age;

        public Human()
        {
            first_Name = string.Empty;
            last_Name = string.Empty;
            Age = 0;
        }

        public Human(string First_Name, string Last_Name, int Age)
        {
            this.first_Name = First_Name;
            this.last_Name = Last_Name;
            this.Age = Age;
        }

        public string FirstName
        {
            get { return first_Name; }
            set { first_Name = value; }
        }

        public string LastName
        {
            get { return last_Name; }
            set { last_Name = value; }
        }

        public int HumanAge
        {
            get { return Age; }
            set { Age = value; }
        }
    }

    public class Administrator : Human
    {
        private string place_of_work;
        private int work_experience;

        public enum AdministratorType
        {
            Empty,
            System,
            Hotel,
            Restaurant
        }

        private AdministratorType Type;

        public Administrator() : base()
        {
            place_of_work = string.Empty;
            work_experience = 0;
        }

        public Administrator(string First_Name, string Last_Name, int Age, string Place_Of_Work, int Work_Experience, AdministratorType type) : base(First_Name: First_Name, Last_Name: Last_Name, Age: Age)
        {
            this.place_of_work = Place_Of_Work;
            this.work_experience = Work_Experience;
            this.Type = AdministratorType.Empty;
        }

        public string Place_Of_Work
        {
            get { return place_of_work; }
            set { place_of_work = value; }
        }

        public int Work_Experience
        {
            get { return work_experience; }
            set { work_experience = value; }
        }

        public AdministratorType TypeOfAdministrator
        {
            get { return Type; }
            set { Type = value; }
        }
    }

    public class Worker : Human
    {
        private string place_of_work;
        private int work_experience;

        public Worker() : base()
        {
            place_of_work = string.Empty;
            work_experience = 0;
        }

        public Worker(string First_Name, string Last_Name, int Age, string Place_Of_Work, int Work_Experience) : base(First_Name: First_Name, Last_Name: Last_Name, Age: Age)
        {
            this.place_of_work = Place_Of_Work;
            this.work_experience = Work_Experience;
        }

        public string Place_Of_Work
        {
            get { return place_of_work; }
            set { place_of_work = value; }
        }

        public int Work_Experience
        {
            get { return work_experience; }
            set { work_experience = value; }
        }

    }
    public class Employee : Human
    {
        private string place_of_work;
        private int work_experience;

        public Employee() : base()
        {
            place_of_work = string.Empty;
            work_experience = 0;
        }

        public Employee(string First_Name, string Last_Name, int Age, string Place_Of_Work, int Work_Experience) : base(First_Name: First_Name, Last_Name: Last_Name, Age: Age)
        {
            this.place_of_work = Place_Of_Work;
            this.work_experience = Work_Experience;
        }

        public string Place_Of_Work
        {
            get { return place_of_work; }
            set { place_of_work = value; }
        }

        public int Work_Experience
        {
            get { return work_experience; }
            set { work_experience = value; }
        }

    }
    public class Firm
    {
        List<Administrator> administrators;
        List<Worker> workers;
        List<Employee> employees;

        public Firm()
        {
            administrators = new List<Administrator>();
            workers = new List<Worker>();
            employees = new List<Employee>();
        }

        public Firm(List<Administrator> administrator_List, List<Worker> workers_List, List<Employee> employees_list)
        {
            administrators = administrator_List;
            workers = workers_List;
            employees = employees_list;
        }

        public Firm(List<Administrator> administrator_List)
        {
            administrators = administrator_List;
        }

        public Firm(List<Worker> workers_List)
        {
            workers = workers_List;
        }
        public Firm(List<Employee> employees_list)
        {
            employees = employees_list;
        }

        public List<Administrator> Administrators
        {
            get { return administrators; }
            set { administrators = value; }
        }

        public List<Worker> Workers
        {
            get { return workers; }
            set { workers = value; }
        }
        public List<Employee> Employees
        {
            get { return employees; }
            set { employees = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your ad could be here");
        }
    }
}

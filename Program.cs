using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_1_SP
{
    internal class Program
    {

        interface IEntity
        {
            int Id { get; set; }
        }
        static int Sum(int n1, int n2)
        {
            return n1 + n2;
        }
        class Animal
        {
            public virtual void animalSound()
            {
                Console.WriteLine("The animal makes a sound ");
            }
        }
        class Cat : Animal
        {
            public override void animalSound()
            {
                Console.WriteLine("meow");
            }
        }

        class User : IEntity
        {
            private int _Id;
            public string Name;
            public string Email;
            public int Id
            {
                get { return _Id; }
                set { _Id = value; }
            }
            public User(int id, string name, string email)
            {
                Id = id;
                Name = name;
                Email = email;
            }

        }
        class Ticket : IEntity
        {
            public int Id { get; set; }
            public string Title;
            public string Description;
            public string Status;
            public Ticket(int id, string title, string description, string status)
            {
                Id = id;
                Title = title;
                Description = description;
                Status = status;
            }
        }
        static void PrintEntity(IEntity entity)
        {
            Console.WriteLine("Entity ID : " + entity.Id);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            int result = Sum(21, 6);
            string tr1 = "Hisham Nairoukh ";
            string tr2 = "Hisham Nairoukh ";
            int age1 = 23;
            int age2 = 21;
            double TrainingHours1 = 6;
            double TrainingHours2 = 6;
            bool hasGitAccount1 = false;
            bool hasGitAccount2 = false;
            Console.WriteLine("Choose a day from 1 to 3 : ");
            int days = Convert.ToInt32(Console.ReadLine());
            switch (days)
            {
                case 1:
                    Console.WriteLine("sunday");
                    break;
                case 2:
                    Console.WriteLine("monday");
                    break;
                case 3:
                    Console.WriteLine("tuesday");
                    break;
                default:
                    Console.WriteLine("Incorrect day");
                    break;
            }
            Console.WriteLine("Now choose the day task : ");
            for (int i = Convert.ToInt32(Console.ReadLine()); i < 6; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("Today task is : Learn C#");
                    break;
                }
                else if (i == 1)
                {
                    Console.WriteLine("Today task is : C# Fundementals");
                    break;
                }
                else if (i == 2)
                {
                    Console.WriteLine("Today task is : Git — The Most Practical Day");
                    break;
                }
                else if (i == 3)
                {
                    Console.WriteLine("Today task is : OOP — Classes & Objects ");
                    break;
                }
                else
                {
                    Console.WriteLine("Today task is : Environment Setup + First Program");
                    break;
                }


            }
            List<string> programmingLanguage = new List<string>
                 {

                     "C#" , "C++" , "Python" , "Java" , "JavaScript"
                 };
            foreach (string language in programmingLanguage)
            {
                Console.WriteLine("Language : " + language);
            }
            Console.WriteLine("Choose a langauage from the list above : ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("C++language ");
                    break;
                case 2:
                    Console.WriteLine("C# language ");
                    break;
                case 3:
                    Console.WriteLine("Python language ");
                    break;
                case 4:
                    Console.WriteLine("Java language ");
                    break;
                case 5:
                    Console.WriteLine("JavaScript language ");
                    break;

            }
            Console.WriteLine("----------Traineer's Information is :--------");
            Console.WriteLine("-------Traineer 1 :-------------- ");
            Console.WriteLine("Name : " + tr1);
            Console.WriteLine("Age : " + age1);
            Console.WriteLine("Trainig Hourse : " + TrainingHours1 + " hourse");
            Console.WriteLine("Has a Git Account ?  " + hasGitAccount1);
            Console.WriteLine("---------------Traineer 2 :----------------");
            Console.WriteLine("Name : " + tr2);
            Console.WriteLine("Age : " + age2);
            Console.WriteLine("Trainig Hourse : " + TrainingHours2 + " hourse");
            Console.WriteLine("Has a Git Account ?  " + hasGitAccount2);
            Console.WriteLine("Result : " + result);
            User u = new User(2320066, "Hisham Nairoukh", "nairoukhhisham.com");
            Ticket t = new Ticket(230, "Final", "  Ticket to Amman", "Sept BP-02");
            Console.WriteLine("-------------------------User INformation --------------------------------");
            Console.WriteLine("User id is : " + u.Id);
            Console.WriteLine("  User Name is :  " + u.Name);
            Console.WriteLine(" User Email is :  " + u.Email);
            Console.WriteLine("-------------------------Ticket INformation --------------------------------");
            Console.WriteLine("Ticket id is : " + t.Id);
            Console.WriteLine(" Ticket title is :  " + t.Title);
            Console.WriteLine(" Ticket description is :  " + t.Description);
            Console.WriteLine(" Ticket status is :  " + t.Status);
            Console.WriteLine("-------------------------IEntity INformation --------------------------------");
            PrintEntity(u);
            PrintEntity(t);
            Console.WriteLine("-------------------------Inheritance------------------------------");
            Animal A = new Animal();
            A.animalSound();
            Cat c = new Cat();
            c.animalSound();
        }
    }
}
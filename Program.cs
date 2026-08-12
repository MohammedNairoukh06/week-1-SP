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
        static int Sum(int n1 , int n2)
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
        
        class User : IEntity // User class to represent a user with id , name , email
        {
            private int _Id;
            public string Name;
            public string Email;
            public int Id
            {
                get { return _Id; }
                set { _Id = value;}
            }
            public User (int id , string name , string email)
            {
                Id = id;
                Name = name;
                Email = email;
            }

        }
        class Ticket : IEntity // ticket class to represent a ticket with id , title , description and status 
        {
            public int Id {get; set;}
            public string Title;
            public string Description;
            public string Status;
            public Ticket(int id, string title, string description, string status)
            {
                Id=id; /////////////////////////////
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
            int result = Sum(20, 5);
            string tr1 = "Mohammed Nairoukh ";
            string tr2 = "Hisham Nairoukh ";
            int age1 = 20;
            int age2 = 20;
            double TrainingHours1=6;
            double TrainingHours2=6;
            bool hasGitAccount1=true;
            bool hasGitAccount2=true;
            Console.WriteLine("Choose a day from 1 to 3 : ");
            int days =Convert.ToInt32(Console.ReadLine());
            switch (days)
            {
                case 1: Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                default:
                    Console.WriteLine("Invaild day ");
                    break;
            }
            Console.WriteLine("Now choose the day task : ");
            for ( int i = Convert.ToInt32(Console.ReadLine()); i < 6; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine("Today task is : Learn C#");
                    break;
                }
                else if (i == 2)
                {
                    Console.WriteLine("Today task is : C# Fundementals");
                    break;
                }
                else if (i == 3)
                {
                    Console.WriteLine("Today task is : Git — The Most Practical Day");
                    break;
                }
                else if (i == 4)
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
                  
                     "C#" , "C++" , "Python" , "Java" , "JavaScript" , "PHP" , "Ruby" , "Swift" , "Koltin" , "Go" , "Rust"
                 }; 
            foreach (string language in programmingLanguage)
            {
                Console.WriteLine("Language : " + language);
            }

            Console.WriteLine("Traineer's Information is : ");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Traineer 1 : ");
            Console.WriteLine("Name : " + tr1);
            Console.WriteLine("Age : " + age1);
            Console.WriteLine("Trainig Hourse : " + TrainingHours1+" hourse");
            Console.WriteLine("Has a Git Account ?  " + hasGitAccount1);
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Traineer 2 : ");
            Console.WriteLine("Name : " + tr2);
            Console.WriteLine("Age : " + age2);
            Console.WriteLine("Trainig Hourse : " + TrainingHours2 + " hourse");
            Console.WriteLine("Has a Git Account ?  " + hasGitAccount2);
            Console.WriteLine("Result : " + result);
            User u = new User(2410205, "Mohammed Nairoukh", "mnairoukh298@gmail.com");
            Ticket t = new Ticket(332, "Final World Cup Ticket", "Spain VS Arganteina", "Seat SP-09");
            Console.WriteLine("-------------------------User INformation --------------------------------");
            Console.WriteLine("User id is : " + u.Id);  
            Console.WriteLine("  User Name is :  " + u.Name); 
            Console.WriteLine(" User Email is :  " + u.Email);
            Console.WriteLine("-------------------------Ticket INformation --------------------------------");
            Console.WriteLine("Ticket id is : " + t.Id);
            Console.WriteLine(" Ticket title is :  " + t.Title); 
            Console.WriteLine(" Ticket description is :  " + t.Description); 
            Console.WriteLine(" Ticket status is :  "+t.Status);
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

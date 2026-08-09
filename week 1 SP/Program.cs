using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_1_SP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            string tr1 = "Mohammed Nairoukh ";
            string tr2 = "Hisham Nairoukh ";
            int age1 = 20;
            int age2 = 20;
            double TrainingHours1=6;
            double TrainingHours2=6;
            bool hasGitAccount1=true;
            bool hasGitAccount2=true;


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
        }
    }
}

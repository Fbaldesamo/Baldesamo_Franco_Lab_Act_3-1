using System;
using System.IO;

namespace Baldesamo_Franco_Lab_Act_3_1
{
    internal class Program
    {
        private class addstud
        {
            
            public static void AddStud()
            {
                try
                {
                    //open/creat the file text
                    FileStream fs = new FileStream("Student.txt", FileMode.Create);

                    //enable you to write in the text
                    StreamWriter sw = new StreamWriter(fs);


                    Console.Write("Student Number: ");
                    long studnum = Int64.Parse(Console.ReadLine());
                    
                    Console.Write("Student Name: ");
                    string studname = Console.ReadLine();

                    Console.Write("Degree: ");
                    string stud_deg = Console.ReadLine();

                    Console.Write("Gender: ");
                    string stud_gen = Console.ReadLine();

                    Console.Write("Email address: ");
                    string stud_emai = Console.ReadLine();

                    sw.WriteLine("Student Number: "+studnum);
                    sw.WriteLine("Student Name: " + studname);
                    sw.WriteLine("Student Degree: " + stud_deg);
                    sw.WriteLine("Student Gender: " + stud_gen);
                    sw.WriteLine("Student Email Address: " + stud_emai);

                    sw.Close();
                    fs.Close();

                }
                catch
                {
                    Console.WriteLine("Invalid input");

                    AddStud();
                    Console.ReadKey();
                }
            }
        }
        public static void Userchoice()
        {
            Console.WriteLine("1.Add new student");

            Console.WriteLine("2.Display all student Data");

            Console.WriteLine("3.Number of Males/Females");

            Console.WriteLine("4.Exit");
             
            


        }
        private static void Main(string[] args)
        {
            //get user input
            Userchoice();
            Console.Write("Choice: ");

            int choice = Int16.Parse(Console.ReadLine());
            while (choice > 4 || choice < 1)
            {
                Console.WriteLine("Invalid input!");
                Userchoice();

                choice = Int16.Parse(Console.ReadLine());
            }

            //add new student
            if (choice == 1)
            {
                addstud.AddStud();
            }
            else if (choice == 2)
            {
                //read the file
            }
            else if (choice == 3)
            {
                //number of male and female
            }
            else if (choice == 4)
            {
                //will close the file
                Console.WriteLine("Press Any key to exit");
                Console.ReadKey();
            }
            
        }
    }
}
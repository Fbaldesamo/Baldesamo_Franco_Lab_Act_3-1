using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Baldesamo_Franco_Lab_Act_3_1
{
    internal class Program
    {
        public class addstud
        {
            public static int AddStud()
            {
                try
                {
                    Console.Write("Student Number: ");
                    long studnum = Int64.Parse(Console.ReadLine());

                    Console.Write("Student Name: ");
                    string studname = Console.ReadLine();

                    Console.Write("Degree: ");
                    string stud_deg = Console.ReadLine();

                    Console.Write("Gender: ");
                    string stud_gen = Console.ReadLine().ToUpper();

                    Console.Write("Email address: ");
                    string stud_emai = Console.ReadLine();

                    //open/creat the file text
                    FileStream fs = new FileStream("Student.txt", FileMode.Append);

                    //enable you to write in the text
                    StreamWriter sw = new StreamWriter(fs);

                    sw.WriteLine("Student Number: " + studnum);
                    sw.WriteLine("Student Name: " + studname);
                    sw.WriteLine("Student Degree: " + stud_deg);
                    sw.WriteLine("Student Gender: " + stud_gen);
                    sw.WriteLine("Student Email Address: " + stud_emai);
                    sw.WriteLine("------------------------------------\n\n");

                    sw.Close();
                    fs.Close();

                    Console.WriteLine("Student Added! ");
                    Console.WriteLine("---------------------------");
                    return 1;
                }
                catch (Exception)
                {
                    Console.WriteLine("error");
                    return 0;
                }
            }
        }

        public static int Userchoice(int choice)
        {
            //add new student
            if (choice == 1)
            {
                int a = addstud.AddStud();
                return a;
            }
            else if (choice == 2)
            {
                //read the file
                string readText = File.ReadAllText("Student.txt");
                Console.WriteLine(readText);
                
                return 1;
            }
            else if (choice == 3)
            {
                int countm = 0;
                int countf = 0;
                string[] readText = File.ReadAllLines("Student.txt");
                
                foreach (string Gender  in readText)
                {
                    
                    if (Gender == "Student Gender: MALE")
                    {
                        countm++;
                    }

                    if (Gender == "Student Gender: FEMALE")
                    {
                        countf++;
                    }

                    
                }
                Console.WriteLine("Male counts: {0}", countm);
                Console.WriteLine("Female counts: {0}", countf);
                //number of male and female


                return 1;
            }
            else if (choice == 4)
            {
                //will close the file
                Console.WriteLine("Press Any key to exit");
                Console.ReadKey();
                
            }
            return 0;
        }

        private static void Main(string[] args)
        {
            int UserChoice_1;
            int UserChoice_2;
            
            
            do
            {
                //get user choice to make
                //UserChoice_1 will hold the chosen value of the user
                //validate the chosen numbers
                UserChoice_1 = Userchoice();
            } while (UserChoice_1 == 0);
            do
            {
                //will go to the specified choice
                //will repeat if error
                UserChoice_2 = Userchoice(UserChoice_1);
            } while (UserChoice_2 == 0);

            
            Console.WriteLine("Still want to continue?");
            Console.WriteLine("Type \"YES\" or \"No\" ");
            string answer = Console.ReadLine().ToUpper();
            Console.Clear();
            while (answer == "YES")
            {
                Redo();
            }
            if (answer == "NO")
            {
                Console.WriteLine("Enter to exit");
                Console.ReadKey();

            }
           
                
            


            
            
        }
        public static void Redo()
        {

            int UserChoice_1;
            int UserChoice_2;


            do
            {
                //get user choice to make
                //UserChoice_1 will hold the chosen value of the user
                //validate the chosen numbers
                UserChoice_1 = Userchoice();
            } while (UserChoice_1 == 0);
            do
            {
                //will go to the specified choice
                //will repeat if error
                UserChoice_2 = Userchoice(UserChoice_1);
            } while (UserChoice_2 == 0);
            
            Console.WriteLine("Still want to continue?");
            Console.WriteLine("Type \"YES\" or \"No\" ");
            string answer = Console.ReadLine().ToUpper();
            Console.Clear();

            while (answer == "YES")
            {
                Redo();
            }
            if (answer == "NO")
            {
                Console.WriteLine("Enter to exit");
                Console.ReadKey();

            }

            

        }
        public static int Userchoice()
        {
            Console.WriteLine("1.Add new student");

            Console.WriteLine("2.Display all student Data");

            Console.WriteLine("3.Number of Males/Females");

            Console.WriteLine("4.Exit");

            Console.Write("Choice: ");
            try
            {
                int choice = Int16.Parse(Console.ReadLine());
                //validate repetition the choices to make
                while (choice > 4 || choice < 1)
                {
                    Console.WriteLine("Invalid input!");

                    Userchoice();

                    choice = Int16.Parse(Console.ReadLine());
                }
                return choice;
            }
            catch
            {
                Console.WriteLine("Invalid Input!");
                return 0;
            }
        }
    }
}
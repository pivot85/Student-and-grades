using System;
using System.Collections.Generic;

namespace StudentAndGrades
{
    class Program
    {
        
        public static void search(List<int> L,int num) {
            int counter = 0;
            foreach (int item in L)
            {
                if (item==num)
                {
                    counter++;
                    
                    
                }
            }
            Console.WriteLine("number of student with grade " + num + " is " + counter);
        }

        static void Main(string[] args)
        {
            List<string> Student = new List<string>();
            List<int> Grade = new List<int>();
            for (int i = 0; i < 1;)
            {
                Console.WriteLine("Student Name: ");
                 string name =Console.ReadLine();
                Student.Add(name);
                Console.WriteLine("Student Grade: ");
                 int grade = Convert.ToInt32(Console.ReadLine());
                Grade.Add(grade);

                Console.WriteLine("Add another Student? (Yes/No)");
                string answer = Console.ReadLine();
                if (answer == "yes".ToLower())
                {
                    i = 0;
                }
                if (answer == "no".ToLower())
                {
                    i = 1;
                }
                
            }

            for (int i = 0; i < Student.Count; i++)
            {
                Console.Write(Student[i]+" "+Grade[i]);
                Console.WriteLine();
            }

            search(Grade, 20);

        }
    }
}

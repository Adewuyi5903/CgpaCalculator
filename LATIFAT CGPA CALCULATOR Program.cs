using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Serialization;

namespace CGPA_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            int[] Coursecode = new int[200];
            int[] Courseunit = new int[200];
            int[] Coursescore = new int[200];
            char[] grades = new char[200];
            int[] gradeUnit = new int[200];
            string[] remark = new string[200];
            string[] CourseName = new string[200];
            int numberOfCourse = 0;
            int[] WeightPoint = new int[200];
            int totalWeightpoint = 0;
            int totalgradeUnit = 0;
            int totalCourseUnitpass = 0;
            int totalgradePoint = 0;

            try
            {
            Console.Write("Please Enter Your Name: ");
            string fullName = Console.ReadLine();
            Console.Clear();

            bool continueAdding = true;

            while (continueAdding)
            {
                Console.Write(fullName + " Please Enter the Course Name for course {0}: ", ++numberOfCourse);
                CourseName[numberOfCourse] = Console.ReadLine();
                Console.Clear();

                Console.Write("Please Enter Your Course Code: ");
                Coursecode[numberOfCourse] = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                Console.Write("Please Enter Course Unit: ");
                Courseunit[numberOfCourse] = int.Parse(Console.ReadLine());
                Console.Clear();

                Console.Write("Please Enter Course Score: ");
                Coursescore[numberOfCourse] = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                Console.Write("Press 1 to add another course or Press 2 to print table: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();


                if (choice == 1)
                {
                    continueAdding = true;
                }

                else if (choice == 2)
                {
                    continueAdding = false;
                }

                if (Coursescore[numberOfCourse] >= 70 && Coursescore[numberOfCourse] <= 100)
                {
                    grades[numberOfCourse] = 'A';
                    gradeUnit[numberOfCourse] = 5;
                    remark[numberOfCourse] = "Excellent";
                }
                else if (Coursescore[numberOfCourse] >= 60)
                {
                    grades[numberOfCourse] = 'B';
                    gradeUnit[numberOfCourse] = 4;
                    remark[numberOfCourse] = "Very Good";
                }
                else if (Coursescore[numberOfCourse] >= 50)
                {
                    grades[numberOfCourse] = 'C';
                    gradeUnit[numberOfCourse] = 3;
                    remark[numberOfCourse] = "Good";
                }
                else if (Coursescore[numberOfCourse] >= 45)
                {
                    grades[numberOfCourse] = 'D';
                    gradeUnit[numberOfCourse] = 2;
                    remark[numberOfCourse] = "Fair";
                }
                else if (Coursescore[numberOfCourse] >= 40)
                {
                    grades[numberOfCourse] = 'E';
                    gradeUnit[numberOfCourse] = 1;
                    remark[numberOfCourse] = "Pass";
                }
                else
                {
                    grades[numberOfCourse] = 'F';
                    gradeUnit[numberOfCourse] = 0;
                    remark[numberOfCourse] = "Fail";
                }

                WeightPoint[numberOfCourse] = Courseunit[numberOfCourse] * gradeUnit[numberOfCourse];
            }


            Console.WriteLine("\n              <<<<<<<<<<<<<<<<<<<    CGPA CALCULATOR    >>>>>>>>>>>>>>>>>>>>           \n ");


            Console.WriteLine("|---------------|---------------|---------------|-------------|------------|--------------------| ");
            Console.WriteLine("|  Course Code  |   Course Unit |     Grade     |  Grade Unit |Weight Pt.  |  Remarks           | ");
            Console.WriteLine("|---------------|---------------|---------------|-------------|------------|--------------------| ");

            for (int i = 1; i <= numberOfCourse; i++)
            {

                Console.WriteLine("|{0,-15}|{1,-15}|{2,-15}|{3,-13}|{4,-12}|{5,-20}| ", CourseName[i], Courseunit[i], grades[i], gradeUnit[i], WeightPoint[i], remark[i]);
                Console.WriteLine("|---------------|---------------|---------------|-------------|------------|--------------------| ");

                totalgradeUnit += Courseunit[i];
                totalWeightpoint += gradeUnit[i] * Courseunit[i];

                if (Coursescore[i] > 40)
                {
                    totalCourseUnitpass += Courseunit[i];
                }

                totalgradePoint += gradeUnit[i];
            }

            double totalGpa = (double)totalWeightpoint / totalgradePoint;

            Console.WriteLine($"This is total course unit Registered {totalgradeUnit} ");
            Console.WriteLine($"This is the total course passed {totalCourseUnitpass}  ");
            Console.WriteLine($"The total weight point is {totalWeightpoint}  ");
            Console.WriteLine("GPA =  {0:F2} ", +totalGpa);

            Console.ReadLine();
            }

            catch (Exception e)

            {
                Console.WriteLine("Enter Valid Input: " + e.Message); 
                Environment.Exit(0);

            }

        }
    }
}


        
/** COMP 1098
 * CSHARP: In Class Exercise/Assignment-1
 * Authors: Jennifer Mendez, Joshi Shiwani, Bina Patel, Dakota McCreary, Harshil Soni 
 *Date: 28/Jan/2021
 *Time: 6:50 PM
 */

using System;

namespace In_Class_Assignment_1
{
    class Program
    {
        //The code execution starts from here (main method)
        static void Main(string[] args)
        {
            //Question 1
            //Print trip options and cost
            Console.WriteLine("Question 1");
            Console.WriteLine("");
            Console.WriteLine("There are three ways to get from Rome to Florence and back");
            Console.WriteLine("Plane: 200EUR");
            Console.WriteLine("Train: 80EUR");
            Console.WriteLine("Bus: 50EUR");
            Console.WriteLine("");

            //Ask User how many trips to take by each method
            Console.Write("How many times do you wish to travel by Plane?");
            int planeTrips = Convert.ToInt32(Console.ReadLine());
            Console.Write("How many times do you wish to travel by Train?");
            int trainTrips = Convert.ToInt32(Console.ReadLine());
            Console.Write("How many times do you wish to travel by Bus?");
            int busTrips = Convert.ToInt32(Console.ReadLine());


            //Calculate total cost of trips
            int totalCost = (planeTrips * 200) + (trainTrips * 80) + (busTrips * 50);

            //If the user enters 0 trips, display error message and keep asking him to enter a valid number of trips
            while (totalCost == 0)
            {
                Console.WriteLine("");
                Console.Write("You must enter at least one travel.");
                Console.Write("Please select how many times you which to tavel.");
                Console.WriteLine("");
                Console.Write("How many times do you wish to travel by Plane?");
                planeTrips = Convert.ToInt32(Console.ReadLine());
                Console.Write("How many times do you wish to travel by Train?");
                trainTrips = Convert.ToInt32(Console.ReadLine());
                Console.Write("How many times do you wish to travel by Bus?");
                busTrips = Convert.ToInt32(Console.ReadLine());

                totalCost = (planeTrips * 200) + (trainTrips * 80) + (busTrips * 50);
            }

            //Calculate average cost of trips
            int averageCost = totalCost / (planeTrips + trainTrips + busTrips);

            //Print costs by using the replacement code
            Console.WriteLine("");
            Console.WriteLine("Total Cost for the Trips: {0}", totalCost);
            Console.WriteLine("Average Cost for the Trips: {0}", averageCost);
           

            //Question 2
            //The minimum eligibility to pass a course
            Console.WriteLine("");
            Console.WriteLine("Question 2");
            Console.WriteLine("");
            Console.WriteLine("The minimum eligibility to passed the course, based upon the following criteria...");
            Console.WriteLine("");

            //Print the minimum requirements in criteria A)
            Console.WriteLine("A). The minimum passing marks should be: ");
            Console.WriteLine("Marks in CSharp >=60");
            Console.WriteLine("Marks in Java >=55");
            Console.WriteLine("Marks in Python >=50");
            Console.WriteLine("");

            //Print the minimum requirements in criteria B)
            Console.WriteLine("B). Another condition to pass the course: ");
            Console.WriteLine("Total in all three subjects >=170");
            Console.WriteLine("OR");
            Console.WriteLine("Total in CSharp and Python >=150");
            Console.WriteLine("");

            //Ask the user to input the marks for the subjects.
            Console.WriteLine("Now enter the marks you obtained in the above criteria: ");
            Console.WriteLine("");
            Console.Write("Marks in CSharp: ");
            int cSharpGrade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Marks in Java: ");
            int javaGrade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Marks in Python: ");
            int pythonGrade = Convert.ToInt32(Console.ReadLine());

            //Calculate the total marks
            int threeClassGrade = cSharpGrade + javaGrade + pythonGrade;
            int twoClassGrade = cSharpGrade + pythonGrade;

            //Evaluate if student can be admitted
            if (cSharpGrade >= 60 && javaGrade >= 55 && pythonGrade >= 50)
            {
                if (threeClassGrade >= 170 || twoClassGrade >= 150)
                {
                    Console.WriteLine("");
                    Console.WriteLine("The candidate is eligible for admission");
                    Console.WriteLine("CSharp Grade: {0}, Java Grade: {1}, Python Grade: {2}", cSharpGrade, javaGrade, pythonGrade);
                    Console.WriteLine("Grade for the three classes: {0}, Grade for CSharp and Python: {1}", threeClassGrade, twoClassGrade);
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("The candidate is NOT eligible for admission");
                    Console.WriteLine("CSharp Grade: {0}, Java Grade: {1}, Python Grade: {2}", cSharpGrade, javaGrade, pythonGrade);
                    Console.WriteLine("Grade for the three classes: {0}, Grade for CSharp and Python: {1}", threeClassGrade, twoClassGrade);
                }
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("The candidate is NOT eligible for admission");
                Console.WriteLine("CSharp Grade:{0}, Java Grade: {1}, Python Grade: {2}", cSharpGrade, javaGrade, pythonGrade);
                Console.WriteLine("Grade for the three classes: {0}, Grade for CSharp and Python: {1}", threeClassGrade, twoClassGrade);
            }
        }
    }
}
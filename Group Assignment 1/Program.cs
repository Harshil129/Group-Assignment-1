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


            //Calculate total and average cost of trips
            int totalCost = (planeTrips * 200) + (trainTrips * 80) + (busTrips * 50);
            int averageCost = totalCost / (planeTrips + trainTrips + busTrips);

            //Print costs by using the replacement code
            Console.WriteLine("");
            Console.WriteLine("Total Cost for the Trips: {0}", totalCost);
            Console.WriteLine("Average Cost for the Trips: {0}", averageCost);
           

            //Question 2
            //The minimum eligibility to crack a course
            Console.WriteLine("");
            Console.WriteLine("Question 2");
            Console.WriteLine("");
            Console.WriteLine("The minimum eligibility to passed the course, based upon the following criteria...");
            Console.WriteLine("");

            //Printing the minimum requirements in criteria A)
            Console.WriteLine("A). The minimum passing marks should be: ");
            Console.WriteLine("Marks in CSharp >=60");
            Console.WriteLine("Marks in Java >=55");
            Console.WriteLine("Marks in Python >=50");
            Console.WriteLine("");

            //Printing the minimum requirements in criteria B)
            Console.WriteLine("B). Another condition to pass the course: ");
            Console.WriteLine("Total in all three subjects >=170");
            Console.WriteLine("OR");
            Console.WriteLine("Total in CSharp and Python >=150");
            Console.WriteLine("");

            //Asking the user to input the marks for the subjects.
            Console.WriteLine("Now enter the marks you obtained in the above criteria: ");
            Console.WriteLine("");
            Console.Write("Marks in CSharp: ");
            int inCSharp = Convert.ToInt32(Console.ReadLine());

            Console.Write("Marks in Java: ");
            int inJava = Convert.ToInt32(Console.ReadLine());

            Console.Write("Marks in Python: ");
            int inPython = Convert.ToInt32(Console.ReadLine());

            //Calculating the total marks
            int totalmarks = inCSharp + inJava + inPython;
            int marks = inCSharp + inPython;
            Console.WriteLine("");
            Console.WriteLine("The total marks in all 3 subjects: {0}", totalmarks);
            Console.WriteLine("The marks in Csharp and Pyhton are: {0}", marks);

            //Instantianing ternary operator to check whether the above eligibility criteria is met or not 
            //if yes, then eligible. if not, then not eligible.
            string finalResult = ((inCSharp >= 60 && inJava >= 55 && inPython >= 50) || 
                                 (inCSharp + inJava + inPython >= 170) || 
                                 (inCSharp + inPython >= 150)) ? 
                                 "Eligible for admission" : 
                                 "not eligible for admission";

            Console.WriteLine("The student is {0}", finalResult);

        }
    }
}
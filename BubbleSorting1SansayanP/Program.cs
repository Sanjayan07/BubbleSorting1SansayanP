/*Name: Sansayan Pratheepan
 * Date: 5/1/2024
 * Title: BubbleSorting1SansayanP
 * Purpose: Bubble Sorting, more info below
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSorting1SansayanP
{
    internal class Program
    {

        static void Main(string[] args)
        {
                BubbleSort3(); //Purpose: Create an application that asks the user to enter a certain number of students into a classlist, where you can sort by
            //first name, lastname, grade (highest-lowest)
            //delete a student, add a student, find the average of the class, find the lowest and highest grades, and find the median  grade of the class
            //as well as offer a way to exit the program. 

                Console.ReadKey();
            
          
        }
        public static void BubbleSort3()
        {
            Console.WriteLine("How Many Students Do You Want To Enter?"); //ask the user how many students they want to enter
            int Num = Int32.Parse(Console.ReadLine());

            string[] Firstname = new string[Num]; //create 3 arrays, 1 for firstname, 1 for lastname, 1 for grade
            string[] Lastname = new string[Num];
            int[] Grade = new int[Num];
            int NumOrg = 0; ;

            string[] FirstnameORG = new string[Firstname.Length];
            string[] LastnameORG = new string[Lastname.Length]; //create 3 more arrays that'll store the original values when the user enters 1. 
            int[] GradeORG = new int[Grade.Length];

            for (int i = 0; i < Num; i++)
            {
                Console.Write($"Student #{i + 1} First Name: "); //copy down all the firstname,lastname,grade entered by the user. 
                Firstname[i] = Console.ReadLine();

                Console.Write($"Student #{i + 1} Last Name: ");
                Lastname[i] = Console.ReadLine();

                Console.Write($"Student #{i + 1} Grade: ");
                Grade[i] = Int32.Parse(Console.ReadLine());
                
            }
            for (int i = 0; i < Firstname.Length; i ++)
            {
                FirstnameORG[i] = Firstname[i]; //copy the current values in the array into the "original array" so that when the user wants to see the orignial array it displays without any changes.
                LastnameORG[i] = Lastname[i];
                GradeORG[i] = Grade[i];
                NumOrg = Num; 
            }

            while (true)
            {
                Console.WriteLine("a. Show Original Unsorted List");
                Console.WriteLine("b. Show Sorted List by Last Name (A-Z)");
                Console.WriteLine("c. Show Sorted List by First Name (A-Z)");
                Console.WriteLine("d. Show Sorted List by Grades (High-Low)"); //display the menu for the user to see what they can do in the application
                Console.WriteLine("e. Delete a student");
                Console.WriteLine("f. Add a student");
                Console.WriteLine("g. Student Average for the class");
                Console.WriteLine("h. Student with Highest Grade");
                Console.WriteLine("i. Student with Lowest Grade");
                Console.WriteLine("j. Median Student(s) Grade");
                Console.WriteLine("k. Exit");
                string Choice = Console.ReadLine();

                switch (Choice)
                {
                    case "a":
                        Console.Clear(); //makes everything clutter free
                        Console.WriteLine("Original Unsorted List:");
                        Console.WriteLine("ID  | First Name | Last Name | Grade");
                        for (int i = 0; i < NumOrg; i++)
                        {
                            Console.WriteLine(String.Format("{0,-4}| {1,-11}| {2,-10}| {3}", i + 1, FirstnameORG[i], LastnameORG[i], GradeORG[i])); //string format, and display the arrays in which we copied the orignial values too
                        }
                        break;
                    case "b":
                        Console.Clear(); //makes everything clutter free. 
                        for (int i = 0; i < Lastname.Length; i++) //rearanges the array based on lastname
                        {
                            for (int j = 0; j < Lastname.Length - 1; j++) //it goes through the whole alphabet looking to see if the letter before comes after it in the alphabet. 
                            {
                                if (Lastname[j].CompareTo(Lastname[j + 1]) > 0)
                                {
                                    // Swap Lastname
                                    string tempLastname = Lastname[j];
                                    Lastname[j] = Lastname[j + 1]; 
                                    Lastname[j + 1] = tempLastname;

                                    // Swap Firstname
                                    string tempFirstname = Firstname[j];
                                    Firstname[j] = Firstname[j + 1];
                                    Firstname[j + 1] = tempFirstname; //using the temporary arrays you can actually compare between the two arrays to bubble sort the names. 

                                    // Swap Grade
                                    int tempGrade = Grade[j];
                                    Grade[j] = Grade[j + 1];
                                    Grade[j + 1] = tempGrade;
                                }
                            }
                        }
                        Console.WriteLine("Sorted List by Last Name (A-Z):");
                        Console.WriteLine("ID  | First Name | Last Name | Grade");
                        for (int i = 0; i < Num; i++)
                        {
                            Console.WriteLine(String.Format("{0,-4}| {1,-11}| {2,-10}| {3}", i + 1, Firstname[i], Lastname[i], Grade[i])); //display the values to the user, displays it as a chart. 
                        }
                        break;
                    case "c":
                        Console.Clear(); //unclutters the console
                        for (int i = 0; i < Firstname.Length; i++)
                        {
                            for (int j = 0; j < Firstname.Length - 1; j++)
                            {
                                if (Firstname[j].CompareTo(Firstname[j + 1]) > 0) //compares the first firstname to the second firstname, alphabetically, if the letter in the first firstname comes after the second, it switchs it. 
                                {
                                    // Swap Firstname
                                    string tempFirstname = Firstname[j];
                                    Firstname[j] = Firstname[j + 1];
                                    Firstname[j + 1] = tempFirstname; //uses the a temporary array to actually compare between the two arrays to buubble sort the firstnames. 

                                    // Swap Lastname
                                    string tempLastname = Lastname[j];
                                    Lastname[j] = Lastname[j + 1];
                                    Lastname[j + 1] = tempLastname;

                                    // Swap Grade
                                    int tempGrade = Grade[j];
                                    Grade[j] = Grade[j + 1];
                                    Grade[j + 1] = tempGrade;
                                }
                            }
                        }

                        // Display the sorted list
                        Console.WriteLine("Sorted List by First Name (A-Z):");
                        Console.WriteLine("ID  | First Name | Last Name | Grade");
                        for (int i = 0; i < Num; i++)
                        {
                            Console.WriteLine(String.Format("{0,-4}| {1,-11}| {2,-10}| {3}", i + 1, Firstname[i], Lastname[i], Grade[i])); //displays the sorted array in the form of a chart so it is easy for the user to read. 
                        }
                        break;
                    case "d":
                        Console.Clear(); //unclutters the console. 
                        for (int i = 0; i < Grade.Length; i++)
                        {
                            for (int j = 0; j < Grade.Length - 1; j++)
                            {
                                if (Grade[j] < Grade[j + 1]) // Compare grades in descending order, goes through all the grades on at a time. 
                                {
                                    // Swap Grade
                                    int tempGrade = Grade[j]; //creates a temporary array to store the orignial values, then reassigns it
                                    Grade[j] = Grade[j + 1];
                                    Grade[j + 1] = tempGrade;

                                    // Swap Firstname
                                    string tempFirstname = Firstname[j];
                                    Firstname[j] = Firstname[j + 1];
                                    Firstname[j + 1] = tempFirstname;

                                    // Swap Lastname
                                    string tempLastname = Lastname[j];
                                    Lastname[j] = Lastname[j + 1];
                                    Lastname[j + 1] = tempLastname;
                                }
                            }
                        }

                        // Display the sorted list
                        Console.WriteLine("Sorted List by Grades (High-Low):");
                        Console.WriteLine("ID  | First Name | Last Name | Grade");
                        for (int i = 0; i < Num; i++)
                        {
                            Console.WriteLine(String.Format("{0,-4}| {1,-11}| {2,-10}| {3}", i + 1, Firstname[i], Lastname[i], Grade[i])); //displays the sorted grade array in the form of a chart so it is easy for the user to read. 
                        }
                        break;
                    case "e":
                        Console.Clear(); //clears the console. 
                        Console.WriteLine("ID  | First Name | Last Name | Grade");
                        for (int i = 0; i < Num; i++)
                        {
                            Console.WriteLine(String.Format("{0,-4}| {1,-11}| {2,-10}| {3}", i + 1, Firstname[i], Lastname[i], Grade[i])); //displays the arrays and shows the index so the user can see what they want to delete. 
                        }
                        Console.WriteLine("Delete a student:"); //asks the user what student they want to delete (in index form) 
                        Console.Write("Enter the index of the student to delete: ");
                        int deleteIndex = Int32.Parse(Console.ReadLine());
                        deleteIndex = deleteIndex - 1; //subtracts one to account for the 0 in binary. 
                        if (deleteIndex >= 0 && deleteIndex < Num) //if the index is equal to or greater than zero, and less than the total number of elements
                        {
                            // Create temporary arrays to holds changed data
                            string[] tempFirstname = new string[Num - 1]; //decreases the size of the arrays, to account for the deletion
                            string[] tempLastname = new string[Num - 1];
                            int[] tempGrade = new int[Num - 1];

                            // Copy data to temporary arrays, excluding the deleted student
                            int tempIndex = 0;
                            for (int i = 0; i < Num; i++)
                            {
                                if (i != deleteIndex)
                                {
                                    tempFirstname[tempIndex] = Firstname[i]; //copies down all the values other than the deleted value. 
                                    tempLastname[tempIndex] = Lastname[i];
                                    tempGrade[tempIndex] = Grade[i];
                                    tempIndex++;
                                }
                            }
                            Firstname = tempFirstname;
                            Lastname = tempLastname; //reassigns the values back to the arrays. 
                            Grade = tempGrade;

                            Num--; // Decrease the total number of students
                            Console.WriteLine("Student deleted successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid index!"); //error catching
                        }
                        break;
                    case "f":
                        Console.Clear();//unclutters the console. 
                        Console.WriteLine("Adding a student:");
                        // Manualyl resize the arrays
                        string[] newFirstname = new string[Num + 1]; //add one to all the arrays. 
                        string[] newLastname = new string[Num + 1];
                        int[] newGrade = new int[Num + 1];

                        // Copy existing data to new arrays
                        for (int i = 0; i < Num; i++)
                        {
                            newFirstname[i] = Firstname[i]; 
                            newLastname[i] = Lastname[i];
                            newGrade[i] = Grade[i];
                        }

                        Console.Write($"Student #{Num + 1} First Name: "); //ask the user the firstname,lastname, and grade of the new student their adding
                        newFirstname[Num] = Console.ReadLine();

                        Console.Write($"Student #{Num + 1} Last Name: ");
                        newLastname[Num] = Console.ReadLine();

                        Console.Write($"Student #{Num + 1} Grade: ");
                        newGrade[Num] = Int32.Parse(Console.ReadLine());

                        Firstname = newFirstname; //copy all the values back 
                        Lastname = newLastname;
                        Grade = newGrade;
                        Num++;//add one to the total number of students
                        break;
                    case "g": //displays the average
                        Console.Clear(); //unclutter the console. 
                        Console.WriteLine("Student Average for the class:"); 
                        double total = 0;
                        for (int i = 0; i < Num; i++)
                        {
                            total += Grade[i]; //adds all the values in the arrray
                        }
                        double average = (double)total / Num; //divides by the total number of students\
                        average = Math.Round(average, 2);
                        Console.WriteLine($"Average Grade: {average}");//shows the average, and rounds to 2 decimal places. 
                        break;
                    case "h"://shows the student with the highest grade. 
                        Console.Clear();
                        Console.WriteLine("Student with Highest Grade:");
                        int maxIndex = 0;
                        for (int i = 1; i < Num; i++)
                        {
                            if (Grade[i] > Grade[maxIndex])
                            {
                                maxIndex = i; //goes to see the highest mark, then assigns the maxIndex value of the max index. 
                            }
                        }
                        Console.WriteLine($"First Name: {Firstname[maxIndex]}, Last Name: {Lastname[maxIndex]}, Grade: {Grade[maxIndex]}"); //display the first and last name of the student with the highest grade, along with their grade. 
                        break;
                    case "i": //shows the lowest grade in the class. 
                        Console.Clear(); //unclutters the console. 
                        Console.WriteLine("Student with Lowest Grade:");
                        int minIndex = 0;
                        for (int i = 1; i < Num; i++)
                        {
                            if (Grade[i] < Grade[minIndex]) //goes through all the values from the highest to lowest, until i is lowest it can be. 
                            {
                                minIndex = i;
                            }
                        }
                        Console.WriteLine($"First Name: {Firstname[minIndex]}, Last Name: {Lastname[minIndex]}, Grade: {Grade[minIndex]}"); //displays the firstname, lastname and grade of the student with the lowest mark. 
                        break;
                    case "j": //median of the class
                        Console.Clear();//unclutters the console. 
                        for (int i = 0; i < Grade.Length; i++)
                        {
                            for (int j = 0; j < Grade.Length - 1; j++)
                            {
                                if (Grade[j] < Grade[j + 1]) //sort the values in terms of highest to lowest grade
                                {
                                    int tempGrade = Grade[j];
                                    Grade[j] = Grade[j + 1];
                                    Grade[j + 1] = tempGrade;
                                    string tempFirstname = Firstname[j];
                                    Firstname[j] = Firstname[j + 1];
                                    Firstname[j + 1] = tempFirstname;
                                    string tempLastname = Lastname[j];
                                    Lastname[j] = Lastname[j + 1];
                                    Lastname[j + 1] = tempLastname;
                                }
                            }
                        }

                        if (Num % 2 == 0) //see if there an even number of elements in the array, if there is
                        {
                            // Even number of elements
                            int midIndex1 = Num / 2 - 1; //you find the middle number, then go one index lower
                            int midIndex2 = Num / 2;//find the middle number
                            double MiddleIndex = Convert.ToDouble( Grade[midIndex1] + Grade[midIndex2]); //add the 2 numbers together, divide by 2 to find the average of the 2 medians. 
                            MiddleIndex = MiddleIndex / 2;
                            Console.WriteLine($"Median Student(s) Grade: {MiddleIndex}"); //display the average of the 2 medians
                        }
                        else
                        {
                            // Odd number of elements
                            int midIndex = Num / 2; //if theres an odd number of elements, just do integer division to find the middle index, then display that
                            Console.WriteLine($"Median Student(s) Grade: {Grade[midIndex]}");
                        }
                        break;

                    case "k":
                        Console.Clear(); //unclutters the console. 
                        Console.WriteLine("Thank You For Coming!"); //exit message, then exits. 
                        return ; 
                }

            }
        }
    }
}




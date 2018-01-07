using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleThreeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using Main() to call each of the methods to prompt for input from a user.
            GetStudentInformation();
            GetTeacherInformation();
            GetCourseInformation();
            GetProgramInformation();
            GetDegreeInformation();
        }

        static void GetStudentInformation()
        {
            // Capturing student information input from application user.
            Console.WriteLine("--- Student Information ---");
            Console.WriteLine("Enter the student's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the student's birthdate (DD/MM/YYYY):");
            string date = Console.ReadLine();
            DateTime birthday = validateLegalAge(date);
            DateTime birthDate = Convert.ToDateTime(birthday);
        static void PrintStudentDetails(string isThisAStudent, int count, string firstName, string lastName, DateTime birthDate)
        {
            Console.WriteLine("\r\n{0} Name: {1} {2}\r\nID number: {3}\r\nwas born in {4}.\r\n", isThisAStudent, firstName, lastName, count, birthDate.Year);
        }

        static void GetTeacherInformation()
        {
            // Capturing teacher information input from application user.
            Console.WriteLine("--- Teacher Information ---");
            Console.WriteLine("Enter the teacher's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's credentials: ");
            string credentials = Console.ReadLine();
            Console.WriteLine("Enter the teacher's class assignment: ");
            string classAssignment = Console.ReadLine();
            bool isStudent = false;
            string isThisAStudent;
            if (isStudent)
            {
                isThisAStudent = "Student";
            }
            else
            {
                isThisAStudent = "Teacher";
            }

            PrintTeacherDetails(isThisAStudent, firstName, lastName, credentials, classAssignment);
        }

        static void PrintTeacherDetails(string isThisAStudent, string firstName, string lastName, string credentials, string classAssignment)
        {
            Console.WriteLine("\r\n{0} Name: {1} {2}, {3}\r\nAssigned to class: {4}.\r\n", isThisAStudent, firstName, lastName, credentials, classAssignment);
        }

        static void GetCourseInformation()
        {
            // Capture course information input from application user.
            Console.WriteLine("--- Course Information ---");
            Console.WriteLine("Enter the course name: ");
            string courseName = Console.ReadLine();
            Console.WriteLine("Enter the number of credits earned with successful completion of course: ");
            int courseCredits = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the number of courses required to complete program: ");
            int coursesRequired = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the associated degree name: ");
            string degreeName = Console.ReadLine();

            PrintCourseDetails(courseName, courseCredits, coursesRequired, degreeName);
        }

        static void PrintCourseDetails(string courseName, int courseCredits, int coursesRequired, string degreeName)
        {
            Console.WriteLine("\r\nCourse name: {0}\r\nCredits for course: {1}\r\nDegree Association: {2}\r\n", courseName, courseCredits, coursesRequired, degreeName);
        }

        static void GetProgramInformation()
        {
            // Capture program information input from application user.
            Console.WriteLine("--- Program Information ---");
            Console.WriteLine("Enter the program name: ");
            string programName = Console.ReadLine();
            Console.WriteLine("Enter the associated degree name: ");
            string degreeName = Console.ReadLine();
            Console.WriteLine("Enter the associated field of study name: ");
            string fieldName = Console.ReadLine();

            PrintProgramDetails(programName, degreeName, fieldName);
        }

        static void PrintProgramDetails(string programName, string degreeName, string fieldName)
        {
            Console.WriteLine("\r\nProgram name: {0}\r\nDegree Association: {1}\r\nField of study: {2}\r\n", programName, degreeName, fieldName);
        }

        static void GetDegreeInformation()
        {
            // Capture degree information input from application user.
            Console.WriteLine("--- Degree Information ---");
            Console.WriteLine("Enter the degree name: ");
            string degreeName = Console.ReadLine();
            Console.WriteLine("Enter the number of credits required to complete degree: ");
            int creditsRequired = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the associated school name (College of...): ");
            string collegeName = Console.ReadLine();

            PrintDegreeDetails(degreeName, creditsRequired, collegeName);
        }

        static void PrintDegreeDetails(string degreeName, int creditsRequired, string collegeName)
        {
            Console.WriteLine("\r\nDegree name: {0}\r\nNumber of credits for completion: {1}\r\nCollege of {2}.\r\n", degreeName, creditsRequired, collegeName);
        }


        static DateTime validateLegalAge(string date)
        {
            try
            {
                DateTime legalAge = DateTime.Parse(date);
                DateTime curDate = DateTime.Today;

                //Validate student birth date input
                if (legalAge > curDate)
                {
                    Console.WriteLine("Invalid birth date provided");
                }
                if (legalAge.AddYears(18).CompareTo(DateTime.Today) > 0)
                {
                    int age = curDate.Year - legalAge.Year;

                    if (legalAge.Month > curDate.Month)
                    {
                        age--;
                    }

                    Console.WriteLine("The student not legal age.\r\nThe student's age is {0}", age);
                }
                else
                {
                    int age = curDate.Year - legalAge.Year;

                    if (legalAge.Month > curDate.Month)
                    {
                        age--;
                    }

                    Console.WriteLine("The student's age is {0}", age);
                    return legalAge;
                }

                return legalAge;
            }

            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message + "\r\nInvalid birthdate (DD/MM/YYYY) format.");
                return DateTime.Today;
            }
        }
    }
}

// Module Three Assignment
// 
// In later modules, you will begin to create class files to represent the items we have
// been using so far.  You will create class files for Students, Teachers, Courses, etc. 
// The class files will consist of attributes and methods.  To prepare for this, the
// assignment for this module will ask you to think about some basic methods that you can
// implement in your code.
// 
// This assignment requires you to create some methods for getting data for your variables
// and sending that data to the console window.
// 
// In the assignment, you are to practice getting values from a user and assigning the to
// local variables.  As a result, move the variables into the appropriate methods.  For
// example, you could create a method called GetStudentInformation() and in that method,
// you could prompt the user for each piece of student information and then assign it to
// the variables you created.
// 
// Next, create methods such as PrintStudentDetails(string first, string last, string
// birthday) that accepts the proper variables, and use an appropriate message to print
// the content to the console window.
// 
// The first example is a guide for you, the rest you will need to create on your own.
// 
// Create a method that prompts a user of your console application to input the
// information for a student:
// 
// static void GetStudentInformation()
// {
//       Console.WriteLine("Enter the student's first name: ");
//       string firstName = Console.ReadLine();
//       Console.WriteLine("Enter the student's last name");
//       string lastName = Console.ReadLine();
//        // Code to finish getting the rest of the student data
//       .....
// }
// }
// static void PrintStudentDetails(string first, string last, string birthday)
// {
//     Console.WriteLine("{0} {1} was born on: {2}", first, last, birthday);
// }
// }
// 1. Using the above partial code sample, complete the method for getting student data.
// 2. Create a method to get information for a teacher, a course, a uprogram, and a degree
// using a similar method as above.
// 3. Create methods to print the information to the screen for each object such as static
// void PrintStudentDetails(...).
// 4. From within Main(), call each of the methods to prompt for input from a user of your
// application.
// 5. Just enter enough information to show you understand how to use methods.  (At least
// three attributes each).
// 6. Assign the values that are input, to the proper variables.
// 7. Output the values of each object using the "print" methods that you created.
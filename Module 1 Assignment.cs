/// Module One Assignment
using System;

namespace studentInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create variables
            string firstName;
            string lastName;
            DateTime birthdate;
            string addressLine1;
            string addressLine2;
            string city;
            string stateProvidence;
            string zipPostal;
            string country;
            bool isStudent; // True/False variable to form Student/Teacher relationship


            // Use assignment statements for assigning values
            firstName = "Lorem";
            lastName = "Ipsum";
            birthdate = new DateTime(1992, 08, 16);
            addressLine1 = "778 North St";
            addressLine2 = null;
            city = "Seattle";
            stateProvidence = "Washington";
            zipPostal = "98001";
            country = "United States";
            isStudent = true;

            string isThisAStudent; // Adding Yes/No value according to boolean logic
            if (isStudent)
            {
                isThisAStudent = "Yes";
            }
            else
            {
                isThisAStudent = "No";
            }


            // Use the Console.WriteLine() method to output the values to the console window
            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("First Name: " + lastName);
            Console.WriteLine("Birthdate: " + birthdate);
            Console.WriteLine("Address 1: " + addressLine1);
            Console.WriteLine("Address 2: " + addressLine2);
            Console.WriteLine("City: " + city);
            Console.WriteLine("State/Providence: " + stateProvidence);
            Console.WriteLine("Zip/Postal: " + zipPostal);
            Console.WriteLine("Country: " + country);
            Console.WriteLine("Is this a student?: " + isThisAStudent);

        }
    }
}

/// Module One Assignment
/// For this module, you have learned about the data types, operators, and statements in C#.
/// Using this knowledge you will start to form some of the foundation for a potential application. 
/// This assignment is designed to allow you to focus on the data types that are appropriate
/// for attributes of real-world objects. Later in your C# studies, you will start to combine these attributes with 
/// behaviors (methods) and then transition them into object-oriented classes.
/// Also, this assignment offers suggestions for attributes for each object but does not give explicit instructions 
/// on every field required. You will be required to think through the attributes of these "objects" as you
/// create the necessary data to support them in an application. Your list may be different in an application
/// that you would create on your own.  You can use the different listed objects for more practice if you want.

/// 1.  Create a C# Console application.
/// 2.  Within the Main() method in this application, create variables of the correct data 
///     type for the information related to a 'student only'.The other information will be
///     used in later modules when you create class files for the other objects listed:
/// 3.  Once you have the variables created, use assignment statements to assign values  
///     to one set of student variables and use the Console.WriteLine() method to output 
///     the values to the console window.
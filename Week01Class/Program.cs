using System;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;

namespace Week01Class
{
    public class Program
    {
        //switch statement...
        //string ==> string methods
        //arrays ==> 
        //loops ==>

        public enum Role
        {
            Admin,
            Reviewer,
            Approver,
            Customer,
            SuperAdmin,
        }

     
        static void Main(string[] args)
        {

            EnumsStuff();
            //StringMethods();

            //StringBuilderMethods();
            // Calculator();

        }
        static bool ValidateInput(string input)
        {
            if(!input.All(Char.IsDigit)) 
                return false;

            return true;
        }

        static bool ValidateOperator(string operation)
        {
            if (operation == "+" || operation == "*" || operation == "/" || operation == "-")
            {
                return true;
            }
            return false;
        }

        static double ActualOperation(int number1, int number2, string operation)
        {
            if(operation == "+")
            {
                return number1+number2;
            }
            if (operation == "*")
            {
                return number1 * number2;
            }
            else if (operation == "-")
            {
                return number1 - number2;
            }else
                return number1/number2;
        }
        static void Calculator()
        {
            var repeat = false;
            do
            {
                Console.WriteLine("Which operation do want to perform? (+, -, *, /)");

                var operation = Console.ReadLine();
                while(!ValidateOperator(operation))
                {
                    Console.WriteLine("Provide a valid operator (+, -, *, /)");
                    operation = Console.ReadLine();
                }

                Console.WriteLine("Enter the first number");

                var firstNumber = Console.ReadLine();


                while (!ValidateInput(firstNumber))
                {
                    Console.WriteLine("Provide a valid number value ");

                    firstNumber = Console.ReadLine();
                }

                Console.WriteLine("Enter the Second number ");

                var secondNumber = Console.ReadLine();
                while (!ValidateInput(secondNumber))
                {
                    Console.WriteLine("Provide a valid number value ");

                    secondNumber = Console.ReadLine();
                }

                int number1 = int.Parse(firstNumber);
                int number2 = int.Parse(secondNumber);

                Console.WriteLine($"The result of the operation is: {ActualOperation(number1, number2, operation)}");

                Console.WriteLine("Do you want to perform another operation? yes/no");

                var userChoice = Console.ReadLine();

                 repeat = userChoice.ToLower() == "yes" ? true : false;

            } while (repeat);
          


        }
        static void StringMethods()
        {
            string myStringValue = "Stanley is teaching Coding here";

            Console.WriteLine(myStringValue.ToLower());
            Console.WriteLine(myStringValue.ToUpper());
            Console.WriteLine(myStringValue.Trim());

            Console.WriteLine(myStringValue.IndexOf("is"));
            Console.WriteLine(myStringValue.Replace("Stanley", "Paul"));
            Console.WriteLine(myStringValue.Length);

            Console.WriteLine(myStringValue.LastIndexOf("e"));
            Console.WriteLine(myStringValue.Substring(7, 10));
            Console.WriteLine(myStringValue.Remove(10,6));

            Console.WriteLine(string.IsNullOrEmpty(myStringValue));
            Console.WriteLine(string.IsNullOrWhiteSpace(myStringValue));

            //string digits

            var stringNumber1 = "20";

            var stringNumber2 = "50";

            string concatenatedString = string.Concat(stringNumber1, stringNumber2);

            string concatenatedString1 = stringNumber1 + stringNumber2;

            Console.WriteLine(concatenatedString);
            Console.WriteLine(concatenatedString1);

            int numberValue1 = int.Parse(stringNumber1);

            Console.WriteLine(numberValue1);

            int numberValue2 = Convert.ToInt32(stringNumber2);

            int numberValue = numberValue1 + numberValue2;
            Console.WriteLine(numberValue2);

            Console.WriteLine(numberValue);

            Console.WriteLine(string.Format("The sum of {0} and {1} is {2}", numberValue1, numberValue2, numberValue));
            Console.WriteLine($"The sum of the two numbers is {numberValue1 + numberValue2}");

            //string escape charater and string Verbatim

            var instruction = @"I want you to pick the file from this directory:
 C:\Desktop\Users\folder1\folder2\filename
and tranfer it to
D:\Desktop\Repos\folderName";


            Console.WriteLine(instruction);



        }

        static void StringBuilderMethods()
        {
            //StringBuilder is a class in C# which means it has properties and Methods
            //StringBuilder uses the System.Text namspace
            //We use StringBuilder to change/mutate strings
            //StringBuilder is more efficient in terms of memory usage than string class

            StringBuilder sb = new StringBuilder();
            string str = string.Empty;


            str = "Hello";

            str += " Stanley";

            sb.Append('-', 8);
            sb.Append("This is StringBuilder Class");
            sb.Append('-', 8);

            sb.AppendLine();

            sb.Append("In this class we will learn about the methods of StringBuilder Class");

           var sbStr = sb.ToString();
           Console.WriteLine(sb);

        }

        static void EnumsStuff()
        {
            var role = 9;

            Console.WriteLine(role);

            if (Enum.IsDefined(typeof(Role), role))
            {
                Console.WriteLine($"{role} is a valid role");
            }
            else
            {
                Console.WriteLine($"{role} is not a valid role");
            }

            Console.WriteLine(Enum.GetName(typeof(Role), role));
        }

        static void IterationStatements()
        {

            //we make use of loop in programming whenevr we want to spit
            //out data/perform an action over a number of time

            //for loop

            for(int i = 0;  i < 10; i++)
            {
                Console.WriteLine($"looped {i + 1} times");
            }

            string[] names = new string[5] { "Stanley", "John", "Doe", "Faith", "Grace" };

            foreach(var  name in names)
            {
                Console.WriteLine($"This is the current name: {name}");
            }

            int number = 0;

            while (number < 10)
            {
                Console.WriteLine($"While Loop: {number}");

                number++;
            }

            do
            {
                Console.WriteLine($"Do while Loop: {number}");

                number++;
            } while (number < 10);

        }

        static void MultiDimensionalArrays()
        {

        }
    }


   public class User
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string FirstName { get; set; } //PascalCase
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }


        public User GetUserInputs()
        {
            User newUser = new User(); // we have created an object/instance of the USer class... newUser

            Console.WriteLine("Enter your First name ");
            var firstName = Console.ReadLine();


            Console.WriteLine("Enter your last name ");
            var lastName = Console.ReadLine();

            if (firstName == "Stanley")
            {
                Console.WriteLine("Welcome Stanley... We've benn instructed to attend to you");
            }
           

            return newUser;

        }


        public double CalulateArea(int raddius)
        {
            //Formular of Area of circle: pi * r * r
            var pi = 3.14;

            var area = pi * raddius * raddius;

            return area;      
        }
    }
}

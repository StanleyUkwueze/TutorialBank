using System;
using System.Linq;
using System.Text;

namespace Week01Class
{
    public class Program
    {
        //switch statement...
        //string ==> string methods
        //arrays ==> 
        //loops ==>

        static void Main(string[] args)
        {
            //#1: Declare an array of students' scores of length 8
            //#1b: loop throgh the the array and print the scores and the grade
            //Keys:
            //0 - 30 is F
            // 31 - 44 is E
            // 45 - 54 is D
            //55 - 64 is C
            // 65 - 69 is B
            //70 - 100 is A

            int[] scores = new int[8] { 45, 78, 67, 23, 54, 12, 90, 32 };


            for (int i = 0; i < scores.Length; i++)
            {
                if(scores[i] >= 0 && scores[i] <= 30)
                {
                    Console.WriteLine($"Your score is {scores[i]} and Grade is F");
                }
                else if (scores[i] >= 31 &&  scores[i] <= 44)
                {
                    Console.WriteLine($"Your score is {scores[i]} and Grade is E");
                }
                else if(scores[i] >= 45 && scores[i] <= 54)
                {
                    Console.WriteLine($"Your score is {scores[i]} and Grade is D");
                }else if(scores[i] >= 55 && scores[i] <= 64)
                {
                    Console.WriteLine($"Your score is {scores[i]} and Grade is C");
                }else if(scores[i] >= 65 && scores[i] <= 69)
                {
                    Console.WriteLine($"Your score is {scores[i]} and Grade is B");
                }
                else
                {
                    Console.WriteLine($"Your score is {scores[i]} and Grade is A");
                }
            }
          
           
        }

        static void MyArrays()
        {
            //Array is a collections of related or items of same data type
            //Elements of an array are the members of the array
            //Lenght of an array ===> the count of it's elements
            //index: index is the position of the elements of an array... starting from 0 to end

            //type[] name_of_array = new type[length];


            string[] fruits = new string[4] { "Mango", "Orange", "Carrot", "Banana" };

            //fruits[0] = "Mango";
            //fruits[1] = "Orange";
            //fruits[2] = "Carrot";
            //fruits[3] = "Banana";

            Console.WriteLine(fruits[2]);
            Console.WriteLine(fruits[0]);
            Console.WriteLine(fruits[3]);
            Console.WriteLine(fruits[1]);
            Console.WriteLine(fruits.Length);

            //string[] names = new string[3] { "Stanley", "Paul", "Chris" };

            //Console.WriteLine(names[2]);

            int[] scores = new int[7] { 34, 87, 56, 90, 89, 56, 44 };

            //Console.WriteLine(scores.Length);

        }


        static void SwitchStatement()
        {
            //switch a is a version of if-else statement

            //write a program that will accept a number from a user and return/print out the day of the week

            //Sunday ===> 1
            //Monday ===> 2
            //Tuesday ===> 3
            //Wednesday ===> 4
            //Thursday === > 5
            //Friday ===> 6
            //Saturday ===> 7
            Console.WriteLine("Enter a number of a day in the week Hint: (1 - 7)");

            var numberOfDay = Convert.ToInt32(Console.ReadLine());

            switch (numberOfDay)
            {
                case 1:
                    Console.WriteLine("Today is Sunday");
                    break;
                case 2:
                    Console.WriteLine("Today is Monday");
                    break;
                case 3:
                    Console.WriteLine("Today is Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Today is Wednesday");
                    break;
                case 5:
                    Console.WriteLine("ToDay is Thursday");
                    break;
                case 6:
                    Console.WriteLine("Today is Friday");
                    break;
                case 7:
                    Console.WriteLine("Today is  Saturday");
                    break;
                default:
                    Console.WriteLine($"{numberOfDay} is not a valid number of day in the week...");
                    break;
            }
        }
        static void StringMethods()
        {
            //index is the position of characters in a string variable 
            //index is the position the lelements of an array
            //NOTE: Index is zer-based i:e it starts from 0 and increments by 1

            string emptyStr = " ";

            var checkIfEmpty = string.IsNullOrEmpty(emptyStr);
            var checkForWhiteSpace = string.IsNullOrWhiteSpace(emptyStr);

            Console.WriteLine($"Checking for Empty string============>{checkIfEmpty}");
            Console.WriteLine($"Checking for WhiteSpace============>{checkForWhiteSpace}");

            string myStringValue = "Stanley is teaching Coding here";

            Console.WriteLine(myStringValue.ToLower());
            Console.WriteLine(myStringValue.ToUpper());
            Console.WriteLine(myStringValue.Trim());

            Console.WriteLine(myStringValue.IndexOf("is"));
            Console.WriteLine(myStringValue.Replace("Stanley", "Paul"));
            Console.WriteLine(myStringValue.Length);

            Console.WriteLine(myStringValue.LastIndexOf("e"));
            Console.WriteLine(myStringValue.Substring(7, 10));
            Console.WriteLine(myStringValue.Remove(10, 6));

            Console.WriteLine(string.IsNullOrEmpty(myStringValue));
            Console.WriteLine(string.IsNullOrWhiteSpace(myStringValue));

            //string digits

            var stringNumber1 = "20";

            var stringNumber2 = "50";

            string concatenatedString = string.Concat(stringNumber1, stringNumber2);

            string concatenatedString1 = stringNumber1 + stringNumber2;

            Console.WriteLine($"Concatenation using Concat Method=======>>{concatenatedString}");
            Console.WriteLine($"Concatenation using + Operator =======>>{concatenatedString1}");


            int numberValue1 = int.Parse(stringNumber1);

            Console.WriteLine(numberValue1);

            int numberValue2 = Convert.ToInt32(stringNumber2);
            Console.WriteLine(numberValue2);


            int numberValue = numberValue1 + numberValue2;
            Console.WriteLine($"This is the number value after conversion: {numberValue}");

       

            Console.WriteLine(string.Format("The sum of {0} and {1} is {2}", numberValue1, numberValue2, numberValue));
            Console.WriteLine($"The sum of the two numbers is {numberValue1 + numberValue2}");

            //string escape charater and string Verbatim

            var instruction = @"I want you to pick the file from this directory: 
C:\Desktop\Users\Tutorials\CSharp
and drop it in this second folder 
C:\Document\Repos\Lessons";


            Console.WriteLine(instruction);
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

        static double ActualOperation(double number1, double number2, string operation)
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

                double number1 = Convert.ToDouble(firstNumber);
                double number2 = Convert.ToDouble(secondNumber);

                Console.WriteLine($"The result of the operation is: {ActualOperation(number1, number2, operation)}");

                Console.WriteLine("Do you want to perform another operation? yes/no");

                var userChoice = Console.ReadLine();

                 repeat = userChoice.ToLower() == "yes" ? true : false;

            } while (repeat);
          


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
            string[] names = new string[5] { "Stanley", "John", "Doe", "Faith", "Grace" };
                                               
            for (int i = 0;  i < 7; i++)
            {
                Console.WriteLine($"For loop printing names: {names[i]}");
            }
   

            //foreach(var  name in names)
            //{
            //    Console.WriteLine($"This is the current name: {name}");
            //}

            //int number = 0;

            //while (number < 10)
            //{
            //    Console.WriteLine($"While Loop: {number}");

            //    number++;
            //}

            //do
            //{
            //    Console.WriteLine($"Do while Loop: {number}");

            //    number++;
            //} while (number < 10);

        }

        static void MultiDimensionalArrays()
        {

        }
        public enum Role
        {
            Admin,
            Reviewer,
            Approver,
            Customer,
            SuperAdmin,
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

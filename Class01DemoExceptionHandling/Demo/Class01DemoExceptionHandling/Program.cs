using System;

namespace Class01DemoExceptionHandling
{
    class Program
    {
        // Main entrance for Console Applications
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // ExceptionExample("Amanda");
            DoubleCatch();

            // try block for Method A. This will add Method A to the callstack
            try
            {
                MethodA();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Caught in Main Method {e.Message}");
            }

            Console.WriteLine("I have continued");
        }

        static string ExceptionExample(string name)
        {
            // Be sure to have the most specific exception first. The most general last.
            try
            {
                Console.WriteLine("Please enter a number");
                string answer = Console.ReadLine();

                int numeric = Convert.ToInt32(answer);

                Console.WriteLine(numeric);
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong FORMAT!!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Hit the generic Exception");
                Console.WriteLine("Amanda, you did it wrong.");
                Console.WriteLine(e.Message);
                
            }

          
 

            return MyString();
        }

        static string MyString()
        {
            return "";
        }

        static void DoubleCatch()
        {
            int num = 13;
            int denom=1, result;
            int[] myArray = { 22, 33, 44 };

            try
            {
                int value = myArray[2];
                result = num / denom;
            
            }
            catch(DivideByZeroException error)
            {
                Console.WriteLine("Don't divide by zero");
                Console.WriteLine(error.Message);
            }
            catch(IndexOutOfRangeException range)
            {
                Console.WriteLine($"your number {num} is invalid");
                Console.WriteLine(range.Message);
            }
            finally
            {
                Console.WriteLine("The End.");
            }
         
        }


        static void MethodA()
        {
            try
            {
                Console.WriteLine("In Method A");
                MethodB();
            }
            catch (Exception)
            {
                Console.WriteLine("Caught in Method A");
                throw;
            }
        }

        static void MethodB()
        {
            try
            {
                Console.WriteLine("In Method B");
                MethodC();
            }
            catch (Exception)
            {

                Console.WriteLine("Caught in Method B");
                throw;
            }
         
        }

        static void MethodC()
        {
            Console.WriteLine("Im in Method C");
            throw (new Exception("I am an Exception, and I am in Method C"));
        }


    }
}

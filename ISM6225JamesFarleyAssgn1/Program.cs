using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace ISM6225JamesFarleyAssgn1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 25;
            printPrimeNumbers(a, b);

            int n1 = 5;
            double r1 = getSeriesResult(n1);
            Console.WriteLine("\nThe sum of the series is: " + r1 + "\n");

            int n4 = 5;
            printTriangle(n4);

            int[] arr = new int[100];
            int[] fr1 = new int[100];
                //{ 1, 2, 3, 2, 2, 1, 3, 2 };
            computeFrequency(arr, fr1);


        }
        public static void printPrimeNumbers(int a, int b)
        {
            try
            {
                bool isPrime = true;
                Console.WriteLine("Prime Numbers: From your choice of "+ a + " To " + b + "\n");
                for (int x = 5; x <= 25; x++)
                {
                    for (int y = 5; y <= 25; y++)
                    {

                        if (x != y && x % y == 0)
                        {
                            isPrime = false;
                            break;
                        }

                    }
                    if (isPrime)
                    {
                        Console.WriteLine("\t" + x);

                    }
                    isPrime = true;

                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printPrimeNumbers()");
            }
        }

        public static double getSeriesResult(int n)
        {
            try
            {
                // Write your code here

                double i, sum = 0.0;

                for (i = 1; i <= n; i++)
                {
                    if (i % 2 != 0)
                    {
                        sum = sum + (CalculateFactorial(i) / (i + 1));
                    }
                    else
                    {
                        sum = sum - (CalculateFactorial(i) / (i + 1));
                    }

                }

                return Math.Round(sum, 3);

            }
            catch
            {
                Console.WriteLine("Exception occured while computing getSeriesResult()");
            }

            return 0;
        }

        private static double CalculateFactorial(double n)
        {
            try
            {
                // Write your code here

                double i, fact = 0;
                fact = n;
                for (i = n - 1; i >= 1; i--)
                {
                    fact = fact * i;
                }

                return fact;
                
            }
            
            catch
            {
                Console.WriteLine("Exception occured while computing getSeriesResult()");
            }
                return 0;
        }
    

        public static void printTriangle(int n)
        {
            try
            {
                int numberoflayer = 5, Space, Number;
                Console.WriteLine("\nPrint pyramid");
                Console.WriteLine("");
                for (int i = 1; i <= numberoflayer; i++) // Total number of layers for pyramid  
                {
                    for (Space = 1; Space <= (numberoflayer - i); Space++) // Loop For Space  
                        Console.Write(" ");
                    for (Number = 1; Number <= i; Number++) // To increase the value  
                        Console.Write('*');
                    for (Number = (i - 1); Number >= 1; Number--) // To decrease the value  
                        Console.Write('*');
                    Console.WriteLine();
                }
                Console.Write("\nPlease hit enter to run array program");
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }
            public static void computeFrequency(int[] a, int[] f)
            {
                try
                {
                    // Write your code here
                    
                    int n, i, j, ctr;

                    Console.Write("\n\nCount the frequency of each element of an array:\n");
                    Console.Write("----------------------------------------------------\n");

                    Console.Write("Input the number of elements to be stored in the array :");
                    n = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Input {0} elements in the array :\n", n);
                    for (i = 0; i < n; i++)
                    {
                        Console.Write("element - {0} : ", i);
                        a[i] = Convert.ToInt32(Console.ReadLine());
                        f[i] = -1;
                    }
                    for (i = 0; i < n; i++)
                    {
                        ctr = 1;
                        for (j = i + 1; j < n; j++)
                        {
                            if (a[i] == a[j])
                            {
                                ctr++;
                                f[j] = 0;
                            }
                        }

                        if (f[i] != 0)
                        {
                            f[i] = ctr;
                        }
                    }
                    Console.Write("\nThe frequency of all elements of the array : \n");
                    Console.Write("\nNumber: \t Frequency: \n");
                        for (i = 0; i < n; i++)
                        {
                            if (f[i] != 0)
                            {
                                Console.WriteLine("\n{0} occurs \t {1} times\n", a[i], f[i]);
                            }
                            Console.WriteLine();
                        }
                            Console.Write("Please hit enter to exit");
                            Console.ReadLine();
                }
                    catch
                    {
                        Console.WriteLine("Exception occured while computing computeFrequency()");
                    }

            }
        }
}


// --------------------------------------------------------------------------------------------
//    INSTRUCTIONS

/*
    * x – starting range, integer (int)
    * y – ending range, integer (int)
    * 
    * summary      : This method prints all the prime numbers between x and y
    * For example 5, 25 will print all the prime numbers between 5 and 25 i.e. 
    * 5, 7, 11, 13, 17, 19, 23
    * Tip: Write a method isPrime() to compute if a number is prime or not.
    *
    * returns      : N/A
    * return type  : void
    *
    */

// -----------------------------------------------------------

/*
* n – number of lines for the pattern, integer (int)
* 
* summary      : This method prints a triangle using *
* For example n = 5 will display the output as: 

            *
           ***
          *****
         *******
        *********

*
* returns      : N/A
* return type  : void
*/

//    ------  APPENDIX -------------

//    int a = 5, b = 15;
//    printPrimeNumbers(a, b);

//    int n1 = 5;
//    double r1 = getSeriesResult(n1);
//    Console.WriteLine("The sum of the series is: " + r1);


//    int n4 = 5;
//    printTriangle(n4);

//    int[] arr = new int[] { 1, 2, 3, 2, 2, 1, 3, 2 };
//    computeFrequency(arr);

//    // write your self-reflection here as a comment

//}

//public static void printPrimeNumbers(int x, int y)
//{
//    try
//    {
//        // Write your code here
//    }
//    catch
//    {
//        Console.WriteLine("Exception occured while computing printPrimeNumbers()");
//    }
//}

//public static double getSeriesResult(int n)
//{
//    try
//    {
//        // Write your code here
//    }
//    catch
//    {
//        Console.WriteLine("Exception occured while computing getSeriesResult()");
//    }

//    return 0;
//}

//public static void printTriangle(int n)
//{
//    try
//    {
//        // Write your code here
//    }
//    catch
//    {
//        Console.WriteLine("Exception occured while computing printTriangle()");
//    }
//}

//public static void computeFrequency(int[] a)
//{
//    try
//    {
//        // Write your code here
//    }
//    catch
//    {
//        Console.WriteLine("Exception occured while computing computeFrequency()");
//    }






//  Extra code that worked differently

//Console.WriteLine("enter a number:");
//int n = Convert.ToInt32(Console.ReadLine());
//for (int i = 1; i <= n; i++)
//{
//    for (int x = i; x <= n; x++)
//    {
//        Console.Write(" ");
//    }
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write("*" + " ");
//    }
//    Console.WriteLine();
//}
//Console.ReadLine();


//int i = 0;
//int count = 0;
//int item = 0;
//Console.WriteLine("Enter numbers : ");
//                    for (i = 0; i< 5; i++)
//                    {
//                        Console.Write("Element[" + (i + 1) + "]: ");
//                        a[i] = int.Parse(Console.ReadLine());
//                    }

//                    Console.Write("Enter item : ");
//                    item = int.Parse(Console.ReadLine());

//                    for (i = 0; i< 5; i++)
//                    {
//                        if (item == a[i])
//                        {
//                            count++;
//                        }
//                    }

//                    Console.WriteLine("Number  " + item + " Frequency : " + count);

//                    Console.WriteLine();


//float res = 0, fact = 1; 
//for (int i = 1; i <= n; i++) 
//{ 
//// fact variable store  
//// factorial of the i 
//fact = fact* i;

//res = res + (i / fact); 
//} 
//return(Math.Round(res, 3)); 


//    s = s + 1 / i;

//double k = s;

//if (k % 2 == 0)
//{
//    //k = k * -1;
//    return (Math.Round(k * -1, 3));
//}
//else
//{
//    //k = k * 1;
//    return (Math.Round(k, 3));
//}

//Sum = 0

//For n = 1 to 10
//If n Is Odd Then
//Sum = Sum + (CalculateFactorial(n) / (n + 1))
//Else
//Sum = Sum - (CalculateFactorial(n) / (n + 1))
//End If
//End For

//Return Round(Sum, 3)


//double i, res = 10;
//for (i = 1; i <= res; i++)
//{
//    return CalculateFactorial(n);
//}
//CalculateFactorial(res);


//        int res = 1;
//        for (int i = 2; i <= n; i++)
//            res *= i;

//        return res;

//        //double i, sum = 0.0;

//        //bool isOdd = true;
//        //for (i = 1; i <= 10; i++)
//        //{
//        //    if (n % 2 != 0)
//        //    {
//        //        isOdd = true;
//        //        sum = sum + (CalculateFactorial(n) / (n + 1));
//        //    }
//        //    else
//        //    {
//        //        sum = sum + (CalculateFactorial(n) / (n + 1));
//        //    }

//        //}

//return Math.Round(sum, 3);


//double i, res = 10;
//    for (i = 1; i <= res; i++)
//    {
//        return CalculateFactorial(n);
//    }

//int i;
//Console.WriteLine("Enter the Number");
//number = int.Parse(Console.ReadLine());


//Console.WriteLine("\nFactorial of Given Number is: " + fact);
//Console.ReadLine();

//throw new NotImplementedException();



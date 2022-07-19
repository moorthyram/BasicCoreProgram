

namespace BasicCoreProgram
{
    class Program
    {
        static public void Main()
        {
            // 1. Flip Coin
            /*      Random random = new Random();
                  int coin = random.Next(0, 1);
                  Console.WriteLine();
                  Console.ReadLine();
                  if (coin == 0)
                  {
                      Console.WriteLine("Head");
                  }
                  else if(coin == 1)
                  {
                      Console.WriteLine("Tail");
                  }*/
            /*     Console.WriteLine(coin);
                 Console.ReadLine();*/

            // 2. Leap year
            /*   int year;
               Console.Write("Enter the Year :");
               year = Convert.ToInt32(Console.ReadLine());
               if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                   Console.WriteLine("{0} is Leap Year", year);
               else
                   Console.WriteLine("{0} is not a Leap Year", year);


               Console.ReadLine();*/


            // 6. check Compute Quotient and Remainder
            /*        int dividend = 50, divisor = 8;

                    int quotient = dividend / divisor;
                    int remainder = dividend % divisor;

                    Console.WriteLine("Dividend:{0} Divisor:{1}", dividend, divisor);
                    Console.WriteLine("Quotient = " + quotient);
                    Console.WriteLine("Remainder = " + remainder);
                    Console.ReadLine();*/


            // 7. check add or even number
            /*       int a;
                   Console.Write("Enter a Number : ");
                   a = int.Parse(Console.ReadLine());
                   if (a % 2 == 0)
                   {
                       Console.Write("Entered Number is an Even Number");
                       Console.Read();
                   }
                   else
                   {
                       Console.Write("Entered Number is an Odd Number");
                       Console.Read();
                   }*/

            // 8.  swapping two numbers
            /*        int num1, num2, temp;
                      Console.Write("\nEnter the First Number : ");
                      num1 = int.Parse(Console.ReadLine());
                      Console.Write("\nEnter the Second Number : ");
                      num2 = int.Parse(Console.ReadLine());
                      temp = num1;
                      num1 = num2;
                      num2 = temp;
                      Console.Write("\nAfter Swapping : ");
                      Console.Write("\nFirst Number : " + num1);
                      Console.Write("\nSecond Number : " + num2);
                      Console.Read();*/

            // 4. Harmonic Number
            /*int i, n;
            double s = 0.0;

            Console.Write("\n\n");
            Console.Write("Calculate the harmonic series and their sum:\n");
            Console.Write("----------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input the number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\n");
            for (i = 1; i <= n; i++)
            {
                Console.Write("1/{0} + ", i);
                s += 1 / (float)i;
            }
            Console.Write("\nSum of Series upto {0} terms : {1} \n", n, s);*/



            // 9. Check Whether an Alphabet is Vowel or Consonant
    /*        char ch;

            Console.WriteLine("Enter any character: ");
            ab = Convert.ToChar(Console.ReadLine());

            // Condition for vowel checking
            if (ab == 'a' || ab == 'e' || ab == 'i' || ab == 'o' || ab == 'u')
            {
                Console.WriteLine(ch + " is Vowel.");
            }
            else if ((ab >= 'a' && ab <= 'z'))
            {
                Console.WriteLine(ch + " is Consonant.");
            }
            Console.ReadLine();*/


            // 10. Find the Largest Among Three Numbers
            int first, second, third;
            Console.WriteLine("Enter the first number : ");
            first = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number : ");
            second = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third number : ");
            third = int.Parse(Console.ReadLine());

            if (first > second)
            {
                if (first > third)
                {
                    Console.WriteLine("largest number : " + first);
                }
                else
                {
                    Console.WriteLine("largest number : " + third);
                }
            }
            else
            {
                if (second > third)
                {
                    Console.WriteLine("largest number : " + second);
                }
                else
                {
                    Console.WriteLine("largest number : " + third);
                }
            }
        }


        // 5. Factors
        /* static void primeFactors(int n)
    {
        int c = 2;
        while (n > 1)
        {
            if (n % c == 0)
            {
                Console.Write(c + " ");
                n /= c;
            }
            else
                c++;
        }
    }
    *//* Driver code *//*
    public static int Main()
    {
        int n = 315;
        primeFactors(n);
        return 0;
    }*/
    }
}
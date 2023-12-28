using System;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(OperationsWithNums(5, 7, '-'));
            Console.WriteLine(SymbolsCount("salam", 'a'));
            Console.WriteLine(SumOfDigits(567));
            Console.WriteLine(PowerOfNumber(4, 2));
            int[] arr = GetPositiveNumbers(new int[] { 34, -567, 99, -3 });
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "");
            }
            Console.WriteLine(ReversedText("salam"));
            Console.WriteLine(WordCount("salam necesen salam"));


        }

        static double OperationsWithNums(double num1, double num2, char operation)
        {
            switch (operation)
            {
                case '+':
                    return num1 + num2;
                case '-':
                    return num1 - num2;
                case '*':
                    return num1 * num2;
                case '/':
                    if (num2 != 0)
                        return num1 / num2;
                    else
                    {
                        Console.WriteLine("Xeta ! 0 a bolmek olmaz ");
                        return 0;
                    }
                default:
                    Console.WriteLine("Yalnish operator !.");
                    return 0;
            }
        }
        static int SymbolsCount(string text, char searchChar)
        {
            int count = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == searchChar)
                {
                    count++;
                }
            }

            return count;
        }
        static int SumOfDigits(int number)
        {
            int sum = 0;

            while (number != 0)
            {
                int digit = number % 10;
                sum += digit;
                number /= 10;
            }

            return sum;
        }
        static int PowerOfNumber(int num1, int num2 )
        {
            int result = 1;
            for (int i = 0; i < num2; i++)
            {
                result *= num1;
            }

            return result;
        }

        static int[] GetPositiveNumbers(int[] array)
        {
            for (int i = 0;i < array.Length; i++)
            {
                
                if (array[i] < 0)
                {
                    array[i] = array[i] * -1; 
                }
            }
            return array;
        }
        static string ReversedText (string text)
        {
            string reversedText = "";
            for (int i = text.Length-1; i >=0; i--)
            {
                reversedText += text[i];
            }
            return reversedText;
        }
        static int WordCount(string text)
        {
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    count++;
                }

            }
            return count + 1;
        }

        //static int WordCount(string text)  //eger boshluglarin sayi 1den chox olarsa
        //{
        //    int count = 0;
        //    for (int i = 0; i < text.Length; i++)
        //    {
        //        if (text[i] == ' ')
        //        {
        //            if (text[i+1] == ' ')
        //            {
        //            count++;

        //            }
        //        }

        //    }
        //    return count + 1;
        //}
    }
}

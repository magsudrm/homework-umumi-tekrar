using System;
using System.Data.SqlTypes;
using System.Globalization;
using System.Threading.Tasks;

namespace Umumi_tekrar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(bothSpaceless("      q      b   wjdjwd   1            "));
        }

        // Task-1   Verilmiş iki ədədi toplayıb nəticəsini qaytaran metod
        static int Sum(int num1,int num2)
        {
            return num1 + num2;
        }

        // Task-2  Verilmiş ədədin kvadratını qaytaran metod
        static int Square(int num)
        {
            return num * num;
        }

        // Task-3  Verilmiş string dəyərində a hərfinin olub olmadığını qaytaran metod
        static bool HasA(string word)
        {
            bool hasA = false;
            for(int i = 0; i < word.Length; i++)
            {
                if (word[i]!='a' && word[i] != 'A')
                {
                    hasA = true;
                }
            }
            hasA = false;
            return hasA;
        }

        // Task-4  Verilmiş ədədin rəqəmləri cəmini qaytaran metod
        static int SumofDigits(int num)
        {
            var sum = 0;
            while (num > 0)
            {
                int x = num % 10;
                sum += x;
                num = (num - x) / 10;
            }
            return sum;
        }

        // Task-5  Verilmiş 4 ədədin ortalamasını tapıq qaytaran metod
        static int avrg(int num1,int num2,int num3,int num4)
        {
            var ortalma = (num1 + num2 + num3 + num4) / 4;
            return ortalma;
        }

        // Task-6  Verilmiş ədədin verilmiş qüvvətini tapan metod
        static int pwr(int num1,int num2)
        {
            var hasil = 1;
            for(int i = 0; i < num2; i++)
            {
                hasil *= num1;
            }
            return hasil;
        }

        // Task-7  Verilmiş 3 ədəddən ən böyüyünü tapan metod
        static int biggestOfThree(int num1,int num2,int num3)
        {
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    return num1;
                }
                else
                    return num3;                   
            }
            else
            {
                if (num2 > num3)
                {
                    return num2;
                }
                else
                    return num3;
            }
        }

        // Task-8  Verilmiş ədədlər siyahısındaki ədədlərin cəmini tapan metod
        static int sumofdigits(int[] list)
        {
            int sum = 0;
            for(int i = 0; i < list.Length; i++)
            {
                sum += list[i];
            }
            return sum;
        }

        // Task-9  Verilmiş ədədlər siyahısındaki ən böyük ədədi tapan metod
        static int BiggestNum(int[] list)
        {
            var biggest = list[0];
            for(int i = 1; i < list.Length; i++)
            {
                if (biggest < list[i])
                {
                    biggest = list[i];
                }
            }
            return biggest;
        }

        // Task-10  Verilmiş ədədlər siyahısındaki ən böyük ədədin yerləşdiyi index-i qaytaran metod
        static int biggestNum(int[] numbers)
        {
            int max = numbers[0];
            int biggest = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                    biggest = i;
                }
            }

            return biggest;
        }

        // Task-11   Verilmiş yazılar siyahısındaki (string array) verilmiş yazının yerləşdiyi indexi qaytaran metod.
        // Əgər verilmiş string array-de verilmiş string dəyər yoxdursa -1 qaytarsın
        static int ReturnIndex(string[] list,string word)
        {
            for(int i = 0; i < list.Length; i++)
            {
                if (list[i] == word)
                {
                    return i;
                }
            }
            return -1;
        }

        // Task-12  Verilmiş ədədlər siyahısındaki ədədlərin yalnız müsbət olanlarından ibarət yeni bir array qaytaran metod.

        static int[] AllNumbers(int[] numbers)
        {
            int count = 0;
            for(int i=0;i<numbers.Length;i++)
            {
                if (numbers[i] > 0)
                {
                    count++;
                }
            }
            int[] positives=new int[count];
            var n =0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                {
                    positives[n] = numbers[i];
                    n++;
                }
            }
            return positives;
        }
        // Task-13  Verilmiş yazıda rəqəm olub olmadığını qaytaran metod
        static bool hasDigit(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (isDigit(input[i]))
                {
                    return true;
                }
            }
            return false;
        }

        // Elave Task
        static int FindIndex(char[] input1, char input2)
        {
            for (int i = 0; i < input1.Length; i++)
            {
                if (input1[i] == input2)
                {
                    return i;
                }
            }
            return -1;
        }

        // Elave Task 2
        static bool isDigit(char input)
        {
            char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            return FindIndex(digits, input) != -1;
        }

        // Task-14  Verilmiş yazılar siyahısında neçə yazıda rəqəm olduğunu qaytaran metod
        static int HowMuchDigits(string[] input)
        {
            int count = 0;
            for (int i = 0; i <= input.Length; i++)
            {
                if (hasDigit(input[i]))
                {
                    count++;
                }
            }
            return count;
        }

        // Task-15  Verilmiş yazıdaki ilk boşluq olmayan index-i qaytaran metod
        static int FirstSpaceless(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != ' ')
                {
                    return i;
                }
            }
            return -1;
        }
    
        // Task-16  Verilmiş yazıdaki son boşluq olmayan index-i qaytaran metod
        static int lastspaceless(string word)
        {
            for (int i = word.Length - 1; i < word.Length; i--)
            {
                if (word[i] != ' ')
                {
                    return i;
                }
            }
            return -1;
        }

        // Task-17  Verilmiş yazını sol tərəfində boşluq olmayan vəziyyətdə qaytaran metod
        static string LeftSpaceless(string word)
        {
            var firstIndex = FirstSpaceless(word);
            string leftWord = "";
            for (int i = firstIndex; i < word.Length; i++)
            {
                leftWord += word[i];
            }

            return leftWord;
        }

        // Task-18  Verilmiş yazını sol və sağ tərəflərində boşluq olmayan vəziyyətdə qaytaran metod
        static string bothSpaceless(string word)
        {
            var firstIndex = FirstSpaceless(word);
            string leftWord = "";
            for (int i = firstIndex; i < word.Length; i++)
            {
                leftWord += word[i];
            }

            var lastIndex = lastspaceless(leftWord);
            string rightWord = "";
            for (int i = lastIndex; i>=0; i--)
            {
                rightWord += leftWord[i];
            }
            return rightWord;

        }


    }
}

using System;

namespace Artem_Topchii___Homework_2
{
    class Program
    {
        static int CompareTwoNumbers(int a, int b)
        {
            int result = default;

            if (a > b)
            {
                result = a + b;
            }
            else if (a == b)
            {
                result = a * b;
            }
            else
            {
                result = a - b;
            }

            return result;
        }

        static int DetermineQuater(int x, int y)
        {
            int result = default;

            if (x > 0 && y > 0)
            {
                result = 1;
            }
            else if (x < 0 && y < 0)
            {
                result = 3;
            }
            else if (x < 0 && y > 0)
            {
                result = 2;
            }
            else if (x > 0 && y < 0)
            {
                result = 4;
            }
            else
            {
                result = 0;
            }

            return result;
        }

        static (int, int, int) SortAscending(int a, int b, int c)
        {
            if (a > b)
            {
                SwapTwoValues(ref a, ref b);
            }
            if (a > c)
            {
                SwapTwoValues(ref a, ref c);
            }
            if (b > c)
            {
                SwapTwoValues(ref b, ref c);
            }

            return (a, b, c);
        }

        static (float, float) SolveQaudraticEquation(float a, float b, float c)
        {
            float x1 = default;
            float x2 = default;
            float d = b * b - 4 * a * c;

            if (d > 0)
            {
                x1 = (float)((-b + Math.Sqrt(d)) / (2 * a));
                x2 = (float)((-b - Math.Sqrt(d)) / (2 * a));
            }
            else if (d == 0)
            {
                x1 = x2 = (float)(-b / (2 * a));
            }
            else
            {
                x1 = x2 = float.NaN;
            }

            return (x1, x2);
        }

        static string CapitalizateNumber(int number)
        {
            int firstDigit = number / 10;
            int secondDigit = number % 10;
            string literalValue = default;

            if (firstDigit != 1)
            {
                string firstWord = GetFirstDigit(firstDigit);
                string secondWord = GetSecondDigit(secondDigit);
                if (secondDigit != 0)
                {
                    literalValue = firstWord + secondWord;
                }
                else
                {
                    literalValue = firstWord;
                }
            }
            else
            {
                literalValue = GetWordFrom10To19(number);
            }

            return literalValue;
        }

        private static string GetWordFrom10To19(int number)
        {
            string literalValue = default;

            switch (number)
            {
                case 10:
                    literalValue = "Ten";
                    break;
                case 11:
                    literalValue = "Eleven";
                    break;
                case 12:
                    literalValue = "Twelve";
                    break;
                case 13:
                    literalValue = "Thirteen";
                    break;
                case 14:
                    literalValue = "Fourteen";
                    break;
                case 15:
                    literalValue = "Fifteen";
                    break;
                case 16:
                    literalValue = "Sixteen";
                    break;
                case 17:
                    literalValue = "Seventeen";
                    break;
                case 18:
                    literalValue = "Eighteen";
                    break;
                case 19:
                    literalValue = "Nineteen";
                    break;
            }

            return literalValue;
        }

        private static string GetSecondDigit(int secondDigit)
        {
            string secondWord = default;

            switch (secondDigit)
            {
                case 1:
                    secondWord = " one";
                    break;
                case 2:
                    secondWord = " two";
                    break;
                case 3:
                    secondWord = " three";
                    break;
                case 4:
                    secondWord = " four";
                    break;
                case 5:
                    secondWord = " five";
                    break;
                case 6:
                    secondWord = " six";
                    break;
                case 7:
                    secondWord = " seven";
                    break;
                case 8:
                    secondWord = " eight";
                    break;
                case 9:
                    secondWord = " nine";
                    break;
            }

            return secondWord;
        }

        private static string GetFirstDigit(int firstDigit)
        {
            string firstWord = default;

            switch (firstDigit)
            {
                case 2:
                    firstWord = "Twenty";
                    break;
                case 3:
                    firstWord = "Thirty";
                    break;
                case 4:
                    firstWord = "Fourty";
                    break;
                case 5:
                    firstWord = "Fifty";
                    break;
                case 6:
                    firstWord = "Sixty";
                    break;
                case 7:
                    firstWord = "Seventy";
                    break;
                case 8:
                    firstWord = "Eighty";
                    break;
                case 9:
                    firstWord = "Ninety";
                    break;
            }

            return firstWord;
        }

        static (int, int) SwapTwoValues(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
            return (a, b);
        }

        static void Main()
        {
         //COMPARE TWO NUMBERS

            //Console.WriteLine(CompareTwoNumbers(10, 15));

         //DETERMINE QUATER

            //Console.WriteLine(DetermineQuater(5, 15));

         //SORT ASCENDING

            //(int a, int b, int c) = SortAscending(3, 4, 8);

            //Console.WriteLine(a + " <= " + b + " <= " + c);

         //SOLVE QAUDRATIC EQUATION

            //(float x1, float x2) = SolveQaudraticEquation(4, 4, 1);

            //Console.WriteLine("X1 = " + x1 + " X2 = " + x2);

         //CAPITALIZATE NUMBER

            //Console.WriteLine(CapitalizateNumber(11));
        }
    }
}

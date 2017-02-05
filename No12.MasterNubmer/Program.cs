using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No12.MasterNubmer
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                byte[] digits = new byte[i.ToString().Length];
                int TempNumber = i;

                for (int o = 0; o < digits.Length; o++)
                {
                    digits[digits.Length - o - 1] = (byte)(TempNumber % 10);
                    TempNumber /= 10;
                }

                if (IsEven(digits) && SymetricNumber(digits) && DevisableSum(digits))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool DevisableSum(byte[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
                sum += numbers[i];

            bool isDivisable = sum % 7 == 0;

            return isDivisable;
        }
        static bool IsEven(byte[] digits)
        {
            bool isEven = false;
            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] % 2 == 0)
                {
                    isEven = true;
                    break;
                }
            }

            return isEven;
        }
        static bool SymetricNumber(byte[] digits)
        {
            bool symetric = false;
            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] == digits[digits.Length - i - 1])
                    symetric = true;
                else
                {
                    symetric = false;
                    break;
                }
            }
            return symetric;
        }
    }
}

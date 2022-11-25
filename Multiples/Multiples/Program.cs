using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int minRandomNumber = 1;
            int maxRandomNumber = 27;
            int serchNumber = rand.Next(minRandomNumber, maxRandomNumber);
            int minNumber = 100;
            int maxNumber = 999;
            int substructNumber = 0;
            int countNaturalNumber = 0;
            bool isSubtracted;

            Console.WriteLine($"Случайное число в диапазоне от 1 до 27 - {serchNumber}");

            for(int i = minNumber; i < maxNumber; i++)
            {
                isSubtracted = true;
                substructNumber = i;

                if (i == maxNumber)
                {
                    isSubtracted = false;
                }
                
                while(isSubtracted)
                {
                    substructNumber -= serchNumber;

                    if (substructNumber == 0)
                    {
                        countNaturalNumber++;
                        isSubtracted = false;
                    }
                    else if (substructNumber < 0)
                    {
                        isSubtracted = false;
                    }
                }
            }

            Console.WriteLine($"Количество трехзначных натуральных чисел которые кратны числу {serchNumber} равно {countNaturalNumber}");
            Console.ReadKey();
        }
    }
}

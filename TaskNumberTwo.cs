using System;

namespace Lab_5_
{
    internal class TaskNumberTwo
    {
        /// <summary>
        /// Проверяет, введено ли целое число
        /// </summary>
        /// <param name="inputData"></param>
        public void CheckIntegerValue()
        {
            Console.WriteLine("Введите целое число");
            string inputData = Console.ReadLine();
            if (CheckSymbolsOfString(inputData))
                PrintResult(GetDigitSum(inputData));
            else
            {
                Console.WriteLine($"{inputData} - не целое число или вообще не число");
                return;
            }
        }

        /// <summary>
        /// Считает сумму цифр числа
        /// </summary>
        /// <param name="inputData"></param>
        /// <returns></returns>
        static int GetDigitSum(string inputData)
        {
            int result = 0;
            for (int i = 0; i < inputData.Length; i++)
            {
                int value = inputData[i] switch
                {
                    '1' => 1,
                    '2' => 2,
                    '3' => 3,
                    '4' => 4,
                    '5' => 5,
                    '6' => 6,
                    '7' => 7,
                    '8' => 8,
                    '9' => 9,
                    _ => 0,
                };
                result += value;
            }
            return result;
        }

        /// <summary>
        /// Выводит результат в консоль
        /// </summary>
        /// <param name="result"></param>
        static void PrintResult(int result)
        {
            Console.Write($"Сумма цифр числа = {result}");
        }

        /// <summary>
        /// Проверяет, равны ли символы строки цифрам 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        static bool CheckSymbolsOfString(string str)
        {
            bool isDigit = true;
            foreach (char item in str)
                if (!char.IsDigit(item)) isDigit = false;
            return isDigit;
        }
    }
}

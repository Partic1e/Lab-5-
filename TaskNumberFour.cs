using System;
using System.Globalization;

namespace Lab_5_
{
    internal class TaskNumberFour
    {
        /// <summary>
        /// Принимает на ввод строку
        /// </summary>
        public void GetString()
        {
            Console.WriteLine("Введите элементы массива через пробел");
            string inputData = Console.ReadLine();
            ConvertToArray(inputData);
        }

        /// <summary>
        /// Конвертирует строку в массив и изменяет его
        /// </summary>
        /// <param name="inputdata"></param>
        static void ConvertToArray(string inputdata)
        {
            string[] array = inputdata.Split(" ");
            PrintArray(array);
            for (int i = 0; i < array.Length; i++)
            {
                if (int.TryParse(array[i], out int value))
                {
                    if (value >= 0)
                        array[i] = Factorial(value);
                }
                else
                    array[i] = GetFractionalPart(array[i]);
            }
            PrintArray(array);
        }

        /// <summary>
        /// Вычисляет факториал целого положительного числа
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        static string Factorial(int value)
        {
            int result = 1;
            for (int i = 1; i <= value; i++)
                result *= i;
            if (value == 0)
                result = 1;
            return result.ToString();
        }

        /// <summary>
        /// Получает дробную часть числа, округлённую до сотых
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        static string GetFractionalPart(string str)
        {
            double value = double.Parse(str, CultureInfo.InvariantCulture);
            if (value < 0)
                value *= -1;
            value = (int)((value - (int)value) * 100);
            return value.ToString();
        }

        /// <summary>
        /// Выводит массив в консоль
        /// </summary>
        /// <param name="array"></param>
        static void PrintArray(string[] array)
        {
            foreach (string item in array)
                Console.Write($"| {item} |");
            Console.WriteLine();
        }
    }
}
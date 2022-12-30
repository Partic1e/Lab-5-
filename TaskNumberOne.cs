using System;
using System.Collections.Generic;
using System.Globalization;

namespace Lab_5_
{
    static class TaskNumberOne
    {
        /// <summary>
        /// Получает строку на в ввод 
        /// </summary>
        public static void GetString()
        {
            Console.WriteLine("Введите число");
            string inputData = Console.ReadLine();
            if (inputData == "q")
                return;
            CheckValueFromString(inputData);
        }

        /// <summary>
        /// Проверяет целостность введённого из строки числа
        /// </summary>
        /// <param name="inputData"></param>
        private static void CheckValueFromString(string inputData)
        {
            if (int.TryParse(inputData, out int value))
                WriteIntValue(value);
            else
                CompareFloatValues(inputData);
        }

        /// <summary>
        /// Выводит символ целого числа
        /// </summary>
        /// <param name="value"></param>
        private static void WriteIntValue(int value)
        {
            char symbol = Convert.ToChar(value);
            Console.WriteLine(symbol);
        }

        /// <summary>
        /// Сравнивает два числа с плавающей точкой
        /// </summary>
        /// <param name="inputData"></param>
        private static void CompareFloatValues(string inputData)
        {
            List<float> list = new List<float>() { float.NaN, float.NaN };
            for (int i = 1; ; i++)
            {
                float value = float.Parse(inputData, CultureInfo.InvariantCulture);
                list[i] = value;
                if (list[i] == list[i - 1])
                    return;
                else
                {
                    list.Add(list[i]);
                    inputData = Console.ReadLine();
                }
            }
        }
    }
}
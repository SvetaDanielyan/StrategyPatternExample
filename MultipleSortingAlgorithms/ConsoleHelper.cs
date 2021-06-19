using System;

namespace MultipleSortingAlgorithms
{
    public class ConsoleHelper
    {
        public static void ShowItems<T>(T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        public static int[] ReadArrayItemsFromConsole()
        {
            int[] arr = new int[Constants.LengthOfArray];
            for (int i = 0; i < Constants.LengthOfArray; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            return arr;
        }
    }
}

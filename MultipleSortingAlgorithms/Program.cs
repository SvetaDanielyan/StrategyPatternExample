using System;

namespace MultipleSortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Constants.ArrayItemsAsker);
            int[] array = ConsoleHelper.ReadArrayItemsFromConsole();

            Console.WriteLine(Constants.SortMethodAsker);
            string strategy = Console.ReadLine();
            SortStrategy sortStrategy = ConvertValueToEnum<SortStrategy>(strategy);

            SortHelper.SortByStrategy(sortStrategy, array);
        }

        public static T ConvertValueToEnum<T>(string value)
        {
            return (T)Enum.Parse(typeof(T), value);
        }
    }
}

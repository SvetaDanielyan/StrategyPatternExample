using System;

namespace MultipleSortingAlgorithms
{
    public class SortHandler
    {
        public ISort SortStrategy { get; set; }
        int[] Array = new int[Constants.LengthOfArray];

        public SortHandler(ISort sortStrategy, int[] array)
        {
            this.SortStrategy = sortStrategy;
            this.Array = array;
        }

        public void SortArray()
        {
            SortStrategy.Sort(Array);
        }

        public void ShowSortedArray()
        {
            Console.Write(Constants.TitleForOutput);
            ConsoleHelper.ShowItems<int>(Array);
        }
    }
}

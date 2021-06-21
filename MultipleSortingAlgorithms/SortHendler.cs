using System;

namespace MultipleSortingAlgorithms
{
    public class SortHandler
    {
        public ISort SortStrategy { get; set; }
        public int[] array;

        public SortHandler(ISort sortStrategy, int[] array)
        {
            this.SortStrategy = sortStrategy;
            this.array = array;
        }

        public void SortArray()
        {
            SortStrategy.Sort(array);
        }

        public void ShowSortedArray()
        {
            Console.Write(Constants.TitleForOutput);
            ConsoleHelper.ShowItems<int>(array);
        }
    }
}

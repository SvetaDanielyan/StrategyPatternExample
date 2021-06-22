using System;

namespace MultipleSortingAlgorithms
{
    public class SortHandler
    {
        private ISort SortStrategy { get; set; }
        private int[] array;

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

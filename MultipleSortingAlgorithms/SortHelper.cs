namespace MultipleSortingAlgorithms
{
    public class SortHelper
    {
        public static void SortByStrategy(SortStrategy sortMethod, int[] array)
        {
            if (array.Length == 0) { return; }

            ISort sortStrategy = IdentifySortStrategy(sortMethod);
            if (sortStrategy == null) { return; }

            SortHandler sortHandler = new SortHandler(sortStrategy, array);
            if (sortHandler == null) { return; }
            sortHandler.SortArray();
            sortHandler.ShowSortedArray();
        }

        public static ISort IdentifySortStrategy(SortStrategy sortMethod)
        {
            ISort sortStrategy = null;
            switch (sortMethod)
            {
                case SortStrategy.Insertion:
                    sortStrategy = new InsertionSort();
                    break;

                case SortStrategy.Selection:
                    sortStrategy = new SelectionSort();
                    break;

                case SortStrategy.Merge:
                    sortStrategy = new MergeSort();
                    break;
            }
            if (sortStrategy == null) { return null; }
            return sortStrategy;
        }
    }
}

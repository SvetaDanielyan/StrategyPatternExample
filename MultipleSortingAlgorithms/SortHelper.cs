namespace MultipleSortingAlgorithms
{
    public class SortHelper
    {
        public static void SortByStrategy(SortStrategy sortMethod, int[] array)
        {
            if (array.Length == 0) { return; }

            SortHandler sortHandler = null;
            switch (sortMethod)
            {
                case SortStrategy.Insertion:
                    InsertionSort insertionSort = new InsertionSort();
                    sortHandler = new SortHandler(insertionSort, array);
                    break;

                case SortStrategy.Selection:
                    SelectionSort selectionSort = new SelectionSort();
                    sortHandler = new SortHandler(selectionSort, array);
                    break;

                case SortStrategy.Merge:
                    MergeSort mergeSort = new MergeSort();
                    sortHandler = new SortHandler(mergeSort, array);
                    break;
            }

            if (sortHandler == null) { return; }
            sortHandler.SortArray();
            sortHandler.ShowSortedArray();
        }
    }
}

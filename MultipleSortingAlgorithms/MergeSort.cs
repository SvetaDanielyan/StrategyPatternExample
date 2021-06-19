namespace MultipleSortingAlgorithms
{
    public class MergeSort : ISort
    {
        public void Sort(int[] array)
        {
            SortMergesArrays(array, 0, array.Length - 1);
        }

        void Merge(int[] array, int l, int m, int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m;

            int[] L = new int[n1];
            int[] R = new int[n2];
            int i, j;

            for (i = 0; i < n1; ++i)
                L[i] = array[l + i];
            for (j = 0; j < n2; ++j)
                R[j] = array[m + 1 + j];

            i = 0;
            j = 0;

            int k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    array[k] = L[i];
                    i++;
                }
                else
                {
                    array[k] = R[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                array[k] = L[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                array[k] = R[j];
                j++;
                k++;
            }
        }

        void SortMergesArrays(int[] array, int l, int r)
        {
            if (l < r)
            {
                int m = l + (r - l) / 2;
                SortMergesArrays(array, l, m);
                SortMergesArrays(array, m + 1, r);

                Merge(array, l, m, r);
            }
        }

    }
}

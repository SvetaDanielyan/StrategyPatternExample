namespace MultipleSortingAlgorithms
{
    public class SelectionSort : ISort
    {
        public void Sort(int[] array)
        {
            int n = array.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndxex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[minIndxex]) 
                    {
                        minIndxex = j;
                    }
                }

                int temp = array[minIndxex];
                array[minIndxex] = array[i];
                array[i] = temp;
            }
        }
    }
}

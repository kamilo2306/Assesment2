using System;
using System.Collections.Generic;

namespace Assesment2
{
    public static class Utility<T> where T : IComparable<T>
    {
        // Sorting methods
        public static void QuickSortAscending(List<T> list)
        {
            if (list == null || list.Count <= 1)
                return;

            QuickSortAscending(list, 0, list.Count - 1);
        }

        public static void QuickSortDescending(List<T> list)
        {
            if (list == null || list.Count <= 1)
                return;

            QuickSortDescending(list, 0, list.Count - 1);
        }

        private static void QuickSortAscending(List<T> list, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = PartitionAscending(list, low, high);

                QuickSortAscending(list, low, pivotIndex - 1);
                QuickSortAscending(list, pivotIndex + 1, high);
            }
        }

        private static void QuickSortDescending(List<T> list, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = PartitionDescending(list, low, high);

                QuickSortDescending(list, low, pivotIndex - 1);
                QuickSortDescending(list, pivotIndex + 1, high);
            }
        }

        private static int PartitionAscending(List<T> list, int low, int high)
        {
            T pivot = list[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (list[j].CompareTo(pivot) <= 0)
                {
                    i++;
                    Swap(list, i, j);
                }
            }

            Swap(list, i + 1, high);
            return i + 1;
        }

        private static int PartitionDescending(List<T> list, int low, int high)
        {
            T pivot = list[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (list[j].CompareTo(pivot) >= 0)
                {
                    i++;
                    Swap(list, i, j);
                }
            }

            Swap(list, i + 1, high);
            return i + 1;
        }

        private static void Swap(List<T> list, int i, int j)
        {
            T temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }

        
    }
}

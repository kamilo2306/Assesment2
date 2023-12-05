using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment2
{
    public static class SearchingUtility<T> where T : IComparable<T>
    {
        public static bool BinarySearch(List<T> sortedList, T target)
        {
            int low = 0;
            int high = sortedList.Count - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                int comparisonResult = sortedList[mid].CompareTo(target);

                if (comparisonResult == 0)
                {
                    // Found the target
                    return true;
                }
                else if (comparisonResult < 0)
                {
                    // Target is in the right half
                    low = mid + 1;
                }
                else
                {
                    // Target is in the left half
                    high = mid - 1;
                }
            }

            // Target not found
            return false;
        }

        public static bool LinearSearch(List<T> unsortedList, T target)
        {
            foreach (var item in unsortedList)
            {
                if (item.CompareTo(target) == 0)
                {
                    return true;
                }
            }

            // Target not found
            return false;
        }
    }
}
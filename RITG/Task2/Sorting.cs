using System;

namespace RITG.Task2
{
    enum SortOrder
    {
        Ascending,
        Descending
    }
    internal static class Sorting
    {
        public static void Swap<T>(ref T value1, ref T value2) =>
            (value1, value2) = (value2, value1);
        public static bool CheckSortOrder<T>(this T[] array, SortOrder sortOrder = SortOrder.Ascending)
            where T : IComparable<T>
        {
            if (array is null)
                throw new ArgumentNullException(nameof(array));
            switch(sortOrder)
            {
                case SortOrder.Ascending:
                    for (var i = 0; i < array.Length - 1; i++)
                    {
                        if (array[i].Equals(null))
                            continue;
                        if (array[i].CompareTo(array[i + 1]) > 0)
                            return false;
                    }
                    break;
                case SortOrder.Descending:
                    for (var i = 0; i < array.Length - 1; i++)
                    {
                        if (array[i].Equals(null))
                            continue;
                        if (array[i].CompareTo(array[i + 1]) < 0)
                            return false;
                    }
                    break;
                default:
                    throw new ArgumentException();
            }
            return true;
        }
    }
}

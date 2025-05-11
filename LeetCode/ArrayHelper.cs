namespace LeetCode;

public class ArrayHelper
{
    public static int[] MergeArrays(int[] array1, int[] array2)
    {
        return array1.Concat(array2).ToArray();
    }

    public static void SortArray(int[] array)
    {
        Array.Sort(array);
    }

    public static string ArrayToString(int[] array)
    {
        return $"[{string.Join(", ", array)}]";
    }

    public static double FindMedian(int[] array)
    {
        int n = array.Length;
        if (n % 2 == 1) // The length of the array is odd.
        {
            int middleIndex = n / 2;
            return array[middleIndex];
        }
        else // The length of the array is even.
        {
            int middleIndex1 = n / 2 - 1;
            int middleIndex2 = n / 2;
            return (double)(array[middleIndex1] + array[middleIndex2]) / 2;
        }
    }
}
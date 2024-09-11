namespace ULearn.Module_1_5;

public class ContainsAtIndexTask
{
    public static int FindSubarrayStartIndex(int[] array, int[] subArray)
    {
        for (var i = 0; i < array.Length - subArray.Length + 1; i++)
            if (ContainsAtIndex(array, subArray, i))
                return i;
        return -1;
    }

    private static bool ContainsAtIndex(int[] array, int[] subArray, int i)
    {
        for (int k = 0; k < subArray.Length; k++)
            if (array[k + i] != subArray[k])
                return false;
        return true;
    }
}
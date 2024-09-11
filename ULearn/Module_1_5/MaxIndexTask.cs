namespace ULearn.Module_1_5;

public class MaxIndexTask
{
    public static int MaxIndex(double[] array)
    {
        var max = double.MinValue;
        foreach (var item in array)
            if (item > max) max = item;
        for (int i = 0; i < array.Length; i++)
            if (array[i] == max)
                return i;
        return -1;
    }
}
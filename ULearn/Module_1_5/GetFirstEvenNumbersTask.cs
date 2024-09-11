namespace ULearn.Module_1_5;

public class GetFirstEvenNumbersTask
{
    public static int[] GetFirstEvenNumbers(int count)
    {
        int[] array = new int[count];
        for (int i = 0; i < array.Length; i++) 
            array[i] = 2 * (i + 1);
        return array;
    }
}
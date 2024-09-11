namespace ULearn.Module_1_5;

public class GetPoweredArrayTask
{
    public static int[] GetPoweredArray(int[] arr, int power)
    {
        var newArr = new int[arr.Length];
        for (int i = 0; i < newArr.Length; i++)
            newArr[i] = (int)Math.Pow(arr[i], power);
        return newArr;
    }
}
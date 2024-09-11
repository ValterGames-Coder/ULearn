namespace ULearn.Module_1_5;

public class CheckFirstElementTask
{
    public static bool CheckFirstElement(int[]? array)
    {
        return array != null && array.Length != 0 && array[0] == 0;
    }
}
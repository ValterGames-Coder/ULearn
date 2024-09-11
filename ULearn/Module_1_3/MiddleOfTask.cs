namespace ULearn.Module_1_3;

public class MiddleOfTask
{
    public static int MiddleOf(int a, int b, int c)
    {
        return (a >= b) ? (b >= c ? b : (a >= c) ? c : a) : (a >= c ? a : (b >= c ? c : b));
    }
    
    public static int MiddleOfByList(int a, int b, int c)
    {
        List<int> sortedList = [a, b, c];
        int max = sortedList.Max();
        int min = sortedList.Min();
        sortedList.Remove(max);
        sortedList.Remove(min);
        return sortedList[0];
    }
}
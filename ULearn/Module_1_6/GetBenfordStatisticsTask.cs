namespace ULearn.Module_1_6;

public class GetBenfordStatisticsTask
{
    public static int[] GetBenfordStatistics(string text)
    {
        var statistics = new int[10];
        for (int i = 0; i < text.Length; i++)
            if (char.IsDigit(text[i]) && (i == 0 || !char.IsDigit(text[i - 1])))
                statistics[text[i] - '0']++;
        return statistics;
    }
}
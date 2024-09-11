namespace ULearn.Module_1_4;

public class WriteTextWithBorderTask
{
    public static void WriteTextWithBorder(string text)
    {
        string line = "+";
        for (int i = 0; i < text.Length + 2; i++) 
            line += "-";
        line += "+";
        string result = $"{line}\n| {text} |\n{line}";
        Console.WriteLine(result);
    }
}
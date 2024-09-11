namespace ULearn.Module_1_6;

public class ReplaceIncorrectSeparatorsTask
{
    public static string ReplaceIncorrectSeparators(string text)
    {
        char[] symbols = new char[] {':', ';', '-', ',', ' '};
        var words = text.Split(symbols, StringSplitOptions.RemoveEmptyEntries);
        return String.Join("\t", words);
    }
}
namespace ULearn.Module_1_6;

public class DecodeMessageTask
{
    public static string DecodeMessage(string[] lines)
    {
        List<string> secret = new List<string>();
        foreach (string line in lines)
        {
            if(line.Length == 0)
                continue;
            string[] words = line.Split(" ");
            foreach (string word in words) 
                if(Char.IsUpper(word[0]))
                    secret.Add(word);
        }
        
        secret.Reverse();
        return String.Join(" ", secret);
    }
}
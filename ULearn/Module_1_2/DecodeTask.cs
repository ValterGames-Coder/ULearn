namespace ULearn.Module_1_2;

public class DecodeTask
{
    static string Decode(string number)
    {
        string newNumber = "";
        foreach (char c in number)
        {
            if (c != '.')
            {
                newNumber += c;
            }
        }

        int decodeNumber = int.Parse(newNumber) % 1024;
        return decodeNumber.ToString();
    }
}
namespace ULearn.Module_1_5;

public enum Suits
{
    Wands,
    Coins,
    Cups,
    Swords
}

public class GetSuitTask
{
    public static string GetSuit(Suits suit)
    {
        return new string[] { "жезлов", "монет", "кубков", "мечей" }[suit.GetHashCode()];
    }
}
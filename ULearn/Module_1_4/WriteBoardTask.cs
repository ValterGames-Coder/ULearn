namespace ULearn.Module_1_4;

public class WriteBoardTask
{
    public static void WriteBoard(int size)
    {
        string board = "";
        for (int i = 0; i < size; i++)
        {
            string line = i % 2 == 0 ? "#" : ".";
            for (int j = 0; j < size - 1; j++) 
                line += i % 2 == 0 ? (j % 2 == 0 ? "." : "#") : (j % 2 == 0 ? "#" : ".");
            board += $"{line}\n";
        }
        Console.WriteLine(board);
    }
}
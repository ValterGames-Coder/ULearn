namespace ULearn.Module_1_3;

public class TheQueenTask
{
    public static bool IsCorrectMove(string from, string to)
    {
        var dx = Math.Abs(to[0] - from[0]); //смещение фигуры по горизонтали
        var dy = Math.Abs(to[1] - from[1]); //смещение фигуры по вертикали
        Console.WriteLine($"{dx} : {dy}");
        return (dx == dy || dx == 0 || dy == 0) && dx + dy > 0;
    }
}
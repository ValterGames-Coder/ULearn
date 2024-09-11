namespace ULearn.Module_1_5;

public enum Mark
{
    Empty,
    Cross,
    Circle
}

public enum GameResult
{
    CrossWin,
    CircleWin,
    Draw
}

public class TicTacToeTask
{
    public static GameResult GetGameResult(Mark[,] field)
    {
        if(HasWinSequence(field, Mark.Cross) == HasWinSequence(field, Mark.Circle))
            return GameResult.Draw;
        if(HasWinSequence(field, Mark.Cross))
            return GameResult.CrossWin;
        return GameResult.CircleWin;
    }

    private static bool HasWinSequence(Mark[,] field, Mark mark)
    {
        for (int i = 0; i < 3; i++)
        {
            if (mark == field[i, 0] && field[i, 1] == mark && field[i, 2] == mark) return true;
            if (mark == field[0, i] && field[1, i] == mark && field[2, i] == mark) return true;
        }
        return (mark == field[0, 0] && field[1, 1] == mark && field[2, 2] == mark) || 
               (mark == field[0, 2] && field[1, 1] == mark && field[2, 0] == mark);
    }
}
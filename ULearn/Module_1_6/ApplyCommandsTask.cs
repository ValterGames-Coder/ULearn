using System.Text;

namespace ULearn.Module_1_6;

public class ApplyCommandsTask
{
    public static string ApplyCommands(string[] commands)
    {
        StringBuilder msg = new StringBuilder();
        foreach (var command in commands)
        {
            if (command.Contains("push"))
                msg.Append(command.Substring(5));
            else
                msg.Remove(msg.Length - int.Parse(command.Split(' ')[1]), int.Parse(command.Split(' ')[1]));
        }
        return msg.ToString();
    }
}
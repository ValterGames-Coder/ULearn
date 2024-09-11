namespace ULearn.Module_1_3;

public class ShouldFireTask
{
    public static bool ShouldFire2(bool enemyInFront, string enemyName, int robotHealth)
    {
        return enemyInFront && enemyName == "boss" && !(robotHealth < 50) && robotHealth > 100;
    }
}
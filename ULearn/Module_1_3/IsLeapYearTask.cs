namespace ULearn.Module_1_3;

public static class IsLeapYearTask
{
    public static bool IsLeapYear(int year)
    {
        //return (year % 1000 == 400 || year % 100 != 0) && year % 4 == 0;
        //return year % 100 != 0 && year % 4 == 0;
        return year % 400 == 0 || year % 100 != 0 && year % 4 == 0;
    }
}
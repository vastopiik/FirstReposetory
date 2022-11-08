namespace HW13;

public static class ExtensionsMethod
{
    public static int ToInt(this bool b) => Convert.ToInt32(b); 

    public static DateTime ToDate(this string str) => Convert.ToDateTime(str);

    public static int ToInt(this double d) => Convert.ToInt32(d); 
}

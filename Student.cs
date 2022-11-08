namespace HW13;

public class Student
{
    public void A1(string a1, int a2) => Console.WriteLine("A1" + a1 + " " + a2);
    public void A2(string a1, int a2) => Console.WriteLine("A2" + a1 + " " + a2);
    public void A3(string a1, int a2) => Console.WriteLine("A2" + a1 + " " + a2);

    public string F1(int f1, double f2) => "F1" + f1.ToString();
    public string F2(int f1, double f2) => "F2" + f1.ToString();
    public string F3(int f1, double f2) => "F3" + f1.ToString();

    public bool P1(int p) => Convert.ToBoolean(p);
    public bool P2(int p) => Convert.ToBoolean(p);
    public bool P3(int p) => Convert.ToBoolean(p);
}

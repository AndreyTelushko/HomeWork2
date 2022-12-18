public static class Program
{
    public static void Center()
    {
        string a = Console.ReadLine();
        if (a.Length == 3)
        {       
            Console.WriteLine(a[1]);
        }
        else
        {
            Console.WriteLine("Не трехзначное число!!!");
        }
    }
    public static void Main()
    {
        Center();
    }
}
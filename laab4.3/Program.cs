class Program
{
    static double Method(double k)
    {
      double m = k + 1 / 13.0;
      return m;
    }

    static double Result(double k)
    {
    if(k==-1)
    {
            return 1;
    }
    else
    {
            return Method(k) * Result(k - 1);
    }
}
    static void Main(string[] args)
    {
        int k = Convert.ToInt32(Console.ReadLine());
        double m = Result(k);
        Console.WriteLine(m);
        Console.ReadKey();
    }
}

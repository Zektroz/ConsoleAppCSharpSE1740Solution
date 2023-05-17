namespace ConsoleAppCSharpSE1740;

public class Program
{
    public static void Main(string[] args)
    {
        int a = 10; double b = 20.5; int c = 30;
        Console.WriteLine($"Sum = {Add(a,b,c)}");
        Console.WriteLine($"Tong cac so chan tu 1 den 100 la: {Sum(100)}");
        Console.WriteLine($"Tong cac so tu 1 den 100 la: {Total(100)}");
        Console.WriteLine($"Factorial: {CalFactorial(8)}");
        Console.WriteLine($"Fibonacci: {CalFibonacci(8)}");
        Console.ReadKey();
    }

    public static int Add(params int[] x)
    {
        int sum = 0;
        foreach(int i in x) { sum += i; }
        return sum;
    }
    //method overloading
    public static double Add(params double[] x)
    {
        double sum = 0;
        foreach (double i in x) { sum += i; }
        return sum;
    }
    public static double Add(int x, int y, double z) => Add(Add(x, y), z);
    //lambda expression
    /*
     * Required: 
     * - Sum of serials (even/odd): 1+2+3+...+n?
     *  + loop
     *  + recursion?
    */
    public static long Sum(int n)
    {
        long total = 0;
        int i = 1;
        while (i <= n)
        {
            if (i % 2 == 0) total += i;//total = total + i;
            i++;//i = i + 1; unary
            
        }
        return total;
    }

    //de quy
    public static long Total(int n)
    {
        if(n == 0 || n == 1) return n;
        else
        return n + Total(n-1);
    }

    //HomeWork dequy n! & Fibonacci

    public static int CalFactorial(int n)
    {
        if (n == 0 || n == 1) return 1;
        else
        return n * CalFactorial(n-1);
    }
    public static int CalFibonacci(int n)
    {
        if (n == 0) return n + 1;
        else if (n == 1 || n == 2) return n;
        else
            return CalFibonacci(n - 1) + CalFibonacci(n - 2);
    }
}
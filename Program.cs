using System;

namespace _3._14
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToInt32(Console.ReadLine());
            double b = Convert.ToInt32(Console.ReadLine());
            double af = Math.Sqrt(a * a);
            double bf = Math.Sqrt(b * b);
            double ag = Math.Truncate(af);
            double bg = Math.Truncate(bf);
            int ah = ag.ToString().Length;
            int bh = bg.ToString().Length;
            double ac = ag / Math.Pow(10, ah - 1);
            double bc = bg / Math.Pow(10, bh - 1);
            double nn = Math.Truncate(ac);
            double mm = Math.Truncate(bc);
            double sum = nn + mm;
            Console.WriteLine(sum);
        }
    }
}

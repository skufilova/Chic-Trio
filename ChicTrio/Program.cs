namespace ChicTrio
{
    internal class Program
    {
        static void CheckFermat(int a, int b, int c, int n)
        {
            if (n > 2)
            {
                if (Math.Pow(a, n) + Math.Pow(b, n) == Math.Pow(c, n))
                {
                    Console.WriteLine($"Существует целое решение для {a}^{n} + {b}^{n} = {c}^{n}");
                }
                else
                {
                    Console.WriteLine($"Нет целого решения для {a}^{n} + {b}^{n} = {c}^{n}");
                }
            }
        }

        static void Main(string[] args)
        {
            CheckFermat(3, 4, 5, 3);
        }
    }
}
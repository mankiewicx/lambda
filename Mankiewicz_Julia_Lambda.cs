using System.Linq.Expressions;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            Expression<Func<int>> sum = () => 1 + a + 3 + 4;
            Func<int> wynik = sum.Compile();
            Console.WriteLine(wynik());
        }
    }
}

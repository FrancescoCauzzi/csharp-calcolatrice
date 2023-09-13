using static System.Console;
namespace csharp_calcolatrice
{

    internal partial class Program
    {
        static void Main(string[] args)
        {
            var test1 = CalcoliHelper.Sum(8, 7.5);
            WriteLine(test1);





            var test2 = CalcoliHelper.Sub(8, 7.5);
            WriteLine(test2);

            var test3 = CalcoliHelper.Mult(8, 7.5);
            WriteLine(test3);

            var test12 = CalcoliHelper.MultRecursive(3, 4);
            WriteLine($"test12: {test12}");

            var test4 = CalcoliHelper.Absolute(-7.5);
            WriteLine(test4);
            var test5 = CalcoliHelper.Absolute(-45);
            WriteLine(test5);
            WriteLine();
            var test6 = CalcoliHelper.Max(-34.5, 54);
            WriteLine(test6);
            WriteLine();
            var test7 = CalcoliHelper.Min(-34.5, 54);
            WriteLine(test7);
            WriteLine();
            // Bonus
            var test8 = CalcoliHelper.Elevate(2, 8);
            WriteLine(test8);
            WriteLine();
            var test10 = CalcoliHelper.ElevateNoMath(2, -8);
            WriteLine($"test10: {test10}");
            WriteLine();
            var test11 = CalcoliHelper.ElevateRecursive(2, -8);
            WriteLine($"test11: {test11}");
            WriteLine();
            // Super Bonus
            var test9 = CalcoliHelper.SumGenerics(21, 22);
            WriteLine(test9);

            ReadKey();
        }
    }
}
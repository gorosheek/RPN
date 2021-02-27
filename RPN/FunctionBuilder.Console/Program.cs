
namespace FunctionBuilder.Console
{
    using System;
    using FunctionBuilder.Logic;

    class Program
    {
        static void Main()
        {
            Console.WriteLine(new Calculator("|1,5 * (1 + 6)|").Answer);
        }
    }
}

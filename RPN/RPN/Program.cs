using System;
using System.IO;
using System.Collections.Generic;

namespace FunctionBuilder.Console
{   
    class Program
    {
        static void Main()
        {
            Calculator calc = new Calculator("|1,5*(10+6)|");
            Console.WriteLine(calc.Answer);
        }
    }
} 
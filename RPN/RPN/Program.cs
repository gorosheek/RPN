using System;
using System.IO;
using System.Collections.Generic;

namespace RPN
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
// файл:
// 1. функция
// 2. шаг
// 3. Диапозон
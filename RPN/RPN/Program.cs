using System;
using System.IO;
using System.Collections.Generic;

namespace RPN
{   
    
    class Calculator
    {          
        bool CheckDigit(string str)
        {
            if (CheckBracket(str) && CheckMulDev(str) && CheckPlusMinus(str)) return false;
            else return true;
        }
        bool CheckMulDev(string op)
        {
            if (op == "*" || op == "/") return true;
            else return false;
        }
        bool CheckPlusMinus(string op)
        {
            if (op == "+" || op == "-") return true;
            else return false;
        }
        bool CheckBracket(string op)
        {
            if (op == "(" || op == ")") return true;
            else return false;
        }

        public void ConvertToRPN(string func)
        {
            Stack<string> outputStr = new Stack<string>();
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < func.Length; i++)
            {
                if (CheckDigit(func[i].ToString()) == false)
                {
                    outputStr.Push(func[i].ToString());
                }
                else if (CheckMulDev(func[i].ToString()))
                {
                    if (stack.Count != 0)
                    {
                        char op = stack.Peek();
                        if (op == func[i])
                        {
                            outputStr.Push(stack.Pop().ToString());
                        }
                    }
                    stack.Push(func[i]);                                        
                }
                else if (CheckPlusMinus(func[i].ToString()))
                {
                    if (stack.Count != 0)
                    {
                        char op = stack.Peek();
                        if (CheckBracket(op.ToString()))
                        {
                            stack.Push(func[i]);
                        }
                        else
                        {

                        }
                    }
                }
            }

        }
    }
    class Program
    {
        static void Main()
        {
            Calculator cal = new Calculator();
            cal.ConvertToRPN("5");
        }
    }
}
// файл:
// 1. функция
// 2. шаг
// 3. Диапозон
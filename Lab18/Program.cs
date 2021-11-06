using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab18
{
    class Program
    {
        static void Main(string[] args)
        {
            string brackets = "a{b[]{cd}t(0)}";
            Stack<char> stackBrackets = new Stack<char>();
            char[] arr = brackets.ToCharArray();
            try
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == '{')
                    {
                        stackBrackets.Push('}');
                    }
                    else if (arr[i] == '[')
                    {
                        stackBrackets.Push(']');
                    }
                    else if (arr[i] == '(')
                    {
                        stackBrackets.Push(')');
                    }
                    else if (arr[i] == '}')
                    {
                        if (stackBrackets.Peek() == '}')
                        {
                            stackBrackets.Pop();
                        }
                    }
                    else if (arr[i] == ')')
                    {
                        if (stackBrackets.Peek() == ')')
                        {
                            stackBrackets.Pop();
                        }
                    }
                    else if (arr[i] == ']')
                    {
                        if (stackBrackets.Peek() == ']')
                        {
                            stackBrackets.Pop();
                        }
                    }
                }
                if (stackBrackets.Count() > 0)
                {
                    Console.WriteLine("Скобки расставлены некорректно! (количество открывающих больше количества закрывающих либо использован разный тип скобок)");
                }
                else
                {
                    Console.WriteLine("Скобки расставлены корректно");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Скобки расставлены некорректно! (количество закрывающих больше открывающих)");
            }
            Console.ReadKey();
        }
    }
}


using System;
using System.Collections.Generic;

namespace RPNCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string rpn = Console.ReadLine();
            Console.WriteLine(CalculateResult(rpn));
        }

        static decimal CalculateResult(string rpn)
        {
            string[] elements = rpn.Split(' ');
            var stack = new Stack<decimal>();
            decimal num = 0;

            foreach (string e in elements)
            {
                if (decimal.TryParse(e, out num))
                {
                    stack.Push(num);
                }
                else
                {
                    switch (e)
                    {
                        case "+":
                            {
                                stack.Push(stack.Pop() + stack.Pop());
                                break;
                            }
                        case "-":
                            {
                                num = stack.Pop();
                                stack.Push(stack.Pop() - num);
                                break;
                            }
                        case "*":
                            {
                                stack.Push(stack.Pop() * stack.Pop());
                                break;
                            }
                        case "/":
                            {
                                num = stack.Pop();
                                stack.Push(stack.Pop() / num);
                                break;
                            }
                        default:
                            Console.WriteLine("Invalid operator");
                            break;
                    }
                }

            }

            return stack.Pop();
        }
    }
}

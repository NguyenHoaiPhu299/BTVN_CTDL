using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3
{
    internal class Bai1
    {
        static int GetPrecedence(char op)
        {
            switch (op)
            {
                case '+': return 1;
                    break;
                case '-': return 1;
                    break;
                case '*': return 2;
                    break;
                case '/': return 2;
                    break;
                case '^': return 3;
                    break;
                default: return 0;
            }
        }
        static string InfixToPostfixConversion(string infixExpression)
        {
            string postfix = "";
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < infixExpression.Length; i++)
            {
                if (char.IsLetterOrDigit(infixExpression[i]))
                {
                    postfix += infixExpression[i];
                }
                else if (infixExpression[i] == '(')
                {
                    stack.Push(infixExpression[i]);
                }
                else if (infixExpression[i] == ')')
                {
                    while (stack.Count > 0 && stack.Peek() != '(')
                    {
                        postfix += stack.Pop();
                    }
                    if (stack.Count > 0 && stack.Peek() != '(')
                    {
                        return "Invalid Expression";
                    }
                    else
                    {
                        while (stack.Count > 0 && GetPrecedence(infixExpression[i]) <= GetPrecedence(stack.Peek()))
                        {
                            postfix += stack.Pop();
                        }
                        stack.Push(infixExpression[i]);
                    }
                }
            }
            while (stack.Count > 0)
                postfix += stack.Pop();
            return postfix;
        }
        static void Main(string[] args)
        {
            string infixExpression = "a+b*(c^d-e)^(f+g*h)-i";
            string postfixExpression = InfixToPostfixConversion(infixExpression);
            Console.WriteLine("Infix Expression: " + infixExpression);
            Console.WriteLine("Postfix Expression: " + postfixExpression);
        }
    }
}

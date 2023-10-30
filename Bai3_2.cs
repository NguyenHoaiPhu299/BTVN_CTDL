using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Bai2
    {
        static int Priority(char op)
        {
            if (op == '+' || op == '-')
                return 1;
            else if (op == '*' || op == '/')
                return 2;
            else if (op == '^')
                return 3;
            else return -1;
        }
        static void process_op(Stack<int> val, char op)
        {
            int r = val.Peek(); val.Pop();
            int l = val.Peek(); val.Pop();

            switch (op)
            {
                case '+': val.Push(l + r); break;
                case '-': val.Push(l - r); break;
                case '*': val.Push(l * r); break;
                case '/': val.Push(l / r); break;
            }
        }
        
        static int evalute (string s)
        {
            Stack<int> val = new Stack<int>();
            Stack<char> op = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]))
                {
                    int number = 0;
                    while (i < (int)s.Length && char.IsDigit(s[i]))
                    {
                        number = number * 10 + s[i] - '0';
                        ++i;
                    }
                    val.Push(number);
                    --i;
                }
                else
                {
                    char cur_op = s[i];
                    while (op.Count > 0 && Priority(op.Peek()) >= Priority(cur_op))
                    // xử lý các toán tử ngay trước nó có độ ưu tiên bằng hoặc lớn hơn
                    // chú ý rằng nếu thay dấu >= bằng dáu > thì đápđáp
                    {
                        process_op(val, op.Peek());
                        op.Pop();
                    }
                    op.Push(cur_op);
                }
            }
            while (op.Count > 0)
            {
                process_op(val, op.Peek());
                op.Pop();
            }
            return val.Peek();
        }
        static void Main(string[] args)
        {
            string s = "2*3+6/2";
            Console.WriteLine(evalute(s));
        }
    }
}

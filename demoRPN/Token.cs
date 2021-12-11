using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoRPN
{
    public class Token
    {
        public static int GetPriority(char op)
        {
            if (op == '*' || op == '/' || op == '%')
                return 2;
            if (op == '+' || op == '-')
                return 1;
            return 0;
        }
        public static bool IsNumber(char str)
        {
            if ((str > 57) || (str < 48))
                return false;
            return true;
        }
        public static bool IsOperator(char str)
        {
            if ((str == '+') || (str == '-') || (str == '*') || (str == '/'))
                return true;
            else return false;
        }
    }
}

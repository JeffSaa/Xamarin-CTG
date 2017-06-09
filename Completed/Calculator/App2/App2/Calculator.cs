using System;
using System.Collections.Generic;
using System.Text;

namespace App2
{
    class Calculator
    {
        int x, y, op;

        public Calculator()
        {
            x = y = op = -1;
        }

        public void clear() {
            x = y = op = -1;
        }

        public int addValue(String value)
        {
            if (x != -1 && y != -1 && op != -1)
                clear();
            switch (value)
            {
                case "+":
                    op = 1;
                    break;
                case "-":
                    op = 0;
                    break;
                default:
                    if (x == -1)
                        x = int.Parse(value);
                    else
                        y = int.Parse(value);
                    break;
            }
            if(x != -1 && y != -1 && op != -1)
            {
                if (op == 1)
                    return x + y;
                else
                    return x - y;
            }
            else
            {
                return 0;
            }
        }

    }
}

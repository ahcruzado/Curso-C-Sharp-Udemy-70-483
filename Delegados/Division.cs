using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados
{
    public class Division
    {
        public Action<int, int> MessageHanlder;
        public int Divide(int a, int b)
        {
            int result = 0;
            if (b==0)
            {
                MessageHanlder(a, b);
            }
            else
            {
                result= a / b;
            }

            return result;
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_Sharp_Udemy_70_483
{
    public class OrdenarDesc : IComparer
    {
        public int Compare(object x, object y)
        {
            return new CaseInsensitiveComparer().Compare( y,x);
        }
    }
}

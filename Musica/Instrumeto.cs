using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musica
{
    public  abstract class Instrumeto
    {

        public abstract string Tocar();

    }

    public class Guitarra: Instrumeto
    {
        public Guitarra()
        {

        }

        public override string Tocar()
        {
            return "Guitarra";
        }

    }

    public class Violin : Instrumeto
    {
        public override string Tocar()
        {
            return "Violin";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoja_de_trabajo_Métodos
{
    public class Divisor
    {

        public int numero;
        public void Division()
        {
            
            for(int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    Console.WriteLine(i + " ");
                }
            }

            
        }














    }
}

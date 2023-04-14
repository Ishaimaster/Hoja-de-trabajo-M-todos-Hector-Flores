using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoja_de_trabajo_Métodos
{
    public class electrodom
    {
        
            
        //Constructor
        public double precio;
        public string consumo;
        public string color;
        public double peso;
        public double preciofinal;
    

        public double Consumoenergia()
        {

            switch (consumo)
            {
                case "A":

                    preciofinal = precio + 100;

                    break;
                case "B":

                    preciofinal = precio + 80;

                    break;

                case "C":

                    preciofinal = precio + 60;

                    break;

                case "D":

                    preciofinal = precio + 50;

                    break;

                    
            }
            return preciofinal;


        }


    public double Pesoprecio()
    {
        if (peso >= 20 && peso < 40)
        {
            preciofinal = preciofinal + (precio * 0.05);

        }
        else if (peso >= 40)
        {
                preciofinal = preciofinal + (precio * 0.10);

        }

            return preciofinal;



    }

}
}

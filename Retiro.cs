using System;
using System.Collections.Generic;
using System.Text;

namespace PrimerParcial
{
    public class Retiro  : MenuDispensacion , Interface1
    {
        ServicioDispensacion service = new ServicioDispensacion();

        public  Retiro() : base ()
        {
         
        }
        public void Read() 
        {

            Console.Clear();
            Console.Write("Digite la cantidad que desea retirar: ");
            
            int monto = Convert.ToInt32(Console.ReadLine());

            service.DispensingMode(dispensingMode, monto);

        }

       
    }
}

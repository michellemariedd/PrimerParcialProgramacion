using System;
using System.Collections.Generic;
using System.Text;

namespace PrimerParcial
{
    public class MenuPrincipal
    {
        enum Opciones 
        {
            DISPENSACION = 1 ,
            RETIRO,
            EXIT
        }
         
        public void ImprimirMenu() 
        {
            MenuDispensacion dispensacion = new MenuDispensacion();
            Interface1 retiro = new Retiro();

            try
            {
                Console.Clear();
                Console.WriteLine("*****************Cajero automático****************");
                Console.WriteLine();
                Console.WriteLine(" 1-Modo dispensación\n 2-Retiro \n 3-Salir ");
                int Opcion = Convert.ToInt32(Console.ReadLine());

                switch (Opcion)
                {
                    case (int)Opciones.DISPENSACION:
                        dispensacion.ImprimirMenu();
                        break;
                    case (int)Opciones.RETIRO:
                        retiro.Read();
                        break;
                    case (int)Opciones.EXIT:
                        Console.WriteLine("Gracias por utilizar el sistema.");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Debe introducir una opcion valida.");
                        Console.ReadKey();
                        ImprimirMenu();
                        break;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Debe introducir una opcion valida");
                Console.ReadKey();
                ImprimirMenu();
            }
        
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisOPP
{
    class Menu
    {
        public int Menus()
        {
            Operadores operadores = new Operadores();
            Condicionales condicionales = new Condicionales();
            Ciclos ciclos = new Ciclos();

            int MenuPrin;
            try
            {
                Console.WriteLine("Menú Miscelánea:");
                Console.WriteLine("-------------------");
                Console.WriteLine("1.Operadores");
                Console.WriteLine("2.Condicionales");
                Console.WriteLine("3.Ciclos");
                Console.WriteLine("99.Salir del Programa");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Valor Incorrecto \nIngresé un valor numérico");
                Retorno.Volver();
            }
            
            MenuPrin = int.Parse(Console.ReadLine());
            switch (MenuPrin)
            {

                case 1:
                    operadores.MenuOperadores();
                    Retorno.Volver();
                    break;

                case 2:
                    condicionales.MenuCondicionales();
                    Retorno.Volver();
                    break;

                case 3:
                    ciclos.MenuCiclos();
                    Retorno.Volver();
                    break;

                case 99:
                    Environment.Exit(1);
                    break;

            }
            return 0;
        }
    }
}
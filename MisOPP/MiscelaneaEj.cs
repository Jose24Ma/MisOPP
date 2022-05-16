using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisOPP
{
    class MiscelaneaEj
    {
        public static void Main(string[] args)
        {
            Menu menu = new Menu();
            try
            {
                menu.Menus();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Valor Incorrecto \nIngrese un valor numerico");
            }
            String RespuestContinuar = null;
            do
            {
                Console.WriteLine("\n¿Desea seguir usar el programa? SI/NO");
                RespuestContinuar = Console.ReadLine();
                if ((RespuestContinuar == "SI") || (RespuestContinuar == "si"))
                {
                    Console.Clear();
                    Menu menus = new Menu();
                    menus.Menus();
                }
                else if ((RespuestContinuar == "NO") || (RespuestContinuar == "no"))
                {
                    Console.Clear();
                    Console.WriteLine("Salio del programa :");
                    Environment.Exit(1);
                }
            } while ((RespuestContinuar == "SI") && (RespuestContinuar == "NO"));

        }
    }
    class Retorno
    {
        public static void Volver()
        {
            String RespuestContinuar = null;
            do
            {
                Console.WriteLine("\n¿Desea seguir usar el programa? SI/NO");
                RespuestContinuar = Console.ReadLine();
                if ((RespuestContinuar == "SI") || (RespuestContinuar == "si"))
                {
                    Console.Clear();
                    Menu menu = new Menu();
                    menu.Menus();
                }
                else if ((RespuestContinuar == "NO") || (RespuestContinuar == "no"))
                {
                    Console.Clear();
                    Console.WriteLine("Salio del programa :");
                    Environment.Exit(1);
                }
            } while ((RespuestContinuar == "SI") && (RespuestContinuar == "NO"));

        }
    }
}
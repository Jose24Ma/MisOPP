using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisOPP
{
    class Ciclos
    {
        public double MenuCiclos()
        {
            EjerciciosCi ejercicios = new EjerciciosCi();
            int opcion3;
            try
            {
                Console.WriteLine("Menu Ciclos:");
                Console.WriteLine("-------------------");
                Console.WriteLine("1.Multiplos de 3 entre 1 y 100");
                Console.WriteLine("2.Impares entre 0 y 100");
                Console.WriteLine("3.Pares entre 1 a 100");
                Console.WriteLine("4.Cuadrados Numeros del 1 al 30");
                Console.WriteLine("5.Suma de cuadrados");
                Console.WriteLine("6.Secuencia Ascendente");
                Console.WriteLine("7.Suma de numeros");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Valor Incorrecto \nIngrese un valor numerico");
                Retorno.Volver();
            }

            opcion3 = int.Parse(Console.ReadLine());
            switch (opcion3)
            {
                case 1:
                    ejercicios.MultiplosxTres();
                    break;
                case 2:
                    ejercicios.ImparesN();
                    break;
                case 3:
                    ejercicios.ParesN();
                    break;
                case 4:
                    ejercicios.NumerosxCuadrados();
                    break;
                case 5:
                    ejercicios.SumaxCuadrados();
                    break;
                case 6:
                    ejercicios.SecuenciaxAscendente();
                    break;
                case 7:
                    ejercicios.SumaEnterosIn();
                    break;
            }
            return 0;
        }
        class EjerciciosCi
        {
            private double num1 = 0.0;
            private double num2 = 0.0;
            private double num3 = 0.0;
            private double num4 = 0.0;

            public double MultiplosxTres()
            {

                do
                {
                    Console.WriteLine("Los multiplos son: " + num3);
                    num3 = num3 + 3;
                    num1 = num1 + 1;
                }
                while (num3 < 100);
                Console.WriteLine("El total de Multiplos son: " + num1);
                return 0.0;
            }
            public double ImparesN()
            {

                for (num1 = 1; num1 <= 100; num1++)
                {
                    if (num1 % 2 != 0)
                    {
                        Console.WriteLine(num1);
                        num2++;
                    }
                }
                return 0.0;
            }

            public double ParesN()
            {

                for (num1 = 2; num1 <= 100; num1 += 2)
                {
                    Console.WriteLine(num1);
                }
                return 0.0;
            }

            public double NumerosxCuadrados()
            {
                for (num1 = 1; num1 <= 30; num1++)
                {
                    double elevadoAlCuadrado = Math.Pow(num1, 2);
                    Console.WriteLine("Proceso " + num1 + "^2 = " + elevadoAlCuadrado);

                }
                return 0.0;
            }
            public double SumaxCuadrados()
            {
                num1 = 0;
                for (num2 = 1; num2 <= 100; num2++)
                {
                    Console.WriteLine("Proceso " + num2);
                    num1 = num2 * num2;
                }
                Console.WriteLine("Valor de la suma : " + num1);
                return 0.0;
            }
            public double SecuenciaxAscendente()
            {
                Console.WriteLine("Digite el primer numero: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite el segundo numero: ");
                num2 = Convert.ToDouble(Console.ReadLine());
                for (num3 = num1 + 1; num3 < num2; num3++)
                {
                    Console.WriteLine("Los numeros comprendidos entre " + num1 + " y " + num2 + " son :");
                    Console.WriteLine(num3);
                }
                return 0.0;
            }
            public double SumaEnterosIn()
            {

                do
                {
                    Console.WriteLine("Ingrese un valor (0 para finalizar) :");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    num2 = num1;
                    if (num2 != 0)
                    {
                        num3 = num3 + num2;
                        num4++;

                    }
                    else
                    {
                        Console.WriteLine("No se ingresan mas valores");
                    }
                } while (num2 != 0);
                Console.WriteLine("La suma total es :" + num3);
                return 0.0;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisOPP
{
    class Condicionales
    {
        public double MenuCondicionales()
        {
            EjerciciosCon ejercicios = new EjerciciosCon();
            int opcion2;
            try
            {
                Console.WriteLine("Menu Condicionales:");
                Console.WriteLine("-------------------");
                Console.WriteLine("1.Positivo o Negativo");
                Console.WriteLine("2.Mayor y Menor");
                Console.WriteLine("3.3 Numeros enteros (Mayor y Menor");
                Console.WriteLine("4.Suma o Resta entre A y B");
                Console.WriteLine("5.Cociente entre A y B");
                Console.WriteLine("6.Suma o Multiplicacion entre A y B");
                Console.WriteLine("7.Año bisiesto o no");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Valor Incorrecto \nIngrese un valor numerico");
                Retorno.Volver();
            }

            opcion2 = int.Parse(Console.ReadLine());
            switch (opcion2)
            {
                case 1:
                    ejercicios.NegativoPositivo();
                    break;
                case 2:
                    ejercicios.MayorMenor();
                    break;
                case 3:
                    ejercicios.MayorMenorTres();
                    break;
                case 4:
                    ejercicios.SumaRestaMenor();
                    break;
                case 5:
                    ejercicios.Cociente();
                    break;
                case 6:
                    ejercicios.NegPos();
                    break;
                case 7:
                    ejercicios.AñoBisiesto();
                    break;
            }
            return 0;
        }
        class EjerciciosCon
        {
            private double num1 = 0.0;
            private double num2 = 0.0;
            private double num3 = 0.0;
            private double num4 = 0.0;
            private double num5 = 0.0;
            public double NegativoPositivo()
            {
                Console.WriteLine("Ingrese el numero: ");
                num1 = float.Parse(Console.ReadLine());
                if (num1 > 0)
                {
                    Console.WriteLine("El numero ingresado es positivo");
                }
                if (num1 < 0)
                {
                    Console.WriteLine("El numero ingresado es negativo");
                }
                return 0.0;
            }

            public double MayorMenor()
            {
                Console.WriteLine("Digite el 1er numero");
                num1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite el 2do numero");
                num2 = float.Parse(Console.ReadLine());
                if (num1 > num2)
                {
                    Console.WriteLine(num1 + " Es mayor que " + num2);
                }
                else
                {
                    Console.WriteLine(num2 + " Es mayor que " + num1);
                }
                return 0.0;
            }
            public double MayorMenorTres()
            {
                Console.WriteLine("Digite el 1er numero");
                num1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite el 2do numero");
                num2 = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite el 3er numero");
                num3 = float.Parse(Console.ReadLine());
                num4 = num1;
                if (num2 > num4)
                    num4 = num2;
                if (num3 > num4)
                    num4 = num3;
                Console.WriteLine("El numero mayor es:" + num4);
                num5 = num1;
                if (num2 < num5)
                    num5 = num2;
                if (num3 < num5)
                    num5 = num3;
                Console.WriteLine("El numero menor es:" + num5);
                return 0.0;
            }

            public double SumaRestaMenor()
            {

                Console.WriteLine("Digite el 1er numero");
                num1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite el 2do numero");
                num2 = float.Parse(Console.ReadLine());
                if (num1 < num2)
                {
                    num3 = num1 + num1;
                    Console.WriteLine("A es menor que B el resultado de la suma es :" + num3);
                }
                else
                {
                    if (num1 > num2)
                    {
                        num4 = num1 - num2;
                        Console.WriteLine("A es mayor que B \nEl resultado de la resta es :" + num4);
                    }

                }
                return 0.0;
            }
            public double Cociente()
            {

                Console.WriteLine("Ingrese el dividendo :");
                num1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese le divisor :");
                num2 = float.Parse(Console.ReadLine());
                if (num1 > 0 && num2 > 0)
                {
                    num3 = num1 / num2;
                    Console.WriteLine("El cociente entre entre A y B es :" + num3);
                }
                else
                {
                    if (num1 <= 0 || num2 <= 0)
                    {
                        Console.WriteLine("la division no es posible");
                    }
                }
                return 0.0;
            }

            public double NegPos()
            {

                num1 = 0;
                Console.WriteLine("Ingrese 1er numero");
                num2 = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el 2do numero");
                num3 = float.Parse(Console.ReadLine());
                if (num2 < 0)
                {
                    num1 = num2 + num3;
                    Console.WriteLine("El numero es negativo \n El resultado de la suma :" + num1);
                }
                else
                {
                    if (num2 > 0)
                        num1 = num2 * num3;
                    Console.WriteLine("El numero es positivo \n El resultado de la multiplacion :" + num1);

                }
                return 0.0;
            }

            public double AñoBisiesto()
            {

                Console.WriteLine("Ingrese el año :");
                num1 = Convert.ToDouble(Console.ReadLine());
                bool esBisiesto = DateTime.IsLeapYear((int)num1);
                Console.WriteLine("¿El año es bisiesto? : " + esBisiesto);
                return num1;

            }
        }
    }
}
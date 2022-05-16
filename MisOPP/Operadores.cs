using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisOPP
{
    class Operadores
    {
        public double MenuOperadores()
        {
            EjerciciosOp ejercicios = new EjerciciosOp();

            int opcion1;
            try
            {
                Console.WriteLine("Menú de Operadores:");
                Console.WriteLine("-------------------");
                Console.WriteLine("1.Área Triángulo");
                Console.WriteLine("2.Suma 2 Enteros");
                Console.WriteLine("3.Elevación al Cuadrado");
                Console.WriteLine("4.Conversión Euros a Dolares");
                Console.WriteLine("5.Valor área y perimetro (Cuadrado)");
                Console.WriteLine("6.Área y Volumen (Cilindro)");
                Console.WriteLine("7.Área de una circunferencia");
                Console.WriteLine("8.Promedio de 3 Num.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Valor Incorrecto \nIngresé un valor numérico");
                Retorno.Volver();
            }

            opcion1 = int.Parse(Console.ReadLine());
            switch (opcion1)
            {
                case 1:
                    ejercicios.AreaTriangulo();
                    break;
                case 2:
                    ejercicios.SumaEnteros();
                    break;
                case 3:
                    ejercicios.PotenciaNum();
                    break;
                case 4:
                    ejercicios.ConversionExD();
                    break;
                case 5:
                    ejercicios.AreaPerimetroCua();
                    break;
                case 6:
                    ejercicios.AreaVolumen();
                    break;
                case 7:
                    ejercicios.AreaCirculo();
                    break;
                case 8:
                    ejercicios.Promedio();
                    break;
            }
            return 0;
        }
        class EjerciciosOp
        {
            private double num1 = 0.0;
            private double num2 = 0.0;
            private double num3 = 0.0;
            private double num4 = 0.0;
            
            
            public double AreaTriangulo()
            {
                Console.WriteLine("Calcular Area Triangulo ");
                Console.WriteLine("Ingrese la base : ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese la altura : ");
                num2 = Convert.ToDouble(Console.ReadLine());
                num4 = num1 * num2 / 2;
                Console.WriteLine("El resultado del area es:" + num4);
                return 0.0;
            }
            public double SumaEnteros()
            {
                Console.WriteLine("Escriba dos numeros enteros: ");
                Console.WriteLine("Ingrese 1er entero : ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese 2do entero: ");
                num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("El resultado de la suma:" + num3);
                num3 = num1 + num2;
                return 0.0;

            }
            public double PotenciaNum()
            {
                Console.WriteLine("Ingrese el numero : ");
                num1 = Convert.ToDouble(Console.ReadLine());
                double elevadoAlCuadrado = Math.Pow(num1, 2);
                Console.WriteLine(string.Format("{0} elevado al cuadrado es {1}", num1, elevadoAlCuadrado));
                return 0.0;
            }
            public double ConversionExD()
            {

                Console.WriteLine("Ingrese la cantidad de euros : ");
                num1 = double.Parse(Console.ReadLine());
                num2 = num1 * 1.06;
                Console.WriteLine("El resultado de la conversion: " + num2);
                return 0.0;
            }
            public double AreaPerimetroCua()
            {
                Console.WriteLine("Ingrese el lado del cuadrado: ");
                num1 = float.Parse(Console.ReadLine());
                num3 = num1 * 4;
                num4 = num1 * num1;
                Console.WriteLine("El perimetro es :" + num3);
                Console.WriteLine("El area es :" + num4);
                return 0.0;
            }
            public double AreaVolumen()
            {
                Console.Write("Ingresa el valor de altura: ");
                num1 = double.Parse(Console.ReadLine());
                Console.Write("Ingresa el valor de radio: ");
                num2 = double.Parse(Console.ReadLine());
                num3 = Math.PI * num2 * num2 * num2;
                num4 = 2.0 * Math.PI * num2 * (num2 + num1);
                Console.WriteLine("Valor de area: " + num4);
                Console.WriteLine("Valor de volumen: " + num3);
                return 0.0;
            }

            public double AreaCirculo()
            {
                Console.WriteLine("Ingrese el numero del Diametro");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("El radio es:" + CircunferenciaEnteros(num1));
                static double CircunferenciaEnteros(double num1)
                {
                    return Convert.ToDouble(num1 / 2);
                }
                Console.WriteLine("La longitud es:" + LongitudEnteros(num1));
                static double LongitudEnteros(double num1)
                {
                    return Convert.ToDouble((2 * 3.14) * num1);
                }
                Console.WriteLine("Ingrese el numero del area");
                num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("El area es:" + AreaCirEnteros(num1, num2));
                static double AreaCirEnteros(double num1, double num2)
                {
                    return Convert.ToDouble(3.14 * (2 * num2));
                }
                return 0.0;
            }

            public double Promedio()
            {
                Console.Write("Ingresa 1er valor: ");
                num1 = double.Parse(Console.ReadLine());
                Console.Write("Ingresa 2do valor: ");
                num2 = double.Parse(Console.ReadLine());
                Console.Write("Ingresa 3er valor: ");
                num3 = double.Parse(Console.ReadLine());
                num4 = (num1 + num2 + num3) / 3;
                Console.WriteLine("El promedio total es:" + num4);
                return 0.0;
            }
        }
    }
}
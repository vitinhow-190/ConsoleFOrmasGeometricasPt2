using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFOrmasGeometricasPt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a forma geométrica desejada (Quadrado, Retangulo, Losango ou Trapézio): ");
            string forma = Console.ReadLine();

            switch (forma)
            {
                case "Quadrado":

                    Quadrado();

                    break;

                case "Retangulo":

                    Retangulo();

                    break;

                case "Losango":

                    Losango();

                    break;

                case "Trapézio":

                    Trapézio();

                    break;
                
            }

            Console.ReadKey();
        }
        static void Quadrado()
        {
            Console.WriteLine("Informe a medida da base: ");
            double B = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a medida da altura");
            double H = double.Parse(Console.ReadLine());
            double area;

            area = B * H;

            Console.WriteLine("A área do Quadrado é: " + area);
        }
        static void Retangulo()
        {
            Console.WriteLine("Informe a medida da base: ");
            double R = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a medida da altura");
            double R2 = double.Parse(Console.ReadLine());

            double arearet;

            arearet = R * R2;

            Console.WriteLine("A área do Quadrado é: " + arearet);
        }
        static void Losango() 
        {
            Console.WriteLine("Informe a medida da diagonal maior: ");
            double L = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a medida da diagonal menor: ");
            double L1 = double.Parse(Console.ReadLine());


            double arealo;

            arealo = (L * L1) / 2;

            Console.WriteLine("A área do Quadrado é: " + arealo);
        }
        static void Trapézio() 
        {
            Console.WriteLine("Informe a medida da base: ");
            double T = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a medida da base: ");
            double T1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a medida da altura");
            double TH = double.Parse(Console.ReadLine());

            double areatra;

            areatra = (T + T1) * TH / 2;

            Console.WriteLine("A área do Quadrado é: " + areatra);
        }
    }
    
} 

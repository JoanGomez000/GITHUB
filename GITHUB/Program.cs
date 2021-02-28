﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GITHUB
{
    class Program
    {
        static void Main(string[] args)
        {
            char continuar_programa = 'S';
            do
            {
                Console.WriteLine("|**********************************|");
                Console.WriteLine("|*                                *|");
                Console.WriteLine("|*  1 - Exàmen de conduir:        *|");
                Console.WriteLine("|*  2 - Exàmen de matemàtiques:   *|");
                Console.WriteLine("|*  3 - Exàmen de programació:    *|");
                Console.WriteLine("|*                                *|");
                Console.WriteLine("|**********************************|");

                char opcio_triar = char.Parse(Console.ReadLine());

                switch (opcio_triar)
                {
                    case '1':
                        {
                            Console.Clear();
                            PreguntaConduir1();
                            Console.ReadKey();
                        }
                        break;
                    case '2':
                        {
                            Console.Clear();
                            PreguntaProgramacio();
                            Console.ReadKey();
                        }
                        break;
                    case '3':
                        {
                            Console.Clear();
                            PreguntaBaseDeDades();
                            Console.ReadKey();
                        }
                        break;
                }

                Console.Clear();
                Console.WriteLine("\n|*  Vols continuar? S/N");
                continuar_programa = char.Parse(Console.ReadLine());
                Console.Clear();
            } while (continuar_programa != 'N');
        }
        static void PreguntaConduir1()
        {
            Console.WriteLine("\n\n|*  La influencia del factor de riesgo vía, como se puede disminuir?\n\n");
            Console.WriteLine("|*          A - Circulando de noche porque hay menos tráfico:");
            Console.WriteLine("|*          B - Adecuando la velocidad y aumentando la distancia de seguridad:");
            Console.WriteLine("|*          C - Circulando de noche porque hay menos tráfico:");
            Console.WriteLine("|*          D - Sin hacer nada:");
            Console.WriteLine("|* ");
            Console.WriteLine("|********************************************************************************|");

            Console.Write("|*   Tria una opció: ");
            char ABCD = char.Parse(Console.ReadLine());

            int acert = 0;
            if (ABCD == 'B')
            {
                Console.WriteLine("|* ");
                Console.WriteLine("|* ");
                Console.WriteLine("|********************************************************************************|");
                Console.WriteLine("|*                          PREGUNTA ACERTADA!                                    ");
                Console.WriteLine("|********************************************************************************|");
                acert++;
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("|* ");
                Console.WriteLine("|* ");
                Console.WriteLine("|********************************************************************************|");
                Console.WriteLine("|*                          PREGUNTA INCORRECTE!                                    ");
                Console.WriteLine("|********************************************************************************|");
                Console.ReadKey();
            }
            Console.Clear();





            Console.WriteLine("\n\n|*  En una calzada con los dos sentidos separados por una línea continua, esta permitido girar a la izquierda?\n\n");
            Console.WriteLine("|*          A - Sí, cuando no se comprometa la seguridad de ningún usuario de la vía.");
            Console.WriteLine("|*          B - No.");
            Console.WriteLine("|*          C - Solo dentro de poblado");
            Console.WriteLine("|*          D - Solo fuera de poblado");
            Console.WriteLine("|* ");
            Console.WriteLine("|********************************************************************************|");

            Console.Write("|*   Tria una opció: ");
            ABCD = char.Parse(Console.ReadLine());


            if (ABCD == 'B')
            {
                Console.WriteLine("|* ");
                Console.WriteLine("|* ");
                Console.WriteLine("|********************************************************************************|");
                Console.WriteLine("|*                          PREGUNTA ACERTADA!                                    ");
                Console.WriteLine("|********************************************************************************|");
                Console.ReadKey();
                acert++;
            }
            else
            {
                Console.WriteLine("|* ");
                Console.WriteLine("|* ");
                Console.WriteLine("|********************************************************************************|");
                Console.WriteLine("|*                          PREGUNTA INCORRECTE!                                    ");
                Console.WriteLine("|********************************************************************************|");
                Console.ReadKey();
            }
            Console.Clear();




            Console.WriteLine("\n\n|*  Quien tiene la responsabilidad por las infracciones cometidas sobre las normas de circulacion?\n\n");
            Console.WriteLine("|*          A - El conductor y si es menor de edad, sus padres o tutores legales.");
            Console.WriteLine("|*          B - Siempre el conductor causante de la infracción cometida.");
            Console.WriteLine("|*          C - El titular del vehículo");
            Console.WriteLine("|*          D - Tus padres");
            Console.WriteLine("|* ");
            Console.WriteLine("|********************************************************************************|");

            Console.Write("|*   Tria una opció: ");
            ABCD = char.Parse(Console.ReadLine());


            if (ABCD == 'A')
            {
                Console.WriteLine("|* ");
                Console.WriteLine("|* ");
                Console.WriteLine("|********************************************************************************|");
                Console.WriteLine("|*                          PREGUNTA ACERTADA!                                    ");
                Console.WriteLine("|********************************************************************************|");
                acert++;
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("|* ");
                Console.WriteLine("|* ");
                Console.WriteLine("|********************************************************************************|");
                Console.WriteLine("|*                          PREGUNTA INCORRECTE!                                    ");
                Console.WriteLine("|********************************************************************************|");
                Console.ReadKey();
            }
            Console.Clear();

        }

    }
}


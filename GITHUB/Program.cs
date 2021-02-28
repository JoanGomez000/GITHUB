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
        static void PreguntaProgramacio()
        {
            Console.WriteLine("\n\n|*  ¿Cuál es la descripción que crees que define mejor el concepto 'clase' en la programación orientada a objetos?\n\n");
            Console.WriteLine("|*          A - Es un concepto similar al de 'array'");
            Console.WriteLine("|*          B - Es un tipo particular de variable");
            Console.WriteLine("|*          C - Es un modelo o plantilla a partir de la cual creamos objetos");
            Console.WriteLine("|*          D - Es una categoria de datos ordenada secuencialmente");
            Console.WriteLine("|* ");
            Console.WriteLine("|********************************************************************************|");

            Console.Write("|*   Tria una opció: ");
            char ABCD = char.Parse(Console.ReadLine());

            int acert = 0;
            if (ABCD == 'C')
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


            Console.WriteLine("\n\n|*  ¿Qué elementos crees que definen a un objeto?\n\n");
            Console.WriteLine("|*          A - Sus cardinalidad y su tipo");
            Console.WriteLine("|*          B - Sus atributos y sus métodos");
            Console.WriteLine("|*          C - La forma en que establece comunicación e intercambia mensajes");
            Console.WriteLine("|*          D - Su interfaz y los eventos asociados");
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




            Console.WriteLine("\n\n|*  ¿Qué código de los siguientes tiene que ver con la herenc\n\n");
            Console.WriteLine("|*          A - public class Componente extends Producto");
            Console.WriteLine("|*          B - public class Componente inherit Producto");
            Console.WriteLine("|*          C - public class Componente implements Producto");
            Console.WriteLine("|*          D - public class Componente belong to Producto");
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




            Console.WriteLine("\n\n|*  ¿Qué significa instanciar una clase?\n\n");
            Console.WriteLine("|*          A - Duplicar una clase");
            Console.WriteLine("|*          B - Eliminar una clase");
            Console.WriteLine("|*          C - Crear un objeto a partir de la clase");
            Console.WriteLine("|*          D - Conectar dos clases entre sí");
            Console.WriteLine("|* ");
            Console.WriteLine("|********************************************************************************|");

            Console.Write("|*   Tria una opció: ");
            ABCD = char.Parse(Console.ReadLine());

            if (ABCD == 'C')
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


            Console.WriteLine("\n\n|*  En Java, ¿a qué nos estamos refiriendo si hablamos de 'Swing'?\n\n");
            Console.WriteLine("|*          A - Una función utilizada para intercambiar valores");
            Console.WriteLine("|*          B - Es el sobrenombre de la versión 1.3 del JDK");
            Console.WriteLine("|*          C - Un framework específico para Android");
            Console.WriteLine("|*          D - Una librería para construir interfaces gráficas");
            Console.WriteLine("|* ");
            Console.WriteLine("|********************************************************************************|");

            Console.Write("|*   Tria una opció: ");
            ABCD = char.Parse(Console.ReadLine());


            if (ABCD == 'D')
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


            if (acert > 3 || acert == 3)
            {
                Console.WriteLine("|********************************************************************************|");
                Console.WriteLine("|*                          HAS APROVAT!                                   ");
                Console.WriteLine("|********************************************************************************|");
            }
            else
            {
                Console.WriteLine("|********************************************************************************|");
                Console.WriteLine("|*                          HAS SUSPÉS!                                   ");
                Console.WriteLine("|********************************************************************************|");
            }
        }
    }
}

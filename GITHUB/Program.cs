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
            //Búcle per obrir i tencar programa
            do
            {
                //Mostrar menú per opció a triar
                Console.WriteLine("|************************************|");
                Console.WriteLine("|*                                  *|");
                Console.WriteLine("|*  1 - Exàmen de conduir:          *|");
                Console.WriteLine("|*  2 - Exàmen de programació:      *|");
                Console.WriteLine("|*  3 - Exàmen de base de dades:    *|");
                Console.WriteLine("|*                                  *|");
                Console.WriteLine("|************************************|");

                char opcio_triar = char.Parse(Console.ReadLine());
                //Switch per obrir els métodes i començar amb les preguntes
                switch (opcio_triar)
                {
                    case '1':
                        {
                            //Natejem pantalla i obrim mètode, per sortir tornem a presionar una tecla
                            Console.Clear();
                            PreguntaConduir1();
                            Console.ReadKey();
                        }
                        break;
                    case '2':
                        {
                            //Natejem pantalla i obrim mètode, per sortir tornem a presionar una tecla
                            Console.Clear();
                            PreguntaProgramacio();
                            Console.ReadKey();
                        }
                        break;
                    case '3':
                        {
                            //Natejem pantalla i obrim mètode, per sortir tornem a presionar una tecla
                            Console.Clear();
                            PreguntaBaseDeDades();
                            Console.ReadKey();
                        }
                        break;
                }
                //Natejem pantalla
                Console.Clear();
                //Ens demana si volem continuar
                Console.WriteLine("\n|*  Vols continuar? S/N");
                continuar_programa = char.Parse(Console.ReadLine());
                //natejem pantalla
                Console.Clear();
            } while (continuar_programa != 'N'); //S'executarà sempre que el char sigui diferent de N
        }
        //PRIMER METODE PER LES PREGUNTES DE EXÀMEN DE CONDUIR
        static void PreguntaConduir1()
        {
            //Mostrem per pantalla la pregunta + respostes
            
            Console.WriteLine("\n\n|*  La influencia del factor de riesgo vía, como se puede disminuir?\n\n");
            Console.WriteLine("|*          A - Circulando de noche porque hay menos tráfico:");
            Console.WriteLine("|*          B - Adecuando la velocidad y aumentando la distancia de seguridad:");
            Console.WriteLine("|*          C - Circulando de noche porque hay menos tráfico:");
            Console.WriteLine("|*          D - Sin hacer nada:");
            Console.WriteLine("|* ");
            Console.WriteLine("|********************************************************************************|");
           
            //Demanem a triar una opció
            Console.Write("|*   Tria una opció: ");
            char ABCD = char.Parse(Console.ReadLine());
            
            //Depenen de la resposta sortira acertada o no
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

            //Mostrem per pantalla la pregunta + respostes
            
            Console.WriteLine("\n\n|*  En una calzada con los dos sentidos separados por una línea continua, esta permitido girar a la izquierda?\n\n");
            Console.WriteLine("|*          A - Sí, cuando no se comprometa la seguridad de ningún usuario de la vía.");
            Console.WriteLine("|*          B - No.");
            Console.WriteLine("|*          C - Solo dentro de poblado");
            Console.WriteLine("|*          D - Solo fuera de poblado");
            Console.WriteLine("|* ");
            Console.WriteLine("|********************************************************************************|");
           
            //Demanem a triar una opció
          
            Console.Write("|*   Tria una opció: ");
            ABCD = char.Parse(Console.ReadLine());

            //Depenen de la resposta sortira acertada o no
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



            //Mostrem per pantalla la pregunta + respostes
            
            Console.WriteLine("\n\n|*  Quien tiene la responsabilidad por las infracciones cometidas sobre las normas de circulacion?\n\n");
            Console.WriteLine("|*          A - El conductor y si es menor de edad, sus padres o tutores legales.");
            Console.WriteLine("|*          B - Siempre el conductor causante de la infracción cometida.");
            Console.WriteLine("|*          C - El titular del vehículo");
            Console.WriteLine("|*          D - Tus padres");
            Console.WriteLine("|* ");
            Console.WriteLine("|********************************************************************************|");
            
            //Demanem a triar una opció
            Console.Write("|*   Tria una opció: ");
            ABCD = char.Parse(Console.ReadLine());

         
            //Depenen de la resposta sortira acertada o no
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

            //Mostrem per pantalla la pregunta + respostes
            
            Console.WriteLine("\n\n|*  En que situación suelen tener menos accidentes las personas mayores como peatones?\n\n");
            Console.WriteLine("|*          A - Cuando van acompañadas de otra persona mayor");
            Console.WriteLine("|*          B - Cuando van acompañando a niños");
            Console.WriteLine("|*          C - Cuando van solas");
            Console.WriteLine("|*          D - Cuando van hablando con otra persona");
            Console.WriteLine("|* ");
            Console.WriteLine("|********************************************************************************|");
            
            //Demanem a triar una opció
            
            Console.Write("|*   Tria una opció: ");
            ABCD = char.Parse(Console.ReadLine());
          
            //Depenen de la resposta sortira acertada o no
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

            //Mostrem per pantalla la pregunta + respostes
          
            Console.WriteLine("\n\n|*  Que función tiene la carrocería como elemento de seguridad pasiva?\n\n");
            Console.WriteLine("|*          A - Absorber la deceleración de las frenadas");
            Console.WriteLine("|*          B - Proteger a los ocupantes del vehiculo en caso de accidente");
            Console.WriteLine("|*          C - Evitar que se produzcan accidentes graves");
            Console.WriteLine("|*          D - Aumentar la aerodinámica del vehiculo.");
            Console.WriteLine("|* ");
            Console.WriteLine("|********************************************************************************|");
           
            //Demanem a triar una opció
            Console.Write("|*   Tria una opció: ");
            ABCD = char.Parse(Console.ReadLine());

           
            //Depenen de la resposta sortira acertada o no
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

            //Depenent de quants accerts hagim fet s'executarà
            if (acert > 3 || acert == 3) //Si hem fet 3 acerts o més haurem aprovat el examen
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
        //A partir d'ara els mètodes son el mateix peró amb les preguntes canviades
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

        static void PreguntaBaseDeDades()
        {
            Console.WriteLine("\n\n|*  Sentencia utilizada para eliminar una base de datos\n\n");
            Console.WriteLine("|*          A - DELETE DATABASE");
            Console.WriteLine("|*          B - DROP DATABASE");
            Console.WriteLine("|*          C - ERASE DATABASE");
            Console.WriteLine("|*          D - TRUNCATE DATABASE");
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


            Console.WriteLine("\n\n|*  El comando ___________ es usado para obtener información acerca de como MySQL podría ejecutar una consulta.\n\n");
            Console.WriteLine("|*          A - ANALIZE");
            Console.WriteLine("|*          B - DESCRIBE");
            Console.WriteLine("|*          C - EXPLAIN");
            Console.WriteLine("|*          D - SHOW");
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




            Console.WriteLine("\n\n|*  ¿Qué sentencia es valida en MySQL?\n\n");
            Console.WriteLine("|*          A - RENAME TABLE");
            Console.WriteLine("|*          B - RENAME DATABASE");
            Console.WriteLine("|*          C - RENAME INDEX");
            Console.WriteLine("|*          D - RENAME TRIGGER");
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




            Console.WriteLine("\n\n|*  ¿Cuál es la estructura que se usa para leer la fila de un cursor?\n\n");
            Console.WriteLine("|*          A - INTO <nombre_cursor> INTO <lista_variables>");
            Console.WriteLine("|*          B - FITCH <nombre_cursor> INTRO <lista_variables>");
            Console.WriteLine("|*          C - FETCH <nombre_cursor> INTO <lista_variables>");
            Console.WriteLine("|*          D - INTO <nombre_cursor> FETCH <lista_variables>");
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


            Console.WriteLine("\n\n|*  Elija la respuesta correcta: ¿Cómo se declara una variable para un cursor?\n\n");
            Console.WriteLine("|*          A - -Nombre");
            Console.WriteLine("|*          B - $Nombre");
            Console.WriteLine("|*          C - @Nombre");
            Console.WriteLine("|*          D - %Nombre");
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





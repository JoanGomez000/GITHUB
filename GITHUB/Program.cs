using System;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabla_de_Frases
{
    class Program
    {
        #region Informar Errores
        // Informa Error01 (Numero fuera del rango).
        static void ErrorRango(int a, int b)
        {
            Console.Title = "Error 01";
            Console.WriteLine("**************************************************");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**      Debe escribir un numero entre " + a + " y " + b + "     **");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**************************************************");
            Console.Beep(3040, 150);
            Console.Beep(3040, 150);
        }

        // Informa Error02 (Numero invalido).
        static void ErrorNumeroInvalido()
        {
            Console.Title = "Error 02";
            Console.WriteLine("**************************************************");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**        Debe ingresar un numero valido        **");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**************************************************");
            Console.Beep(3040, 150);
            Console.Beep(3040, 150);
        }

        // Informa Error03 (La tabla esta llena).
        static void ErrorNoEspacio()
        {
            Console.Title = "Error 03";
            Console.Clear();
            Console.CursorVisible = false;
            Console.WriteLine("**************************************************");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**             La tabla esta llena.             **");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**         Presione enter para volver.          **");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**************************************************");
            Console.Beep(3040, 150);
            Console.Beep(3040, 150);
            Console.ReadLine();
            Console.CursorVisible = true;
        }

        // Informa Error04 (No hay frases cargadas).
        static void ErrorNoFrases()
        {
            Console.Title = "Error 04";
            Console.CursorVisible = false;
            Console.Clear();
            Console.WriteLine("**************************************************");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**           No hay frases cargadas.            **");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**   Presione enter para volver a intentarlo.   **");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**************************************************");
            Console.Beep(3040, 150);
            Console.Beep(3040, 150);
            Console.ReadLine();
            Console.CursorVisible = true;
        }

        // Informa Error05 (La frase debe tener entre 3 y 10 palabras).
        static void ErrorTamanioFrase()
        {
            Console.Title = "Error 05";
            Console.WriteLine("**************************************************");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**             La frase debe tener              **\n**            entre 3 y 10 palabras.            **");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**************************************************");
            Console.Beep(3040, 150);
            Console.Beep(3040, 150);
        }

        // Informa Error06 (Error inesperado, podria suceder si fallan los controles de rango).
        static void ErrorInesperado()
        {
            Console.Title = "Error 06";
            Console.CursorVisible = false;
            Console.WriteLine("**************************************************");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**              Error inesperado.               **");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**   Presione enter para volver a intentarlo.   **");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**************************************************");
            Console.Beep(3040, 150);
            Console.Beep(3040, 150);
            Console.ReadLine();
            Console.CursorVisible = true;
        }

        // Informa Error07 (Se intento acceder a una funcion premium).
        static void ErrorNoVip(int opcion)
        {
            Console.Title = "Error 07";
            Console.Clear();
            Console.CursorVisible = false;
            Console.WriteLine("**************************************************");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**   Intentaste acceder a una funcion premium,  **");

            switch (opcion)
            {
                case 0:
                    Console.WriteLine("**      no puedes personalizar la consola.      **");
                    break;
                case 3:
                    Console.WriteLine("**         no puedes remplazar frases.          **");
                    break;
                case 4:
                    Console.WriteLine("**          no puedes duplicar frases.          **");
                    break;
                case 7:
                    Console.WriteLine("**        no puedes ver las estadisticas.       **");
                    break;
                case 8:
                    Console.WriteLine("**      no puedes borrar todas las frases.      **");
                    break;
                case 10:
                    Console.WriteLine("**      no puedes buscar palabras en frase.     **");
                    break;
                case 11:
                    Console.WriteLine("**    no puedes ver el esqueleto de la tabla.   **");
                    break;

                default:
                    ErrorInesperado();
                    break;
            }

            Console.WriteLine("**                                              **");
            Console.WriteLine("**          Presione enter para volver          **");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**************************************************");
            Console.Beep(3040, 150);
            Console.Beep(3040, 150);
            Console.ReadLine();
            Console.CursorVisible = true;
        }

        // Informa Error08 (Se necesitan al menos 2 frases).
        static void Error2FrasesRequeridas()
        {
            Console.Title = "Error 08";
            Console.CursorVisible = false;
            Console.Clear();
            Console.WriteLine("**************************************************");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**   Se necesitan al menos 2 frases cargadas.   **");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**   Presione enter para volver a intentarlo.   **");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**************************************************");
            Console.Beep(3040, 150);
            Console.Beep(3040, 150);
            Console.ReadLine();
            Console.CursorVisible = true;
        }

        #endregion

        #region Desplegar Menus

        // Despliega el menu de Bienvenida.
        static void MenuInicio()
        {
            Console.Title = "Proyecto obligatorio";
            Console.Clear();
            Console.WriteLine("**************************************************");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**       Bienvenido al primer obligatorio       **");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**               " + DateTime.Now.ToString("dd/MM/yyyy hh:mm") + "               **");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**   1 - Tabla de frases                        **");
            Console.WriteLine("**   2 - Personalizar consola (\u03B2)               **");
            Console.WriteLine("**   3 - Suscripcion premium                    **");
            Console.WriteLine("**   4 - Creditos                               **");
            Console.WriteLine("**   5 - Salir                                  **");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**************************************************");
        }

        // Despliega el menu de personalizar.
        static void MenuPersonalizar()
        {
            Console.Title = "Personalizar consola";
            Console.Clear();
            Console.WriteLine("**************************************************");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**             Personalizar consola             **");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**    ▲    Usa tus flechas para cambiar    ▲    **");
            Console.WriteLine("**  ◄ ▼ ►     el color de la consola     ◄ ▼ ►  **");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**        Presione Enter para finalizar.        **");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**************************************************");
        }

        // Despliega el menu Tabla de frases.
        static void MenuSecundario(int frases)
        {
            {
                Console.Title = "Tabla de frases";
                Console.Clear();
                Console.WriteLine("**************************************************");
                Console.WriteLine("**                                              **");
                Console.WriteLine("**               Tabla de frases                **");
                Console.WriteLine("**          Actualmente hay " + frases + " frases.           **");
                Console.WriteLine("**                                              **");
                Console.WriteLine("**   1 - Agregar una frase                      **");
                Console.WriteLine("**   2 - Eliminar una frase                     **");
                Console.WriteLine("**   3 - Remplazar una frase (\u03B2)                **");
                Console.WriteLine("**   4 - Duplicar una frase (\u03B2)                 **");
                Console.WriteLine("**   5 - Invertir una frase                     **");
                Console.WriteLine("**   6 - Mostrar todas las frases               **");
                Console.WriteLine("**   7 - Mostrar estadisticas (\u03B2)               **");
                Console.WriteLine("**   8 - Borrar todas las frases (\u03B2)            **");
                Console.WriteLine("**   9 - Buscar una palabra en la tabla         **");
                Console.WriteLine("**   10 - Buscar una palabra en una frase (\u03B2)   **");
                Console.WriteLine("**   11 - Mostrar el esqueleto de la tabla (\u03B2)  **");
                Console.WriteLine("**                                              **");
                Console.WriteLine("**   12 - Volver                                **");
                Console.WriteLine("**                                              **");
                Console.WriteLine("**************************************************");
            }
        }

        // Despliega el menu de suscripciones.
        static void MenuVip(bool vip)
        {
            Console.Clear();
            Console.Title = "Suscripcion a premium";
            Console.WriteLine("**************************************************");
            Console.WriteLine("**                                              **");
            Console.Write("**         Actualmente tu plan es ");
            if (vip)
                Console.WriteLine("premium.      **");
            else
                Console.WriteLine("basico.       **");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**   1 - Comprar suscripcion                    **");
            Console.WriteLine("**   2 - Cancelar suscripcion                   **");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**   3 - Volver                                 **");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**************************************************");
        }

        #endregion

        #region Calculo de datos

        // Metodo para leer un numero dentro de un rango.
        static int NumeroValido(int a, int b)
        {
            int numero;
            while (true)
            {
                Console.Write("**   ");
                try
                {
                    numero = Convert.ToInt32(Console.ReadLine());
                    // Controlamos que el numero este en el intervalo deseado.
                    if (numero < a || numero > b)
                        ErrorRango(a, b);
                    else
                        break;
                }
                catch
                {
                    ErrorNumeroInvalido();
                }
            }
            return (numero);
        }

        // Metodo para mostrar una frase.
        static void MostrarFrase(string[,] tablaFrases, int miFrase)
        {
            int palabra = 0;

            while (palabra < 10 && tablaFrases[miFrase, palabra] != null)
            {
                Console.Write(tablaFrases[miFrase, palabra]);
                palabra++;
                if (palabra < 10 && tablaFrases[miFrase, palabra] != null)
                    Console.Write(" ");
            }
        }

        // Metodo para mostrar todas las frases de la tabla.
        static void ListarTabla(string[,] tablaFrases, int cantidadFrases)
        {
            for (int i = 0; i <= cantidadFrases - 1; i++)
            {
                Console.Write("**  " + (i + 1) + " - ");
                MostrarFrase(tablaFrases, i);
                Console.WriteLine();
            }
        }

        // Metodo retornar la cantidad de veces que se repite una palabra en una frase.
        static int CantRepeticiones(string[,] tablaFrases, string miPalabra, int miFrase)
        {
            int contador = 0, i = 0;
            while (i < 10 && tablaFrases[miFrase, i] != null)
            {
                if (tablaFrases[miFrase, i].ToLower() == miPalabra.ToLower())
                    contador++;
                i++;
            }
            return contador;
        }

        // Metodo para contar los caracteres de las frases.
        static int CantidadLetras(string[,] tablaFreses, int miFrase)
        {
            int contador = 0, i = 0;
            while (i < 10 && tablaFreses[miFrase, i] != null)
            {
                contador += tablaFreses[miFrase, i].Length;
                i++;
            }
            return contador;
        }

        #endregion

        #region Opciones de la aplicacion

        // Metodo para mostrar el esqueleto de la tabla.
        static void Esqueleto(string[,] tablaFrases)
        {
            Console.Clear();
            Console.Title = "Esqueleto de la tabla";
            Console.CursorVisible = false;
            Console.WriteLine(" >>  Esqueleto de la tabla de frases.\n");
            for (int filas = 0; filas < tablaFrases.GetLength(0); filas++)
            {
                Console.Write("  Indice real: " + filas + "  >>");
                for (int columnas = 0; columnas < tablaFrases.GetLength(1); columnas++)
                {
                    if (tablaFrases[filas, columnas] != null)
                        Console.Write(" " + tablaFrases[filas, columnas]);
                    else
                        Console.Write(" ~Vacio");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n >>  Presione enter para volver.");
            Console.ReadLine();
            Console.CursorVisible = true;
        }

        // Metodo para buscar palabra en frase.
        static void BuscarEnFrase(string[,] tablaFrases, int cantidadFrases)
        {
            Console.Title = "Buscar una palabra en una frase";
            Console.Clear();
            Console.WriteLine("**************************************************");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**      Buscar una palabra en una frase.        **");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**     Escriba la palabra que desea buscar.     **");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**************************************************");
            Console.WriteLine("**                                              **");
            Console.Write("**  ");
            string palabra = Console.ReadLine();

            Console.WriteLine("**                                              **");
            Console.WriteLine("**       Indique el indice de la frase en       **");
            Console.WriteLine("**   la que desea buscar la palabra “" + palabra + "”.");

            Console.WriteLine("**                                              **");
            ListarTabla(tablaFrases, cantidadFrases);
            Console.WriteLine("**                                              **");
            Console.WriteLine("**************************************************");
            Console.WriteLine("**                                              **");

            int frase = NumeroValido(1, cantidadFrases) - 1;
            int repeticiones = (CantRepeticiones(tablaFrases, palabra, frase));

            Console.WriteLine("**                                              **");

            if (repeticiones == 0)
                Console.Write("**  La palabra “" + palabra + "” no aparece en la frase “");
            else if (repeticiones == 1)
                Console.Write("**  La palabra “" + palabra + "” aparece una sola vez en la frase “");
            else
                Console.Write("**  La palabra “" + palabra + "” aparece " + repeticiones + " veces en la frase “");

            MostrarFrase(tablaFrases, frase);

            Console.WriteLine("”");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**        Presione enter para continuar.        **");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**************************************************");
            Console.ReadLine();
        }

        // Metodo para buscar palabra en tabla.
        static void BuscarEnTabla(string[,] tablaFrases, int cantidadFrases)
        {
            Console.Title = "Buscar una palabra en la tabla";
            Console.Clear();
            Console.WriteLine("**************************************************");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**       Buscar una palabra en la tabla.        **");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**     Escriba la palabra que desea buscar.     **");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**************************************************");
            Console.WriteLine("**                                              **");
            Console.Write("**  ");
            string palabra = Console.ReadLine();
            int repeticiones = 0;

            // Creamos un bucle que recorra todas las frases, sumando 1 al contador cada vez que la palabra aparece
            for (int i = 0; i < cantidadFrases; i++)
                repeticiones += CantRepeticiones(tablaFrases, palabra, i);

            Console.WriteLine("**                                              **");
            if (repeticiones == 0)
                Console.Write("**  La palabra “" + palabra + "” no aparece en la tabla.");
            else if (repeticiones == 1)
                Console.Write("**  La palabra “" + palabra + "” aparece una sola vez en la tabla.");
            else
                Console.Write("**  La palabra “" + palabra + "” aparece " + repeticiones + " veces en la tabla.");

            Console.WriteLine("\n**        Presione enter para continuar.        **");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**************************************************");
            Console.ReadLine();
        }

        // Metodo para borrar todas las frases de la tabla.
        static void BorrarTabla(string[,] tablaFrases, ref int cantidadFrases)
        {
            Console.Title = "Borrar todas las frases de la tabla";

            // El bucle no termina hasta que el usuario tome una desicion.
            while (1 > 0)
            {
                Console.Clear();
                Console.WriteLine("**************************************************");
                Console.WriteLine("**                                              **");
                Console.WriteLine("**           Estas seguro que deseas            **\n**      borrar todas las frases? (Si - No)      **");
                Console.WriteLine("**                                              **");
                Console.WriteLine("**************************************************");
                Console.Write("**  >> ");
                string borrar = Console.ReadLine();
                Console.CursorVisible = false;

                if (borrar.ToLower() == "si")
                {
                    for (int filas = 0; filas < tablaFrases.GetLength(0); filas++)
                    {
                        if (tablaFrases[filas, 1] == null)
                            break;
                        for (int columnas = 0; columnas < tablaFrases.GetLength(1); columnas++)
                            if (tablaFrases[filas, columnas] != null)
                                tablaFrases[filas, columnas] = null;
                            else
                                break;
                    }
                    Console.Clear();
                    Console.WriteLine("**************************************************");
                    Console.WriteLine("**                                              **");
                    Console.WriteLine("** Todas las frases fueron eliminadas con exito **");
                    Console.WriteLine("**                                              **");
                    Console.WriteLine("**        Presione enter para continuar.        **");
                    Console.WriteLine("**                                              **");
                    Console.WriteLine("**************************************************");
                    Console.ReadLine();
                    cantidadFrases = 0;
                    break;
                }
                else if (borrar.ToLower() == "no")
                {
                    Console.Clear();
                    Console.WriteLine("**************************************************");
                    Console.WriteLine("**                                              **");
                    Console.WriteLine("**       No se ha eliminado ninguna frase.      **");
                    Console.WriteLine("**                                              **");
                    Console.WriteLine("**        Presione enter para continuar.        **");
                    Console.WriteLine("**                                              **");
                    Console.WriteLine("**************************************************");
                    Console.ReadLine();
                    break;
                }
                Console.CursorVisible = true;
            }
        }

        // Metodo para mostrar estadisticas de la tabla.
        static void EstadisticasGenerales(string[,] tablaFrases, int cantidadFrases, DateTime fechaInicio)
        {
            Console.Clear();
            Console.CursorVisible = false;
            Console.Title = "Estadisticas";

            // Se inicializan datos variados.
            int tiempoUsado = Convert.ToInt32((DateTime.Now - fechaInicio).TotalMinutes);
            int cantPalabras = 0, cantLetras = 0, palabrasVacias = 0, mayorFrase = -1, mayorIndice = -1;

            // Se recorre la tabla por completo para obtener datos.
            for (int filas = 0; filas < tablaFrases.GetLength(0); filas++)
            {
                for (int columnas = 0; columnas < tablaFrases.GetLength(1); columnas++)
                {
                    if (tablaFrases[filas, columnas] != null)
                    {
                        cantPalabras++;
                        cantLetras += tablaFrases[filas, columnas].Length;

                        if (mayorIndice < columnas)
                        {
                            mayorIndice = columnas;
                            mayorFrase = filas + 1;
                        }
                    }
                    else
                        palabrasVacias++;
                }
            }

            Console.WriteLine("**************************************************");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**   Bienvenido a las estadisticas generales!   **");
            Console.WriteLine("**         Actualmente la hora es " + DateTime.Now.ToString("hh:mm") + "         **");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**  >> Llevas " + tiempoUsado + " minutos usando la aplicacion.");
            Console.WriteLine("**  >> Tienes el plan premium.");
            Console.WriteLine("**  >> Actualmente hay " + cantPalabras + " palabras cargadas.");
            Console.WriteLine("**  >> La tabla tiene " + cantLetras + " letras cargadas.");
            if ((25 - cantidadFrases) == 0)
                Console.WriteLine("**  >> La tabla esta completamente llena :(");
            else if ((25 - cantidadFrases) == 1)
                Console.WriteLine("**  >> Solo hay espacio para una frase mas.");
            else
                Console.WriteLine("**  >> Aun se pueden agregar " + (25 - cantidadFrases) + " frases mas.");
            Console.WriteLine("**  >> Hay " + palabrasVacias + " palabras vacias.");
            Console.WriteLine("**  >> La frase mas larga es la numero " + mayorFrase + ".");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**          Presione enter para volver.         **");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**************************************************");
            Console.ReadLine();
            Console.CursorVisible = true;
        }

        // Metodo para mostrar todas las frases.
        static void MostrarTabla(string[,] tablaFrases, int cantidadFrases)
        {
            Console.Title = "Mostrar todas las frases";
            Console.Clear();
            Console.CursorVisible = false;
            Console.WriteLine("**************************************************");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**     Mostrar todas las frases de la tabla.    **");
            Console.WriteLine("**                                              **");
            Console.WriteLine("** ============================================ **");

            for (int i = 0; i <= cantidadFrases - 1; i++)
            {
                Console.WriteLine("**  Posicion: " + (i + 1));
                Console.Write("**  Caracteres: " + CantidadLetras(tablaFrases, i) + "\n**  Frase: “");
                MostrarFrase(tablaFrases, i);
                Console.Write("”\n** ============================================ **\n");
            }

            Console.WriteLine("**                                              **");
            Console.WriteLine("**        Presione enter para contunuar.        **");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**************************************************");
            Console.ReadLine();
            Console.CursorVisible = true;
        }

        // Metodo para invertir una frase parcialmente.
        static void InvertirFrase(string[,] tablaFrases, int cantidadFrases)
        {
            Console.Title = "Invertir frase";
            Console.Clear();

            Console.WriteLine("**************************************************");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**                Invertir frase.               **");
            Console.WriteLine("**                                              **");
            ListarTabla(tablaFrases, cantidadFrases);
            Console.WriteLine("**                                              **");
            Console.WriteLine("**  0 - Volver.                                 **");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**           Indique el indice de la            **");
            Console.WriteLine("**          frase que desea invertir.           **");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**************************************************");

            int frase = NumeroValido(0, cantidadFrases);
            if (frase != 0)
            {
                frase--;

                // Contamos la cantidad de palabras que tiene la frase seleccionada.
                int cantPalabras = 3;
                for (int auxpal = 3; auxpal < 10; auxpal++)
                {
                    if (tablaFrases[frase, auxpal] != null)
                        cantPalabras++;
                    else
                        break;
                }

                // Copiamos la frase seleccionada de manera inversa en un arreglo.
                string[] fraseInvertida = new string[cantPalabras];
                int ultimoIndice = 0;
                for (int pal = 9; pal >= 0; pal--)
                    if (tablaFrases[frase, pal] != null)
                    {
                        fraseInvertida[ultimoIndice] = tablaFrases[frase, pal];
                        ultimoIndice++;
                    }

                Console.CursorVisible = false;
                Console.Clear();
                Console.WriteLine("**************************************************");
                Console.WriteLine("**                                              **");
                Console.WriteLine("**                Invertir frase.               **");
                Console.WriteLine("**                                              **");
                Console.Write("**   Frase original: “"); MostrarFrase(tablaFrases, frase);
                Console.WriteLine("”.");
                Console.Write("**   Frase inversa: “");

                // Escribimos la frase inversa en consola.
                int palInv = 0;
                while (palInv < cantPalabras)
                {
                    Console.Write(fraseInvertida[palInv]);
                    palInv++;
                    if (palInv < cantPalabras)
                        Console.Write(" ");
                }

                Console.WriteLine("”.");
                Console.WriteLine("**                                              **");
                Console.WriteLine("**        Presione enter para continuar         **");
                Console.WriteLine("**                                              **");
                Console.WriteLine("**************************************************");
                Console.ReadLine();
                Console.CursorVisible = true;
            }
        }

        // Metodo para duplicar una frase.
        static void DuplicarFrase(string[,] tablaFrases, ref int cantidadFrases)
        {
            Console.Title = "Duplicar una frase";
            Console.Clear();
            Console.WriteLine("**************************************************");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**             Duplicar una frase.              **");
            Console.WriteLine("**                                              **");
            ListarTabla(tablaFrases, cantidadFrases);
            Console.WriteLine("**                                              **");
            Console.WriteLine("**  0 - Volver.                                 **");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**           Indique el indice de la            **");
            Console.WriteLine("**          frase que desea duplicar.           **");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**************************************************");
            int frase = NumeroValido(0, cantidadFrases);
            if (frase != 0)
            {
                while (frase != 0)
                {
                    // Se vuelve a controlar que haya espacio suficiente.
                    if (cantidadFrases < 25)
                    {
                        frase--;
                        // Copiamos todas las frases 1 indice hacia adelante.
                        for (int f = cantidadFrases - 1; f > frase - 1; f--)
                        {
                            for (int pal = 0; pal < 10; pal++)
                            {
                                if (tablaFrases[f, pal] != null)
                                    tablaFrases[f + 1, pal] = tablaFrases[f, pal];
                                else
                                    tablaFrases[f + 1, pal] = null;
                            }
                        }
                        cantidadFrases++;
                        Console.Clear();
                        Console.WriteLine("**************************************************");
                        Console.WriteLine("**                                              **");
                        Console.WriteLine("**          Frase duplicada con exito!          **");
                        Console.WriteLine("**                                              **");
                        ListarTabla(tablaFrases, cantidadFrases);
                        Console.WriteLine("**                                              **");
                        Console.WriteLine("**  0 - Volver.                                 **");
                        Console.WriteLine("**                                              **");
                        Console.WriteLine("**           Indique el indice de la            **");
                        Console.WriteLine("**          frase que desea duplicar.           **");
                        Console.WriteLine("**                                              **");
                        Console.WriteLine("**************************************************");
                        frase = NumeroValido(0, cantidadFrases);
                    }
                    else
                    {
                        Console.Clear();
                        ErrorNoEspacio();
                        break;
                    }

                }
            }
        }

        // Metodo para remplazar una frase.
        static void RemplazarFrase(string[,] tablaFrases, int cantidadFrases)
        {
            Console.Title = "Remplazar una frase";
            Console.Clear();
            Console.WriteLine("**************************************************");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**              Remplazar una frase.            **");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**   Seleccione la frase que desea remplazar.   **");
            Console.WriteLine("**                                              **");
            ListarTabla(tablaFrases, cantidadFrases);
            Console.WriteLine("**                                              **");
            Console.WriteLine("**  0 - Volver.                                 **");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**************************************************");
            int frase = NumeroValido(0, cantidadFrases);
            if (frase != 0)
            {
                Console.WriteLine("**                                              **");
                Console.WriteLine("**           Escriba la nueva frase,            **\n**       recuerde que la frase debe tener       **\n**            entre 3 y 10 palabras.            **");
                Console.WriteLine("**                                              **");
                while (true)
                {
                    frase--;
                    Console.Write("**   >>> ");

                    string palabras = Console.ReadLine();

                    // Creamos un vector con los caracteres que van a separar cada palabra de la frase.
                    char[] separadores = new char[] { ' ', '.' };

                    // Separamos nuestra frase en palabras y las agregamos al vector.
                    string[] fraseNueva = palabras.Split(separadores, StringSplitOptions.RemoveEmptyEntries);

                    // Si la frase tiene menos de 3 o mas de 10 palabras informamos un error.
                    if (fraseNueva.Length > 10 || fraseNueva.Length < 3)
                        ErrorTamanioFrase();
                    else
                    {
                        // Si la frase es valida la sobreescribimos en el indice deseado 
                        for (int pal = 0; pal < fraseNueva.Length; pal++)
                            tablaFrases[frase, pal] = fraseNueva[pal];
                        // Borramos posibles restos de la anterior frase.
                        for (int pal = fraseNueva.Length; pal < 10; pal++)
                            tablaFrases[frase, pal] = null;
                        break;
                    }
                }

                Console.CursorVisible = false;
                Console.Clear();
                Console.WriteLine("**************************************************");
                Console.WriteLine("**                                              **");
                Console.WriteLine("**          Frase remplazada conexito.          **");
                Console.WriteLine("**                                              **");
                Console.Write("**  Nueva frase: “");
                MostrarFrase(tablaFrases, frase);
                Console.WriteLine("”\n**                                              **");
                Console.WriteLine("**        Presione enter para continuar.        **");
                Console.WriteLine("**                                              **");
                Console.WriteLine("**************************************************");
                Console.ReadLine();
                Console.CursorVisible = true;
            }
        }

        // Metodo para elimiar una frase.
        static void EliminarFrase(string[,] tablaFrases, ref int cantidadFrases)
        {
            Console.Title = "Eliminar frase";
            Console.Clear();
            Console.WriteLine("**************************************************");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**                Eliminar frase.               **");
            Console.WriteLine("**                                              **");
            ListarTabla(tablaFrases, cantidadFrases);
            Console.WriteLine("**                                              **");
            Console.WriteLine("**  0 - Volver.                                 **");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**           Indique el indice de la            **");
            Console.WriteLine("**          frase que desea eliminar.           **");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**************************************************");

            int frase = NumeroValido(0, cantidadFrases);
            if (frase != 0)
            {
                frase--;
                string[] fraseaux = new string[10];
                int pal = 0;

                // Recorremos todas las palabras de la frase que indico el usuario.
                while (pal < 10 && tablaFrases[(frase), pal] != null)
                {
                    // Creamos una copia de la frase que vamos a eliminar.
                    fraseaux[pal] = tablaFrases[(frase), pal];
                    // Vaciamos la frase de la tabla.
                    tablaFrases[(frase), pal] = null;
                    pal++;
                }

                // Moveremos todas las frases que siguen despues de la eliminada, 1 indice atras.
                // Recorremos todas las frases que siguen despues de la frase eliminada.
                for (int i = frase + 1; i < cantidadFrases + 1; i++)
                {
                    // Recorremos todo el vector y remplazamos la frase anterior por la actual.
                    for (int x = 0; x < 10; x++)
                        if (i < 25)
                        {
                            if (tablaFrases[i, x] != null)
                                tablaFrases[(i - 1), x] = tablaFrases[(i), x];
                            else if (tablaFrases[(i - 1), x] != null)
                                tablaFrases[(i - 1), x] = null;
                            else
                                break;
                        }
                    else
                        tablaFrases[(24), x] = null;
                }

                // Eliminamos la ultima frase ya que se duplico.
                int y = 0;
                while (pal < 10 && tablaFrases[cantidadFrases-1, y] != null)
                {
                    tablaFrases[cantidadFrases-1, y] = null;
                    y++;
                }

                Console.Clear();
                Console.WriteLine("**************************************************");
                Console.WriteLine("**                                              **");
                Console.Write("**  La frase “");

                // Mostramos la frase auxiliar (La que el usuario elimino).
                int palaux = 0;
                while (palaux < 10 && fraseaux[palaux] != null)
                {
                    Console.Write(fraseaux[palaux]);
                    if (palaux < 10 && fraseaux[palaux] != null)
                        Console.Write(" ");
                    palaux++;
                }

                Console.WriteLine("” fue eliminada con exito!");
                Console.WriteLine("**                                              **");
                Console.WriteLine("**        Presione enter para continuar.        **");
                Console.WriteLine("**                                              **");
                Console.WriteLine("**************************************************");
                Console.ReadLine();
                cantidadFrases -= 1;
            }
        }

        // Metodo para agregar una frase a la tabla.
        static void AgregarFrase(string[,] tablaFrases, int ultimaFrase)
        {
            Console.Title = "Agregar frase";
            Console.Clear();
            Console.WriteLine("**************************************************");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**           Agregar frase a la tabla.          **");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**       Recuerde que la frase debe tener       **\n**            entre 3 y 10 palabras.            **");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**************************************************");
            while (true)
            {
                Console.Write("**   >>> ");
                string palabras = Console.ReadLine();

                // Creamos un vector con los caracteres que van a separar cada palabra de la frase.
                char[] separadores = new char[] { ' ', '.' };

                // Separamos nuestra frase en palabras y las agregamos al vector.
                string[] frase = palabras.Split(separadores, StringSplitOptions.RemoveEmptyEntries);

                // Si la frase tiene menos de 3 o mas de 10 palabras informamos un error.
                if (frase.Length > 10 || frase.Length < 3)
                    ErrorTamanioFrase();
                // Si la frase es valida la agregamos a la tabla.
                else
                {
                    for (int pal = 0; pal < frase.Length; pal++)
                        tablaFrases[ultimaFrase, pal] = frase[pal];
                    break;
                }
            }
            Console.Clear();
            Console.WriteLine("**************************************************");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**       La frase fue agregada con exito!       **");
            Console.WriteLine("**                                              **");
            Console.Write("**   “");
            MostrarFrase(tablaFrases, ultimaFrase);
            Console.WriteLine("”.");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**        Presione enter para continuar.        **");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**************************************************");
            Console.ReadLine();
        }

        // Despliega el menu Salir.
        static void Salir(DateTime fechaInicial)
        {
            Console.Title = "Adios :c";
            Console.Clear();
            Console.CursorVisible = false;

            // Calculamos el tiempo usado en la aplicacion.
            int tiempoUsado = Convert.ToInt32((DateTime.Now - fechaInicial).TotalMinutes);

            Console.WriteLine("**************************************************");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**      Gracias por usar nuestra aplicacion     **");
            Console.WriteLine("**              durante " + tiempoUsado + " minutos!              **");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**        Presione enter para finalizar.        **");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**************************************************");
            Console.ReadLine();
        }

        // Despliega el menu creditos.
        static void Creditos()
        {
            Console.Title = "Creditos";
            Console.Clear();
            Console.CursorVisible = false;

            Console.WriteLine("**************************************************");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**                   Creditos                   **");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**   ===> Franco Rollandi                       **");
            Console.WriteLine("**   ===> Pablo Raspino                         **");
            Console.WriteLine("**   ===> Luis Puerto                           **");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**          Presione enter para volver.         **");
            Console.WriteLine("**                                              **");
            Console.WriteLine("**************************************************");
            Console.ReadLine();

            Console.CursorVisible = true;
            Console.Clear();

            MenuInicio();
        }

        // Metodo para adquirir o remover tu suscripcion.
        static void Suscripcion(ref bool vip)
        {
            MenuVip(vip);

            int status = NumeroValido(1, 3);
            Console.Clear();
            Console.CursorVisible = false;
            if (status == 1)
                if (vip)
                {
                    Console.WriteLine("**************************************************");
                    Console.WriteLine("**                                              **");
                    Console.WriteLine("**          Ya tenias el plan premium!          **");
                    Console.WriteLine("**                                              **");
                    Console.WriteLine("**        Presione enter para continuar.        **");
                    Console.WriteLine("**                                              **");
                    Console.WriteLine("**************************************************");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("**************************************************");
                    Console.WriteLine("**                                              **");
                    Console.WriteLine("**         Compra realizada con exito!          **");
                    Console.WriteLine("**                                              **");
                    Console.WriteLine("**        Presione enter para continuar.        **");
                    Console.WriteLine("**                                              **");
                    Console.WriteLine("**************************************************");
                    vip = true;
                    Console.ReadLine();
                }
            else if (status == 2)
                if (vip)
                {
                    Console.WriteLine("**************************************************");
                    Console.WriteLine("**                                              **");
                    Console.WriteLine("**     Suscripcion cancelada correctamente.     **");
                    Console.WriteLine("**                                              **");
                    Console.WriteLine("**        Presione enter para continuar.        **");
                    Console.WriteLine("**                                              **");
                    Console.WriteLine("**************************************************");
                    Console.ReadLine();
                    vip = false;
                }
                else
                {
                    Console.WriteLine("**************************************************");
                    Console.WriteLine("**                                              **");
                    Console.WriteLine("**           No tienes suscripciones.           **");
                    Console.WriteLine("**                                              **");
                    Console.WriteLine("**        Presione enter para continuar.        **");
                    Console.WriteLine("**                                              **");
                    Console.WriteLine("**************************************************");
                    Console.ReadLine();
                }
            Console.CursorVisible = true;
        }

        // Metodo personalizar el color de la consola.
        static void Personalizar(ref int horizontal, ref int vertical)
        {
            // Los valores se pasan por referencia para mantener la confguracion del usuario al volver a personalizar la consola.

            Console.CursorVisible = false;
            MenuPersonalizar();
            bool finalizar = false;
            while (!finalizar)
            {
                ConsoleKeyInfo flecha = Console.ReadKey(true);

                // Modificamos nuestras variables segun que flecha presione el usuario.
                switch (flecha.Key)
                {
                    case ConsoleKey.UpArrow: 
                        vertical--; 
                        break;
                    case ConsoleKey.DownArrow: 
                        vertical++; 
                        break;

                    case ConsoleKey.LeftArrow: 
                        horizontal--; 
                        break;
                    case ConsoleKey.RightArrow: 
                        horizontal++; 
                        break;

                    case ConsoleKey.Enter: 
                        finalizar = true; 
                        break;
                }

                // Reiniciamos el valor de nuestras variables en caso de sobrepasar el limite.
                if (vertical < 0) vertical = 8; else if (vertical > 8) vertical = 0;
                if (horizontal < 0) horizontal = 8; else if (horizontal > 8) horizontal = 0;

                // Segun que indice tiene nuestra variable seleccionamos un color para el fondo.
                switch (horizontal)
                {
                    case 0:
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            MenuPersonalizar();
                            break;
                        }
                    case 1:
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            MenuPersonalizar();
                            break;
                        }
                    case 2:
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            MenuPersonalizar();
                            break;
                        }
                    case 3:
                        {
                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                            MenuPersonalizar();
                            break;
                        }
                    case 4:
                        {
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            MenuPersonalizar();
                            break;
                        }
                    case 5:
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            MenuPersonalizar();
                            break;
                        }
                    case 6:
                        {
                            Console.BackgroundColor = ConsoleColor.Cyan;
                            MenuPersonalizar();
                            break;
                        }
                    case 7:
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            MenuPersonalizar();
                            break;
                        }
                    case 8:
                        {
                            Console.BackgroundColor = ConsoleColor.Magenta;
                            MenuPersonalizar();
                            break;
                        }
                    default:
                        break;
                }

                // Segun que indice tiene nuestra variable seleccionamos un color para las letras.
                switch (vertical)
                {
                    case 0:
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            MenuPersonalizar();
                            break;
                        }
                    case 1:
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            MenuPersonalizar();
                            break;
                        }
                    case 2:
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            MenuPersonalizar();
                            break;
                        }
                    case 3:
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            MenuPersonalizar();
                            break;
                        }
                    case 4:
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            MenuPersonalizar();
                            break;
                        }
                    case 5:
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            MenuPersonalizar();
                            break;
                        }
                    case 6:
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            MenuPersonalizar();
                            break;
                        }
                    case 7:
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            MenuPersonalizar();
                            break;
                        }
                    case 8:
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            MenuPersonalizar();
                            break;
                        }
                    default:
                        break;
                }
            }
            Console.CursorVisible = true;
            MenuInicio();
        }

        // Menu secundario.
        static void OpcionesDeTabla(string[,] tablaFrases, ref int cantidadFrases, bool vip, DateTime fechaInicial)
        {
            int opcionB = 0;
            while (opcionB != 12)
            {
                MenuSecundario(cantidadFrases);
                opcionB = NumeroValido(1, 12);
                switch (opcionB)
                {
                    case 1: // Agregar frase.
                        if (cantidadFrases == 25)
                            ErrorNoEspacio();
                        else
                        {
                            AgregarFrase(tablaFrases, cantidadFrases);
                            cantidadFrases += 1;
                        }
                        break;

                    case 2: // Eliminar frase.
                        if (cantidadFrases == 0)
                            ErrorNoFrases();
                        else
                            EliminarFrase(tablaFrases, ref cantidadFrases);
                        break;

                    case 3: // Remplazar frase (Solo vip).
                        if (vip)
                            if (cantidadFrases > 0)
                                RemplazarFrase(tablaFrases, cantidadFrases);
                            else
                                ErrorNoFrases();
                        else
                            ErrorNoVip(opcionB);
                        break;

                    case 4: // Duplicar frase (Solo vip).
                        if (vip)
                            if (cantidadFrases == 0)
                                ErrorNoFrases();
                            else if (cantidadFrases == 25)
                                ErrorNoEspacio();
                            else
                                DuplicarFrase(tablaFrases, ref cantidadFrases);
                        else
                            ErrorNoVip(opcionB);
                        break;

                    case 5: // Invertir frase.
                        if (cantidadFrases == 0)
                            ErrorNoFrases();
                        else
                            InvertirFrase(tablaFrases, cantidadFrases);
                        break;

                    case 6: // Mostrar todas las frases.
                        if (cantidadFrases == 0)
                            ErrorNoFrases();
                        else
                            MostrarTabla(tablaFrases, cantidadFrases);
                        break;

                    case 7:// Mostrar estadisticas generales (Solo vip).
                        if (vip)
                            if (cantidadFrases == 0)
                                ErrorNoFrases();
                            else
                                EstadisticasGenerales(tablaFrases, cantidadFrases, fechaInicial);
                        else
                            ErrorNoVip(opcionB);
                        break;

                    case 8: // Borrar todas las frases (Solo vip).
                        if (vip)
                            if (cantidadFrases < 2)
                                Error2FrasesRequeridas();
                            else
                                BorrarTabla(tablaFrases, ref cantidadFrases);
                        else
                            ErrorNoVip(opcionB);
                        break;

                    case 9: // Buscar una palabra en la tabla.
                        if (cantidadFrases == 0)
                            ErrorNoFrases();
                        else
                            BuscarEnTabla(tablaFrases, cantidadFrases);
                        break;

                    case 10: // Buscar una palabra en una frase (Solo vip).
                        if (vip)
                            if (cantidadFrases == 0)
                                ErrorNoFrases();
                            else
                                BuscarEnFrase(tablaFrases, cantidadFrases);
                        else
                            ErrorNoVip(opcionB);
                        break;

                    case 11: // Mostrar esqueleto de la tabla.
                        if (vip)
                            Esqueleto(tablaFrases);
                        else
                            ErrorNoVip(11);
                        break;
                    case 12: // Volver.
                        break;

                    default:
                        ErrorInesperado();
                        break;
                }
            }
        }

        #endregion

        static void Main(string[] args)
        {
            // Inicializamos datos variados.
            DateTime fechaInicial = DateTime.Now;
            string[,] tablaFrases = new string[25, 10];
            int cantidadFrases = 0, horizontal = 0, vertical = 0;
            bool vip = false;

            // Menu principal.
            int opcion = 0;
            while (opcion != 5)
            {
                MenuInicio();
                opcion = NumeroValido(1, 5);

                switch (opcion)
                {
                    case 1: // Menu de Tabla.
                        OpcionesDeTabla(tablaFrases, ref cantidadFrases, vip, fechaInicial);
                        break;
                    case 2: // Personalizar consola.
                        if (vip)
                            Personalizar(ref horizontal, ref vertical);
                        else
                            ErrorNoVip(0);
                        break;
                    case 3: // Adquirir o remover suscripcion.
                        Suscripcion(ref vip);
                        break;
                    case 4: // Creditos.
                        Creditos();
                        break;
                    case 5: // Salir.
                        Salir(fechaInicial);
                        break;
                    default:
                        ErrorInesperado();
                        break;
                }
            }
        }
    }
}
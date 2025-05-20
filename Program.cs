using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ChepeBuscado
{
    internal class Program
    {
        static int[] array = new int[0];
        static Hash hash = new Hash(10);

        static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===== ALGORITMOS DE BUSQUEDA =====");
                Console.WriteLine("1. Búsqueda Secuencial");
                Console.WriteLine("2. Búsqueda Secuencial Ordenada");
                Console.WriteLine("3. Búsqueda Binaria");
                Console.WriteLine("4. Introducir Arreglo a Tabla Hash");
                Console.WriteLine("5. Ver Tabla Hash");
                Console.WriteLine("6. Buscar por Clave en Tabla Hash");
                Console.WriteLine("7. Insertar Arreglo Manualmente");
                Console.WriteLine("8. Crear Arreglo Aleatorio");
                Console.WriteLine("9. Ver Arreglo Actual");
                Console.WriteLine("10. Crear Arreglo Ordenado Automáticamente");
                Console.WriteLine("11. Salir");
                Console.Write("Selecciona una opción: ");

                string opcion = Console.ReadLine();

                if (opcion == "11")
                    break;

                switch (opcion)
                {
                    case "1":
                        if (array.Length == 0)
                        {
                            Console.WriteLine("Primero crea el arreglo (opción 7, 8 o 10).");
                            Console.ReadLine();
                            break;
                        }
                        Console.Write("Número a buscar: ");
                        int b1 = Convert.ToInt32(Console.ReadLine());
                        Search.UnorderedLinear(array, b1);
                        Console.ReadLine();
                        break;

                    case "2":
                        if (array.Length == 0)
                        {
                            Console.WriteLine("Primero crea el arreglo (opción 7, 8 o 10).");
                            Console.ReadLine();
                            break;
                        }
                        Console.Write("Número a buscar: ");
                        int b2 = Convert.ToInt32(Console.ReadLine());
                        Search.OrderedLinear(array, b2);
                        Console.ReadLine();
                        break;

                    case "3":
                        if (array.Length == 0)
                        {
                            Console.WriteLine("Primero crea el arreglo (opción 7, 8 o 10).");
                            Console.ReadLine();
                            break;
                        }
                        Console.Write("Número a buscar: ");
                        int b3 = Convert.ToInt32(Console.ReadLine());
                        Search.Binary(array, b3);
                        Console.ReadLine();
                        break;

                    case "4":
                        if (array.Length == 0)
                        {
                            Console.WriteLine("Primero crea el arreglo.");
                            Console.ReadLine();
                            break;
                        }
                        InsertarArregloEnHash(array);
                        Console.WriteLine("Arreglo insertado en tabla hash con claves automáticas.");
                        Console.ReadLine();
                        break;

                    case "5":  // Mostrar tabla hash
                        Console.WriteLine("Contenido de la tabla hash:");
                        hash.DisplayTable();
                        Console.ReadLine();
                        break;

                    case "6":
                        Console.Write("Clave a buscar: ");
                        int clave = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Resultado: ");
                        hash.Get(clave);
                        Console.ReadLine();
                        break;

                    case "7":
                        Console.Write("¿Cuántos elementos tendrá el arreglo? ");
                        int n = Convert.ToInt32(Console.ReadLine());

                        array = new int[n];
                        Console.WriteLine("Introduce los valores:");
                        for (int i = 0; i < n; i++)
                        {
                            Console.Write($"Elemento {i}: ");
                            array[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine("Arreglo creado:");
                        MostrarArreglo(array);
                        Console.ReadLine();
                        break;

                    case "8":
                        Console.Write("¿Cuántos elementos tendrá el arreglo aleatorio? ");
                        int m = Convert.ToInt32(Console.ReadLine());

                        Random rnd = new Random();
                        array = new int[m];
                        for (int i = 0; i < m; i++)
                            array[i] = rnd.Next(1, 101);

                        Console.WriteLine("Arreglo aleatorio creado:");
                        MostrarArreglo(array);
                        Console.ReadLine();
                        break;

                    case "9":
                        MostrarArreglo(array);
                        Console.ReadLine();
                        break;

                    case "10":
                        Console.Write("¿Cuántos elementos tendrá el arreglo ordenado? ");
                        int o = Convert.ToInt32(Console.ReadLine());

                        array = new int[o];
                        for (int i = 0; i < o; i++)
                        {
                            array[i] = (i + 1) * 10;
                        }

                        Console.WriteLine("Arreglo ordenado creado automáticamente:");
                        MostrarArreglo(array);
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        Console.ReadLine();
                        break;
                }
            }
        }

        static void InsertarArregloEnHash(int[] array)
        {
            int clave = 0;
            foreach (var valor in array)
            {
                hash.Insert(valor, clave);
                clave++;
            }
        }

        static void MostrarArreglo(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                Console.WriteLine("Arreglo vacío.");
                return;
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChepeBuscado
{
    internal class Search
    {
        public static void UnorderedLinear(int[] array, int element)
        {
            int i = 0;

            while (i < array.Length && array[i] != element)
            {
                i++;
            }

            if (i == array.Length)
            {
                Console.WriteLine("El elemento no esta en el arreglo");
            }
            else
            {
                Console.WriteLine("El elemento esta en la posicion " + i);
            }
        }

        public static void OrderedLinear(int[] array, int element)
        {
            int i = 0;

            while (i < array.Length && element > array[i])
            {
                i++;
            }

            if (i == array.Length || element < array[i])
            {
                Console.WriteLine("El elemento no esta en el arreglo");
            }
            else
            {
                Console.WriteLine("El elemento esta en la posicion " + i);
            }
        }

        public static void Binary(int[] array, int element)
        {
            int left = 0;
            int right = array.Length - 1;
            int center = right + 1 / 2;
            bool flag = false;

            while (left <= right && flag == false)
            {
                center = right + 1 / 2;
                if (element == array[center])
                {
                    flag = true;
                }
                else
                {
                    if (element > array[center])
                    {
                        left = center + 1;
                    }
                    else
                    {
                        right = center - 1;
                    }
                }
            }

            if (flag)
            {
                Console.WriteLine("El elemento esta en la posicion " + center);
            }
            else
            {
                Console.WriteLine("El elemento no esta en el arreglo");
            }
        }
    }
}

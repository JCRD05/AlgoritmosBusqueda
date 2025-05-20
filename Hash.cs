using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChepeBuscado
{
    internal class Hash
    {
        private int size;
        private List<(int key, int value)>[] table;

        public Hash(int size)
        {
            this.size = size;
            table = new List<(int, int)>[size];
            for (int i = 0; i < size; i++)
            {
                table[i] = new List<(int, int)>();
            }
        }

        public void Insert(int value, int key)
        {
            int index = HashModule(key);
            for (int i = 0; i < table[index].Count; i++)
            {
                if (table[index][i].key == key)
                {
                    table[index][i] = (key, value); // Actualizar si ya existe
                    return;
                }
            }
            table[index].Add((key, value));
        }

        public void Get(int key)
        {
            int index = HashModule(key);
            foreach (var pair in table[index])
            {
                if (pair.key == key)
                {
                    Console.WriteLine(pair.value);
                    return;
                }
            }
            Console.WriteLine("El elemento no es parte del arreglo");
            return;
        }

        private int HashModule(int key)
        {
            return key % size;
        }

        public void DisplayTable()
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write("Index " + i + ": ");
                if (table[i].Count == 0)
                {
                    Console.WriteLine("Empty");
                }
                else
                {
                    foreach (var pair in table[i])
                    {
                        Console.Write("[Key: " + pair.key + ", Value: " + pair.value + "] ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}

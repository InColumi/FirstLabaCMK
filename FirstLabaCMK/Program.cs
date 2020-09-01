using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLabaCMK
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int m;
            int n;
            List<int> simpleNumbers;
            bool[] maybeSimple; 
            Console.Write("Enter start number: ");
            input = Console.ReadLine();
            if (int.TryParse(input, out m))
            {
                simpleNumbers = new List<int>(m);
                maybeSimple = new bool[m];
                Fill(maybeSimple, true);
                for (int i = 2; i * i < m; i++) 
                {
                    if (maybeSimple[i])
                    {
                        for (int j = i * i; j < m; j+=i)
                        {
                            maybeSimple[j] = false;
                        }
                    }
                }

                simpleNumbers.Add(0);
                simpleNumbers.Add(1);
                for (int i = 2; i < m; i++)
                {
                    if (maybeSimple[i])
                    {
                        simpleNumbers.Add(i);
                    }
                }

                ShowArray(simpleNumbers);
            }
            else
            {
                Console.WriteLine("Wrong number");
            }
            
            Console.ReadKey();
            Console.Clear();
        }

        static void Fill(bool[] numbers, bool element)
        {
            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = element;
        }

        static void ShowArray(bool[] array)
        {
            Console.Write("[ ");
            for (int i = 0; i < array.Length - 1; i++)
                Console.Write(array[i] + ", ");
            Console.WriteLine(array[array.Length - 1] + " ]");
        }

        static void ShowArray(List<int> array)
        {
            Console.Write("[ ");
            for (int i = 0; i < array.Count - 1; i++)
                Console.Write(array[i] + ", ");
            Console.WriteLine(array[array.Count - 1] + " ]");
        }
    }
}

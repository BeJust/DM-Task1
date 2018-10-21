using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите упорядоченный массив для поиска, разделяя элементы пробелом: ");
            string[] strelems = Console.ReadLine().Split(' ');
            int[] searchingArr = new int[strelems.Length];
            for (int i = 0; i < strelems.Length; i++)
            {
                searchingArr[i] = int.Parse(strelems[i]);
            }
            Console.WriteLine("Введите число которое ищем: ");
            int target = int.Parse(Console.ReadLine());

            string result = SearchAnalyser.BinarySearchAnalyser(searchingArr, target);
            Console.WriteLine(result);
        }
    }
}

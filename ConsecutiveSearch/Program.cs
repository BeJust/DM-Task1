using System;
using ClassLib;

namespace ConsecutiveSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите массив для поиска, разделяя элементы пробелом: ");
            string[] strelems = Console.ReadLine().Split(' ');
            int[] searchingArr = new int[strelems.Length];
            for(int i = 0; i < strelems.Length; i++)
            {
                searchingArr[i] = int.Parse(strelems[i]);
            }
            Console.WriteLine("Введите число которое ищем: ");
            int target = int.Parse(Console.ReadLine());

            string result = SearchAnalyser.ConsecutiveSearchAnalyser(searchingArr, target);
            Console.WriteLine(result);
        }
    }
}

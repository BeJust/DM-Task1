using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public static class SearchAnalyser
    {
        public static string ConsecutiveSearchAnalyser(int[] searchingArr, int target)
        {
            int n = 0; //comparison number
            bool found = false;

            for (int i = 0; i < searchingArr.Length; i++)
            {
                n++;
                if (searchingArr[i] == target)
                {
                    found = true;
                    break;
                }
            }
            if (found)
            {
                return String.Format("Элемент найден,количество сравнений: {0}", n);
            }
            else
            {
                return String.Format("Запрошенного элемента нет в массиве, количество сравнений: {0}", n);
            }
        }

        public static string BinarySearchAnalyser(int[] searchingArr, int target)
        {
            int n = 0;

           if ((searchingArr.Length == 0) || (target < searchingArr[0]) || (target > searchingArr[searchingArr.Length - 1]))
               return String.Format("Элемента нет в массиве");

            int first = 0;

            int last = searchingArr.Length;

            while (first < last)
            {
                int mid = first + (last - first) / 2;

                if (target <= searchingArr[mid])
                {

                    last = mid;
                    n++;
                }
                else
                {
                    first = mid + 1;
                    n++;
                }
            }

            if (searchingArr[last] == target)
                return String.Format("Элемент найден, количество сравнений: {0}", n);
            else
                return String.Format("Элемент не найден, количество сравнений: {0}", n);
        }
    }
}

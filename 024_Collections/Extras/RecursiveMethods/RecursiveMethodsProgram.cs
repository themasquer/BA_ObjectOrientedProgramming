using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _024_Collections.Extras.RecursiveMethods
{
    static class RecursiveMethodsProgram
    {
        public static void Run()
        {
            DisplayNumbers(1, 10);
            DisplayNumbersRecursive(10, 20, 2);

            List<int> list = new List<int>()
            {
                1,
                2,
                3,
                4,
                5
            };
            int itemToFind = 3;
            int? itemResult = FindItemInListByLoop(list, itemToFind);

            //if (itemResult == null)
            //    Console.WriteLine("Item not found.");
            //else
            //    Console.WriteLine(itemResult + " found.");
            if (!itemResult.HasValue)
                Console.WriteLine("Item not found.");
            else
                Console.WriteLine(itemResult.Value + " found.");

            itemResult = FindItemInListByRecursion(list, itemToFind);
            Console.WriteLine(itemResult.HasValue ? itemResult.Value + " found." : itemToFind + " not found.");
            itemResult = FindItemInListByLinq(list, itemToFind);
            Console.WriteLine(itemResult.HasValue ? itemResult.Value + " found." : itemToFind + " not found.");
            itemToFind = 6;
            itemResult = FindItemInListByLoop(list, itemToFind);
            if (itemResult == null)
                Console.WriteLine(itemToFind + " not found.");
            else
                Console.WriteLine(itemResult + " found.");
            itemResult = FindItemInListByRecursion(list, itemToFind);
            Console.WriteLine(itemResult.HasValue ? itemResult.Value + " found." : itemToFind + " not found.");
            itemResult = FindItemInListByLinq(list, itemToFind);
            Console.WriteLine(itemResult.HasValue ? itemResult.Value + " found." : itemToFind + " not found.");
        }

        static void DisplayNumbers(int start, int end, int increment = 1)
        {
            for (int i = start; i <= end; i += increment)
            {
                Console.WriteLine(i);
            }
        }

        static void DisplayNumbersRecursive(int start, int end, int increment = 1)
        {
            if (start > end)
            {
                return;
            }
            Console.WriteLine(start);
            start += increment;
            DisplayNumbersRecursive(start, end, increment);
        }

        static int? FindItemInListByLoop(List<int> list, int itemToFind)
        {
            //Nullable<int> result = null;
            int? result = null;
            foreach (var item in list)
            {
                if (item == itemToFind)
                {
                    result = item;
                    break;
                }
            }
            return result;
        }

        static int? FindItemInListByRecursion(List<int> list, int itemToFind, int? result = null)
        {
            if (list[0] == itemToFind)
            {
                result = list[0];
            }
            else
            {
                list.RemoveAt(0);
                if (list.Count > 0)
                {
                    result = FindItemInListByRecursion(list, itemToFind, result);
                }
            }
            return result;
        }

        static int? FindItemInListByLinq(List<int> list, int itemToFind)
        {
            try
            {
                int result = list.Single(item => item == itemToFind);
                return result;
            }
            catch
            {
                return null;
            }
        }
    }
}

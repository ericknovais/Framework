using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysListas
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new ArrayList() { 1, 2, 3, 4, 5, 6 };
            var nums2 = new ArrayList() { 8, 9, 10, 11, 12, 13 };

            nums.Add(7);
            nums.Insert(3, 999);
            nums.Remove(4);
            nums[5] = 888;
            nums.AddRange(nums2);
            //nums.Add("abc"); // object
            //foreach (var n in nums)
            //{
            //    Console.WriteLine(n);
            //}
            Console.WriteLine("Capacidade: " + nums.Capacity);
            Console.WriteLine("Num. items: " + nums.Count);
            Console.WriteLine("Posição do 999: "+ nums.IndexOf(999));

            var qry = from int n in nums
                      where n % 2 == 0
                      select n;

            foreach(int n in qry)
                Console.WriteLine(n);
            Console.ReadLine();
        }

        private static void ExemploVetores()
        {
            int[] nums = new int[] { 1, 2, 3, 4, 5, 6 };
            foreach (int n in nums)
            {
                Console.WriteLine(n);
            }
        }
    }
}

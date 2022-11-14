using AlgsDataStucturesPractice.Data_Structures.Linked_Lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AlgsDataStucturesPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LinkedList Testing
            MyLL testLL = new MyLL();
            Console.Out.WriteLine("Hello");
            testLL.print(); //Output: []
            testLL.add(5);
            testLL.add(3);
            testLL.add(1);
            testLL.add(2);
            testLL.add(4);
            testLL.print(); //Output: [5, 3, 1, 2, 4]
            testLL.removeInt(4);
            testLL.print(); //Output: [5, 3, 1, 2]
            testLL.add(4);
            testLL.removeatPos(3);
            testLL.print(); //Output: [5, 3, 1, 4]
            testLL.reverse();
            testLL.print(); //Output: [4, 1, 3, 5]
            testLL.removeatPos(3);
            testLL.removeatPos(1);
            testLL.print(); //Output: [1, 3, 5]
            testLL.sort();
            testLL.print(); //Output: [1, 3, 4, 5]


            //Sorting test cases
            /*
            Sorting test = new Sorting();
            int[] test_arr1 = new int[] {1, 0, 3, 2, 3 };
            int[] test_arr2 = new int[] { 3, 2, 1, 0, 1 };
            int[] test_arr3 = new int[] { 3, 1, 1 };
            int[] test_arr4 = new int[] { 2, 2 };
            int[] test_arr5 = new int[] { 4 };
            int[] test_arr6 = new int[0];

            //bubble sort testing
            Console.Out.WriteLine(test.bubble_sort(test_arr1));
            Console.Out.WriteLine(test.bubble_sort(test_arr2));
            Console.Out.WriteLine(test.bubble_sort(test_arr3));
            Console.Out.WriteLine(test.bubble_sort(test_arr4));
            Console.Out.WriteLine(test.bubble_sort(test_arr5));
            Console.Out.WriteLine(test.bubble_sort(test_arr6));

            //counting sort testing
            Console.Out.WriteLine(test.counting_sort(test_arr1));
            Console.Out.WriteLine(test.counting_sort(test_arr2));
            Console.Out.WriteLine(test.counting_sort(test_arr3));
            Console.Out.WriteLine(test.counting_sort(test_arr4));
            Console.Out.WriteLine(test.counting_sort(test_arr5));
            Console.Out.WriteLine(test.counting_sort(test_arr6));
            */
        }
    }
}

using AlgsDataStucturesPractice.Data_Structures.BinaryTree;
using AlgsDataStucturesPractice.Data_Structures.Linked_Lists;
using AlgsDataStucturesPractice.Data_Structures.Stacks;
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
            //Binary Tree Testing
            MyBSTree testTree = new MyBSTree();
            testTree.add(16);
            testTree.add(8);
            testTree.add(24);
            testTree.add(4);
            testTree.add(12);
            testTree.add(20);
            testTree.add(28);
            testTree.add(2);
            testTree.add(6);
            testTree.add(10);
            testTree.add(14);
            testTree.add(18);
            testTree.add(22);
            testTree.add(26);
            testTree.add(30);
            testTree.add(1);
            testTree.add(3);
            testTree.add(5);
            testTree.add(7);
            testTree.add(9);
            testTree.add(11);
            testTree.add(13);
            testTree.add(15);
            testTree.add(17);
            testTree.add(19);
            testTree.add(21);
            testTree.add(23);
            testTree.add(25);
            testTree.add(27);
            testTree.add(29);
            testTree.add(31);
            testTree.printBFS();
            testTree.remove(2);
            Console.Out.WriteLine();
            testTree.printBFS();

            //Stack Testing
            /*
            MyStack testStack = new MyStack(5);
            Console.Out.WriteLine(testStack.isEmpty()); //Output: true
            Console.Out.WriteLine(testStack.isFull()); //Output: false
            testStack.print(); //Output: []
            testStack.push(1);
            testStack.print(); //Output: [1]
            testStack.push(2);
            testStack.push(15);
            testStack.pop();
            testStack.push(0);
            testStack.push(40);
            testStack.push(12);
            testStack.print();
            Console.Out.WriteLine(testStack.isFull()); //Output: true
            Console.Out.WriteLine(testStack.isEmpty()); //Output: false
            */



            //LinkedList Testing
            /*
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
            */

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

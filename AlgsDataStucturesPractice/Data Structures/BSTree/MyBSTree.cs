using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AlgsDataStucturesPractice.Data_Structures.BinaryTree
{
    internal class MyBSTree
    {
        
        /*
         * Class was originally a binary search tree class, but as I wrote improvements to the code, it became more of an AVL Tree. 
         * The tree is automatically sorted by node value when added (left most node is the smallest value and right most ndoe is the lasrgest value)
         * At each node addition and removal, the tree is checked to see if the heights are balanced
        */

        public TNode root;

        public MyBSTree()
        {

        }

        /* Add a node to the sorted tree. Places in a location that all nodes to the left of it are less than it, and all nodes to the right are greater than
         * Methods used:
         *      add()
        */
        public void add(int val)
        {
            TNode adder = new TNode(val);
            if (this.root == null)
            {
                root = adder;
                return;
            }
            TNode curr = this.root;
            while (curr != null)
            {
                if (curr.r_child == null && val > curr.value)
                {
                    curr.r_child = adder;
                    return;
                }
                if (curr.l_child == null && val <= curr.value)
                {
                    curr.l_child = adder;
                    return;
                }
                if (val < curr.value)
                {
                    curr = curr.l_child;
                }
                else
                {
                    curr = curr.r_child;
                }

            }
            curr = adder;
        }

        /* Removes a node to the sorted tree. If need be, deals with the children once the node is removed
         * Methods used:
         *      remove()
         *      remove_root()
        */
        public void remove(int val)
        {
            if (this.root.value == val)
            {
                remove_root(this.root);
            }
            TNode temp_root = this.root;
            while (temp_root.l_child != null || temp_root.r_child != null)
            {
                if (temp_root.l_child.value == val || temp_root.r_child.value == val)
                {
                    if (temp_root.l_child.value == val)
                    {
                        if (temp_root.l_child.l_child == null && temp_root.l_child.r_child == null)
                        {
                            temp_root.l_child = null;
                            return;
                        }
                        remove_root(temp_root.l_child);
                        return;
                    }
                    if (temp_root.r_child.value == val)
                    {
                        if (temp_root.r_child.l_child == null && temp_root.r_child.r_child == null)
                        {
                            temp_root.r_child = null;
                            return;
                        }
                        remove_root(temp_root.r_child);
                    }
                }
                if (val < temp_root.value)
                {
                    temp_root = temp_root.l_child;
                } 
                else if (val > temp_root.value) 
                {
                    temp_root = temp_root.r_child;
                } 
                else
                {
                    if (temp_root.l_child == null && temp_root.r_child == null)
                    {

                    }
                    remove_root(temp_root);
                }
                
                
            }
        }
        public void remove_root(TNode subroot)
        {
            TNode temp = subroot;
            //case: leaf
            if (subroot.l_child == null && subroot.r_child == null)
            {
                subroot.value = -1;
            }
            //case: one side is empty
            else if (subroot.l_child == null || subroot.r_child == null)
            {
                if (subroot.l_child == null) {
                    subroot.value = subroot.r_child.value;
                    subroot.l_child = subroot.r_child.l_child;
                    subroot.r_child = subroot.r_child.r_child;
                }
                if (subroot.r_child == null)
                {
                    subroot.value = subroot.l_child.value;
                    subroot.l_child = subroot.l_child.l_child;
                    subroot.r_child = subroot.l_child.r_child;
                }
            }

            //case: both are filled
            else
            {
                temp = subroot.l_child;
                if (temp.r_child == null)
                {
                    subroot.value = temp.value;
                    subroot.l_child = temp.l_child;
                    return;
                }
                while (temp.r_child.r_child != null)
                {
                    temp = temp.r_child;
                }
                subroot.value = temp.r_child.value;
                temp.r_child = null;
            }
        }
        
        public void sort()
        {
            /*Steps to check to make sure that the tree is sorted:
             *  traverse through the tree and make sure that at every node, the heights are balanced
             */
            bool balanced = true;
            while (balanced == true)
            {

            }
        }

        public void traverse(TNode node)
        {

        }

        public bool check_balanced(TNode temp_r)
        {
            if (temp_r.l_child == null || temp_r.r_child == null)
            {
                return true;
            }
            if (Math.Abs(height(temp_r.l_child.value) - temp_r.r_child.value) < 2)
            {
                return true;
            }
            return false;
        }

        public int findheight(TNode r)
        {
            if (r == null)
            {
                return 0;
            }
            else
            {
                return Math.Max(findheight(r.l_child), findheight(r.r_child)) + 1;
            }
        }

        public int height(int val)
        {
            TNode curr = this.root;
            while (curr != null)
            {
                if (val < curr.value)
                {
                    curr = curr.l_child;
                } else if (val > curr.value)
                {
                    curr = curr.r_child;
                } else
                {
                    return findheight(curr);
                }
            }
            return -1;
        }

        /*
         * Prints the tree in a DFS traversal method. 
         * Methods used:
         *      printDFS()
         *      DFSreturn()
        */

        public string DFSreturn(TNode initial)
        {
            if (initial.l_child == null && initial.r_child != null)
            {
                return (initial.value.ToString() + ",None," + DFSreturn(initial.r_child));
            }
            if (initial.r_child == null && initial.l_child != null)
            {
                return (initial.value.ToString() + "," + DFSreturn(initial.l_child) + "None,");
            }
            if (initial.r_child == null && initial.l_child == null)
            {
                if (initial.value == 8)
                {
                    Console.Out.WriteLine("pass");
                }
                return initial.value.ToString() + ",";
            }
            else
            {
                return initial.value.ToString() + "," + DFSreturn(initial.l_child) + DFSreturn(initial.r_child);
            }
        }

        public void printDFS()                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  
        {
            string output = "[" + DFSreturn(this.root);
            output = output.Remove(output.Length - 1, 1);
            output += "]";
            Console.Out.WriteLine(output);

        }
        /*
         * Prints the tree in a BFS traversal method. 
         * Methods used:
         *      printBFS()
         *      BFSreturn()
         *      printCurrentLevel()
        */
        public string BFSreturn(TNode subroot)
        {
            if (subroot.l_child == null && subroot.r_child == null)
            {
                return(subroot.value.ToString() + ",");
            }
            if (subroot.r_child == null && subroot.l_child != null)
            {

            }
            return "";
        }
        public void printBFS()
        {
            int h = height(this.root.value);
            int i;
            for (i = 1; i <= h; i++)
            {
                printCurrentLevel(this.root, i);
            }
        }
        public virtual void printCurrentLevel(TNode r, int level)
        {
            if (r == null)
            {
                Console.Out.Write("None ");
                return;
            }
            if (level == 1)
            {
                Console.Out.Write(r.value + " ");
            }
            else if (level > 1)
            {
                printCurrentLevel(r.l_child, level - 1);
                printCurrentLevel(r.r_child, level - 1);
            }
        }
    }
}

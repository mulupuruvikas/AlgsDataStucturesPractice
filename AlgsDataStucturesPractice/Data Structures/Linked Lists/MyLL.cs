using AlgsDataStucturesPractice.Sorting_Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDataStucturesPractice.Data_Structures.Linked_Lists
{
    internal class MyLL
    {
        
        public MyLL()
        {

        }

        public NodeLL head;

        public void add(int value)
        {
            NodeLL c;
            if (this.head == null)
            {
                this.head = new NodeLL(value);
                return;
            }
            for (c = this.head; c.next != null; c = c.next) { }
            c.next = new NodeLL(value);
        }

        public void removeatPos(int index)
        {
            NodeLL c = this.head;
            if (index == 0)
            {
                this.head = c.next;
                c.next = null;
                return;
            }
            for (int i = 0; i < index - 1; i++)
            {
                try
                {
                    c = c.next;
                }
                catch
                {
                    return;
                }
            }
            NodeLL n = c.next;
            c.next = n.next;
            n.next = null;
        }

        public void removeInt(int v)
        {
            NodeLL c = this.head;
            NodeLL n;
            for (c = this.head; c.next.value != v && c != null; c = c.next) { }
            n = c.next;
            c.next = n.next;
            n.next = null;

        }

        public void sort()
        {
            if (this.head == null || this.head.next == null)
            {
                return;
            }
            
            bool changed = true;


            while (changed == true)
            {
                NodeLL p = null;
                NodeLL x = this.head;
                NodeLL y = x.next;
                changed = false;
                while (y != null)
                {
                    if (x.value > y.value) 
                    {
                        NodeLL z = y.next;
                        y.next = x;
                        x.next = z;
                        changed = true;
                        if (x == this.head)
                        {
                            this.head = y;
                        } else
                        {
                            p.next = y;
                        }
                        x = y;
                        y = y.next;
                    }
                    p = x;
                    x = x.next;
                    y = y.next;
                }
            }
        }

        public void reverse()
        {
            if (this.head == null || this.head.next == null)
            {
                return;
            }

            NodeLL p = null;
            NodeLL c = this.head;
            NodeLL n = this.head.next;

            for (c = this.head; n != null; n = n.next)
            {
                c.next = p;
                p = c;
                c = n;
            }
            c.next = p;
            this.head = c;
            return;
        }
        public void print()
        {
            if (head == null)
            {
                Console.Out.WriteLine("[]");
                return;
            }
            string output = "[";
            for (NodeLL c = this.head; c != null; c = c.next)
            {
                output += c.value.ToString() + ",";
            }
            output = output.Remove(output.Length - 1, 1);
            output += "]";
            Console.Out.WriteLine(output);
        }


    }
}

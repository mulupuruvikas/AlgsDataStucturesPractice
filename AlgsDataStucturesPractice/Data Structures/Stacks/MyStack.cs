using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDataStucturesPractice.Data_Structures.Stacks
{
    internal class MyStack
    {
        int capacity;
        Element bottom;

        public MyStack()
        {

        }
        
        public MyStack(int c)
        {
            this.capacity = c;
        }

        public void push(int val)
        {
            Element adder = new Element(val);
            if (bottom == null)
            {
                bottom = adder;
                return;
            }
            int counter = 0;
            Element c;

            for(c = bottom; c.top != null; c = c.top)
            {
                counter++;
            }
            if (counter >= this.capacity)
            {
                Console.Out.WriteLine("Capacity exceeded.");
                return;
            }
            c.top = adder;
            return;
        }

        public int pop()
        {
            if (this.bottom == null)
            {
                Console.Out.WriteLine("Stack is empty. Cannot pop an element.");
                return -1;
            }
            if (this.bottom.top == null)
            {
                int output = this.bottom.value;
                this.bottom = null;
                return output;
            }
            Element p = this.bottom;
            Element c;
            for (c = p.top; c.top != null; c = c.top)
            {
                p = p.top;
            }
            p.top = null;
            return c.value;
        }

        public int peek()
        {
            if (this.bottom == null)
            {
                Console.Out.WriteLine("Stack is empty. Cannot pop an element.");
                return -1;
            }
            if (this.bottom.top == null)
            {
                int output = this.bottom.value;
                this.bottom = null;
                return output;
            }
            Element p = this.bottom;
            Element c;
            for (c = p.top; c.top != null; c = c.top)
            {
                p = p.top;
            }
            return c.value;
        }

        public bool isFull()
        {
            int counter = 0;
            Element c;

            for (c = bottom; c != null; c = c.top)
            {
                counter++;
            }
            if (counter == this.capacity)
            {
                return true;
            }
            return false;
        }
        public bool isEmpty()
        {
            if (bottom == null)
            {
                return true;
            }
            return false;
        }

        public void print()
        {
            if (bottom == null)
            {
                Console.Out.WriteLine("[]");
                return;
            }

            string output = "[";
            for (Element c = bottom;  c != null; c = c.top)
            {
                output += c.value.ToString() + ",";
            }
            output = output.Remove(output.Length - 1, 1);
            output += "]";
            Console.Out.WriteLine(output);
        }
    }
}

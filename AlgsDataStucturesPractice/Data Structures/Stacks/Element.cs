using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDataStucturesPractice.Data_Structures.Stacks
{
    internal class Element
    {
        public int value;
        public Element top;

        public Element()
        {

        }

        public Element(int val)
        {
            this.value = val;
        }
    }
}

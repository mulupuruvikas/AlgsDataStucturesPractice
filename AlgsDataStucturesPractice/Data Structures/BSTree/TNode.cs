using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgsDataStucturesPractice.Data_Structures.BinaryTree
{
    internal class TNode
    {
        public int value;
        public TNode l_child;
        public TNode r_child;

        public TNode ()
        {

        }
        
        public TNode(int v)
        {
            this.value = v;
        }
    }
}

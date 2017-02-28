using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working_with_Linked_List
{
    public class Node
    {
        public Node next { get; set; }
        public object data { get; set; }

        public Node(object o)
        {
            data = o;
            next = null;
        }
    }
}

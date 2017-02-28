using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working_with_Linked_List
{
    
    class MyList
    {
        
        private Node head { get; set; }

        public MyList()
        {
            head = null;
        }
        public void Insert(object data)
        {
            Node toAdd = new Node(data);

            toAdd.data = data;
            toAdd.next = head;

            head = toAdd;
        }

     


        public void Delete()
        {
            Node temp = head;
            head = head.next;
            temp.next = null;
        }
        public string Search(string c)
        {
            Node cur = head;
            int i = Convert.ToInt32(c);
            int counter = 0;
            while (counter == i || cur.next == null)
            {
                cur = cur.next;
                counter++;
            }
            return cur.ToString();
        }
        public override string ToString()
        {
            string s = "";
            Node cur = head;
            while (cur.next != null)
            {
                s =s+ "\n" + cur.data;
                cur = cur.next;
            }
            return s;
        }
    }
}

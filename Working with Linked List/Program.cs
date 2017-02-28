using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working_with_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList myList = new MyList();

            //add to list
            ClubMember clubmember1 = new ClubMember(0, "Surer", "Ali", 20);
            ClubMember clubmember2 = new ClubMember(1, "Sarah", "James", 55);
            ClubMember clubmember3 = new ClubMember(2, "Mark", "Johnson", 2);
            ClubMember clubmember4 = new ClubMember(3, "Peter", "Pen", 7);
            myList.Insert(clubmember1);
            myList.Insert(clubmember2);
            myList.Insert(clubmember3);
            myList.Insert(clubmember4);
          

            // print list
            Console.WriteLine(myList.ToString());
            

            //delelte 
            myList.Delete();
            Console.WriteLine(myList.ToString());

            Console.ReadKey();
        }

    }
}

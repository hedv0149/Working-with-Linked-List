using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working_with_Linked_List
{
    class ClubMember
    {
        public int Nr { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public int Age { get; set; }



        public ClubMember(int n, string f, string l, int a)
        {
            Nr = n;
            FName = f;
            LName = l;
            Age = a;  


        }
        public override string ToString()
        {
            string clubMembersString = "Nr: " + Nr + "; First Name: " + FName + "; Last Name: " + LName + "; Age: " + Age;
            return clubMembersString;
        }

    }
}

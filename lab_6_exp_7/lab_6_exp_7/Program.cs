using System;
using System.Collections;
using System.Windows.Forms;

namespace Forms
{
    class Forms
    {

        static void Main(string[] args)
        {
            ArrayList arraylist = new ArrayList();

            arraylist.Add(1);
            arraylist.Add(2);
            arraylist.Add(4.5);

            IList arraylist2 = new ArrayList()
            {
                100, 200
            };
        }
    }

}
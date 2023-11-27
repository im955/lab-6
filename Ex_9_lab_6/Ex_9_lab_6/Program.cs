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
            arraylist.Add("Two");
            arraylist.Add(4.5);

            arraylist.Insert(1, "Second Item");

            foreach (var i in arraylist)
            {
                Console.WriteLine(i);
            }
        }
    }

}
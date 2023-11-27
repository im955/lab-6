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

            arraylist.Add(1000);
            arraylist.Add(2000);
            arraylist.Add(5000);

            arraylist.Remove(1000);

            foreach (var item in arraylist)
            {
                Console.WriteLine(item);
            }
        }
    }

}


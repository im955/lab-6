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

            int FirstElement = (int)arraylist[0];
            string SecondElement = (string)arraylist[1];
            float ThirdElement = (float)arraylist[2];

            var FirstElement = arraylist[0];
        }
    }

}
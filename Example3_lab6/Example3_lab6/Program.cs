using System;
using System.Windows.Forms;

namespace Forms
{
    class Forms 
    {
        static void Main(string[] args)
        {

            List<int> list = new List<int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);

            List<string> list2 = new List<string>();

            foreach (int i in list)
                Console.WriteLine(i);

        }
    }

}
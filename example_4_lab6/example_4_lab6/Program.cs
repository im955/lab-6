using System;
//using System.Windows.Forms;

namespace Forms
{
    static void Print(IList<string> list)
    {
        Console.WriteLine("Count [0]", list.Count);
        foreach (string val in list)
        {
            Console.WriteLine(val);
        }
    }
    class Forms
    {
        static void Main(string[] args)
        {
            string[] strarray = new string[2];
            strarray[0] = "Hello";
            strarray[1] = "World";
            Print(strarray);

            List<string> list = new List<string>();
            list.Add("Hello");
            list.Add("World");
            Print(list);


        }
    }

}
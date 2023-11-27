using System;
using System.Windows.Forms;

namespace Forms
{
    class Forms
    {
        static bool isPositive(int i)
        {
            return i > 0;
        }
        static void Main(string[] args)
        {

            List<int> list = new List<int>() { 10, 20, 30, 40 };

            bool res = list.TrueForAll(isPositive);


        }
    }

}
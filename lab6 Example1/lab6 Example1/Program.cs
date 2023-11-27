using System;
using System.Windows.Forms;
namespace Forms
{
    class Forms
    {
        public partial class YourForm : Forms
        {

        }
        static void Main(string[] args)
        {

            List<int> list = new List<int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);

            List<string> list2 = new List<string>();
            list2.Add("One");
            list2.Add("Two");
            list2.Add("Three");
            list2.Add("Four");
            list2.Add("Four");
            list2.Add(null);
            list2.Add(null);

            IList<int> list3 = list.ToList();

        }

    }
}

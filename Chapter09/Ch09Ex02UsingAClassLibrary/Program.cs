using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ch09ClassLib;

namespace Ch09Ex02UsingAClassLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyInternalClass myObj = new MyInternalClass(); //MyInternalClass() is inaccessible due to its protection level
            MyExternalClass myObj = new MyExternalClass();
            Console.WriteLine(myObj.ToString());
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10Ex01UsingFieldsMethodProperties
{
    public class MyClass
    {
        public readonly string Name;
        private int intVal;
        public int Val
        {
            get { return intVal; }
            set
            {
                if (value >= 0 && value <= 10)
                    intVal = value;
                else
                    throw (new ArgumentOutOfRangeException("Val", value, 
                         "Val must be assigned a value between 0 and 10."));                                                                                                                  
            }
        }
        public override string ToString() => "Name: " + Name + "\nVal: " + Val;//method must be declared using override keyword, 
                                                        //because it overrides the virtual ToString() method of the base System.Object class
        private MyClass() : this("Default Name") { } //instatiation oa a class by using nondefault constructor
                                                    //because the default constructor of MyClass is private
                                                   //using this("Default Name" endures that Name gets a value if the constructor is called
        public MyClass (String newName)
        {
            Name = newName;
            intVal = 0;
        }
        private int myDoubleInt = 5;
        public int myDoubledIntProp => (myDoubleInt * 2);
    }
}

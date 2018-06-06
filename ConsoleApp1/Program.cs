using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        // la solution alternative est utilisé interface implementé par 3 classe A B et C

        static void Main(string[] args)
        {
            IMessage mB = new MessageB();
            IMessage mA = new MessageA();
            IMessage mC= new MessageC();
            mA.MyCustomMethod();
            mB.MyCustomMethod();
            mC.MyCustomMethod();

        }


    }
    
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MessageA : IMessage
    {
        public string MyCustomMethod()
        {
            throw new NotImplementedException();
        }
    }
}

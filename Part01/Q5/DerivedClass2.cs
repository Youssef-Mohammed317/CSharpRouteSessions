using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRouteSessions.Part01.Q5
{
    internal class DerivedClass2 : BaseClass
    {

        // Overriding the DisplayMessage method from BaseClass
        public new void DisplayMessage()
        {
            Console.WriteLine("Message from DerivedClass2");
        }
    }
}

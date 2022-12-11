using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceträning
{
    internal class BankAccount : INameable
    {
        public string Name { get; set; }
        public string AccountNumber { get; set; }
    }
}

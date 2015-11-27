using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Gambler
    {
        protected Gambler(string name)
        {
            Name = name;
        }
        public string Name { get; }
        public double Score { get; private set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class Gambler
    {
        protected Gambler(string name)
        {
            Name = name;
        }
        public string Name { get; }
        public double Score { get; protected set; } = 0;

        public abstract void FetchNewNumber(int number);
    }
}

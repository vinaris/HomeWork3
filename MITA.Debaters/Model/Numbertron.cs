using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Numbertron
    {
        public delegate void NumbertronNumbers(int number);
        public event NumbertronNumbers NewNumber;
        Random rnd = new Random((int)DateTime.Now.Ticks);
        public void Generate()
        {
            int number = rnd.Next();
            NewNumber?.Invoke(number);
            Console.WriteLine(number);
        }
    }
}

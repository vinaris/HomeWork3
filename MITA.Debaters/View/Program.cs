using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Model;

namespace View
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Numbertron numbertron = new Numbertron();
                Gambler jay = new Jay();
                Gambler silentBob = new SilentBob();

                numbertron.NewNumber += jay.FetchNewNumber;
                numbertron.NewNumber += silentBob.FetchNewNumber;

                Console.WriteLine("Наши спорщики: {0} и {1}", jay.Name, silentBob.Name);
                Console.Write("Введите количество чисел: ");
                try
                {
                    var count = Convert.ToInt32(Console.ReadLine());
                    if (count > 0)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            numbertron.Generate();
                            //Thread.Sleep(1); //Необходима для корректной рандомизации
                        }
                        if (jay.Score > silentBob.Score) Console.WriteLine("Jay победил!");
                        else if(jay.Score < silentBob.Score) Console.WriteLine("SilentBob победил!");
                        else Console.WriteLine("Ничья!");
                    }
                    else
                    {
                        Console.WriteLine("Введите число больше 0.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Вы ввели не число! Попробуйте ещё раз.");
                }
            }
        }
    }
}

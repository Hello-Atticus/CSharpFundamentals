using PractialExample.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Lib2
{
    [Unfinished]
    public class Cow : IAnimal
    {
        public void Voice(int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine("Wong Wong");
            }
        }
    }
}

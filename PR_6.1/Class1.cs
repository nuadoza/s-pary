using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PR_6._1.Galaxy;

namespace PR_6._1
{
    internal class Class1
    {
        class Program
        {
            static void Main()
            {
                SpaceBase spaceBase = SpaceBase.GetInstance();
                RandomEventGenerator eventGenerator = RandomEventGenerator.GetInstance();
                spaceBase.ConquerPlanet("Марс");
                string randomEvent = eventGenerator.GetRandomEvent();
                Console.WriteLine($"Случайное событие: {randomEvent}");
            }
        }
    }
}

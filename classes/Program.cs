using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            Engine engine = new Engine();

            void list()
            {
                Console.WriteLine(c.Name);
                Console.WriteLine(c.Model);
                Console.WriteLine(engine.Volume);
                Console.WriteLine(engine.Power);
                Console.WriteLine(engine.Speed);
                Console.WriteLine("------------");
            }

            c.Name = "BMW E60";
            c.Model = "M5";
            engine.Volume = 5.0;
            engine.Power = 506;
            engine.Speed = 349;
            list();

            c.Name = "Bmw F90";
            c.Model = "M5 Competition";
            engine.Volume = 4.4;
            engine.Power = 625;
            engine.Speed = 349;
            list();

            engine.message("Legend M5 is definitely E60 M5 and Legend of son is F90 M5 COMPETITION");
        }
    }
}

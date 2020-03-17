using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace bubblegumMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Gui gui = new Gui();
            Dispenser dispenser = new Dispenser();
            gui.RenderMenu();
            dispenser.FillDispenser();
            bool start = false;
            
            
            while (!start)
            {
                int userInput = int.Parse(Console.ReadLine());
                
                switch (userInput)
                {
                    case 1:
                        Bubblegum gum = dispenser.DrawRandomGum();
                        Console.WriteLine($"You´ve got a gum of: {gum.Name} and the color is: {gum.Color}");
                        Thread.Sleep(2000);
                        Console.Clear();
                        gui.RenderMenu();
                        break;

                    case 2:
                        int count = dispenser.CountBubblegum();
                        Console.WriteLine("bubblegum left in the machine: "+count);
                        Thread.Sleep(2000);
                        Console.Clear();
                        gui.RenderMenu();
                        break;

                    case 3:
                        start = true;
                        break;


                }

            }
        }
    }
}

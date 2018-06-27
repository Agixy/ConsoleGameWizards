using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var wizard1 = new BadWizard(45, 5, "Saruman");
            var wizard2 = new GoodWizard(50, 6, "Gandalf");

            Fight.WizardFight(wizard1, wizard2);

            Console.ReadKey();
        }
    }
}

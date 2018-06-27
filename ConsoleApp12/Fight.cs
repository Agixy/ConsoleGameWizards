using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleGame
{
    public class Fight
    {
        public static void WizardFight(Wizard wizard1, Wizard wizard2)
        {
            bool fightOn = true;
            do
            {
                Random rnd = new Random();
                int option = rnd.Next(100);
                Console.WriteLine(option);
                if (option > 0 && option < 35)
                {
                    wizard1.CastSpell(rnd.Next(1, wizard2.damage + 1), wizard2.name); // wywołujemy dla atakowanego i przekazujemy dane atakującego

                }
                else if (option > 35 && option < 70)
                {
                    wizard2.CastSpell(wizard1.damage, wizard1.name);

                }
                else if (option > 70 && option < 85)
                {
                    wizard1.Heal(rnd.Next(0, 3));
                }
                else if (option < 85 && option < 96)
                {
                    wizard2.Heal(rnd.Next(1, 3));
                }
                else if (option < 85 && option < 96)
                {
                    wizard1.poison = true;
                    wizard1.duration = rnd.Next(1, 3);
                }
                else
                {
                    wizard2.poison = true;
                    wizard2.duration = rnd.Next(1, 3);
                }

                wizard1.Poison();
                wizard2.Poison();

                fightOn = wizard1.IsAlive();
                fightOn = wizard2.IsAlive();
                Thread.Sleep(2000); // aby dodać "using" trzeba najechac myszka -> nacisnac ctrl i . -> Enter aby zatwierdzic -> Using doda sie sam.
            }
            while (fightOn);

            if(wizard1.IsAlive())
            {
                Console.WriteLine($"{wizard1.name} WYGRAŁ !!!");
            }
            else
                Console.WriteLine($"{wizard2.name} WYGRAŁ !!!");
        }
    }
}

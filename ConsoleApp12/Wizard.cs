using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    public abstract class Wizard
    {
        public int health;
        public int damage;
        public string name;
        public int maxHp;
        public bool poison = false;
        public int duration;


        public void CastSpell(int dmg, string damageDealer)
        {
            if (dmg > 0)
            {
                Console.WriteLine(damageDealer + $"Deals {dmg} to {name}");
                health -= dmg;
                Console.WriteLine($"actual hp = {health}");
            }
            else
            {
                Console.WriteLine($"Deals {damageDealer} spell fizzled");
            }
        }
        public void Heal(int heal)
        {
            health += heal;
            if (health > maxHp)
            {
                health = maxHp;
            }
            Console.WriteLine($"{name} drink {heal} hp ");
            Console.WriteLine($"actual hp = {health}");
        }

        public void Poison()
        {
            if (poison)
            {
                Console.WriteLine($"Ucierpial poisonem {name}");
                duration -= 1;
                health -= 3;
                if (duration == 0)
                    poison = false;

            }
        }

            public bool IsAlive()
            {
                if (health <= 0)
                    return false;
                else
                    return true;
            }

        }
    }


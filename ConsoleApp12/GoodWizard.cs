using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    class GoodWizard : Wizard
    {
        public GoodWizard(int hp, int dmg, string name )
        {
            health = hp;
            damage = dmg;
            this.name = name;
            maxHp = hp;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Hero_Game
{
    public class Leader : Enemy
    {
        private Tile target { get; set; }

        public Leader(int x, int y, int enemyArrayNum) : base(x, y, enemyArrayNum)
        {
            HP = 20;
            Damage = 2;
        }
        public override Movement ReturnMove(Movement move = 0)
        {

        }
    }
}

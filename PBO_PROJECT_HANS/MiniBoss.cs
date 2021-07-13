using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace PBO_PROJECT_HANS
{
    public class MiniBoss : Enemy
    {
        int armor;
        

        #region properties
        public int Armor
        {
            get { return armor; }
            set
            {
                if (value < 0)
                {
                    armor = 0;
                }
                else if (value > 100)
                {
                    armor = 100;
                }
                else
                {
                    armor = value;
                }
            }
        }
        
        
        #endregion
        #region cons
        public MiniBoss() :base()
        {
            Armor = 0;
        }
        public MiniBoss(string nama, int health, int kek, int scr, Image gambar, int Arm) : base( nama, health,  kek,  scr, gambar)
        {
            Armor = Arm;
        }
        #endregion
        #region method
        public void MoveLeft(int space)
        {
            Position = new Point(Position.X - space, Position.Y);
        }
        public void MoveRight(int space)
        {
            Position = new Point(Position.X + space, Position.Y);
        }
        public void MoveUp(int Height)
        {
            Position = new Point(Position.X, Position.Y + Height);
        }
        public void MoveDown(int Height)
        {
            Position = new Point(Position.X, Position.Y - Height);
        }
        public override void Hit(Character chr)
        {
            if (armor >= 25)
            {
                Armor -= chr.WeaponCharacter.Power;
                Hp -= (chr.WeaponCharacter.Power / 10);
            }
            else if (armor >= 5)
            {
                Armor -= chr.WeaponCharacter.Power;
                Hp -= (chr.WeaponCharacter.Power / 25);
            }
            else
            {
                Hp -= chr.WeaponCharacter.Power;
            }
        }
        #endregion
    }
}

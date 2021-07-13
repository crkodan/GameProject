using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace PBO_PROJECT_HANS
{
    public class BossEnemy : Enemy
    {
        int armor;
        int specAttackPow;
        Senjata weapon;

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
        public int SpecialAtk
        {
            get { return specAttackPow; }
            set
            {
                if (value > 75)
                {
                    specAttackPow = 75;
                }
                else if (value < 0)
                {
                    specAttackPow = 0;
                }
                else
                {
                    specAttackPow = value;
                }
            }
        }
        public Senjata Weap
        {
            get { return weapon; }
            set
            {
                weapon = value;
            }
        }
        #endregion
        #region cons
        public BossEnemy() : base()
        {
            Armor = 0;
        }
        public BossEnemy(string nama, int health, int kek, int scr, Image gambar, int Arm, int spc) : base(nama, health, kek, scr, gambar)
        {
            Armor = Arm;
            SpecialAtk = spc;
        }
        #endregion
        #region method
        public void MoveLeft (int space)
        {
            Position = new Point(Position.X - space, Position.Y);
        }
        public void MoveRight (int space)
        {
            Position = new Point(Position.X + space, Position.Y);
        }
        public void MoveUp (int Height)
        {
            Position = new Point(Position.X, Position.Y + Height);
        }
        public void MoveDown (int Height)
        {
            Position = new Point(Position.X, Position.Y - Height);
        }
        public override void Hit(Character chr)
        {
            if (armor >= 50)
            {
                Armor -= chr.WeaponCharacter.Power;
                Hp -= (chr.WeaponCharacter.Power / 10);
            }
            else if (armor >= 25)
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

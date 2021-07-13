using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace PBO_PROJECT_HANS
{
    public class MainEnemy : Enemy
    {
        int HitVal;
        int attackPower;
        public MainEnemy() : base()
        {
            HitVal = 0;
            AtkPow = 0;
        }
        public MainEnemy(string nama, int health, int kek, int scr, Image gambar, int hv, int ap) : base(nama,health,kek,scr,gambar)
        {
            HitVal = hv;
            AtkPow = ap;
        }

        public int HitValue
        {
            get { return HitVal; }
            set
            {
                if (value < 0)
                {
                    HitVal = 0;
                }
                else if (value > 100)
                {
                    HitVal = 100;
                }
                else
                {
                    HitVal = value;
                }
            }
        }
        public int AtkPow
        {
            get { return attackPower; }
            set
            {
                if (value > 100)
                {
                    attackPower = 100;
                }
                else if (value < 0)
                {
                    attackPower = 0;
                }
                else
                {
                    attackPower = value;
                }
            }
        }
        public override void Hit(Character chr)
        {
            Hp -= chr.WeaponCharacter.Power;
        }
        public void MoveLeft(int space)
        {
            Position = new Point(Position.X - space, Position.Y);
        }
        public void MoveRight(int space)
        {
            Position = new Point(Position.X + space, Position.Y);
        }
        public void MoveUp(int height)
        {
            Position = new Point(Position.X, Position.Y - height);
        }
        public void MoveDown(int height)
        {
            Position = new Point(Position.X, Position.Y + height);
        }
    }
}

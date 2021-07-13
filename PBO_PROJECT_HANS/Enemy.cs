using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PBO_PROJECT_HANS
{
    public abstract class Enemy
    {
        string name;
        int hp;
        int strength;
        int scoreToGet;
        Image enPic;
        Point post;
        #region const
        public Enemy()
        {
            Name = "Azaroth";
            Hp = 0;
            Strength = 1;
            Score = 0;
            Picture = null;
            Position = new Point(0, 0);
        }
        public Enemy(string nama, int health, int kek, int scr, Image gambar)
        {
            Name = nama;
            Hp = health;
            Strength = kek;
            Score = scr;
            Picture = gambar;
            Position = new Point(0, 0);
        }
        #endregion
        #region prop
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }
        public int Hp
        {
            get { return hp; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                else if (value > 100)
                {
                    value = 100;
                }
                else
                {
                    hp = value;
                }
            }
        }
        public int Score
        {
            get { return scoreToGet; }
            set
            {
                if (scoreToGet < 0)
                {
                    scoreToGet = 0;
                }
                else
                {
                    scoreToGet = value;
                }
            }
        }
        public int Strength
        {
            get { return strength; }
            set
            {
                if (strength < 0)
                {
                    strength = 0;
                }
                else if (strength > 5)
                {
                    strength = 5;
                }
                else
                {
                    strength = value;
                }
            }
        }
        public Image Picture
        {
            get { return enPic; }
            set { enPic = value; }
        }
        public Point Position
        {
            get { return post; }
            set
            {
                post = value;
            }
        }
        #endregion
        #region method
        public PictureBox Draw(PictureBox enemyPict, Control display)
        {
            enemyPict.Size = new Size(90, 90);
            enemyPict.Location = Position;
            enemyPict.BringToFront();
            enemyPict.BackColor = Color.Transparent;
            enemyPict.BackgroundImage = Picture;
            enemyPict.Parent = display;
            enemyPict.SizeMode = PictureBoxSizeMode.StretchImage;
            enemyPict.BackgroundImageLayout = ImageLayout.Stretch;
            return enemyPict;
        }
        public abstract void Hit(Character chr);
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
        #endregion
    }
}

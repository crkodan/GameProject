using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Media;
using System.IO;

namespace PBO_PROJECT_HANS
{
    public class Character
    {
        private string name;
        private int hp, numOfBullet, score;
        private Image picture;
        private Point position;
        private Senjata weaponCharacter;

        #region Constructors
        public Character()
        {
            Name = "";
            HP = 100;
            NumOfBullet = 0;
            Score = 1;
            Pictures = null;
            Position = new Point(0, 0);
           weaponCharacter = new Senjata();
        }

        #endregion

        #region Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int HP
        {
            get { return hp; }
            set
            {
                if (value < 0)
                    hp = 0;
                else if (value > 100)
                    hp = 100;
                else
                    hp = value;
            }
        }
        public int NumOfBullet
        {
            get { return numOfBullet; }
            set
            {
                if (value < 0)
                    numOfBullet = 0;
                else
                    numOfBullet = value;
            }
        }
        public int Score
        {
            get { return score; }
            set
            {
                if (value <= 0)
                    score = 1;
                else
                    score = value;
            }
        }
        public Image Pictures
        {
            get { return picture; }
            set
            {
                picture = value;
            }
        }
        public Point Position
        {
            get { return position; }
            set
            {
                position = value;
                //if (value.X < 0)
                //{
                //    position.X = 0;
                //    position.Y = value.Y;
                //}
                //else if (value.X > 649)
                //{
                //    position.X = 0;
                //    position.Y = value.Y;
                //}
                //else if (value.Y < 0)
                //{
                //    position.X = value.X;
                //    position.Y = 0;
                //}
                //else if (value.Y > 327)
                //{
                //    position.X = value.X;
                //    position.Y = 0;
                //}
                //else
                //{
                //    position.X = value.X;
                //    position.Y = value.Y;
                //}
            }
        }
        public Senjata WeaponCharacter
        {
            get { return weaponCharacter; }
            set
            {
                weaponCharacter = value;
            }
        }

        #endregion

        #region Methods
        public void Draw(PictureBox pictureBoxToDisplay, Control displayAt)
        {
            pictureBoxToDisplay.Parent = displayAt;
            pictureBoxToDisplay.Size = new System.Drawing.Size(90, 90);
            pictureBoxToDisplay.Location = Position;
            pictureBoxToDisplay.Image = Pictures; 
            pictureBoxToDisplay.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxToDisplay.BackColor = System.Drawing.Color.Transparent;
            //pictureBoxToDisplay.BringToFront();
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
        public void SetWeapon(string weaponName, int weaponPower, Image weaponPicture)
        {
            //this.WeaponCharacter.Nama = weaponName;
            //this.WeaponCharacter.Power = weaponPower;
            //this.WeaponCharacter.Picture = weaponPicture;
            //this.WeaponCharacter.Position = new Point(0, 0);
            if (Name == "Berseker")
            {
                Senjata koukadon = new Senjata("Koukadon", 25, Properties.Resources.images);
                WeaponCharacter = koukadon;
            }
            else if (Name == "Archer")
            {
                Senjata exorcismBolt = new Senjata("Exorcsm Bolt", 15, Properties.Resources._8NArGWZ);
                weaponCharacter = exorcismBolt;
            }
            else if (Name == "Raven")
            {
                Senjata Katon = new Senjata("Katon", 35, Properties.Resources.fireball);
                weaponCharacter = Katon;
            }
        }
        public bool Shoot()
        {
            if (NumOfBullet > 0)
            {
                numOfBullet--;
                this.WeaponCharacter.Position = new Point(Position.X + 45, Position.Y + 45);
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}

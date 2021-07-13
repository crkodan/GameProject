using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace PBO_PROJECT_HANS
{
    public class Senjata
    {
        #region datamembers
        private string nama;
        private int power;
        private Image picture;
        private Point position;
        #endregion
        #region constructors
        public Senjata()
        {
            Nama = "";
            Power = 10;
            Picture = null;
            Position = new Point(0, 0);
        }
        public Senjata(string names, int pow, Image pct)
        {
            Nama = names;
            Power = pow;
            Picture = pct;
            Position = new Point(0, 0);
        }
        #endregion
        #region properties
        public string Nama
        {
            get
            {
                return nama;
            }
            set
            {
                nama = value;
            }
        }
        public int Power
        {
            get
            {
                return power;
            }
            set
            {
                if (value < 0)
                    power = 0;
                else if (value > 100)
                    power = 100;
                else
                    power = value;
            }
        }
        public Image Picture
        {
            get
            {
                return picture;
            }
            set
            {
                picture = value;
            }
        }
        public Point Position
        {
            get
            {
                return position;
            }
            set
            {
                position = value;
            }
        }
        #endregion
        #region methods
        public void Draw(PictureBox pictureBoxToDisplay, Control displayAt)
        {
            pictureBoxToDisplay.Parent = displayAt;
            pictureBoxToDisplay.Size = new Size(25, 25);
            pictureBoxToDisplay.Location = Position;
            pictureBoxToDisplay.Image = Picture;
            pictureBoxToDisplay.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxToDisplay.BackColor = Color.Transparent;
            pictureBoxToDisplay.BringToFront();
        }
        #endregion
    }
}

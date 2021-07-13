using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace PBO_PROJECT_HANS
{
    public class Arena
    {
        private string name;
        private Image picture;
        private Stream sound;

        #region Constructors
        public Arena()
        {
            Name = "";
            Sound = null;
            Picture = null;
        }
        public Arena(string pName, Image pPicture, Stream pSound)
        {
            Name = name;
            Picture = pPicture;
            Sound = pSound;
        }
        #endregion

        #region Properties
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }

        public Stream Sound
        {
            get { return sound; }
            set
            {
                sound = value;
            }
        }
        public Image Picture
        {
            get { return picture; }
            set
            {
                picture = value;
            }
        }
        #endregion

        #region Methods
        public void Draw(Control controlToDisplay)
        {
            controlToDisplay.BackgroundImage = Picture;
            controlToDisplay.BackgroundImageLayout = ImageLayout.Stretch;
        }
        #endregion
    }
}

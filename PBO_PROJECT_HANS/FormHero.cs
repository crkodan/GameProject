using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBO_PROJECT_HANS
{
    public partial class FormHero : Form
    {
        public FormHero()
        {
            InitializeComponent();
        }

        private void FormHero_Load(object sender, EventArgs e)
        {
            radioButtonBerseker.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormGame frmGameArena = (FormGame)this.Owner;

            //draw Character
            if (radioButtonArcher.Checked)
            {
                frmGameArena.character = new Character();
                frmGameArena.character.Name = "Archer";
                frmGameArena.character.HP = 100;
                frmGameArena.character.NumOfBullet = 5;
                frmGameArena.character.Score = 0;
                frmGameArena.character.Pictures = Properties.Resources.Archer;
                frmGameArena.character.Position = new Point(0, 250);
                //frmGameArena.character.SetWeapon("Arrow", 15, Properties.Resources.arrow);

            }
            else if (radioButtonBerseker.Checked)
            {
                frmGameArena.character = new Character();
                frmGameArena.character.Name = "Berseker";
                frmGameArena.character.HP = 100;
                frmGameArena.character.NumOfBullet = 20;
                frmGameArena.character.Score = 0;
                frmGameArena.character.Pictures = Properties.Resources.Berseker;
                frmGameArena.character.Position = new Point(0, 250);
                //frmGameArena.character.Draw(frmGameArena.pictureBoxCharacter, frmGameArena.panelArena);
                //frmGameArena.character.SetWeapon("Stone", 5, Properties.Resources.stone);
            }
            else
            {
                frmGameArena.character = new Character();
                frmGameArena.character.Name = "Raven";
                frmGameArena.character.HP = 100;
                frmGameArena.character.NumOfBullet = 10;
                frmGameArena.character.Score = 0;
                frmGameArena.character.Pictures = Properties.Resources.Ravenn;
                frmGameArena.character.Position = new Point(0, 250);
                //frmGameArena.character.SetWeapon("Metal Bullet", 10, Properties.Resources.bullet);
            }

            //tampilkan gambar karakter
            FormGame frmHome = (FormGame)this.Owner;
            frmHome.pictureBoxCharacter = new PictureBox();
            frmGameArena.character.Draw(frmHome.pictureBoxCharacter, frmGameArena.panelGame);

            //tampilkan info karakter di panel info
            frmGameArena.labelName.Text = frmGameArena.character.Name;
            frmGameArena.labelHPCharacter.Text = frmGameArena.character.HP.ToString();
            frmGameArena.labelScore.Text = frmGameArena.character.Score.ToString();

            frmGameArena.panelGame.Enabled = false;
            frmGameArena.panelInfo.Enabled = false;

            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

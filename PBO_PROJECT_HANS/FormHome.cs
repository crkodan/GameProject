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
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }
        public Character character;
        public PictureBox pictureBoxCharacter;
        private void button1_Click(object sender, EventArgs e)
        {
            FormGame frm = new FormGame();
            frm.Owner = this;
            frm.Show();
            //this.Hide();
            KeyPreview = true;
            //Form1 frms = new Form1();
            //frms.Owner = this;
            //frms.Show();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
        }
    }
}

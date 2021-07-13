using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace PBO_PROJECT_HANS
{
    public partial class FormGame : Form
    {
        public FormGame()
        {
            InitializeComponent();
        }
        int i = 1;
        public Character character;
        int currentArena;
        public List<Arena> listArena = new List<Arena>();
        public PictureBox pictureBoxCharacter;
        public List<PictureBox> listPictureBoxBullet = new List<PictureBox>();
        public List<Enemy> listOfEnemy = new List<Enemy>();
        public List<PictureBox> listOfPicEnemy = new List<PictureBox>();
        public List<Timer> listTimeEnemy = new List<Timer>();
        int count = 0;
        Random rndLokasi = new Random();
        private void button3_Click(object sender, EventArgs e)
        {
            panelInfo.Enabled = true;
            panelGame.Enabled = true;

            //buat data semua arena masukkan ke listArena
            LoadArena();
            Enemy senm = enemyChecker();
            listOfEnemy.Add(senm);
            PictureBox PBENM = new PictureBox();
            listOfPicEnemy.Add(PBENM);
            senm.Draw(PBENM, panelGame);
            PBENM.Location = new Point((int)(new Random().Next(0, panelGame.Width)), (int)(new Random().Next(0, panelGame.Height)));

            listArena[currentArena].Draw(panelGame);
            labelStage.Text = listArena[currentArena].Name;
            //labelBullet.Text = character.WeaponCharacter.Nama;
            label5.Text = character.WeaponCharacter.Nama + "=" + character.NumOfBullet.ToString();

            //untuk memutar sound di arena tertentu secara kontinu
            // belum dikasih resource buat sound !!!! <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
            //soundPlayerGame = new SoundPlayer(listArena[currentArena].Sound);
            //soundPlayerGame.PlayLooping();

            //agar dapat menggerakkan karakter dengan tombol tertentu
            KeyPreview = true;
            panelGame.Focus();
            timerGame.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormHero frm = new FormHero();
            frm.Owner = this;
            frm.Show();
        }

        private void FormGame_Load(object sender, EventArgs e)
        {
            panelInfo.Enabled = false;
            KeyPreview = true;

        }
        private void LoadArena()
        {
            //create arena
            Arena arena1 = new Arena();
            //// belum kuganti nama nya ... tolong diganti
            //// tinggal ganti nama recourse belakang, itu kamu panggil dari Resources gambar nya
            arena1.Name = "Divider Bridge";
            //arena1.Sound = Properties.Resources;
            arena1.Picture = Properties.Resources.BackGround1;
            listArena.Add(arena1);

            Arena arena2 = new Arena();
            arena2.Name = "Deep Dark Forest";
            //arena2.Sound = Properties.Resources.Romantic;
            arena2.Picture = Properties.Resources.BackGround2;
            listArena.Add(arena2);

            Arena arena3 = new Arena();
            arena3.Name = "Soekyi's Temple";
            //arena3.Sound = Properties.Resources.Sea;
            arena3.Picture = Properties.Resources.BackGround3;
            listArena.Add(arena3);

           
            listArena[count].Draw(panelGame);
            currentArena = 0;
        }
        

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
            FormHome home = (FormHome)this.Owner;
            //home.Close();
        }



        private void formGame_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Right)
                {
                    character.MoveRight(2);
                    character.Draw(pictureBoxCharacter, panelGame);
                    //if (character.Position.X + pictureBoxCharacter.Width >= panelGame.Width && currentArena <4 && character.Score >= 300)
                    //{
                    //    currentArena++;
                    //    listArena[currentArena].Draw(panelGame);

                    //    labelStage.Text = listArena[currentArena].Name;

                    //    character.Position = new Point(0, 250);
                    //    character.Draw(pictureBoxCharacter, panelGame);
                    //}
                }
                else if (e.KeyCode == Keys.Left)
                {
                    character.MoveLeft(2);
                    character.Draw(pictureBoxCharacter, panelGame);
                }
                else if (e.KeyCode == Keys.Up)
                {
                    character.MoveUp(2);
                    character.Draw(pictureBoxCharacter, panelGame);
                }
                else if (e.KeyCode == Keys.Down)
                {
                    character.MoveDown(1);
                    character.Draw(pictureBoxCharacter, panelGame);
                }

                Timer t = new Timer();

                if (e.KeyCode == Keys.Space)
                {
                    if (character.Shoot() == true)
                    {
                        character.NumOfBullet--;
                        PictureBox bullet = new PictureBox();

                        character.WeaponCharacter.Draw(bullet, panelGame);

                        bullet.SizeMode = PictureBoxSizeMode.StretchImage;

                        label5.Text = character.WeaponCharacter.Nama + "+" + character.NumOfBullet;
                        listPictureBoxBullet.Add(bullet);
                        timerShoot.Enabled = true;
                        Refresh();


                    }
                }
            }
            catch  (Exception ex)
            {
                count++;
                if (count>3)
                {
                    panelButton.Enabled = true;
                    panelInfo.Enabled = true;
                    panelGame.Enabled = false;
                    MessageBox.Show(ex.Message);
                }
                else
                {
                    labelStage.Text = listArena[count].Name;
                    listArena[count].Draw(panelGame);
                }
            }
        }
        private void pictureBoxCharacter_Click (object sender, EventArgs e)
        {
            DoubleBuffered = true;
        }
        int cnt = 0;
        private void timerGame_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            
            if (cnt == 10)
            {

                Enemy senm = enemyChecker();
                listOfEnemy.Add(senm);
                PictureBox PBENM = new PictureBox();
                PBENM.Location = new Point((int)(new Random().Next(0, panelGame.Width)), (int)(new Random().Next(0, panelGame.Height)));
                listOfPicEnemy.Add(PBENM);
                senm.Draw(PBENM, panelGame);
                cnt = 0;
                //cnt++;
            }
            
            cnt++;
            
            for (int i = 0; i < listOfEnemy.Count; i++)
            {
                listOfPicEnemy[i].Location = new Point((int)(new Random().Next(0, panelGame.Width)), (int)(new Random().Next(0, panelGame.Height)));
                if (listOfEnemy[i].Position.X < panelGame.Width - 90)
                {
                    listOfEnemy[i].MoveRight(3);
                    listOfEnemy[i].Draw(listOfPicEnemy[i], panelGame);
                    if (listOfPicEnemy[i].Right < panelGame.Width - 90)
                    {
                        listOfEnemy[i].MoveLeft(3);
                        listOfEnemy[i].Draw(listOfPicEnemy[i], panelGame);
                    }
                }
                if (listOfEnemy[i].Position.X > panelGame.Width)
                {

                    listOfEnemy[i].MoveLeft(3);
                    listOfEnemy[i].Draw(listOfPicEnemy[i], panelGame);
                    if (listOfPicEnemy[i].Right > panelGame.Width)
                    {
                        
                        listOfEnemy[i].MoveLeft(3);
                        listOfEnemy[i].Draw(listOfPicEnemy[i], panelGame);
                    }
                }
            }
            
            if (character.Score % 250 == 0)
            {
                
                LoadArena();
            }
            tit.Text = i.ToString();
            i++;
            labelScore.Text = character.Score.ToString();
        }
        

        private void timerShoot_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i<listPictureBoxBullet.Count;i++)
            {
                if (listPictureBoxBullet[i].Left>300)
                {
                    character.NumOfBullet++;
                    label5.Text = character.NumOfBullet.ToString();
                    listPictureBoxBullet[i].Dispose();
                    listPictureBoxBullet.RemoveAt(i);
                    label5.Text = character.WeaponCharacter.Nama + "+" + character.NumOfBullet;
                }
                else
                {
                    listPictureBoxBullet[i].Left += 2;
                }
            }
        }
        Random rand = new Random();
        public Enemy enemyChecker()
        {
            Random a = new Random();
            Random b = new Random();
            Random c = new Random();
            int enemyType = a.Next(1, 3);
            int locX = a.Next(150, 400);
            int locY = a.Next(0, 300);

            //Enemy enemy = new  

            if (character.Score >= 0)
            {
                int tipeMusuh = rand.Next(0, 4);
                MainEnemy main;
                if (tipeMusuh == 1)
                {
                    main = new MainEnemy("Caspaer Cutie", 50, 1, 25, Properties.Resources.Enemy, 2, 20);
                    
                }
                else if (tipeMusuh == 2)
                {
                    main = new MainEnemy("Zombie Cactues", 50, 2, 50, Properties.Resources.staticenemy1, 4, 50);
                }
                else if (tipeMusuh == 3)
                {
                    main = new MainEnemy("Dead Hound", 50, 5, 150, Properties.Resources.Enemy1, 6, 20);
                }
                else
                {
                    main = new MainEnemy("GLoB", 50, 3, 40, Properties.Resources.staticenemy2, 3, 25);
                }
                main.Position = new Point(locX, locY);
                return main;


            }
            else if ((character.Score -1) %400 == 0 && labelStage.Text == "Deep Dark Forest")
            {
                MiniBoss minBoss = new MiniBoss("Golitahz", 100, 6, 250, Properties.Resources.miniboss, 25);
                for(int i=0; i<listOfEnemy.Count; i++)
                {
                    listOfEnemy.Clear();
                }
                minBoss.Position = new Point(locX, locY);
                return minBoss;
            }
            else if ((character.Score -1) % 500 == 0 && labelStage.Text == "Soekyi's Temple")
            {
                BossEnemy Boss = new BossEnemy("Soekyi Guardian", 200, 6, 500, Properties.Resources.main_boss, 75, 50);
                Boss.Position = new Point(locX, locY);
                return Boss;
            }
            else
            {
                return null;
            }
        }

        
        private void DeleteEnemy()
        {
            listOfEnemy.Clear();

            for (int i = 0; i<listOfPicEnemy.Count;i++)
            {
                listTimeEnemy[i].Stop();
                listOfPicEnemy[i].Dispose();
            }
            listTimeEnemy.Clear();
            listOfPicEnemy.Clear();
        }

        private void timerEnemy_Tick(object sender, EventArgs e)
        {
            if (listOfEnemy[i] is MainEnemy)
            {
                MainEnemy main = listOfEnemy[i] as MainEnemy;
                for (int i = 0; i < listOfEnemy.Count; i++)
                {
                    if (listOfEnemy[i].Position.X > panelGame.Width - 90)
                    {
                        listOfPicEnemy[i].Tag = -10;
                    }
                    if (listOfEnemy[i].Position.X < panelGame.Width)
                    {
                        listOfPicEnemy[i].Tag = 10;
                    }
                    main.MoveRight((int)listOfPicEnemy[i].Tag);
                }
                listOfEnemy[i].Draw(listOfPicEnemy[i], panelGame);
            }

            else if (listOfEnemy[i] is MiniBoss)
            {
                MiniBoss minBos = listOfEnemy[i] as MiniBoss;
                for (int i = 0; i < listOfEnemy.Count; i++)
                {
                    if (listOfEnemy[i].Position.X > panelGame.Width - 90)
                    {
                        listOfPicEnemy[i].Tag = -10;
                    }
                    else if (listOfEnemy[i].Position.X < panelGame.Width)
                    {
                        listOfPicEnemy[i].Tag = 10;
                    }
                    else if (listOfEnemy[i].Position.Y > panelGame.Height - 90)
                    {
                        listOfPicEnemy[i].Tag = -10;
                    }
                    else
                    {
                        listOfPicEnemy[i].Tag = 10;
                    }
                    minBos.MoveRight((int)listOfPicEnemy[i].Tag);
                    minBos.MoveUp((int)listOfPicEnemy[i].Tag);

                }
                listOfEnemy[i].Draw(listOfPicEnemy[i], panelGame);
            }
            Refresh();
        }
    }
}

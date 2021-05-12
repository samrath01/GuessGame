using GuessGame.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessGame
{
    public partial class MainForm : Form
    {
        Cylinder cylinder;
        SoundPlayer player;
        int chance, position;
        Random random;

        public MainForm()
        {
            InitializeComponent();
            ResetControls();
            random = new Random();
            player = new SoundPlayer();
        }

        public void ResetControls()
        {
            btnLoad.Enabled = btnSpin.Enabled = btnPress.Enabled = false;
            labelChance.Visible = false;
            progressChance.Visible = false;
            btnStart.Enabled = true;
            pictureStatus.Image = Resources.head_gun;
            labelMessage.Text = "Start Game";
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exit From Game...", "Russian Roulette");
            Application.Exit();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            labelMessage.Text = "Now, Load the Bullet...";
            chance = 3;            
            cylinder = new Cylinder();
            btnLoad.Enabled = true;
            btnStart.Enabled = false;
        }

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            btnLoad.Enabled = false;
            position = random.Next(0, 6);
            labelMessage.Text = "Now, Bullet Loaded At Position No: " + (position + 1);
            cylinder.LoadBullet(position);
            await Task.Delay(2000);
            labelMessage.Text = "Now, Spin the Bullet...";
            btnSpin.Enabled = true;
        }

        private async void btnSpin_Click(object sender, EventArgs e)
        {
            btnSpin.Enabled = false;
            labelMessage.Text = "Spinning the Chamber...";
            cylinder.Spin();            
            await Task.Delay(3000);
            btnPress.Enabled = true;
            labelMessage.Text = "Now, Press the Trigger.";
            position = 0;
            labelChance.Visible = true;
            progressChance.Visible = true;
            labelChance.Text = "Number of Chances: " + chance;
            progressChance.Value = chance;
        }

        private async void btnPress_Click(object sender, EventArgs e)
        {
            if (cylinder.Fire(position))
            {
                player.Stream = Resources.shot;
                player.Play();
                pictureStatus.Image = Resources.gun_shot;
                await Task.Delay(1000);
                pictureStatus.Image = Resources.head_shot;
                await Task.Delay(1000);
                labelMessage.Text = "Dead!!!";
                MessageBox.Show("Sorry!!! You Lost Game...","Russian Roulette");
                ResetControls();
                return;
            }
            else
            {
                player.Stream = Resources.blank;
                player.Play();
                pictureStatus.Image = Resources.empty_shot;
                await Task.Delay(1000);
                pictureStatus.Image = Resources.head_gun;
            }
            position++;
            chance--;
            labelChance.Text = "Number of Chances: " + chance;
            progressChance.Value = chance;
            if (chance == 0)
            {
                labelMessage.Text = "You Won the Game!!!";
                await Task.Delay(500);
                MessageBox.Show("Congratulations. You Won!!!");
                ResetControls();
            }
        }
    }
}

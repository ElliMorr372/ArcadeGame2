using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace ArcadeGame2
{
    public partial class background1 : Form
    {
        public background1()
        {
            InitializeComponent();

            gameStartLabel.Visible = false;
            countdownLabel3.Visible = false;
            countdownLabel2.Visible = false;
            countdownLabel1.Visible = false;
            countdownLabel0.Visible = false;
            goLabel.Visible = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            playGameButton.Visible = false;
            gameStartLabel.Visible = true;

            countdownLabel3.Visible = true;
            Refresh();
            Thread.Sleep(1000);

            countdownLabel3.Visible = false;
            countdownLabel2.Visible = true;
            Refresh();
            Thread.Sleep(1000);

            countdownLabel2.Visible = false;
            countdownLabel1.Visible = true;
            Refresh();
            Thread.Sleep(1000);

            countdownLabel1.Visible = false;
            countdownLabel0.Visible = true;
            Refresh();
            Thread.Sleep(1000);

            countdownLabel0.Visible = false;
            gameStartLabel.Visible = false;
            Refresh();

            this.BackColor = Color.Green;
            goLabel.Visible = true;
            SoundPlayer alertPlayer = new SoundPlayer(Properties.Resources.alert);
            alertPlayer.Play();
        }
    }
}

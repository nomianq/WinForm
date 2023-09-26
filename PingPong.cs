using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormApp
{
    public partial class PingPong : Form
    {

        private int _speedVer = 5, _speedHor = 5, _platformSpeed = 15;
        private int _score = 0;

        public PingPong()
        {
            InitializeComponent();
            //Cursor.Hide();
        }
        private void PingPong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)            
                this.Close();            
            else if ((e.KeyCode == Keys.A || e.KeyCode == Keys.Left) && Platform.Left > GamePanel.Left)
                Platform.Left -= _platformSpeed;
            else if ((e.KeyCode == Keys.D || e.KeyCode == Keys.Right) && Platform.Right < GamePanel.Right)
                Platform.Left += _platformSpeed;
            else if(e.KeyCode == Keys.R && !timer.Enabled)
            {
                Random random = new Random();

                GameBall.Top = random.Next(20,300);
                GameBall.Left = random.Next(20, 500);
                _score = 0;
                LoseLabel.Visible = false;
                ResultLabel.Text = "Результат: 0";
                timer.Enabled = true;
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            GameBall.Left -= _speedHor;
            GameBall.Top -= _speedVer;

            if (GameBall.Top <= GamePanel.Top)
                _speedVer *=  -1;
            if (GameBall.Bottom >= GamePanel.Bottom)
            {
                timer.Enabled = false;
                LoseLabel.Visible = true;
            }
                
            if (GameBall.Right >= GamePanel.Right)
                _speedHor *= -1;
            if (GameBall.Left <= GamePanel.Left)
                _speedHor *= -1;

            if (GameBall.Bottom >= Platform.Top &&
                GameBall.Left >= Platform.Left && GameBall.Right <= Platform.Right)
            {
                _speedVer *= -1;
                _score++;
                ResultLabel.Text = "Результат: " + _score;
                Random random = new Random();
                GamePanel.BackColor = Color.FromArgb(random.Next(150,255), random.Next(150, 255), random.Next(150, 255));
            }
        }
    }
}

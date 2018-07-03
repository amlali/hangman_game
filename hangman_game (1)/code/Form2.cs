using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hangman_game
{
    public partial class Form2 : Form
    {
        int cnt=0;
        public Form2()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                
                Form1 f = new Form1();
                f.FormClosed += new FormClosedEventHandler(delegate { Close(); });
                f.IntValue = cnt;
                f.twoplayer = false;
                f.Show();
                this.Hide();
            }
            if (radioButton2.Checked == true)
            {
                secondplayer f = new secondplayer();
                f.FormClosed += new FormClosedEventHandler(delegate { Close(); });
                f.IntValue = cnt;
                f.Show();
                this.Hide();
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkRed;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            cnt = 5;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.DarkRed;
            button1.BackColor = Color.White;
            button3.BackColor = Color.White;
            cnt = 4;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.DarkRed;
            button2.BackColor = Color.White;
            button1.BackColor = Color.White;
            cnt = 3;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            


        }
    }
}

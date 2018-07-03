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
    public partial class secondplayer : Form
    {
        public int IntValue { get; set; }

        public secondplayer()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string word = textBox1.Text;
            string cate = textBox2.Text;
            Form1 f = new Form1();
            f.FormClosed += new FormClosedEventHandler(delegate { Close(); });
            f.wr = word;
            f.cat = cate;
            f.twoplayer = true;
            f.IntValue = IntValue;
            f.Show();
            this.Hide();
        }

        private void secondplayer_Load(object sender, EventArgs e)
        {

        }
    }
}

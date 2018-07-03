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
namespace hangman_game
{
    public partial class Form1 : Form
    {
       
        public int IntValue { get; set; }
        public string wr { get; set; }
        public string cat { get; set; }
        public bool twoplayer { get; set; }
        List<string> words ;
      public int cnt = 0;
      int fail_cnt=6;
        hang_word hw;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            words = new List<string>();
            hw = new hang_word();
            cnt = 0;
            if(IntValue>0)
            fail_cnt = IntValue;
            else
            { fail_cnt = 5; }

            A.Visible = true;
            B.Visible = true;
            C.Visible = true;
            D.Visible = true;
            E.Visible = true;
            F.Visible = true;
            G.Visible = true;
            H.Visible = true;
            I.Visible = true;
            J.Visible = true;
            K.Visible = true;
            L.Visible = true;
            M.Visible = true;
            N.Visible = true;
            O.Visible = true;
            P.Visible = true;
            Q.Visible = true;
            R.Visible = true;
            S.Visible = true;
            T.Visible = true;
            U.Visible = true;
            V.Visible = true;
            W.Visible = true;
            X.Visible = true;
            Y.Visible = true;
            Z.Visible = true;
            if (twoplayer == false)
            {
                StreamReader sd = new StreamReader("hangdata.txt");
                while (sd.ReadLine() != null)
                {
                    cnt++;
                    string str = sd.ReadLine();
                    words.Add(str);
                }
                sd.Close();
                Random rand = new Random();
                int anyind = rand.Next(0, cnt);
                string[] temp = words[anyind].Split('/');
                hw.Category = temp[1].ToLower();
                hw.Name = temp[0].ToLower();
               
            }
            else
            {
                hw.Category = cat.ToLower();
                hw.Name = wr.ToLower();
            }

            des.Text = hw.Category;
            word.Text = hw.hide_word();
            conter.Text = fail_cnt.ToString();
        }
         


        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void msg_succ(object sender, EventArgs e)
        {
            if (fail_cnt != 0 && word.Text == hw.Name)
            {
               
                DialogResult result;
                MessageBoxButtons mbb = MessageBoxButtons.YesNo;
                result = MessageBox.Show("you win the game :) \nyou went to play new game ?", " Error Detected in Input", mbb);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    if(twoplayer==false)
                    this.Form1_Load(sender, e);
                    else
                    {
                        secondplayer f = new secondplayer();
                        f.IntValue = IntValue;
                        f.FormClosed += new FormClosedEventHandler(delegate { Close(); });
                        f.Show();
                        this.Hide();
                    }
                }
                if (result == System.Windows.Forms.DialogResult.No)
                {
                    
                    this.Close();
                }
            }

        }

        public void msg_fail(object sender, EventArgs e)
        {
            if (fail_cnt == 0)
            {
                word.Text = hw.Name;
                DialogResult result;
                MessageBoxButtons mbb = MessageBoxButtons.YesNo;
                result = MessageBox.Show("game over :( \nyou went to play new game ?", " Error Detected in Input", mbb);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {

                    if (twoplayer == false)
                        this.Form1_Load(sender, e);
                    else
                    {
                        secondplayer f = new secondplayer();
                        f.IntValue = IntValue;
                        f.FormClosed += new FormClosedEventHandler(delegate { Close(); });
                        f.Show();
                        this.Hide();
                    }
                }
                if (result == System.Windows.Forms.DialogResult.No)
                {

                    this.Close();
                }
            }

        }
        private void A_Click(object sender, EventArgs e)
        {
            if (hw.check_char('a') == true)
            {
                word.Text = hw.word_when_click('a', word.Text);
            }
            else
            {
                fail_cnt--;
                
            }
            conter.Text = fail_cnt.ToString();
            A.Visible = false;
            msg_succ(sender, e);
            msg_fail(sender, e);
        }

        private void B_Click(object sender, EventArgs e)
        {
            if (hw.check_char('b') == true)
            {
                word.Text = hw.word_when_click('b', word.Text);
            }
            else
            {
                fail_cnt--;

            }
            conter.Text = fail_cnt.ToString();
            B.Visible = false;

            msg_succ(sender, e);
            msg_fail(sender, e);
        }

        private void D_Click(object sender, EventArgs e)
        {
            if (hw.check_char('d') == true)
            {
                word.Text = hw.word_when_click('d', word.Text);
            }
            else
            {
                fail_cnt--;

            }
            conter.Text = fail_cnt.ToString();
            D.Visible = false;
            msg_succ(sender, e);
            msg_fail(sender, e);
        }

        private void C_Click(object sender, EventArgs e)
        {
            if (hw.check_char('c') == true)
            {
                word.Text = hw.word_when_click('c', word.Text);
            }
            else
            {
                fail_cnt--;

            }
            conter.Text = fail_cnt.ToString();
            C.Visible = false;

            msg_succ(sender, e);
            msg_fail(sender, e);
        }

        private void E_Click(object sender, EventArgs e)
        {
            if (hw.check_char('e') == true)
            {
                word.Text = hw.word_when_click('e', word.Text);
            }
            else
            {
                fail_cnt--;

            }
            conter.Text = fail_cnt.ToString();
            E.Visible = false;

            msg_succ(sender, e);
            msg_fail(sender, e);
        }

        private void F_Click(object sender, EventArgs e)
        {
            if (hw.check_char('g') == true)
            {
                word.Text = hw.word_when_click('g', word.Text);
            }
            else
            {
                fail_cnt--;

            }
            conter.Text = fail_cnt.ToString();
            G.Visible = false;

            msg_succ(sender, e);
            msg_fail(sender, e);
        }

        private void G_Click(object sender, EventArgs e)
        {
            if (hw.check_char('g') == true)
            {
                word.Text = hw.word_when_click('g', word.Text);
            }
            else
            {
                fail_cnt--;

            }
            conter.Text = fail_cnt.ToString();
            msg_succ(sender, e);
            msg_fail(sender, e);
            G.Visible = false;
        }

        private void H_Click(object sender, EventArgs e)
        {
            if (hw.check_char('h') == true)
            {
                word.Text = hw.word_when_click('h', word.Text);
            }
            else
            {
                fail_cnt--;

            }
            conter.Text = fail_cnt.ToString();
            H.Visible = false;

            msg_succ(sender, e);
            msg_fail(sender, e);
        }

        private void I_Click(object sender, EventArgs e)
        {
            if (hw.check_char('i') == true)
            {
                word.Text = hw.word_when_click('i', word.Text);
            }
            else
            {
                fail_cnt--;

            }
            conter.Text = fail_cnt.ToString();
            I.Visible = false;

            msg_succ(sender, e);
            msg_fail(sender, e);
        }

        private void J_Click(object sender, EventArgs e)
        {
            if (hw.check_char('j') == true)
            {
                word.Text = hw.word_when_click('j', word.Text);
            }
            else
            {
                fail_cnt--;

            }

            conter.Text = fail_cnt.ToString();
            J.Visible = false;

            msg_succ(sender, e);
            msg_fail(sender, e);
        }

        private void K_Click(object sender, EventArgs e)
        {
            if (hw.check_char('k') == true)
            {
                word.Text = hw.word_when_click('k', word.Text);
            }
            else
            {
                fail_cnt--;

            }
            conter.Text = fail_cnt.ToString();
            K.Visible = false;

            msg_succ(sender, e);
            msg_fail(sender, e);
        }

        private void L_Click(object sender, EventArgs e)
        {
            if (hw.check_char('l') == true)
            {
                word.Text = hw.word_when_click('l', word.Text);
            }
            else
            {
                fail_cnt--;

            }
            conter.Text = fail_cnt.ToString();
            L.Visible = false;
            msg_succ(sender, e);
            msg_fail(sender, e);
        }

        private void M_Click(object sender, EventArgs e)
        {
            if (hw.check_char('m') == true)
            {
                word.Text = hw.word_when_click('m', word.Text);
            }
            else
            {
                fail_cnt--;

            }
            conter.Text = fail_cnt.ToString();
            M.Visible = false;
            msg_succ(sender, e);
            msg_fail(sender, e);
        }

        private void N_Click(object sender, EventArgs e)
        {
            if (hw.check_char('n') == true)
            {
                word.Text = hw.word_when_click('n', word.Text);
            }
            else
            {
                fail_cnt--;

            }
            msg_succ(sender, e);
            N.Visible = false;
            conter.Text = fail_cnt.ToString();
            msg_fail(sender, e);
        }

        private void O_Click(object sender, EventArgs e)
        {
            if (hw.check_char('o') == true)
            {
                word.Text = hw.word_when_click('o', word.Text);
            }
            else
            {
                fail_cnt--;

            }
            conter.Text = fail_cnt.ToString();
            O.Visible = false;
            msg_succ(sender, e);
            msg_fail(sender, e);
        }

        private void P_Click(object sender, EventArgs e)
        {
            if (hw.check_char('p') == true)
            {
                word.Text = hw.word_when_click('p', word.Text);
            }
            else
            {
                fail_cnt--;

            }
            conter.Text = fail_cnt.ToString();
            P.Visible = false;
            msg_succ(sender, e);
            msg_fail(sender, e);
        }

        private void Q_Click(object sender, EventArgs e)
        {
            if (hw.check_char('q') == true)
            {
                word.Text = hw.word_when_click('q', word.Text);
            }
            else
            {
                fail_cnt--;

            }
            conter.Text = fail_cnt.ToString();
            Q.Visible = false;
            msg_succ(sender, e);
            msg_fail(sender, e);
        }

        private void R_Click(object sender, EventArgs e)
        {
            if (hw.check_char('r') == true)
            {
                word.Text = hw.word_when_click('r', word.Text);
            }
            else
            {
                fail_cnt--;

            }
            conter.Text = fail_cnt.ToString();
            R.Visible = false;
            msg_succ(sender, e);
            msg_fail(sender, e);
        }

        private void S_Click(object sender, EventArgs e)
        {
            if (hw.check_char('s') == true)
            {
                word.Text = hw.word_when_click('s', word.Text);
            }
            else
            {
                fail_cnt--;

            }
            conter.Text = fail_cnt.ToString();
            S.Visible = false;
            msg_succ(sender, e);
            msg_fail(sender, e);
        }

        private void T_Click(object sender, EventArgs e)
        {
            if (hw.check_char('t') == true)
            {
                word.Text = hw.word_when_click('t', word.Text);
            }
            else
            {
                fail_cnt--;

            }
            conter.Text = fail_cnt.ToString();
            T.Visible = false;
            msg_succ(sender, e);
            msg_fail(sender, e);
        }

        private void U_Click(object sender, EventArgs e)
        {
            if (hw.check_char('u') == true)
            {
                word.Text = hw.word_when_click('u', word.Text);
            }
            else
            {
                fail_cnt--;

            }
            conter.Text = fail_cnt.ToString();
            U.Visible = false;
            msg_succ(sender, e);
            msg_fail(sender, e);
        }

        private void V_Click(object sender, EventArgs e)
        {
            if (hw.check_char('v') == true)
            {
                word.Text = hw.word_when_click('v', word.Text);
            }
            else
            {
                fail_cnt--;

            }
            conter.Text = fail_cnt.ToString();
            V.Visible = false;
            msg_succ(sender, e);
            msg_fail(sender, e);
        }

        private void W_Click(object sender, EventArgs e)
        {
            if (hw.check_char('w') == true)
            {
                word.Text = hw.word_when_click('w', word.Text);
            }
            else
            {
                fail_cnt--;

            }
            conter.Text = fail_cnt.ToString();
            W.Visible = false;
            msg_succ(sender, e);
            msg_fail(sender, e);
        }

        private void X_Click(object sender, EventArgs e)
        {
            if (hw.check_char('x') == true)
            {
                word.Text = hw.word_when_click('x', word.Text);
            }
            else
            {
                fail_cnt--;

            }
            conter.Text = fail_cnt.ToString();
            X.Visible = false;
            msg_succ(sender, e);
            msg_fail(sender, e);
        }

        private void Y_Click(object sender, EventArgs e)
        {
            if (hw.check_char('y') == true)
            {
                word.Text = hw.word_when_click('y', word.Text);
            }
            else
            {
                fail_cnt--;

            }
            conter.Text = fail_cnt.ToString();
            Y.Visible = false;
            msg_succ(sender, e);
            msg_fail(sender, e);
        }

        private void Z_Click(object sender, EventArgs e)
        {
            if (hw.check_char('z') == true)
            {
                word.Text = hw.word_when_click('z', word.Text);
            }
            else
            {
                fail_cnt--;

            }
            conter.Text = fail_cnt.ToString();
            Z.Visible = false;

            msg_succ(sender, e);
            msg_fail(sender, e);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Forms_Kolko_i_Krzyzyk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool player1 = true;
        int move = 0;
        int oScore = 0;
        int xScore = 0;


        private void btnRestart_Click(object sender, EventArgs e)
        {
            Restart();
            lblOScore.Text = "0";
            lblXScore.Text = "0";
            lblMove.Text = "O";
            player1 = true;
            oScore = 0;
            xScore = 0;
        }

        private void Restart()
        {
            move = 0;
            Button[] all = new Button[9];
            all[0] = btn1;
            all[1] = btn2;
            all[2] = btn3;
            all[3] = btn4;
            all[4] = btn5;
            all[5] = btn6;
            all[6] = btn7;
            all[7] = btn8;
            all[8] = btn9;

            foreach (Button b in all)
            {
                b.Enabled = true;
                b.Text = "";
            }

            player1 = false;
        }

        private void Check()
        {
            Button[] all = new Button[9];
            all[0] = btn1;
            all[1] = btn2;
            all[2] = btn3;
            all[3] = btn4;
            all[4] = btn5;
            all[5] = btn6;
            all[6] = btn7;
            all[7] = btn8;
            all[8] = btn9;

            string box = "";
            if (player1 == true)
            {
                box = "O";
            }
            else
            {
                box = "X";
            }

            bool endVoid = false;

            for (int i = 0; i < 9; i += 3)
            {
                if (all[i].Text == box && all[i + 1].Text == box && all[i + 2].Text == box)
                {
                    if (player1 == true)
                    {
                        oScore++;
                        lblOScore.Text = oScore.ToString();
                    }
                    else
                    {
                        xScore++;
                        lblXScore.Text = xScore.ToString();
                    }
                    endVoid = true;
                    Restart();
                    break;
                }
            }

            if (endVoid == false)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (all[i].Text == box && all[i + 3].Text == box && all[i + 6].Text == box)
                    {
                        if (player1 == true)
                        {
                            oScore++;
                            lblOScore.Text = oScore.ToString();
                        }
                        else
                        {
                            xScore++;
                            lblXScore.Text = xScore.ToString();
                        }
                        endVoid = true;
                        Restart();
                        break;
                    }
                }
            }

            if (endVoid == false)
            {
                if (all[0].Text == box && all[4].Text == box && all[8].Text == box)
                {
                    if (player1 == true)
                    {
                        oScore++;
                        lblOScore.Text = oScore.ToString();
                    }
                    else
                    {
                        xScore++;
                        lblXScore.Text = xScore.ToString();
                    }
                    endVoid = true;
                    Restart();
                }
            }


            if (endVoid == false)
            {
                if (all[2].Text == box && all[4].Text == box && all[6].Text == box)
                {
                    if (player1 == true)
                    {
                        oScore++;
                        lblOScore.Text = oScore.ToString();
                    }
                    else
                    {
                        xScore++;
                        lblXScore.Text = xScore.ToString();
                    }
                    endVoid = true;
                    Restart();
                }
            }

            if(move == 9)
            {
                MessageBox.Show("Wykonane zostały wszystkie ruchy", "Remis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Restart();
            }
           
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            move++;
            ((Button)sender).Text = player1 ? "O" : "X";
            ((Button)sender).Enabled = false;

            if (move >= 5)
            {
                Check();
            }
            player1 = !player1;

            lblMove.Text = player1 ? "O" : "X";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            move++;
            ((Button)sender).Text = player1 ? "O" : "X";
            ((Button)sender).Enabled = false;

            if (move >= 5)
            {
                Check();
            }
            player1 = !player1;

            lblMove.Text = player1 ? "O" : "X";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            move++;
            ((Button)sender).Text = player1 ? "O" : "X";
            ((Button)sender).Enabled = false;

            if (move >= 5)
            {
                Check();
            }
            player1 = !player1;

            lblMove.Text = player1 ? "O" : "X";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            move++;
            ((Button)sender).Text = player1 ? "O" : "X";
            ((Button)sender).Enabled = false;

            if (move >= 5)
            {
                Check();
            }
            player1 = !player1;

            lblMove.Text = player1 ? "O" : "X";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            move++;
            ((Button)sender).Text = player1 ? "O" : "X";
            ((Button)sender).Enabled = false;

            if (move >= 5)
            {
                Check();
            }
            player1 = !player1;

            lblMove.Text = player1 ? "O" : "X";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            move++;
            ((Button)sender).Text = player1 ? "O" : "X";
            ((Button)sender).Enabled = false;

            if (move >= 5)
            {
                Check();
            }
            player1 = !player1;

            lblMove.Text = player1 ? "O" : "X";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            move++;
            ((Button)sender).Text = player1 ? "O" : "X";
            ((Button)sender).Enabled = false;

            if (move >= 5)
            {
                Check();
            }
            player1 = !player1;

            lblMove.Text = player1 ? "O" : "X";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            move++;
            ((Button)sender).Text = player1 ? "O" : "X";
            ((Button)sender).Enabled = false;

            if (move >= 5)
            {
                Check();
            }
            player1 = !player1;

            lblMove.Text = player1 ? "O" : "X";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            move++;
            ((Button)sender).Text = player1 ? "O" : "X";
            ((Button)sender).Enabled = false;

            if (move >= 5)
            {
                Check();
            }
            player1 = !player1;

            lblMove.Text = player1 ? "O" : "X";
        }
    }
}

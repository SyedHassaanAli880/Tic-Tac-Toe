using System;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private bool isPlayerOneTurn = true;

        private int button_click_counts;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed By Syed Hassan Ali\n\nAll Rights Reserved","ABOUT",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            b1button.Enabled = false;

            b2button.Enabled = false;

            b3button.Enabled = false;

            b4button.Enabled = false;

            b5button.Enabled = false;

            b6button.Enabled = false;

            b7button.Enabled = false;

            b8button.Enabled = false;

            b9button.Enabled = false;

            startGameToolStripMenuItem.Enabled = true;

            ResetGametoolStripMenuItem3.Enabled = false;
        }

   

        private void startGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableButtons(true);

            ResetGametoolStripMenuItem3.Enabled = true;

            startGameToolStripMenuItem.Enabled = false;

            EnablePlayerOptions(false);

            isPlayerOneTurn = true;

            button_click_counts = 0;
    }

        private void EnableButtons(bool enable)
        {
            b1button.Enabled = enable;

            b2button.Enabled = enable;

            b3button.Enabled = enable;

            b4button.Enabled = enable;

            b5button.Enabled = enable;

            b6button.Enabled = enable;

            b7button.Enabled = enable;

            b8button.Enabled = enable;

            b9button.Enabled = enable;
        }

        private void ResetGametoolStripMenuItem3_Click(object sender, EventArgs e)
        {
            RESET_GAME();
        }

        private void RESET_GAME()
        {
            EnableButtons(false);

            startGameToolStripMenuItem.Enabled = true;

            ResetGametoolStripMenuItem3.Enabled = false;

            EnablePlayerOptions(true);
        }

        private void EnablePlayerOptions(bool enable)
        {
            groupBox1.Enabled = enable;

            groupBox2.Enabled = enable;

            groupBox3.Enabled = enable;
        }

        private void Button_Click(object sender, EventArgs e)
        {

            Button b = (Button)sender;

            if (isPlayerOneTurn == true)
            {
                b.Text = "X";

                isPlayerOneTurn = false;

                b.Enabled = false;
            }
            else
            {
                b.Text = "O";

                isPlayerOneTurn = true;

                b.Enabled = false;
            }

            button_click_counts ++ ;

        check_winner();

        }

        private void check_winner()
        {
            bool isWinner = false;

            if (button_click_counts == 9)
            {

                MessageBox.Show("The Game is drawn .Please Restart the game!!!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RESET_GAME();

            }
            else
            {
                if ((b1button.Text == b2button.Text) && (b2button.Text == b3button.Text) && (!b1button.Enabled))
                {
                    isWinner = true;
                }
                else if ((b4button.Text == b5button.Text) && (b5button.Text == b6button.Text) && (!b4button.Enabled))
                {
                    isWinner = true;
                }
                else if ((b7button.Text == b8button.Text) && (b8button.Text == b9button.Text) && (!b7button.Enabled))
                {
                    isWinner = true;
                }
                else if ((b1button.Text == b4button.Text) && (b4button.Text == b7button.Text) && (!b7button.Enabled))
                {
                    isWinner = true;
                }
                else if ((b2button.Text == b5button.Text) && (b8button.Text == b5button.Text) && (!b2button.Enabled))
                {
                    isWinner = true;
                }
                else if ((b3button.Text == b6button.Text) && (b6button.Text == b9button.Text) && (!b9button.Enabled))
                {
                    isWinner = true;
                }
                else if ((b1button.Text == b5button.Text) && (b5button.Text == b9button.Text) && (!b9button.Enabled))
                {
                    isWinner = true;
                }
                else if ((b3button.Text == b5button.Text) && (b5button.Text == b7button.Text) && (!b7button.Enabled))
                {
                    isWinner = true;
                }


                if (isWinner == true)
                {
                    if (isPlayerOneTurn == true)
                    {
                        MessageBox.Show("Player one wins", "GAME OVER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Player one wins", "GAME OVER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    c_lear();
                    RESET_GAME();

                }
            }
        }
        private void c_lear()
        {
        b1button.Text = "";

        b2button.Text = "";

        b3button.Text = "";

        b4button.Text = "";

        b5button.Text = "";

        b6button.Text = "";

        b7button.Text = "";

        b8button.Text = "";

        b9button.Text = "";
        }
    }
}

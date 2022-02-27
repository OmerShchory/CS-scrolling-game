using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ruppin_Game
{
    public partial class StartingMenu : Form
    {
        public static int player_pic = 1; //value holds the player choice of the image they want to play with.
        public StartingMenu()
        {
            InitializeComponent();
        }

        //updating mouse image to hands when the mouse is on top of one of the player pictures, or the start button.
        private void picPlayer1_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }
        private void picPlayer2_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }
        private void picPlayer3_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }
        private void btnstart_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        //method of clicking the button START
        private void btnstart_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand; //keep the image of the cursor
            this.Hide(); //hiding the current form of starting menu
            frmGame frmGame = new frmGame(); //opening the form of the game
            frmGame.Show();
        }

        //method updating the border of the image after the user clicks it.
        //updating the rest of the images to no border.
        private void picPlayer1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand; //keep the image of the cursor
            player_pic = 1;
            picPlayer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            picPlayer2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            picPlayer3.BorderStyle = System.Windows.Forms.BorderStyle.None;

        }
        private void picPlayer2_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand; //keep the image of the cursor
            player_pic = 2;
            picPlayer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            picPlayer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            picPlayer3.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }
        private void picPlayer3_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand; //keep the image of the cursor
            player_pic = 3;
            picPlayer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            picPlayer2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            picPlayer1.BorderStyle = System.Windows.Forms.BorderStyle.None;

        }

    }
}

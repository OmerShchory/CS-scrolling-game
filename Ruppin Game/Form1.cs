using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media; //added system of media for the audio effect when striking the professor


namespace Ruppin_Game
{
    public partial class frmGame : Form
    {
        //initializing player speed, background speed, countdown seconds, audios, scores, strikes

        int jumpspeed = 10;
        int jumpheight = 12;
        int horizontalspeed = 6; //for the professor movement
        int TimeLeft = 60;
        int studentspeed = 15;
        int backgroundSpeed = 15;
        bool jumping, left, right;
       
        private SoundPlayer audio_professor; 
        private SoundPlayer lose; 
        private SoundPlayer goldenExam; 
        private SoundPlayer finishGame;

        //displayed on the screen - 10 scores for small exam, 100 scores for the gold exam.
        int GameScore = 0;
        int strikes = 0;

        //constructor of the form with audio for professor strike
        public frmGame()
        {
            InitializeComponent();
            audio_professor = new SoundPlayer(Ruppin_Game.Properties.Resources.strike);
            lose = new SoundPlayer(Ruppin_Game.Properties.Resources.crying);
            goldenExam = new SoundPlayer(Ruppin_Game.Properties.Resources.yay);
            finishGame = new SoundPlayer(Ruppin_Game.Properties.Resources.endgame);
        }

        //method coordinates and adjusts the player's, background's and items' motion by the timer tick of 20 ms
        //and defines interactions with the pictureBoxes
        private void Timer(object sender, EventArgs e)
        {
            //opening the form with the user's choice of player (or default)
            if (StartingMenu.player_pic == 1)
            {
                picStudent.Image = Ruppin_Game.Properties.Resources.sutdent;
            }
            else if (StartingMenu.player_pic == 2)
            {
                picStudent.Image = Ruppin_Game.Properties.Resources.hulk;
            }
            else
            {
                picStudent.Image = Ruppin_Game.Properties.Resources.spiderMan;
            }
            //updating scores and strikes every tick
            lblScore.Text = "Score: " + GameScore;
            lblStrike.Text = "Strike: " + strikes;

            //moving the player
            picStudent.Top += jumpspeed;

            //updating player movement by the speed
            if (left == true && picStudent.Left > 60)
            {
                picStudent.Left -= studentspeed;
            }
            if (right == true && picStudent.Right + 60 < this.ClientSize.Width - 100)
            {
                picStudent.Left += studentspeed;
            }

            //updating movement of the background image
            if (left == true && picBackground.Left < 0)
            {
                picBackground.Left += backgroundSpeed;
                moveItems("MoveForward");
            }

            if (right == true && picBackground.Left > -6350)
            {
                picBackground.Left -= backgroundSpeed;
                moveItems("MoveBack");
            }

            //enabaling the player jump
            jumping_settings();

            //loop for every interaction of the player with any picturebox
            foreach (Control item in this.Controls)
            {
                //having the player on the platform 
                if (item is PictureBox && (string)item.Tag == "platform")
                {
                    if (picStudent.Bounds.IntersectsWith(item.Bounds) && jumping == false)
                    {
                        jumpheight = 8;
                        picStudent.Top = item.Top - picStudent.Height;
                        jumpspeed = 0;
                    }
                    item.BringToFront();
                }
                //collecting exams once the player touches them, updating scores
                if (item is PictureBox && (string)item.Tag == "Exam")
                {
                    if (picStudent.Bounds.IntersectsWith(item.Bounds) && item.Visible == true)
                    {
                        item.Visible = false;
                        GameScore += 10;
                    }
                }

                if (item is PictureBox && (string)item.Tag == "Gold Exam")
                {
                    if (picStudent.Bounds.IntersectsWith(item.Bounds) && item.Visible == true)
                    {
                        goldenExam.Play();
                        item.Visible = false;
                        GameScore += 100;
                    }
                }

                //interaction with the professor - updating strikes
                if (item is PictureBox && (string)item.Tag == "professor")
                {
                    item.Location = new Point (item.Location.X -horizontalspeed, item.Location.Y);
                    if (picStudent.Bounds.IntersectsWith(item.Bounds) && item.Visible == true)
                    {
                        audio_professor.Play(); //adding audio when player interacts with the professor
                        item.Visible = false;
                        if (strikes != 2)
                            strikes++;
                        else //when striking 3 times - stop the game and ask user if restarting the game or not
                        {
                            strikes++;
                            tmrGameTimer.Stop();
                            CountDownTimer.Stop();
                            lblStrike.Text = "Strike: " + strikes;
                            lose.Play();
                            DialogResult result = MessageBox.Show("You striked the professor 3 times! Game over!" +
                                "\nDo you want to restart the game?", "Game Over", MessageBoxButtons.YesNo);

                            if (result == DialogResult.Yes)
                            {
                                PlayAgain();
                                GameScore = 0;
                                strikes = 0;
                            }
                            else //exiting if not restarting
                            {
                                this.Hide();
                                Close();
                            }
                        }
                    }
                }
            }

            //interaction with the finish line picturebox
            if (picStudent.Bounds.IntersectsWith(picFinish.Bounds))
            {
                //stoping the game and the countdown
                tmrGameTimer.Stop();
                CountDownTimer.Stop();
                if (GameScore < 500) //if the goal is not reached
                {
                    MessageBox.Show("Your score is under 500! Try again.");
                }
                else //if the goal is reached
                {
                    finishGame.Play();
                    MessageBox.Show($"Well done!\nYour {lblScore.Text}." + Environment.NewLine + "\nClick OK to play again.");
                }
                PlayAgain(); //play again any way.
            }

            //if player passes the bottom line of the screen - game over (player dies)
            if (picStudent.Top + picStudent.Height > this.ClientSize.Height)
            {
                tmrGameTimer.Stop();
                CountDownTimer.Stop();
                lose.Play();
                MessageBox.Show("You died." + Environment.NewLine + "\nClick OK to play again.");
                PlayAgain();
            }
            if ( picStudent.Height + picStudent.Bottom < 100)
            {
                jumping_settings();
            }
        }

        //initialing what happens when pressing the arrow keys
        private void KeyISDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                left = true;
            if (e.KeyCode == Keys.Right)
                right = true;
            if (e.KeyCode == Keys.Up && jumping == false)
                jumping = true;
        }

        //initialing what happens when not holding the keys
        private void KeyISUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                left = false;
            if (e.KeyCode == Keys.Right)
                right = false;
            if (jumping == true)
                jumping = false;
        }

        //method of the exit button on the menu bar on the top left of the screen
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tmrGameTimer.Stop();
            CountDownTimer.Stop();//stop the countdown
            //ask user a warning message of exiting
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)//exit
            {
                this.Hide();
                Close();
            }
            else //continue, don't exit
            {
                tmrGameTimer.Start();
                CountDownTimer.Start();
            }
        }

        //method of the restart button on the menu bar on the top left of the screen
        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //stopping the timers and restarting the game
            tmrGameTimer.Stop();
            CountDownTimer.Stop();
            PlayAgain();
        }

        //method of the "back to starting menu" button on the menu bar on the top left of the screen
        private void backToStartingMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //stopping the game and the countdown
            tmrGameTimer.Stop();
            CountDownTimer.Stop();
            //hiding the current form
            this.Hide();
            //showing the starting menu again
            StartingMenu startingMenu = new StartingMenu();
            startingMenu.Show();
        }

        //method of the pause button on the menu bar on the top left of the screen
        private void pauseGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //stopping the timers
            tmrGameTimer.Stop();
            CountDownTimer.Stop();
            //showing the user a message box
            MessageBox.Show("Click OK to continue.");
            //continuing the game after user presses OK
            CountDownTimer.Start();
            tmrGameTimer.Start();
        }

        //method of timer - what happens in every tick of the countdown timer
        private void CountDownTimer_Tick(object sender, EventArgs e)
        {
            if (TimeLeft > 0) //if there is time left
            {
                TimeLeft = TimeLeft - 1; //keep counting the seconds
                lblTime.Text = "Count Down: " + TimeLeft + " Seconds"; //update the label
            }
            else //if there isn't time left
            {
                //stop the game
                tmrGameTimer.Stop();
                CountDownTimer.Stop();
                //show a message to the user
                lose.Play();
                MessageBox.Show("You ran out of time! Click OK to restart game.");
                //restart game
                PlayAgain();
            }
        }

        //method handles moving the pictureboxes when player moves too, 
        //so it seems like the stand in their place
        private void moveItems(string ditrection)
        {
            foreach (Control item in this.Controls)
            {
                //for every interaction with platform, regular exam, gold exam , professor or finish picturebox
                if (item is PictureBox && (string)item.Tag == "platform" || item is PictureBox && (string)item.Tag == "Exam" || item is PictureBox && (string)item.Tag == "professor"
                    || item is PictureBox &&(string)item.Tag == "finish" || item is PictureBox && (string)item.Tag == "Gold Exam")

                {
                    //move the items with the player
                    if (ditrection == "MoveBack")
                        item.Left -= backgroundSpeed;
                    if (ditrection == "MoveForward")
                        item.Left += backgroundSpeed;
                }
            }
        }

        //method defines the settings for jumping values of the player 
        private void jumping_settings()
        {
            if (jumping == true)
            {
                jumpspeed = -12;
                jumpheight -= 1;
            }
            else
                jumpspeed = 12;

            if (jumping == true && jumpheight < 0)
                jumping = false;
        }

        //method restarting the game
        private void PlayAgain()
        {
            //opening new window of the same form
            frmGame NewWindow = new frmGame();
            NewWindow.Show();
            //hiding the current form
            this.Hide();
        }

        //after finishing the program, close every form that has been hed and still
        //running in the backgroung, and the current one.
        private void Close(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}

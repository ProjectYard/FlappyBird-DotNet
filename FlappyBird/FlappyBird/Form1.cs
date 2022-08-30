namespace FlappyBird
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 8;
        int gravity = 15;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void GameKeyDown(object sender, KeyEventArgs e)
        {
            // this is the game key is down event thats linked to the main form
            Console.WriteLine("Space up");
            if (e.KeyCode == Keys.Space)
            {
                // if the space key is pressed then the gravity will be set to -15
                gravity = -15;
            }


        }

        private void GameKeyUp(object sender, KeyEventArgs e)
        {
            // this is the game key is up event thats linked to the main form

            if (e.KeyCode == Keys.Space)
            {
                // if the space key is released then gravity is set back to 15
                gravity = 15;
            }

        }

        private void endGame()
        {
            // this is the game end function, this function will when the bird touches the ground or the pipes
            gameTimer.Stop(); // stop the main timer
            Score.Text += " Game over!!!"; // show the game over text on the score text, += is used to add the new string of text next to the score instead of overriding it
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            FlappyBird.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            Score.Text = "Score: " + score;


            if (pipeBottom.Left < -150)
            {
                // if the bottom pipes location is -150 then we will reset it back to 800 and add 1 to the score
                pipeBottom.Left = 800;
                score++;
            }
            if (pipeTop.Left < -180)
            {
                // if the top pipe location is -180 then we will reset the pipe back to the 950 and add 1 to the score
                pipeTop.Left = 950;
                score++;
            }



            if (FlappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                FlappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                FlappyBird.Bounds.IntersectsWith(Ground.Bounds) || FlappyBird.Top < -25
                )
            {
                // if any of the conditions are met from above then we will run the end game function
                endGame();
            }


            // if score is greater then 5 then we will increase the pipe speed to 15
            if (score > 5)
            {
                pipeSpeed = 15;
            }

        }
    }
}
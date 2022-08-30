namespace FlappyBird
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.FlappyBird = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.Score = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            this.SuspendLayout();
            // 
            // Top
            // 
            this.pipeTop.Image = global::FlappyBird.Properties.Resources.pipedown;
            this.pipeTop.Location = new System.Drawing.Point(487, -77);
            this.pipeTop.Name = "Top";
            this.pipeTop.Size = new System.Drawing.Size(120, 277);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 0;
            this.pipeTop.TabStop = false;
            // 
            // FlappyBird
            // 
            this.FlappyBird.Image = global::FlappyBird.Properties.Resources.bird;
            this.FlappyBird.Location = new System.Drawing.Point(156, 280);
            this.FlappyBird.Name = "FlappyBird";
            this.FlappyBird.Size = new System.Drawing.Size(82, 74);
            this.FlappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FlappyBird.TabIndex = 1;
            this.FlappyBird.TabStop = false;
            //this.FlappyBird.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Bottom
            // 
            this.pipeBottom.Image = global::FlappyBird.Properties.Resources.pipe;
            this.pipeBottom.Location = new System.Drawing.Point(351, 457);
            this.pipeBottom.Name = "Bottom";
            this.pipeBottom.Size = new System.Drawing.Size(120, 285);
            this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom.TabIndex = 2;
            this.pipeBottom.TabStop = false;
            // 
            // Ground
            // 
            this.Ground.Image = global::FlappyBird.Properties.Resources.ground;
            this.Ground.Location = new System.Drawing.Point(-2, 730);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(662, 132);
            this.Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground.TabIndex = 3;
            this.Ground.TabStop = false;
            //this.Ground.Click += new System.EventHandler(this.Ground_Click);
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Lucida Sans Unicode", 26.29565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Score.Location = new System.Drawing.Point(-2, 2);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(194, 51);
            this.Score.TabIndex = 4;
            this.Score.Text = "Score: 0";
            //this.Score.Click += new System.EventHandler(this.Score_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(654, 791);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.pipeBottom);
            this.Controls.Add(this.FlappyBird);
            this.Controls.Add(this.pipeTop);
            this.Name = "Form1";
            this.Text = "FlappyBird-C#";
            //this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pipeTop;
        private PictureBox FlappyBird;
        private PictureBox pipeBottom;
        private PictureBox Ground;
        private Label Score;
        private System.Windows.Forms.Timer gameTimer;
    }
}
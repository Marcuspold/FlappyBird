
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PipeTop = new System.Windows.Forms.PictureBox();
            this.PipeTop2 = new System.Windows.Forms.PictureBox();
            this.Grounds = new System.Windows.Forms.PictureBox();
            this.Bird = new System.Windows.Forms.PictureBox();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PlayAgain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grounds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).BeginInit();
            this.SuspendLayout();
            // 
            // PipeTop
            // 
            this.PipeTop.Image = ((System.Drawing.Image)(resources.GetObject("PipeTop.Image")));
            this.PipeTop.Location = new System.Drawing.Point(126, 0);
            this.PipeTop.Name = "PipeTop";
            this.PipeTop.Size = new System.Drawing.Size(127, 138);
            this.PipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeTop.TabIndex = 0;
            this.PipeTop.TabStop = false;
            // 
            // PipeTop2
            // 
            this.PipeTop2.Image = ((System.Drawing.Image)(resources.GetObject("PipeTop2.Image")));
            this.PipeTop2.Location = new System.Drawing.Point(306, 282);
            this.PipeTop2.Name = "PipeTop2";
            this.PipeTop2.Size = new System.Drawing.Size(127, 122);
            this.PipeTop2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeTop2.TabIndex = 1;
            this.PipeTop2.TabStop = false;
            // 
            // Grounds
            // 
            this.Grounds.Image = ((System.Drawing.Image)(resources.GetObject("Grounds.Image")));
            this.Grounds.Location = new System.Drawing.Point(-1, 395);
            this.Grounds.Name = "Grounds";
            this.Grounds.Size = new System.Drawing.Size(471, 63);
            this.Grounds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Grounds.TabIndex = 2;
            this.Grounds.TabStop = false;
            // 
            // Bird
            // 
            this.Bird.Image = ((System.Drawing.Image)(resources.GetObject("Bird.Image")));
            this.Bird.Location = new System.Drawing.Point(12, 180);
            this.Bird.Name = "Bird";
            this.Bird.Size = new System.Drawing.Size(80, 61);
            this.Bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bird.TabIndex = 3;
            this.Bird.TabStop = false;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ScoreLabel.Location = new System.Drawing.Point(12, 31);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(111, 40);
            this.ScoreLabel.TabIndex = 4;
            this.ScoreLabel.Text = "Score 0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_tick);
            // 
            // PlayAgain
            // 
            this.PlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayAgain.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PlayAgain.Location = new System.Drawing.Point(170, 180);
            this.PlayAgain.Name = "PlayAgain";
            this.PlayAgain.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PlayAgain.Size = new System.Drawing.Size(161, 74);
            this.PlayAgain.TabIndex = 0;
            this.PlayAgain.Text = "PLAY AGAIN";
            this.PlayAgain.UseVisualStyleBackColor = true;
            this.PlayAgain.Visible = false;
            this.PlayAgain.Click += new System.EventHandler(this.PlayAgain_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(470, 450);
            this.Controls.Add(this.PlayAgain);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.Bird);
            this.Controls.Add(this.Grounds);
            this.Controls.Add(this.PipeTop2);
            this.Controls.Add(this.PipeTop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grounds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PipeTop;
        private System.Windows.Forms.PictureBox PipeTop2;
        private System.Windows.Forms.PictureBox Grounds;
        private System.Windows.Forms.PictureBox Bird;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button PlayAgain;
    }
}


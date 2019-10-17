namespace RockPaperScissors
{
    partial class FormRockPapeerSccissors
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRockPapeerSccissors));
            this.label1 = new System.Windows.Forms.Label();
            this.labelYourChoice = new System.Windows.Forms.Label();
            this.buttonRock = new System.Windows.Forms.Button();
            this.buttonPaper = new System.Windows.Forms.Button();
            this.buttonScissors = new System.Windows.Forms.Button();
            this.labelUserChoice = new System.Windows.Forms.Label();
            this.textBoxUserChoice = new System.Windows.Forms.TextBox();
            this.textBoxComputerChoice = new System.Windows.Forms.TextBox();
            this.labelComputerChoice = new System.Windows.Forms.Label();
            this.textBoxWinner = new System.Windows.Forms.TextBox();
            this.labelWinner = new System.Windows.Forms.Label();
            this.buttonRules = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxUserWins = new System.Windows.Forms.TextBox();
            this.textBoxComputerWIns = new System.Windows.Forms.TextBox();
            this.textBoxTies = new System.Windows.Forms.TextBox();
            this.labelUserWins = new System.Windows.Forms.Label();
            this.labelComputerWins = new System.Windows.Forms.Label();
            this.labelTies = new System.Windows.Forms.Label();
            this.labelResetAll = new System.Windows.Forms.Label();
            this.buttonResetAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(886, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rock/Paper/Scissors - You vs. The Computer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelYourChoice
            // 
            this.labelYourChoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelYourChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYourChoice.Location = new System.Drawing.Point(143, 203);
            this.labelYourChoice.Name = "labelYourChoice";
            this.labelYourChoice.Size = new System.Drawing.Size(173, 23);
            this.labelYourChoice.TabIndex = 1;
            this.labelYourChoice.Text = "Your Choice:";
            this.labelYourChoice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonRock
            // 
            this.buttonRock.Image = ((System.Drawing.Image)(resources.GetObject("buttonRock.Image")));
            this.buttonRock.Location = new System.Drawing.Point(322, 106);
            this.buttonRock.Name = "buttonRock";
            this.buttonRock.Size = new System.Drawing.Size(220, 217);
            this.buttonRock.TabIndex = 2;
            this.buttonRock.UseVisualStyleBackColor = true;
            this.buttonRock.Click += new System.EventHandler(this.buttonRock_Click);
            // 
            // buttonPaper
            // 
            this.buttonPaper.Image = ((System.Drawing.Image)(resources.GetObject("buttonPaper.Image")));
            this.buttonPaper.Location = new System.Drawing.Point(564, 109);
            this.buttonPaper.Name = "buttonPaper";
            this.buttonPaper.Size = new System.Drawing.Size(220, 217);
            this.buttonPaper.TabIndex = 3;
            this.buttonPaper.UseVisualStyleBackColor = true;
            this.buttonPaper.Click += new System.EventHandler(this.buttonPaper_Click);
            // 
            // buttonScissors
            // 
            this.buttonScissors.Image = ((System.Drawing.Image)(resources.GetObject("buttonScissors.Image")));
            this.buttonScissors.Location = new System.Drawing.Point(808, 109);
            this.buttonScissors.Name = "buttonScissors";
            this.buttonScissors.Size = new System.Drawing.Size(220, 217);
            this.buttonScissors.TabIndex = 4;
            this.buttonScissors.UseVisualStyleBackColor = true;
            this.buttonScissors.Click += new System.EventHandler(this.buttonScissors_Click);
            // 
            // labelUserChoice
            // 
            this.labelUserChoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelUserChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserChoice.Location = new System.Drawing.Point(143, 343);
            this.labelUserChoice.Name = "labelUserChoice";
            this.labelUserChoice.Size = new System.Drawing.Size(173, 34);
            this.labelUserChoice.TabIndex = 5;
            this.labelUserChoice.Text = "User Choice:";
            this.labelUserChoice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxUserChoice
            // 
            this.textBoxUserChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserChoice.Location = new System.Drawing.Point(337, 346);
            this.textBoxUserChoice.Name = "textBoxUserChoice";
            this.textBoxUserChoice.Size = new System.Drawing.Size(688, 31);
            this.textBoxUserChoice.TabIndex = 6;
            this.textBoxUserChoice.TextChanged += new System.EventHandler(this.textBoxUserChoice_TextChanged);
            // 
            // textBoxComputerChoice
            // 
            this.textBoxComputerChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxComputerChoice.Location = new System.Drawing.Point(334, 409);
            this.textBoxComputerChoice.Name = "textBoxComputerChoice";
            this.textBoxComputerChoice.Size = new System.Drawing.Size(688, 31);
            this.textBoxComputerChoice.TabIndex = 8;
            this.textBoxComputerChoice.TextChanged += new System.EventHandler(this.textBoxComputerChoice_TextChanged);
            // 
            // labelComputerChoice
            // 
            this.labelComputerChoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelComputerChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComputerChoice.Location = new System.Drawing.Point(99, 406);
            this.labelComputerChoice.Name = "labelComputerChoice";
            this.labelComputerChoice.Size = new System.Drawing.Size(214, 34);
            this.labelComputerChoice.TabIndex = 7;
            this.labelComputerChoice.Text = "Computer Choice:";
            this.labelComputerChoice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxWinner
            // 
            this.textBoxWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWinner.Location = new System.Drawing.Point(337, 469);
            this.textBoxWinner.Name = "textBoxWinner";
            this.textBoxWinner.Size = new System.Drawing.Size(688, 31);
            this.textBoxWinner.TabIndex = 10;
            this.textBoxWinner.TextChanged += new System.EventHandler(this.textBoxWinner_TextChanged);
            // 
            // labelWinner
            // 
            this.labelWinner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWinner.Location = new System.Drawing.Point(140, 469);
            this.labelWinner.Name = "labelWinner";
            this.labelWinner.Size = new System.Drawing.Size(173, 34);
            this.labelWinner.TabIndex = 9;
            this.labelWinner.Text = "Winner:";
            this.labelWinner.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonRules
            // 
            this.buttonRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRules.Location = new System.Drawing.Point(107, 610);
            this.buttonRules.Name = "buttonRules";
            this.buttonRules.Size = new System.Drawing.Size(130, 42);
            this.buttonRules.TabIndex = 11;
            this.buttonRules.Text = "Rules";
            this.buttonRules.UseVisualStyleBackColor = true;
            this.buttonRules.Click += new System.EventHandler(this.buttonRules_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(356, 610);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(130, 42);
            this.buttonClear.TabIndex = 12;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(639, 610);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(130, 42);
            this.buttonExit.TabIndex = 13;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // textBoxUserWins
            // 
            this.textBoxUserWins.BackColor = System.Drawing.Color.Yellow;
            this.textBoxUserWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserWins.Location = new System.Drawing.Point(107, 566);
            this.textBoxUserWins.Name = "textBoxUserWins";
            this.textBoxUserWins.ReadOnly = true;
            this.textBoxUserWins.Size = new System.Drawing.Size(133, 31);
            this.textBoxUserWins.TabIndex = 14;
            this.textBoxUserWins.TextChanged += new System.EventHandler(this.textBoxUserWins_TextChanged);
            // 
            // textBoxComputerWIns
            // 
            this.textBoxComputerWIns.BackColor = System.Drawing.Color.Yellow;
            this.textBoxComputerWIns.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxComputerWIns.Location = new System.Drawing.Point(353, 566);
            this.textBoxComputerWIns.Name = "textBoxComputerWIns";
            this.textBoxComputerWIns.ReadOnly = true;
            this.textBoxComputerWIns.Size = new System.Drawing.Size(133, 31);
            this.textBoxComputerWIns.TabIndex = 15;
            this.textBoxComputerWIns.TextChanged += new System.EventHandler(this.textBoxComputerWIns_TextChanged);
            // 
            // textBoxTies
            // 
            this.textBoxTies.BackColor = System.Drawing.Color.Yellow;
            this.textBoxTies.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTies.Location = new System.Drawing.Point(639, 566);
            this.textBoxTies.Name = "textBoxTies";
            this.textBoxTies.ReadOnly = true;
            this.textBoxTies.Size = new System.Drawing.Size(133, 31);
            this.textBoxTies.TabIndex = 16;
            this.textBoxTies.TextChanged += new System.EventHandler(this.textBoxTies_TextChanged);
            // 
            // labelUserWins
            // 
            this.labelUserWins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelUserWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserWins.Location = new System.Drawing.Point(107, 529);
            this.labelUserWins.Name = "labelUserWins";
            this.labelUserWins.Size = new System.Drawing.Size(130, 34);
            this.labelUserWins.TabIndex = 17;
            this.labelUserWins.Text = "User Wins:";
            this.labelUserWins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelComputerWins
            // 
            this.labelComputerWins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelComputerWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComputerWins.Location = new System.Drawing.Point(332, 529);
            this.labelComputerWins.Name = "labelComputerWins";
            this.labelComputerWins.Size = new System.Drawing.Size(181, 34);
            this.labelComputerWins.TabIndex = 18;
            this.labelComputerWins.Text = "Computer WIns:";
            this.labelComputerWins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTies
            // 
            this.labelTies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelTies.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTies.Location = new System.Drawing.Point(642, 529);
            this.labelTies.Name = "labelTies";
            this.labelTies.Size = new System.Drawing.Size(130, 34);
            this.labelTies.TabIndex = 19;
            this.labelTies.Text = "Ties:";
            this.labelTies.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelResetAll
            // 
            this.labelResetAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelResetAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResetAll.Location = new System.Drawing.Point(892, 529);
            this.labelResetAll.Name = "labelResetAll";
            this.labelResetAll.Size = new System.Drawing.Size(130, 34);
            this.labelResetAll.TabIndex = 22;
            this.labelResetAll.Text = "Reset All:";
            this.labelResetAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonResetAll
            // 
            this.buttonResetAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResetAll.Location = new System.Drawing.Point(889, 610);
            this.buttonResetAll.Name = "buttonResetAll";
            this.buttonResetAll.Size = new System.Drawing.Size(130, 42);
            this.buttonResetAll.TabIndex = 20;
            this.buttonResetAll.Text = "Reset All";
            this.buttonResetAll.UseVisualStyleBackColor = true;
            this.buttonResetAll.Click += new System.EventHandler(this.buttonResetAll_Click);
            // 
            // FormRockPapeerSccissors
            // 
            this.AcceptButton = this.buttonRules;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CancelButton = this.buttonClear;
            this.ClientSize = new System.Drawing.Size(1142, 678);
            this.Controls.Add(this.labelResetAll);
            this.Controls.Add(this.buttonResetAll);
            this.Controls.Add(this.labelTies);
            this.Controls.Add(this.labelComputerWins);
            this.Controls.Add(this.labelUserWins);
            this.Controls.Add(this.textBoxTies);
            this.Controls.Add(this.textBoxComputerWIns);
            this.Controls.Add(this.textBoxUserWins);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonRules);
            this.Controls.Add(this.textBoxWinner);
            this.Controls.Add(this.labelWinner);
            this.Controls.Add(this.textBoxComputerChoice);
            this.Controls.Add(this.labelComputerChoice);
            this.Controls.Add(this.textBoxUserChoice);
            this.Controls.Add(this.labelUserChoice);
            this.Controls.Add(this.buttonScissors);
            this.Controls.Add(this.buttonPaper);
            this.Controls.Add(this.buttonRock);
            this.Controls.Add(this.labelYourChoice);
            this.Controls.Add(this.label1);
            this.Name = "FormRockPapeerSccissors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jeff Scott - Chapter 4 Pages 182 - 183 Rock Paper Scissors Program";
            this.Load += new System.EventHandler(this.FormRockPapeerSccissors_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelYourChoice;
        private System.Windows.Forms.Button buttonRock;
        private System.Windows.Forms.Button buttonPaper;
        private System.Windows.Forms.Button buttonScissors;
        private System.Windows.Forms.Label labelUserChoice;
        private System.Windows.Forms.TextBox textBoxUserChoice;
        private System.Windows.Forms.TextBox textBoxComputerChoice;
        private System.Windows.Forms.Label labelComputerChoice;
        private System.Windows.Forms.TextBox textBoxWinner;
        private System.Windows.Forms.Label labelWinner;
        private System.Windows.Forms.Button buttonRules;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxUserWins;
        private System.Windows.Forms.TextBox textBoxComputerWIns;
        private System.Windows.Forms.TextBox textBoxTies;
        private System.Windows.Forms.Label labelUserWins;
        private System.Windows.Forms.Label labelComputerWins;
        private System.Windows.Forms.Label labelTies;
        private System.Windows.Forms.Label labelResetAll;
        private System.Windows.Forms.Button buttonResetAll;
    }
}


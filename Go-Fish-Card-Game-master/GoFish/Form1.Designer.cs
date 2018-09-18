namespace GoFish
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBooks = new System.Windows.Forms.TextBox();
            this.textProgress = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.listHand = new System.Windows.Forms.ListBox();
            this.askForCard = new System.Windows.Forms.Button();
            this.startGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(17, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(478, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Your Hand";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(17, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Game Progress";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(17, 369);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Books";
            // 
            // textBooks
            // 
            this.textBooks.Location = new System.Drawing.Point(17, 389);
            this.textBooks.Margin = new System.Windows.Forms.Padding(4);
            this.textBooks.Multiline = true;
            this.textBooks.Name = "textBooks";
            this.textBooks.Size = new System.Drawing.Size(435, 155);
            this.textBooks.TabIndex = 4;
            // 
            // textProgress
            // 
            this.textProgress.Location = new System.Drawing.Point(17, 145);
            this.textProgress.Margin = new System.Windows.Forms.Padding(4);
            this.textProgress.Multiline = true;
            this.textProgress.Name = "textProgress";
            this.textProgress.Size = new System.Drawing.Size(435, 205);
            this.textProgress.TabIndex = 5;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(17, 84);
            this.textName.Margin = new System.Windows.Forms.Padding(4);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(212, 22);
            this.textName.TabIndex = 7;
            // 
            // listHand
            // 
            this.listHand.FormattingEnabled = true;
            this.listHand.ItemHeight = 16;
            this.listHand.Location = new System.Drawing.Point(479, 63);
            this.listHand.Margin = new System.Windows.Forms.Padding(4);
            this.listHand.Name = "listHand";
            this.listHand.Size = new System.Drawing.Size(216, 436);
            this.listHand.TabIndex = 8;
            // 
            // askForCard
            // 
            this.askForCard.BackColor = System.Drawing.SystemColors.Info;
            this.askForCard.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.askForCard.FlatAppearance.BorderSize = 3;
            this.askForCard.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.askForCard.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.askForCard.Location = new System.Drawing.Point(479, 507);
            this.askForCard.Margin = new System.Windows.Forms.Padding(4);
            this.askForCard.Name = "askForCard";
            this.askForCard.Size = new System.Drawing.Size(217, 38);
            this.askForCard.TabIndex = 9;
            this.askForCard.Text = "Ask for a card";
            this.askForCard.UseVisualStyleBackColor = false;
            this.askForCard.Click += new System.EventHandler(this.askForCard_Click);
            // 
            // startGame
            // 
            this.startGame.BackColor = System.Drawing.SystemColors.Info;
            this.startGame.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.startGame.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGame.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.startGame.Location = new System.Drawing.Point(263, 63);
            this.startGame.Margin = new System.Windows.Forms.Padding(4);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(192, 43);
            this.startGame.TabIndex = 10;
            this.startGame.Text = "Start the Game!";
            this.startGame.UseVisualStyleBackColor = false;
            this.startGame.Click += new System.EventHandler(this.startGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(716, 585);
            this.Controls.Add(this.startGame);
            this.Controls.Add(this.askForCard);
            this.Controls.Add(this.listHand);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textProgress);
            this.Controls.Add(this.textBooks);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "GoFish!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBooks;
        private System.Windows.Forms.TextBox textProgress;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.ListBox listHand;
        private System.Windows.Forms.Button askForCard;
        private System.Windows.Forms.Button startGame;
    }
}


namespace Monopoly_Game
{
    partial class Game
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
            this.btnRollDice = new DevComponents.DotNetBar.ButtonX();
            this.label1 = new System.Windows.Forms.Label();
            this.Player1Selection = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.Player2Selection = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStartGame = new DevComponents.DotNetBar.ButtonX();
            this.btnEndGame = new DevComponents.DotNetBar.ButtonX();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblP2Money = new System.Windows.Forms.Label();
            this.lblP1Money = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTurn = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnMortgage = new System.Windows.Forms.Button();
            this.btnTrade = new System.Windows.Forms.Button();
            this.btnAddHouse = new System.Windows.Forms.Button();
            this.btnAddHotel = new System.Windows.Forms.Button();
            this.btnPropertyInfo = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRollDice
            // 
            this.btnRollDice.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRollDice.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRollDice.Enabled = false;
            this.btnRollDice.Location = new System.Drawing.Point(3, 207);
            this.btnRollDice.Name = "btnRollDice";
            this.btnRollDice.Size = new System.Drawing.Size(198, 29);
            this.btnRollDice.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnRollDice.TabIndex = 0;
            this.btnRollDice.Text = "Roll Dice!";
            this.btnRollDice.Click += new System.EventHandler(this.btnRollDice_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player 1:";
            // 
            // Player1Selection
            // 
            this.Player1Selection.DisplayMember = "Text";
            this.Player1Selection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Player1Selection.Enabled = false;
            this.Player1Selection.ForeColor = System.Drawing.Color.Black;
            this.Player1Selection.FormattingEnabled = true;
            this.Player1Selection.ItemHeight = 14;
            this.Player1Selection.Location = new System.Drawing.Point(3, 37);
            this.Player1Selection.Name = "Player1Selection";
            this.Player1Selection.Size = new System.Drawing.Size(167, 20);
            this.Player1Selection.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Player1Selection.TabIndex = 1;
            // 
            // Player2Selection
            // 
            this.Player2Selection.DisplayMember = "Text";
            this.Player2Selection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Player2Selection.Enabled = false;
            this.Player2Selection.ForeColor = System.Drawing.Color.Black;
            this.Player2Selection.FormattingEnabled = true;
            this.Player2Selection.ItemHeight = 14;
            this.Player2Selection.Location = new System.Drawing.Point(3, 87);
            this.Player2Selection.Name = "Player2Selection";
            this.Player2Selection.Size = new System.Drawing.Size(167, 20);
            this.Player2Selection.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Player2Selection.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(0, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Player 2";
            // 
            // btnStartGame
            // 
            this.btnStartGame.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnStartGame.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnStartGame.Location = new System.Drawing.Point(3, 145);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(198, 25);
            this.btnStartGame.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnStartGame.TabIndex = 4;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // btnEndGame
            // 
            this.btnEndGame.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEndGame.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEndGame.Enabled = false;
            this.btnEndGame.Location = new System.Drawing.Point(3, 176);
            this.btnEndGame.Name = "btnEndGame";
            this.btnEndGame.Size = new System.Drawing.Size(198, 25);
            this.btnEndGame.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEndGame.TabIndex = 5;
            this.btnEndGame.Text = "End Game";
            this.btnEndGame.Click += new System.EventHandler(this.btnEndGame_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(7, 586);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Player 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(7, 562);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Player 1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(7, 543);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Money(Millions):";
            // 
            // lblP2Money
            // 
            this.lblP2Money.AutoSize = true;
            this.lblP2Money.BackColor = System.Drawing.Color.White;
            this.lblP2Money.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP2Money.ForeColor = System.Drawing.Color.Black;
            this.lblP2Money.Location = new System.Drawing.Point(69, 586);
            this.lblP2Money.Name = "lblP2Money";
            this.lblP2Money.Size = new System.Drawing.Size(15, 16);
            this.lblP2Money.TabIndex = 10;
            this.lblP2Money.Text = "0";
            // 
            // lblP1Money
            // 
            this.lblP1Money.AutoSize = true;
            this.lblP1Money.BackColor = System.Drawing.Color.White;
            this.lblP1Money.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP1Money.ForeColor = System.Drawing.Color.Black;
            this.lblP1Money.Location = new System.Drawing.Point(69, 562);
            this.lblP1Money.Name = "lblP1Money";
            this.lblP1Money.Size = new System.Drawing.Size(15, 16);
            this.lblP1Money.TabIndex = 9;
            this.lblP1Money.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(0, -1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Starting Settings:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(0, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Game:";
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.Location = new System.Drawing.Point(7, 641);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(48, 15);
            this.lblTurn.TabIndex = 17;
            this.lblTurn.Text = "Player1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(4, 620);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Whos Turn:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(891, -1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Player1 Properties:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(896, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(177, 186);
            this.listBox1.TabIndex = 20;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(896, 248);
            this.listBox2.Name = "listBox2";
            this.listBox2.ScrollAlwaysVisible = true;
            this.listBox2.Size = new System.Drawing.Size(177, 186);
            this.listBox2.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(891, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "Player2 Properties:";
            // 
            // btnMortgage
            // 
            this.btnMortgage.Enabled = false;
            this.btnMortgage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMortgage.Location = new System.Drawing.Point(896, 468);
            this.btnMortgage.Name = "btnMortgage";
            this.btnMortgage.Size = new System.Drawing.Size(87, 35);
            this.btnMortgage.TabIndex = 23;
            this.btnMortgage.Text = "Mortgage Property";
            this.btnMortgage.UseVisualStyleBackColor = true;
            // 
            // btnTrade
            // 
            this.btnTrade.Enabled = false;
            this.btnTrade.Location = new System.Drawing.Point(896, 440);
            this.btnTrade.Name = "btnTrade";
            this.btnTrade.Size = new System.Drawing.Size(176, 22);
            this.btnTrade.TabIndex = 24;
            this.btnTrade.Text = "Trade";
            this.btnTrade.UseVisualStyleBackColor = true;
            // 
            // btnAddHouse
            // 
            this.btnAddHouse.Enabled = false;
            this.btnAddHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddHouse.Location = new System.Drawing.Point(896, 509);
            this.btnAddHouse.Name = "btnAddHouse";
            this.btnAddHouse.Size = new System.Drawing.Size(87, 35);
            this.btnAddHouse.TabIndex = 25;
            this.btnAddHouse.Text = "Add House";
            this.btnAddHouse.UseVisualStyleBackColor = true;
            // 
            // btnAddHotel
            // 
            this.btnAddHotel.Enabled = false;
            this.btnAddHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddHotel.Location = new System.Drawing.Point(896, 550);
            this.btnAddHotel.Name = "btnAddHotel";
            this.btnAddHotel.Size = new System.Drawing.Size(87, 35);
            this.btnAddHotel.TabIndex = 26;
            this.btnAddHotel.Text = "Add Hotel";
            this.btnAddHotel.UseVisualStyleBackColor = true;
            // 
            // btnPropertyInfo
            // 
            this.btnPropertyInfo.Enabled = false;
            this.btnPropertyInfo.Location = new System.Drawing.Point(896, 634);
            this.btnPropertyInfo.Name = "btnPropertyInfo";
            this.btnPropertyInfo.Size = new System.Drawing.Size(176, 22);
            this.btnPropertyInfo.TabIndex = 27;
            this.btnPropertyInfo.Text = "Property List/Information";
            this.btnPropertyInfo.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.ForeColor = System.Drawing.Color.Black;
            this.pictureBox2.Image = global::Monopoly_Game.Properties.Resources.monopoly_token_barrow;
            this.pictureBox2.Location = new System.Drawing.Point(3, 293);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.ForeColor = System.Drawing.Color.Black;
            this.pictureBox3.Image = global::Monopoly_Game.Properties.Resources.monopoly_token_thimble;
            this.pictureBox3.Location = new System.Drawing.Point(3, 248);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.ForeColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::Monopoly_Game.Properties.Resources.monopoly_board1;
            this.pictureBox1.Location = new System.Drawing.Point(225, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(660, 660);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(985, 550);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 35);
            this.button1.TabIndex = 30;
            this.button1.Text = "Remove Hotel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(985, 509);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 35);
            this.button2.TabIndex = 29;
            this.button2.Text = "Remove House";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(985, 468);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 35);
            this.button3.TabIndex = 28;
            this.button3.Text = "Unmortgage Property";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 669);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnPropertyInfo);
            this.Controls.Add(this.btnAddHotel);
            this.Controls.Add(this.btnAddHouse);
            this.Controls.Add(this.btnTrade);
            this.Controls.Add(this.btnMortgage);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblP2Money);
            this.Controls.Add(this.lblP1Money);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEndGame);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.Player2Selection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Player1Selection);
            this.Controls.Add(this.btnRollDice);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1100, 708);
            this.MinimumSize = new System.Drawing.Size(1100, 708);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monopoly Game - By MJR";
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnRollDice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx Player2Selection;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx Player1Selection;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.ButtonX btnStartGame;
        private DevComponents.DotNetBar.ButtonX btnEndGame;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblP2Money;
        private System.Windows.Forms.Label lblP1Money;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnMortgage;
        private System.Windows.Forms.Button btnTrade;
        private System.Windows.Forms.Button btnAddHouse;
        private System.Windows.Forms.Button btnAddHotel;
        private System.Windows.Forms.Button btnPropertyInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}


namespace minesweeper.net
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.MNU_Game = new System.Windows.Forms.MenuItem();
            this.MNU_New = new System.Windows.Forms.MenuItem();
            this.MNU_SEP1 = new System.Windows.Forms.MenuItem();
            this.MNU_Beginner = new System.Windows.Forms.MenuItem();
            this.MNU_Intermediate = new System.Windows.Forms.MenuItem();
            this.MNU_Expert = new System.Windows.Forms.MenuItem();
            this.MNU_Custom = new System.Windows.Forms.MenuItem();
            this.MNU_SEP2 = new System.Windows.Forms.MenuItem();
            this.MNU_Marks = new System.Windows.Forms.MenuItem();
            this.MNU_Color = new System.Windows.Forms.MenuItem();
            this.MNU_SEP3 = new System.Windows.Forms.MenuItem();
            this.MNU_Best_Times = new System.Windows.Forms.MenuItem();
            this.MNU_SEP4 = new System.Windows.Forms.MenuItem();
            this.MNU_Exit = new System.Windows.Forms.MenuItem();
            this.MNU_Help = new System.Windows.Forms.MenuItem();
            this.MNU_Contents = new System.Windows.Forms.MenuItem();
            this.MNU_Using_Help = new System.Windows.Forms.MenuItem();
            this.MNU_SEP5 = new System.Windows.Forms.MenuItem();
            this.MNU_About = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.MainBtn = new System.Windows.Forms.PictureBox();
            this.MainBtnBorder = new System.Windows.Forms.PictureBox();
            this.TableDisplay = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.MinesDisplay = new System.Windows.Forms.PictureBox();
            this.TimerDisplay = new System.Windows.Forms.PictureBox();
            this.topleft = new System.Windows.Forms.PictureBox();
            this.topright = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MainBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainBtnBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinesDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimerDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topleft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topright)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MNU_Game,
            this.MNU_Help});
            // 
            // MNU_Game
            // 
            this.MNU_Game.Index = 0;
            this.MNU_Game.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MNU_New,
            this.MNU_SEP1,
            this.MNU_Beginner,
            this.MNU_Intermediate,
            this.MNU_Expert,
            this.MNU_Custom,
            this.MNU_SEP2,
            this.MNU_Marks,
            this.MNU_Color,
            this.MNU_SEP3,
            this.MNU_Best_Times,
            this.MNU_SEP4,
            this.MNU_Exit});
            this.MNU_Game.Text = "Game";
            // 
            // MNU_New
            // 
            this.MNU_New.Index = 0;
            this.MNU_New.Shortcut = System.Windows.Forms.Shortcut.F2;
            this.MNU_New.Text = "New";
            this.MNU_New.Click += new System.EventHandler(this.MNU_New_Click);
            // 
            // MNU_SEP1
            // 
            this.MNU_SEP1.Index = 1;
            this.MNU_SEP1.Text = "-";
            // 
            // MNU_Beginner
            // 
            this.MNU_Beginner.Index = 2;
            this.MNU_Beginner.Text = "Beginner";
            this.MNU_Beginner.Click += new System.EventHandler(this.MNU_Beginner_Click);
            // 
            // MNU_Intermediate
            // 
            this.MNU_Intermediate.Index = 3;
            this.MNU_Intermediate.Text = "Intermediate";
            this.MNU_Intermediate.Click += new System.EventHandler(this.MNU_Intermediate_Click);
            // 
            // MNU_Expert
            // 
            this.MNU_Expert.Index = 4;
            this.MNU_Expert.Text = "Expert";
            this.MNU_Expert.Click += new System.EventHandler(this.MNU_Expert_Click);
            // 
            // MNU_Custom
            // 
            this.MNU_Custom.Index = 5;
            this.MNU_Custom.Text = "Custom...";
            this.MNU_Custom.Click += new System.EventHandler(this.MNU_Custom_Click);
            // 
            // MNU_SEP2
            // 
            this.MNU_SEP2.Index = 6;
            this.MNU_SEP2.Text = "-";
            // 
            // MNU_Marks
            // 
            this.MNU_Marks.Checked = true;
            this.MNU_Marks.Index = 7;
            this.MNU_Marks.Text = "Marks (?)";
            this.MNU_Marks.Click += new System.EventHandler(this.ToCheck_Click);
            // 
            // MNU_Color
            // 
            this.MNU_Color.Checked = true;
            this.MNU_Color.Index = 8;
            this.MNU_Color.Text = "Color";
            this.MNU_Color.Click += new System.EventHandler(this.ToCheck_Click);
            // 
            // MNU_SEP3
            // 
            this.MNU_SEP3.Index = 9;
            this.MNU_SEP3.Text = "-";
            // 
            // MNU_Best_Times
            // 
            this.MNU_Best_Times.Index = 10;
            this.MNU_Best_Times.Text = "Best Times...";
            // 
            // MNU_SEP4
            // 
            this.MNU_SEP4.Index = 11;
            this.MNU_SEP4.Text = "-";
            // 
            // MNU_Exit
            // 
            this.MNU_Exit.Index = 12;
            this.MNU_Exit.Text = "Exit";
            this.MNU_Exit.Click += new System.EventHandler(this.MNU_Exit_Click);
            // 
            // MNU_Help
            // 
            this.MNU_Help.Index = 1;
            this.MNU_Help.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MNU_Contents,
            this.MNU_Using_Help,
            this.MNU_SEP5,
            this.MNU_About});
            this.MNU_Help.Text = "Help";
            // 
            // MNU_Contents
            // 
            this.MNU_Contents.Index = 0;
            this.MNU_Contents.Shortcut = System.Windows.Forms.Shortcut.F1;
            this.MNU_Contents.Text = "Contents";
            // 
            // MNU_Using_Help
            // 
            this.MNU_Using_Help.Index = 1;
            this.MNU_Using_Help.Text = "Using Help";
            // 
            // MNU_SEP5
            // 
            this.MNU_SEP5.Index = 2;
            this.MNU_SEP5.Text = "-";
            // 
            // MNU_About
            // 
            this.MNU_About.Index = 3;
            this.MNU_About.Text = "About Minesweeper...";
            // 
            // menuItem1
            // 
            this.menuItem1.Index = -1;
            this.menuItem1.Text = "";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = -1;
            this.menuItem2.Text = "";
            // 
            // MainBtn
            // 
            this.MainBtn.BackColor = System.Drawing.SystemColors.Control;
            this.MainBtn.Location = new System.Drawing.Point(121, 16);
            this.MainBtn.Name = "MainBtn";
            this.MainBtn.Size = new System.Drawing.Size(24, 24);
            this.MainBtn.TabIndex = 12;
            this.MainBtn.TabStop = false;
            this.MainBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainBtn_MouseDown);
            this.MainBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainBtn_MouseMove);
            this.MainBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainBtn_MouseUp);
            // 
            // MainBtnBorder
            // 
            this.MainBtnBorder.BackColor = System.Drawing.Color.Transparent;
            this.MainBtnBorder.Image = global::minesweeper.net.Properties.Resources.border;
            this.MainBtnBorder.Location = new System.Drawing.Point(120, 15);
            this.MainBtnBorder.Name = "MainBtnBorder";
            this.MainBtnBorder.Size = new System.Drawing.Size(26, 26);
            this.MainBtnBorder.TabIndex = 11;
            this.MainBtnBorder.TabStop = false;
            // 
            // TableDisplay
            // 
            this.TableDisplay.Location = new System.Drawing.Point(12, 55);
            this.TableDisplay.Name = "TableDisplay";
            this.TableDisplay.Size = new System.Drawing.Size(256, 256);
            this.TableDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.TableDisplay.TabIndex = 10;
            this.TableDisplay.TabStop = false;
            this.TableDisplay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TableDisplay_MouseDown);
            this.TableDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TableDisplay_MouseMove);
            this.TableDisplay.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TableDisplay_MouseUp);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox5.Image = global::minesweeper.net.Properties.Resources.bottomleft;
            this.pictureBox5.Location = new System.Drawing.Point(0, 311);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(12, 8);
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Image = global::minesweeper.net.Properties.Resources.bottomright;
            this.pictureBox4.Location = new System.Drawing.Point(268, 311);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(8, 8);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // MinesDisplay
            // 
            this.MinesDisplay.Location = new System.Drawing.Point(17, 16);
            this.MinesDisplay.Name = "MinesDisplay";
            this.MinesDisplay.Size = new System.Drawing.Size(39, 23);
            this.MinesDisplay.TabIndex = 1;
            this.MinesDisplay.TabStop = false;
            // 
            // TimerDisplay
            // 
            this.TimerDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TimerDisplay.Location = new System.Drawing.Point(222, 16);
            this.TimerDisplay.Name = "TimerDisplay";
            this.TimerDisplay.Size = new System.Drawing.Size(39, 23);
            this.TimerDisplay.TabIndex = 0;
            this.TimerDisplay.TabStop = false;
            // 
            // topleft
            // 
            this.topleft.Image = global::minesweeper.net.Properties.Resources.topleft;
            this.topleft.Location = new System.Drawing.Point(0, 0);
            this.topleft.Name = "topleft";
            this.topleft.Size = new System.Drawing.Size(57, 55);
            this.topleft.TabIndex = 2;
            this.topleft.TabStop = false;
            // 
            // topright
            // 
            this.topright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.topright.Image = global::minesweeper.net.Properties.Resources.topright;
            this.topright.Location = new System.Drawing.Point(221, 0);
            this.topright.Name = "topright";
            this.topright.Size = new System.Drawing.Size(55, 55);
            this.topright.TabIndex = 3;
            this.topright.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackgroundImage = global::minesweeper.net.Properties.Resources.top;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(274, 55);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox8.BackgroundImage = global::minesweeper.net.Properties.Resources.bottom;
            this.pictureBox8.Location = new System.Drawing.Point(0, 311);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(276, 8);
            this.pictureBox8.TabIndex = 9;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox6.BackgroundImage = global::minesweeper.net.Properties.Resources.left;
            this.pictureBox6.Location = new System.Drawing.Point(0, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(12, 340);
            this.pictureBox6.TabIndex = 7;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox7.BackgroundImage = global::minesweeper.net.Properties.Resources.right;
            this.pictureBox7.Location = new System.Drawing.Point(268, 0);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(10, 340);
            this.pictureBox7.TabIndex = 8;
            this.pictureBox7.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 319);
            this.Controls.Add(this.MainBtn);
            this.Controls.Add(this.MainBtnBorder);
            this.Controls.Add(this.TableDisplay);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.MinesDisplay);
            this.Controls.Add(this.TimerDisplay);
            this.Controls.Add(this.topleft);
            this.Controls.Add(this.topright);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Minesweeper.NET";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainBtnBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinesDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimerDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topleft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topright)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox TimerDisplay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem MNU_Game;
        private System.Windows.Forms.MenuItem MNU_New;
        private System.Windows.Forms.MenuItem MNU_SEP1;
        private System.Windows.Forms.MenuItem MNU_Beginner;
        private System.Windows.Forms.MenuItem MNU_Intermediate;
        private System.Windows.Forms.MenuItem MNU_Expert;
        private System.Windows.Forms.MenuItem MNU_Custom;
        private System.Windows.Forms.MenuItem MNU_SEP2;
        private System.Windows.Forms.MenuItem MNU_Marks;
        private System.Windows.Forms.MenuItem MNU_Color;
        private System.Windows.Forms.MenuItem MNU_SEP3;
        private System.Windows.Forms.MenuItem MNU_Best_Times;
        private System.Windows.Forms.MenuItem MNU_SEP4;
        private System.Windows.Forms.MenuItem MNU_Exit;
        private System.Windows.Forms.MenuItem MNU_Help;
        private System.Windows.Forms.MenuItem MNU_Contents;
        private System.Windows.Forms.MenuItem MNU_Using_Help;
        private System.Windows.Forms.MenuItem MNU_SEP5;
        private System.Windows.Forms.MenuItem MNU_About;
        private System.Windows.Forms.PictureBox MinesDisplay;
        private System.Windows.Forms.PictureBox topleft;
        private System.Windows.Forms.PictureBox topright;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox TableDisplay;
        private System.Windows.Forms.PictureBox MainBtnBorder;
        private System.Windows.Forms.PictureBox MainBtn;
    }
}


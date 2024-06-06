namespace ProyectoFinal
{
    partial class Menu
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
            btnFrmBook = new FontAwesome.Sharp.IconButton();
            btnFrmComputer = new FontAwesome.Sharp.IconButton();
            R = new Label();
            btnExit = new FontAwesome.Sharp.IconButton();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnFrmBook
            // 
            btnFrmBook.Font = new Font("NSimSun", 11.25F);
            btnFrmBook.IconChar = FontAwesome.Sharp.IconChar.BookBookmark;
            btnFrmBook.IconColor = Color.Black;
            btnFrmBook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFrmBook.IconSize = 29;
            btnFrmBook.ImageAlign = ContentAlignment.MiddleLeft;
            btnFrmBook.Location = new Point(207, 184);
            btnFrmBook.Name = "btnFrmBook";
            btnFrmBook.Size = new Size(173, 34);
            btnFrmBook.TabIndex = 2;
            btnFrmBook.Text = "Book";
            btnFrmBook.UseVisualStyleBackColor = true;
            btnFrmBook.Click += btnFrmBook_Click;
            // 
            // btnFrmComputer
            // 
            btnFrmComputer.Font = new Font("NSimSun", 11.25F);
            btnFrmComputer.IconChar = FontAwesome.Sharp.IconChar.Computer;
            btnFrmComputer.IconColor = Color.Black;
            btnFrmComputer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFrmComputer.IconSize = 36;
            btnFrmComputer.ImageAlign = ContentAlignment.MiddleLeft;
            btnFrmComputer.Location = new Point(207, 224);
            btnFrmComputer.Name = "btnFrmComputer";
            btnFrmComputer.Size = new Size(173, 34);
            btnFrmComputer.TabIndex = 3;
            btnFrmComputer.Text = "Computer";
            btnFrmComputer.UseVisualStyleBackColor = true;
            btnFrmComputer.Click += btnFrmComputer_Click;
            // 
            // R
            // 
            R.AutoSize = true;
            R.Font = new Font("NSimSun", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            R.Location = new Point(256, 152);
            R.Name = "R";
            R.Size = new Size(71, 16);
            R.TabIndex = 4;
            R.Text = "REGISTER";
            // 
            // btnExit
            // 
            btnExit.Font = new Font("NSimSun", 11.25F);
            btnExit.IconChar = FontAwesome.Sharp.IconChar.None;
            btnExit.IconColor = Color.Black;
            btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExit.Location = new Point(207, 264);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(173, 34);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Gardenpngg;
            pictureBox1.Location = new Point(195, -21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 189);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(598, 321);
            Controls.Add(btnExit);
            Controls.Add(R);
            Controls.Add(btnFrmComputer);
            Controls.Add(btnFrmBook);
            Controls.Add(pictureBox1);
            Name = "Menu";
            Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnFrmBook;
        private FontAwesome.Sharp.IconButton btnFrmComputer;
        private Label R;
        private FontAwesome.Sharp.IconButton btnExit;
        private PictureBox pictureBox1;
    }
}
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
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
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
            btnFrmBook.Location = new Point(151, 216);
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
            btnFrmComputer.Location = new Point(151, 256);
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
            R.Location = new Point(200, 192);
            R.Name = "R";
            R.Size = new Size(0, 16);
            R.TabIndex = 4;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("NSimSun", 11.25F);
            btnExit.IconChar = FontAwesome.Sharp.IconChar.None;
            btnExit.IconColor = Color.Black;
            btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExit.Location = new Point(151, 296);
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
            pictureBox1.Location = new Point(155, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(169, 167);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Perpetua Titling MT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(109, 169);
            label1.Name = "label1";
            label1.Size = new Size(269, 23);
            label1.TabIndex = 7;
            label1.Text = "G A R D E N  L I B R A R Y";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Handwriting", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(190, 192);
            label2.Name = "label2";
            label2.Size = new Size(90, 21);
            label2.TabIndex = 8;
            label2.Text = "Register";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnFrmBook);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnFrmComputer);
            groupBox1.Controls.Add(btnExit);
            groupBox1.Controls.Add(R);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(39, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(491, 361);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(586, 395);
            Controls.Add(groupBox1);
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnFrmBook;
        private FontAwesome.Sharp.IconButton btnFrmComputer;
        private Label R;
        private FontAwesome.Sharp.IconButton btnExit;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
    }
}
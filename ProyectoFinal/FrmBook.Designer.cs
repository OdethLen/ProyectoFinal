namespace ProyectoFinal
{
    partial class FrmBook
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            txtPublisher = new TextBox();
            txtAuthor = new TextBox();
            txtLastName = new TextBox();
            txtTitle = new TextBox();
            txtName = new TextBox();
            dtpEndDate = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            dtpDate = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lstvBookregister = new ListView();
            btnAdd = new Button();
            btnExporttxt = new Button();
            btnBack = new FontAwesome.Sharp.IconButton();
            ErrorProvider = new ErrorProvider(components);
            btnOpentxt = new Button();
            btnWord = new FontAwesome.Sharp.IconButton();
            btnExcel = new FontAwesome.Sharp.IconButton();
            btnDelete = new FontAwesome.Sharp.IconButton();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightPink;
            groupBox1.Controls.Add(txtPublisher);
            groupBox1.Controls.Add(txtAuthor);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Controls.Add(txtTitle);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(dtpEndDate);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(dtpDate);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("NSimSun", 11.25F);
            groupBox1.Location = new Point(52, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(557, 203);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Book Register";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtPublisher
            // 
            txtPublisher.Location = new Point(106, 109);
            txtPublisher.Name = "txtPublisher";
            txtPublisher.Size = new Size(168, 25);
            txtPublisher.TabIndex = 13;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(376, 67);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(139, 25);
            txtAuthor.TabIndex = 12;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(376, 24);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(139, 25);
            txtLastName.TabIndex = 11;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(76, 72);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(198, 25);
            txtTitle.TabIndex = 10;
            // 
            // txtName
            // 
            txtName.Location = new Point(76, 34);
            txtName.Name = "txtName";
            txtName.Size = new Size(127, 25);
            txtName.TabIndex = 9;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(285, 146);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(110, 25);
            dtpEndDate.TabIndex = 8;
            dtpEndDate.ValueChanged += dtpEndDate_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(208, 156);
            label7.Name = "label7";
            label7.Size = new Size(71, 15);
            label7.TabIndex = 7;
            label7.Text = "End date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 158);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 6;
            label6.Text = "Date";
            // 
            // dtpDate
            // 
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(66, 149);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(110, 25);
            dtpDate.TabIndex = 5;
            dtpDate.ValueChanged += dtpDate_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 119);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 4;
            label5.Text = "Publisher";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(291, 75);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 3;
            label4.Text = "Author ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 80);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 2;
            label3.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(291, 34);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 1;
            label2.Text = "Last name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 42);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // lstvBookregister
            // 
            lstvBookregister.Font = new Font("NSimSun", 11.25F);
            lstvBookregister.FullRowSelect = true;
            lstvBookregister.GridLines = true;
            lstvBookregister.Location = new Point(36, 255);
            lstvBookregister.Name = "lstvBookregister";
            lstvBookregister.Size = new Size(727, 184);
            lstvBookregister.TabIndex = 1;
            lstvBookregister.UseCompatibleStateImageBehavior = false;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("NSimSun", 11.25F);
            btnAdd.Location = new Point(633, 35);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(117, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnExporttxt
            // 
            btnExporttxt.Font = new Font("NSimSun", 11.25F);
            btnExporttxt.Location = new Point(633, 64);
            btnExporttxt.Name = "btnExporttxt";
            btnExporttxt.Size = new Size(117, 23);
            btnExporttxt.TabIndex = 3;
            btnExporttxt.Text = "Export txt";
            btnExporttxt.UseVisualStyleBackColor = true;
            btnExporttxt.Click += btnExporttxt_Click;
            // 
            // btnBack
            // 
            btnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            btnBack.IconColor = Color.Black;
            btnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBack.IconSize = 24;
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(34, 23);
            btnBack.TabIndex = 9;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // ErrorProvider
            // 
            ErrorProvider.ContainerControl = this;
            // 
            // btnOpentxt
            // 
            btnOpentxt.Font = new Font("NSimSun", 11.25F);
            btnOpentxt.Location = new Point(633, 93);
            btnOpentxt.Name = "btnOpentxt";
            btnOpentxt.Size = new Size(117, 23);
            btnOpentxt.TabIndex = 10;
            btnOpentxt.Text = "Open txt";
            btnOpentxt.UseVisualStyleBackColor = true;
            btnOpentxt.Click += btnOpentxt_Click;
            // 
            // btnWord
            // 
            btnWord.Font = new Font("NSimSun", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnWord.IconChar = FontAwesome.Sharp.IconChar.None;
            btnWord.IconColor = Color.Black;
            btnWord.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnWord.Location = new Point(781, 302);
            btnWord.Name = "btnWord";
            btnWord.Size = new Size(95, 23);
            btnWord.TabIndex = 11;
            btnWord.Text = "Word";
            btnWord.UseVisualStyleBackColor = true;
            btnWord.Click += btnWord_Click;
            // 
            // btnExcel
            // 
            btnExcel.Font = new Font("NSimSun", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExcel.IconChar = FontAwesome.Sharp.IconChar.None;
            btnExcel.IconColor = Color.Black;
            btnExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExcel.Location = new Point(781, 331);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(95, 23);
            btnExcel.TabIndex = 12;
            btnExcel.Text = "Excel";
            btnExcel.UseVisualStyleBackColor = true;
            btnExcel.Click += btnExcel_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("NSimSun", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.IconChar = FontAwesome.Sharp.IconChar.None;
            btnDelete.IconColor = Color.Black;
            btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDelete.Location = new Point(781, 273);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(95, 23);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // FrmBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightPink;
            ClientSize = new Size(921, 521);
            Controls.Add(btnDelete);
            Controls.Add(btnExcel);
            Controls.Add(btnWord);
            Controls.Add(btnOpentxt);
            Controls.Add(btnBack);
            Controls.Add(btnExporttxt);
            Controls.Add(btnAdd);
            Controls.Add(lstvBookregister);
            Controls.Add(groupBox1);
            Name = "FrmBook";
            Text = "Book";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private TextBox txtPublisher;
        private TextBox txtAuthor;
        private TextBox txtLastName;
        private TextBox txtTitle;
        private TextBox txtName;
        private DateTimePicker dtpEndDate;
        private Label label7;
        private Label label6;
        private DateTimePicker dtpDate;
        private Label label5;
        private Label label4;
        private Label label3;
        private ListView lstvBookregister;
        private Button btnAdd;
        private Button btnExporttxt;
        private FontAwesome.Sharp.IconButton btnBack;
        private ErrorProvider ErrorProvider;
        private Button btnOpentxt;
        private FontAwesome.Sharp.IconButton btnWord;
        private FontAwesome.Sharp.IconButton btnExcel;
        private FontAwesome.Sharp.IconButton btnDelete;
    }
}

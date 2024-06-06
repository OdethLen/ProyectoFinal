namespace ProyectoFinal
{
    partial class FrmComputer
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
            components = new System.ComponentModel.Container();
            btnExporttxt = new Button();
            btnAdd = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dtpDate = new DateTimePicker();
            label6 = new Label();
            txtName = new TextBox();
            txtLastName = new TextBox();
            txtPrintNumber = new TextBox();
            groupBox1 = new GroupBox();
            lblTotal = new Label();
            cboboxComputernumber = new ComboBox();
            lstvComputerregsiter = new ListView();
            btnBack = new FontAwesome.Sharp.IconButton();
            btnOpentxt = new Button();
            ErrorProvider = new ErrorProvider(components);
            btnWord = new FontAwesome.Sharp.IconButton();
            btnExcel = new FontAwesome.Sharp.IconButton();
            btnDelete = new FontAwesome.Sharp.IconButton();
            btnXml = new FontAwesome.Sharp.IconButton();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // btnExporttxt
            // 
            btnExporttxt.Font = new Font("NSimSun", 11.25F);
            btnExporttxt.Location = new Point(621, 92);
            btnExporttxt.Name = "btnExporttxt";
            btnExporttxt.Size = new Size(114, 23);
            btnExporttxt.TabIndex = 6;
            btnExporttxt.Text = "Export txt";
            btnExporttxt.UseVisualStyleBackColor = true;
            btnExporttxt.Click += btnExporttxt_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("NSimSun", 11.25F);
            btnAdd.Location = new Point(621, 63);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(114, 23);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(290, 37);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 1;
            label2.Text = "Last name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 78);
            label3.Name = "label3";
            label3.Size = new Size(127, 15);
            label3.TabIndex = 2;
            label3.Text = "Computer number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(270, 78);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(290, 74);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 4;
            label5.Text = "Print number";
            // 
            // dtpDate
            // 
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(83, 109);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(110, 25);
            dtpDate.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 117);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 6;
            label6.Text = "Date";
            // 
            // txtName
            // 
            txtName.Location = new Point(98, 34);
            txtName.Name = "txtName";
            txtName.Size = new Size(127, 25);
            txtName.TabIndex = 9;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(399, 27);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(139, 25);
            txtLastName.TabIndex = 11;
            // 
            // txtPrintNumber
            // 
            txtPrintNumber.Location = new Point(399, 70);
            txtPrintNumber.Name = "txtPrintNumber";
            txtPrintNumber.Size = new Size(139, 25);
            txtPrintNumber.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightBlue;
            groupBox1.Controls.Add(lblTotal);
            groupBox1.Controls.Add(cboboxComputernumber);
            groupBox1.Controls.Add(txtPrintNumber);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(dtpDate);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("NSimSun", 11.25F);
            groupBox1.Location = new Point(47, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(559, 203);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Computer Register";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(425, 119);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(31, 15);
            lblTotal.TabIndex = 14;
            lblTotal.Text = "...";
            // 
            // cboboxComputernumber
            // 
            cboboxComputernumber.FormattingEnabled = true;
            cboboxComputernumber.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cboboxComputernumber.Location = new Point(149, 70);
            cboboxComputernumber.Name = "cboboxComputernumber";
            cboboxComputernumber.Size = new Size(121, 23);
            cboboxComputernumber.TabIndex = 13;
            // 
            // lstvComputerregsiter
            // 
            lstvComputerregsiter.Font = new Font("NSimSun", 9.75F);
            lstvComputerregsiter.FullRowSelect = true;
            lstvComputerregsiter.GridLines = true;
            lstvComputerregsiter.Location = new Point(47, 266);
            lstvComputerregsiter.Name = "lstvComputerregsiter";
            lstvComputerregsiter.Size = new Size(668, 184);
            lstvComputerregsiter.TabIndex = 7;
            lstvComputerregsiter.UseCompatibleStateImageBehavior = false;
            // 
            // btnBack
            // 
            btnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            btnBack.IconColor = Color.Black;
            btnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBack.IconSize = 24;
            btnBack.Location = new Point(12, 8);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(34, 23);
            btnBack.TabIndex = 8;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnOpentxt
            // 
            btnOpentxt.Font = new Font("NSimSun", 11.25F);
            btnOpentxt.Location = new Point(621, 121);
            btnOpentxt.Name = "btnOpentxt";
            btnOpentxt.Size = new Size(114, 23);
            btnOpentxt.TabIndex = 9;
            btnOpentxt.Text = "Open txt";
            btnOpentxt.UseVisualStyleBackColor = true;
            btnOpentxt.Click += btnOpentxt_Click;
            // 
            // ErrorProvider
            // 
            ErrorProvider.ContainerControl = this;
            // 
            // btnWord
            // 
            btnWord.Font = new Font("NSimSun", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnWord.IconChar = FontAwesome.Sharp.IconChar.FileWord;
            btnWord.IconColor = Color.Black;
            btnWord.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnWord.IconSize = 30;
            btnWord.ImageAlign = ContentAlignment.MiddleLeft;
            btnWord.Location = new Point(729, 295);
            btnWord.Name = "btnWord";
            btnWord.Size = new Size(95, 47);
            btnWord.TabIndex = 10;
            btnWord.Text = "Word";
            btnWord.UseVisualStyleBackColor = true;
            btnWord.Click += btnWord_Click;
            // 
            // btnExcel
            // 
            btnExcel.Font = new Font("NSimSun", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            btnExcel.IconColor = Color.Black;
            btnExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExcel.IconSize = 30;
            btnExcel.Location = new Point(729, 377);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(95, 23);
            btnExcel.TabIndex = 11;
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
            btnDelete.Location = new Point(729, 266);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(95, 23);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnXml
            // 
            btnXml.Font = new Font("NSimSun", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXml.IconChar = FontAwesome.Sharp.IconChar.None;
            btnXml.IconColor = Color.Black;
            btnXml.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnXml.Location = new Point(729, 406);
            btnXml.Name = "btnXml";
            btnXml.Size = new Size(95, 23);
            btnXml.TabIndex = 13;
            btnXml.Text = "Xml";
            btnXml.UseVisualStyleBackColor = true;
            btnXml.Click += btnXml_Click;
            // 
            // FrmComputer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(836, 521);
            Controls.Add(btnXml);
            Controls.Add(btnDelete);
            Controls.Add(btnExcel);
            Controls.Add(btnWord);
            Controls.Add(btnOpentxt);
            Controls.Add(btnBack);
            Controls.Add(lstvComputerregsiter);
            Controls.Add(btnExporttxt);
            Controls.Add(btnAdd);
            Controls.Add(groupBox1);
            Name = "FrmComputer";
            Text = "FrmComputer";
            Load += FrmComputer_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnExporttxt;
        private Button btnAdd;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dtpDate;
        private Label label6;
        private TextBox txtName;
        private TextBox txtLastName;
        private TextBox txtPrintNumber;
        private GroupBox groupBox1;
        private ComboBox cboboxComputernumber;
        private ListView lstvComputerregsiter;
        private FontAwesome.Sharp.IconButton btnBack;
        private Button btnOpentxt;
        private ErrorProvider ErrorProvider;
        private Label lblTotal;
        private FontAwesome.Sharp.IconButton btnWord;
        private FontAwesome.Sharp.IconButton btnExcel;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnXml;
    }
}
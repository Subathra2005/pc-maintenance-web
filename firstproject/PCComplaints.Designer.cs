namespace firstproject
{
    partial class PCComplaints
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PCComplaints));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            statusComboBox = new ComboBox();
            label2 = new Label();
            updateBtn = new Button();
            PCId = new Label();
            Date = new Label();
            Complaints = new Label();
            complaintscomboBox = new ComboBox();
            queriestextBox = new TextBox();
            Queries = new Label();
            pcidtextBox = new TextBox();
            dateTimePicker = new DateTimePicker();
            panel1 = new Panel();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 147);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.MintCream;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(1054, 313);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.Size = new Size(778, 485);
            dataGridView1.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.Controls.Add(statusComboBox);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(updateBtn);
            panel2.Controls.Add(PCId);
            panel2.Controls.Add(Date);
            panel2.Controls.Add(Complaints);
            panel2.Controls.Add(complaintscomboBox);
            panel2.Controls.Add(queriestextBox);
            panel2.Controls.Add(Queries);
            panel2.Controls.Add(pcidtextBox);
            panel2.Controls.Add(dateTimePicker);
            panel2.Location = new Point(91, 286);
            panel2.Name = "panel2";
            panel2.Size = new Size(891, 512);
            panel2.TabIndex = 17;
            panel2.Paint += panel2_Paint;
            // 
            // statusComboBox
            // 
            statusComboBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusComboBox.FormattingEnabled = true;
            statusComboBox.Items.AddRange(new object[] { "Resolved", "Pending", "Processing" });
            statusComboBox.Location = new Point(265, 372);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(568, 30);
            statusComboBox.TabIndex = 17;
            statusComboBox.Text = "Status of the Complaint";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 377);
            label2.Name = "label2";
            label2.Size = new Size(81, 25);
            label2.TabIndex = 16;
            label2.Text = "Status ";
            label2.Click += label2_Click;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.FromArgb(0, 0, 192);
            updateBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateBtn.ForeColor = Color.White;
            updateBtn.Location = new Point(265, 453);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(228, 41);
            updateBtn.TabIndex = 15;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // PCId
            // 
            PCId.AutoSize = true;
            PCId.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PCId.Location = new Point(34, 32);
            PCId.Name = "PCId";
            PCId.Size = new Size(72, 25);
            PCId.TabIndex = 2;
            PCId.Text = "PC Id";
            // 
            // Date
            // 
            Date.AutoSize = true;
            Date.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Date.Location = new Point(34, 113);
            Date.Name = "Date";
            Date.Size = new Size(60, 25);
            Date.TabIndex = 3;
            Date.Text = "Date";
            // 
            // Complaints
            // 
            Complaints.AutoSize = true;
            Complaints.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Complaints.Location = new Point(34, 199);
            Complaints.Name = "Complaints";
            Complaints.Size = new Size(125, 25);
            Complaints.TabIndex = 4;
            Complaints.Text = "Complaints";
            Complaints.Click += Complaints_Click;
            // 
            // complaintscomboBox
            // 
            complaintscomboBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            complaintscomboBox.FormattingEnabled = true;
            complaintscomboBox.Items.AddRange(new object[] { "Overheating", "Power supply problems", "Hard drive failure", "Operating system crashes", "Slow performance", "Frequent freezing", "Slow internet speed", "Malware and viruses", "Lack of maintenance" });
            complaintscomboBox.Location = new Point(263, 194);
            complaintscomboBox.Name = "complaintscomboBox";
            complaintscomboBox.Size = new Size(568, 30);
            complaintscomboBox.TabIndex = 11;
            complaintscomboBox.Text = "Search for the complaints here";
            // 
            // queriestextBox
            // 
            queriestextBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            queriestextBox.Location = new Point(263, 282);
            queriestextBox.Name = "queriestextBox";
            queriestextBox.Size = new Size(568, 30);
            queriestextBox.TabIndex = 9;
            queriestextBox.Text = "Specify other complaints, if any";
            // 
            // Queries
            // 
            Queries.AutoSize = true;
            Queries.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Queries.Location = new Point(34, 287);
            Queries.Name = "Queries";
            Queries.Size = new Size(89, 25);
            Queries.TabIndex = 5;
            Queries.Text = "Queries";
            // 
            // pcidtextBox
            // 
            pcidtextBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pcidtextBox.Location = new Point(263, 27);
            pcidtextBox.Name = "pcidtextBox";
            pcidtextBox.Size = new Size(566, 30);
            pcidtextBox.TabIndex = 6;
            pcidtextBox.Text = "Enter the PC Id";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker.Location = new Point(265, 108);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(566, 30);
            dateTimePicker.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1902, 147);
            panel1.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(872, 51);
            label1.Name = "label1";
            label1.Size = new Size(280, 45);
            label1.TabIndex = 11;
            label1.Text = "PC Complaints";
            label1.Click += label1_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 192, 255);
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(0, 153);
            button1.Name = "button1";
            button1.Size = new Size(181, 43);
            button1.TabIndex = 19;
            button1.Text = "PC Maintenance";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 192, 255);
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(187, 153);
            button2.Name = "button2";
            button2.Size = new Size(192, 43);
            button2.TabIndex = 20;
            button2.Text = "PC History";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // PCComplaints
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.MintCream;
            ClientSize = new Size(1902, 1033);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "PCComplaints";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PC Complaints";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Label PCId;
        private Label Date;
        private Label Complaints;
        private ComboBox complaintscomboBox;
        private TextBox queriestextBox;
        private Label Queries;
        private TextBox pcidtextBox;
        private DateTimePicker dateTimePicker;
        private Panel panel1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button updateBtn;
        private Label label2;
        private ComboBox statusComboBox;
    }
}

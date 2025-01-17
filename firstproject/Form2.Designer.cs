namespace firstproject
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            IpTextBox = new TextBox();
            RemarksTextBox = new TextBox();
            modelTextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            presentEmpidTextBox = new TextBox();
            PresentUserNameTextBox = new TextBox();
            PCId = new Label();
            Date = new Label();
            updateBtn = new Button();
            Complaints = new Label();
            submit = new Button();
            MacTextBox = new TextBox();
            Queries = new Label();
            pcidTextBox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            deleteBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1902, 171);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(769, 61);
            label1.Name = "label1";
            label1.Size = new Size(409, 45);
            label1.TabIndex = 12;
            label1.Text = "PC Maintenance Form";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 171);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.MintCream;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle7.SelectionForeColor = Color.Black;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(1053, 317);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.Size = new Size(816, 485);
            dataGridView1.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.Controls.Add(deleteBtn);
            panel2.Controls.Add(IpTextBox);
            panel2.Controls.Add(RemarksTextBox);
            panel2.Controls.Add(modelTextBox);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(presentEmpidTextBox);
            panel2.Controls.Add(PresentUserNameTextBox);
            panel2.Controls.Add(PCId);
            panel2.Controls.Add(Date);
            panel2.Controls.Add(updateBtn);
            panel2.Controls.Add(Complaints);
            panel2.Controls.Add(submit);
            panel2.Controls.Add(MacTextBox);
            panel2.Controls.Add(Queries);
            panel2.Controls.Add(pcidTextBox);
            panel2.Location = new Point(27, 290);
            panel2.Name = "panel2";
            panel2.Size = new Size(984, 512);
            panel2.TabIndex = 18;
            // 
            // IpTextBox
            // 
            IpTextBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IpTextBox.Location = new Point(779, 241);
            IpTextBox.Name = "IpTextBox";
            IpTextBox.Size = new Size(165, 30);
            IpTextBox.TabIndex = 22;
            // 
            // RemarksTextBox
            // 
            RemarksTextBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RemarksTextBox.Location = new Point(779, 351);
            RemarksTextBox.Name = "RemarksTextBox";
            RemarksTextBox.Size = new Size(165, 30);
            RemarksTextBox.TabIndex = 21;
            // 
            // modelTextBox
            // 
            modelTextBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            modelTextBox.Location = new Point(222, 351);
            modelTextBox.Name = "modelTextBox";
            modelTextBox.Size = new Size(165, 30);
            modelTextBox.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(537, 236);
            label4.Name = "label4";
            label4.Size = new Size(36, 25);
            label4.TabIndex = 19;
            label4.Text = "IP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(34, 356);
            label3.Name = "label3";
            label3.Size = new Size(76, 25);
            label3.TabIndex = 18;
            label3.Text = "Model";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(537, 356);
            label2.Name = "label2";
            label2.Size = new Size(102, 25);
            label2.TabIndex = 17;
            label2.Text = "Remarks";
            // 
            // presentEmpidTextBox
            // 
            presentEmpidTextBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            presentEmpidTextBox.Location = new Point(222, 126);
            presentEmpidTextBox.Name = "presentEmpidTextBox";
            presentEmpidTextBox.Size = new Size(165, 30);
            presentEmpidTextBox.TabIndex = 16;
            // 
            // PresentUserNameTextBox
            // 
            PresentUserNameTextBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PresentUserNameTextBox.Location = new Point(779, 126);
            PresentUserNameTextBox.Name = "PresentUserNameTextBox";
            PresentUserNameTextBox.Size = new Size(163, 30);
            PresentUserNameTextBox.TabIndex = 15;
            // 
            // PCId
            // 
            PCId.AutoSize = true;
            PCId.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PCId.Location = new Point(281, 32);
            PCId.Name = "PCId";
            PCId.Size = new Size(76, 25);
            PCId.TabIndex = 2;
            PCId.Text = "PC ID";
            // 
            // Date
            // 
            Date.AutoSize = true;
            Date.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Date.Location = new Point(34, 131);
            Date.Name = "Date";
            Date.Size = new Size(168, 25);
            Date.TabIndex = 3;
            Date.Text = "Present EmpID";
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.FromArgb(0, 0, 192);
            updateBtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateBtn.ForeColor = Color.White;
            updateBtn.Location = new Point(359, 441);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(228, 41);
            updateBtn.TabIndex = 14;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // Complaints
            // 
            Complaints.AutoSize = true;
            Complaints.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Complaints.Location = new Point(537, 131);
            Complaints.Name = "Complaints";
            Complaints.Size = new Size(207, 25);
            Complaints.TabIndex = 4;
            Complaints.Text = "Present User Name";
            // 
            // submit
            // 
            submit.BackColor = Color.FromArgb(0, 192, 0);
            submit.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            submit.ForeColor = Color.AliceBlue;
            submit.Location = new Point(19, 441);
            submit.Name = "submit";
            submit.Size = new Size(245, 41);
            submit.TabIndex = 0;
            submit.Text = "Submit";
            submit.UseVisualStyleBackColor = false;
            submit.Click += submit_Click;
            // 
            // MacTextBox
            // 
            MacTextBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MacTextBox.Location = new Point(222, 236);
            MacTextBox.Name = "MacTextBox";
            MacTextBox.Size = new Size(165, 30);
            MacTextBox.TabIndex = 9;
            // 
            // Queries
            // 
            Queries.AutoSize = true;
            Queries.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Queries.Location = new Point(34, 241);
            Queries.Name = "Queries";
            Queries.Size = new Size(68, 25);
            Queries.TabIndex = 5;
            Queries.Text = "MAC";
            // 
            // pcidTextBox
            // 
            pcidTextBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pcidTextBox.Location = new Point(507, 27);
            pcidTextBox.Name = "pcidTextBox";
            pcidTextBox.Size = new Size(163, 30);
            pcidTextBox.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 192, 255);
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(0, 168);
            button1.Name = "button1";
            button1.Size = new Size(176, 42);
            button1.TabIndex = 19;
            button1.Text = "PC History";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 192, 255);
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(182, 168);
            button2.Name = "button2";
            button2.Size = new Size(176, 42);
            button2.TabIndex = 20;
            button2.Text = "PC Complaints";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.Red;
            deleteBtn.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            deleteBtn.ForeColor = Color.AliceBlue;
            deleteBtn.Location = new Point(678, 441);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(245, 41);
            deleteBtn.TabIndex = 23;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.MintCream;
            ClientSize = new Size(1902, 1033);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PC Maintenance Form";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Label PCId;
        private Label Date;
        private Button updateBtn;
        private Label Complaints;
        private Button submit;
        private TextBox MacTextBox;
        private Label Queries;
        private TextBox pcidTextBox;
        private TextBox presentEmpidTextBox;
        private TextBox PresentUserNameTextBox;
        private TextBox IpTextBox;
        private TextBox RemarksTextBox;
        private TextBox modelTextBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button deleteBtn;
    }
}
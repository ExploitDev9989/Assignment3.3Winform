namespace Assignment3._4
{
    partial class AddForm
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
            groupBox1 = new GroupBox();
            label5 = new Label();
            btnAdd = new Button();
            txtSid = new TextBox();
            txtName = new TextBox();
            comboClass = new ComboBox();
            txtTuition = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboClass1 = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboClass1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(txtSid);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(comboClass);
            groupBox1.Controls.Add(txtTuition);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(152, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(395, 336);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student Record";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 168);
            label5.Name = "label5";
            label5.Size = new Size(116, 15);
            label5.TabIndex = 10;
            label5.Text = "Month of Admission";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(112, 285);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(121, 23);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add Student";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // txtSid
            // 
            txtSid.Location = new Point(125, 58);
            txtSid.Name = "txtSid";
            txtSid.Size = new Size(213, 23);
            txtSid.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Location = new Point(125, 90);
            txtName.Name = "txtName";
            txtName.Size = new Size(213, 23);
            txtName.TabIndex = 6;
            // 
            // comboClass
            // 
            comboClass.FormattingEnabled = true;
            comboClass.Location = new Point(125, 206);
            comboClass.Name = "comboClass";
            comboClass.Size = new Size(213, 23);
            comboClass.TabIndex = 5;
            comboClass.SelectedIndexChanged += comboClass_SelectedIndexChanged;
            // 
            // txtTuition
            // 
            txtTuition.Location = new Point(125, 126);
            txtTuition.Name = "txtTuition";
            txtTuition.Size = new Size(213, 23);
            txtTuition.TabIndex = 4;
            txtTuition.TextChanged += txtTuition_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 129);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 3;
            label4.Text = "Student Tuition";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 209);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 2;
            label3.Text = "Class Enrollment";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 93);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 1;
            label2.Text = "Student Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 61);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Student ID";
            // 
            // comboClass1
            // 
            comboClass1.FormattingEnabled = true;
            comboClass1.Location = new Point(125, 165);
            comboClass1.Name = "comboClass1";
            comboClass1.Size = new Size(213, 23);
            comboClass1.TabIndex = 11;
            comboClass1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Coral;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "AddForm";
            Text = "AddForm";
            Load += AddForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnAdd;
        private TextBox txtSid;
        private TextBox txtName;
        private ComboBox comboClass;
        private TextBox txtTuition;
        private Label label5;
        private ComboBox comboClass1;
    }
}
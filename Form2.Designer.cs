namespace WinFormsApp2
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
            txtCompanyName = new TextBox();
            txtID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            txtMessageText = new RichTextBox();
            radOrders = new RadioButton();
            radEmployee = new RadioButton();
            radCustomers = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(120, 91);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(125, 27);
            txtCompanyName.TabIndex = 0;
            // 
            // txtID
            // 
            txtID.Location = new Point(120, 35);
            txtID.Name = "txtID";
            txtID.Size = new Size(125, 27);
            txtID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 42);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 2;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-5, 98);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 3;
            label2.Text = "Company Name:";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.AppWorkspace;
            button1.Location = new Point(68, 159);
            button1.Name = "button1";
            button1.Size = new Size(144, 29);
            button1.TabIndex = 4;
            button1.Text = "Update Database";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnUpdate_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.AppWorkspace;
            button2.Location = new Point(542, 159);
            button2.Name = "button2";
            button2.Size = new Size(140, 29);
            button2.TabIndex = 5;
            button2.Text = "Count Records";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnCount_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.AppWorkspace;
            button3.Location = new Point(283, 399);
            button3.Name = "button3";
            button3.Size = new Size(195, 29);
            button3.TabIndex = 6;
            button3.Text = "View Database";
            button3.UseVisualStyleBackColor = false;
            button3.Click += btnView_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 207);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(761, 167);
            dataGridView1.TabIndex = 7;
            // 
            // txtMessageText
            // 
            txtMessageText.Enabled = false;
            txtMessageText.Location = new Point(460, 2);
            txtMessageText.Name = "txtMessageText";
            txtMessageText.Size = new Size(328, 139);
            txtMessageText.TabIndex = 8;
            txtMessageText.Text = "";
            // 
            // radOrders
            // 
            radOrders.AutoSize = true;
            radOrders.Location = new Point(307, 147);
            radOrders.Name = "radOrders";
            radOrders.Size = new Size(113, 24);
            radOrders.TabIndex = 9;
            radOrders.TabStop = true;
            radOrders.Text = "Orders Table";
            radOrders.UseVisualStyleBackColor = true;
            // 
            // radEmployee
            // 
            radEmployee.AutoSize = true;
            radEmployee.Location = new Point(307, 177);
            radEmployee.Name = "radEmployee";
            radEmployee.Size = new Size(141, 24);
            radEmployee.TabIndex = 10;
            radEmployee.TabStop = true;
            radEmployee.Text = "Employees Table";
            radEmployee.UseVisualStyleBackColor = true;
            // 
            // radCustomers
            // 
            radCustomers.AutoSize = true;
            radCustomers.Location = new Point(307, 117);
            radCustomers.Name = "radCustomers";
            radCustomers.Size = new Size(132, 24);
            radCustomers.TabIndex = 11;
            radCustomers.TabStop = true;
            radCustomers.Text = "Customer Table";
            radCustomers.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(radCustomers);
            Controls.Add(radEmployee);
            Controls.Add(radOrders);
            Controls.Add(txtMessageText);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtID);
            Controls.Add(txtCompanyName);
            Name = "Form2";
            Text = "554";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCompanyName;
        private TextBox txtID;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private RichTextBox txtMessageText;
        private RadioButton radOrders;
        private RadioButton radEmployee;
        private RadioButton radCustomers;
    }
}
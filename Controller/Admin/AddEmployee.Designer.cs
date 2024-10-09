namespace Leave_Management_System.Admin
{
    partial class AddEmployee
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
            txtName = new TextBox();
            txtAnnualLeaves = new TextBox();
            txtCasualLeaves = new TextBox();
            txtShortLeaves = new TextBox();
            txtConformPassword = new TextBox();
            dateRoasterStartTime = new DateTimePicker();
            txtPassword = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            panel1 = new Panel();
            txtSearchValue = new TextBox();
            btnSearchOnAction = new Button();
            btnAddEmployeeOnAction = new Button();
            dateRoasterEndTime = new DateTimePicker();
            tableEmployee = new TableLayoutPanel();
            btnReloadOnAction = new Button();
            btnUpdateOnAction = new Button();
            btnDeleteOnAction = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F);
            txtName.Location = new Point(247, 100);
            txtName.Name = "txtName";
            txtName.Size = new Size(221, 34);
            txtName.TabIndex = 1;
            // 
            // txtAnnualLeaves
            // 
            txtAnnualLeaves.Font = new Font("Segoe UI", 12F);
            txtAnnualLeaves.Location = new Point(247, 159);
            txtAnnualLeaves.Name = "txtAnnualLeaves";
            txtAnnualLeaves.Size = new Size(221, 34);
            txtAnnualLeaves.TabIndex = 2;
            // 
            // txtCasualLeaves
            // 
            txtCasualLeaves.Font = new Font("Segoe UI", 12F);
            txtCasualLeaves.Location = new Point(247, 217);
            txtCasualLeaves.Name = "txtCasualLeaves";
            txtCasualLeaves.Size = new Size(221, 34);
            txtCasualLeaves.TabIndex = 3;
            // 
            // txtShortLeaves
            // 
            txtShortLeaves.Font = new Font("Segoe UI", 12F);
            txtShortLeaves.Location = new Point(247, 278);
            txtShortLeaves.Name = "txtShortLeaves";
            txtShortLeaves.Size = new Size(221, 34);
            txtShortLeaves.TabIndex = 4;
            // 
            // txtConformPassword
            // 
            txtConformPassword.Font = new Font("Segoe UI", 12F);
            txtConformPassword.Location = new Point(690, 276);
            txtConformPassword.Name = "txtConformPassword";
            txtConformPassword.Size = new Size(221, 34);
            txtConformPassword.TabIndex = 5;
            // 
            // dateRoasterStartTime
            // 
            dateRoasterStartTime.Font = new Font("Segoe UI", 10.8F);
            dateRoasterStartTime.Location = new Point(655, 101);
            dateRoasterStartTime.Name = "dateRoasterStartTime";
            dateRoasterStartTime.Size = new Size(316, 31);
            dateRoasterStartTime.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(690, 217);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(221, 34);
            txtPassword.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(181, 103);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 9;
            label2.Text = "Name : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(130, 162);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 10;
            label3.Text = "AnnualLeaves : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(133, 220);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 11;
            label4.Text = "CasualLeaves : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(141, 281);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 12;
            label5.Text = "ShortLeaves : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(515, 106);
            label6.Name = "label6";
            label6.Size = new Size(134, 20);
            label6.TabIndex = 13;
            label6.Text = "RoasterStartTime : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(521, 161);
            label7.Name = "label7";
            label7.Size = new Size(128, 20);
            label7.TabIndex = 14;
            label7.Text = "RoasterEndTime : ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(602, 221);
            label8.Name = "label8";
            label8.Size = new Size(81, 20);
            label8.TabIndex = 16;
            label8.Text = "Password : ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(540, 279);
            label9.Name = "label9";
            label9.Size = new Size(143, 20);
            label9.TabIndex = 17;
            label9.Text = "Conform Password : ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(24, 17);
            label10.Name = "label10";
            label10.Size = new Size(336, 38);
            label10.TabIndex = 18;
            label10.Text = "Manage Employee Form";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(txtSearchValue);
            panel1.Controls.Add(btnSearchOnAction);
            panel1.Controls.Add(label10);
            panel1.Location = new Point(-1, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1119, 72);
            panel1.TabIndex = 19;
            // 
            // txtSearchValue
            // 
            txtSearchValue.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtSearchValue.Location = new Point(727, 22);
            txtSearchValue.Name = "txtSearchValue";
            txtSearchValue.Size = new Size(264, 34);
            txtSearchValue.TabIndex = 23;
            txtSearchValue.Text = "SEARCH BY ID";
            // 
            // btnSearchOnAction
            // 
            btnSearchOnAction.BackColor = Color.DarkViolet;
            btnSearchOnAction.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSearchOnAction.ForeColor = Color.White;
            btnSearchOnAction.Location = new Point(997, 22);
            btnSearchOnAction.Name = "btnSearchOnAction";
            btnSearchOnAction.Size = new Size(94, 33);
            btnSearchOnAction.TabIndex = 23;
            btnSearchOnAction.Text = "Search";
            btnSearchOnAction.UseVisualStyleBackColor = false;
            btnSearchOnAction.Click += btnSearchOnAction_Click;
            // 
            // btnAddEmployeeOnAction
            // 
            btnAddEmployeeOnAction.BackColor = Color.Green;
            btnAddEmployeeOnAction.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddEmployeeOnAction.ForeColor = Color.White;
            btnAddEmployeeOnAction.Location = new Point(914, 331);
            btnAddEmployeeOnAction.Name = "btnAddEmployeeOnAction";
            btnAddEmployeeOnAction.Size = new Size(137, 40);
            btnAddEmployeeOnAction.TabIndex = 20;
            btnAddEmployeeOnAction.Text = "Add";
            btnAddEmployeeOnAction.UseVisualStyleBackColor = false;
            btnAddEmployeeOnAction.Click += btnAddEmployeeOnAction_Click_1;
            // 
            // dateRoasterEndTime
            // 
            dateRoasterEndTime.Font = new Font("Segoe UI", 10.8F);
            dateRoasterEndTime.Location = new Point(655, 156);
            dateRoasterEndTime.Name = "dateRoasterEndTime";
            dateRoasterEndTime.Size = new Size(316, 31);
            dateRoasterEndTime.TabIndex = 15;
            // 
            // tableEmployee
            // 
            tableEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableEmployee.AutoScroll = true;
            tableEmployee.BackColor = SystemColors.ControlLight;
            tableEmployee.ColumnCount = 7;
            tableEmployee.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.46154F));
            tableEmployee.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 134F));
            tableEmployee.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 114F));
            tableEmployee.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            tableEmployee.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 134F));
            tableEmployee.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 228F));
            tableEmployee.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 223F));
            tableEmployee.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableEmployee.Location = new Point(49, 385);
            tableEmployee.Name = "tableEmployee";
            tableEmployee.RowCount = 1;
            tableEmployee.RowStyles.Add(new RowStyle(SizeType.Percent, 14.23221F));
            tableEmployee.Size = new Size(1032, 228);
            tableEmployee.TabIndex = 21;
            // 
            // btnReloadOnAction
            // 
            btnReloadOnAction.BackColor = Color.Yellow;
            btnReloadOnAction.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReloadOnAction.Location = new Point(953, 630);
            btnReloadOnAction.Name = "btnReloadOnAction";
            btnReloadOnAction.Size = new Size(128, 39);
            btnReloadOnAction.TabIndex = 22;
            btnReloadOnAction.Text = "Reload";
            btnReloadOnAction.UseVisualStyleBackColor = false;
            btnReloadOnAction.Click += btnReloadOnAction_Click;
            // 
            // btnUpdateOnAction
            // 
            btnUpdateOnAction.BackColor = Color.MidnightBlue;
            btnUpdateOnAction.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateOnAction.ForeColor = Color.White;
            btnUpdateOnAction.Location = new Point(771, 331);
            btnUpdateOnAction.Name = "btnUpdateOnAction";
            btnUpdateOnAction.Size = new Size(137, 40);
            btnUpdateOnAction.TabIndex = 23;
            btnUpdateOnAction.Text = "Update";
            btnUpdateOnAction.UseVisualStyleBackColor = false;
            btnUpdateOnAction.Click += btnUpdateOnAction_Click;
            // 
            // btnDeleteOnAction
            // 
            btnDeleteOnAction.BackColor = Color.Crimson;
            btnDeleteOnAction.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteOnAction.ForeColor = Color.White;
            btnDeleteOnAction.Location = new Point(628, 331);
            btnDeleteOnAction.Name = "btnDeleteOnAction";
            btnDeleteOnAction.Size = new Size(137, 40);
            btnDeleteOnAction.TabIndex = 24;
            btnDeleteOnAction.Text = "Delete";
            btnDeleteOnAction.UseVisualStyleBackColor = false;
            btnDeleteOnAction.Click += btnDeleteOnAction_Click;
            // 
            // AddEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 686);
            Controls.Add(btnDeleteOnAction);
            Controls.Add(btnUpdateOnAction);
            Controls.Add(btnReloadOnAction);
            Controls.Add(tableEmployee);
            Controls.Add(btnAddEmployeeOnAction);
            Controls.Add(panel1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(dateRoasterEndTime);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(dateRoasterStartTime);
            Controls.Add(txtConformPassword);
            Controls.Add(txtShortLeaves);
            Controls.Add(txtCasualLeaves);
            Controls.Add(txtAnnualLeaves);
            Controls.Add(txtName);
            Name = "AddEmployee";
            Text = "AddEmployee";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtName;
        private TextBox txtAnnualLeaves;
        private TextBox txtCasualLeaves;
        private TextBox txtShortLeaves;
        private TextBox txtConformPassword;
        private DateTimePicker dateRoasterStartTime;
        private TextBox txtPassword;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Panel panel1;
        private Button btnAddEmployeeOnAction;
        private DateTimePicker dateRoasterEndTime;
        private TableLayoutPanel tableEmployee;
        private Button btnReloadOnAction;
        private TextBox txtSearchValue;
        private Button btnSearchOnAction;
        private Button btnUpdateOnAction;
        private Button btnDeleteOnAction;
    }
}
namespace Leave_Management_System.Controller.Admin
{
    partial class AdminDash
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
            btnReloadOnAction = new Button();
            btnAddEmployeeOnAction = new Button();
            panel6 = new Panel();
            lblRejectLeaveCount = new Label();
            label18 = new Label();
            panel5 = new Panel();
            lblPendingLeaveCount = new Label();
            label16 = new Label();
            panel4 = new Panel();
            lblApprovedLeaveCount = new Label();
            label13 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            listViewLeaves = new ListView();
            txtLeaveType = new TextBox();
            txtLeaveStatus = new TextBox();
            txtEmployeeID = new TextBox();
            txtLeaveID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            richTextNote = new RichTextBox();
            label7 = new Label();
            txtEmployeName = new TextBox();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btnReloadOnAction
            // 
            btnReloadOnAction.Location = new Point(888, 550);
            btnReloadOnAction.Name = "btnReloadOnAction";
            btnReloadOnAction.Size = new Size(94, 29);
            btnReloadOnAction.TabIndex = 1;
            btnReloadOnAction.Text = "Reload";
            btnReloadOnAction.UseVisualStyleBackColor = true;
            btnReloadOnAction.Click += btnReloadOnAction_Click;
            // 
            // btnAddEmployeeOnAction
            // 
            btnAddEmployeeOnAction.Location = new Point(997, 550);
            btnAddEmployeeOnAction.Name = "btnAddEmployeeOnAction";
            btnAddEmployeeOnAction.Size = new Size(144, 29);
            btnAddEmployeeOnAction.TabIndex = 2;
            btnAddEmployeeOnAction.Text = "Add Employee";
            btnAddEmployeeOnAction.UseVisualStyleBackColor = true;
            btnAddEmployeeOnAction.Click += btnAddEmployeeOnAction_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.DarkRed;
            panel6.Controls.Add(lblRejectLeaveCount);
            panel6.Controls.Add(label18);
            panel6.Location = new Point(503, 100);
            panel6.Name = "panel6";
            panel6.Size = new Size(168, 80);
            panel6.TabIndex = 33;
            // 
            // lblRejectLeaveCount
            // 
            lblRejectLeaveCount.AutoSize = true;
            lblRejectLeaveCount.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRejectLeaveCount.ForeColor = Color.White;
            lblRejectLeaveCount.Location = new Point(71, 15);
            lblRejectLeaveCount.Name = "lblRejectLeaveCount";
            lblRejectLeaveCount.Size = new Size(27, 31);
            lblRejectLeaveCount.TabIndex = 5;
            lblRejectLeaveCount.Text = "2";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label18.ForeColor = Color.White;
            label18.Location = new Point(15, 55);
            label18.Name = "label18";
            label18.Size = new Size(138, 20);
            label18.TabIndex = 4;
            label18.Text = "Reject Leave Count";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Goldenrod;
            panel5.Controls.Add(lblPendingLeaveCount);
            panel5.Controls.Add(label16);
            panel5.Location = new Point(299, 100);
            panel5.Name = "panel5";
            panel5.Size = new Size(168, 80);
            panel5.TabIndex = 32;
            // 
            // lblPendingLeaveCount
            // 
            lblPendingLeaveCount.AutoSize = true;
            lblPendingLeaveCount.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPendingLeaveCount.ForeColor = Color.White;
            lblPendingLeaveCount.Location = new Point(71, 15);
            lblPendingLeaveCount.Name = "lblPendingLeaveCount";
            lblPendingLeaveCount.Size = new Size(27, 31);
            lblPendingLeaveCount.TabIndex = 5;
            lblPendingLeaveCount.Text = "2";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label16.ForeColor = Color.White;
            label16.Location = new Point(8, 55);
            label16.Name = "label16";
            label16.Size = new Size(153, 20);
            label16.TabIndex = 4;
            label16.Text = "Pending Leave Count";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Green;
            panel4.Controls.Add(lblApprovedLeaveCount);
            panel4.Controls.Add(label13);
            panel4.Location = new Point(92, 100);
            panel4.Name = "panel4";
            panel4.Size = new Size(168, 80);
            panel4.TabIndex = 31;
            // 
            // lblApprovedLeaveCount
            // 
            lblApprovedLeaveCount.AutoSize = true;
            lblApprovedLeaveCount.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApprovedLeaveCount.ForeColor = Color.White;
            lblApprovedLeaveCount.Location = new Point(71, 15);
            lblApprovedLeaveCount.Name = "lblApprovedLeaveCount";
            lblApprovedLeaveCount.Size = new Size(27, 31);
            lblApprovedLeaveCount.TabIndex = 5;
            lblApprovedLeaveCount.Text = "2";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label13.ForeColor = Color.White;
            label13.Location = new Point(8, 55);
            label13.Name = "label13";
            label13.Size = new Size(157, 20);
            label13.TabIndex = 4;
            label13.Text = "Approved Leve Count";
            // 
            // panel3
            // 
            panel3.BackColor = Color.MidnightBlue;
            panel3.Controls.Add(label3);
            panel3.Location = new Point(1, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(1159, 63);
            panel3.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(19, 8);
            label3.Name = "label3";
            label3.Size = new Size(240, 38);
            label3.TabIndex = 1;
            label3.Text = "Admin Dashbord";
            // 
            // listViewLeaves
            // 
            listViewLeaves.BackgroundImageTiled = true;
            listViewLeaves.FullRowSelect = true;
            listViewLeaves.Location = new Point(50, 231);
            listViewLeaves.Name = "listViewLeaves";
            listViewLeaves.Size = new Size(723, 292);
            listViewLeaves.TabIndex = 34;
            listViewLeaves.UseCompatibleStateImageBehavior = false;
            // 
            // txtLeaveType
            // 
            txtLeaveType.Location = new Point(908, 277);
            txtLeaveType.Name = "txtLeaveType";
            txtLeaveType.Size = new Size(189, 27);
            txtLeaveType.TabIndex = 35;
            // 
            // txtLeaveStatus
            // 
            txtLeaveStatus.Location = new Point(908, 343);
            txtLeaveStatus.Name = "txtLeaveStatus";
            txtLeaveStatus.Size = new Size(189, 27);
            txtLeaveStatus.TabIndex = 36;
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.Location = new Point(908, 156);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.Size = new Size(189, 27);
            txtEmployeeID.TabIndex = 37;
            // 
            // txtLeaveID
            // 
            txtLeaveID.Location = new Point(908, 100);
            txtLeaveID.Name = "txtLeaveID";
            txtLeaveID.Size = new Size(189, 27);
            txtLeaveID.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(836, 103);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 39;
            label1.Text = "Leave ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(810, 160);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 40;
            label2.Text = "Employee ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(821, 282);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 41;
            label4.Text = "Leave Type:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(812, 348);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.TabIndex = 42;
            label5.Text = "Leave Status:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(818, 403);
            label6.Name = "label6";
            label6.Size = new Size(87, 20);
            label6.TabIndex = 43;
            label6.Text = "Leave Note:";
            // 
            // richTextNote
            // 
            richTextNote.Location = new Point(908, 403);
            richTextNote.Name = "richTextNote";
            richTextNote.Size = new Size(189, 120);
            richTextNote.TabIndex = 44;
            richTextNote.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(785, 222);
            label7.Name = "label7";
            label7.Size = new Size(122, 20);
            label7.TabIndex = 46;
            label7.Text = "Employee Name:";
            // 
            // txtEmployeName
            // 
            txtEmployeName.Location = new Point(908, 219);
            txtEmployeName.Name = "txtEmployeName";
            txtEmployeName.Size = new Size(189, 27);
            txtEmployeName.TabIndex = 45;
            // 
            // AdminDash
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1161, 600);
            Controls.Add(label7);
            Controls.Add(txtEmployeName);
            Controls.Add(richTextNote);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtLeaveID);
            Controls.Add(txtEmployeeID);
            Controls.Add(txtLeaveStatus);
            Controls.Add(txtLeaveType);
            Controls.Add(listViewLeaves);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(btnAddEmployeeOnAction);
            Controls.Add(btnReloadOnAction);
            Name = "AdminDash";
            Text = "AdminDash";
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnReloadOnAction;
        private Button btnAddEmployeeOnAction;
        private Panel panel6;
        private Label lblRejectLeaveCount;
        private Label label18;
        private Panel panel5;
        private Label lblPendingLeaveCount;
        private Label label16;
        private Panel panel4;
        private Label lblApprovedLeaveCount;
        private Label label13;
        private Panel panel3;
        private Label label3;
        private ListView listViewLeaves;
        private TextBox txtLeaveType;
        private TextBox txtLeaveStatus;
        private TextBox txtEmployeeID;
        private TextBox txtLeaveID;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private RichTextBox richTextNote;
        private Label label7;
        private TextBox txtEmployeName;
    }
}
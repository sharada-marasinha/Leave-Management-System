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
            tableEmployee = new TableLayoutPanel();
            btnReloadOnAction = new Button();
            btnAddEmployeeOnAction = new Button();
            SuspendLayout();
            // 
            // tableEmployee
            // 
            tableEmployee.BackColor = SystemColors.ControlLight;
            tableEmployee.ColumnCount = 7;
            tableEmployee.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.46154F));
            tableEmployee.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 188F));
            tableEmployee.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 138F));
            tableEmployee.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 146F));
            tableEmployee.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 152F));
            tableEmployee.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 194F));
            tableEmployee.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 181F));
            tableEmployee.Location = new Point(12, 158);
            tableEmployee.Name = "tableEmployee";
            tableEmployee.RowCount = 1;
            tableEmployee.RowStyles.Add(new RowStyle(SizeType.Percent, 14.23221F));
            tableEmployee.Size = new Size(1095, 286);
            tableEmployee.TabIndex = 0;
            // 
            // btnReloadOnAction
            // 
            btnReloadOnAction.Location = new Point(854, 483);
            btnReloadOnAction.Name = "btnReloadOnAction";
            btnReloadOnAction.Size = new Size(94, 29);
            btnReloadOnAction.TabIndex = 1;
            btnReloadOnAction.Text = "Reload";
            btnReloadOnAction.UseVisualStyleBackColor = true;
            btnReloadOnAction.Click += btnReloadOnAction_Click;
            // 
            // btnAddEmployeeOnAction
            // 
            btnAddEmployeeOnAction.Location = new Point(963, 483);
            btnAddEmployeeOnAction.Name = "btnAddEmployeeOnAction";
            btnAddEmployeeOnAction.Size = new Size(144, 29);
            btnAddEmployeeOnAction.TabIndex = 2;
            btnAddEmployeeOnAction.Text = "Add Employee";
            btnAddEmployeeOnAction.UseVisualStyleBackColor = true;
            btnAddEmployeeOnAction.Click += btnAddEmployeeOnAction_Click;
            // 
            // AdminDash
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 537);
            Controls.Add(btnAddEmployeeOnAction);
            Controls.Add(btnReloadOnAction);
            Controls.Add(tableEmployee);
            Name = "AdminDash";
            Text = "AdminDash";
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableEmployee;
        private Button btnReloadOnAction;
        private Button btnAddEmployeeOnAction;
    }
}
namespace Teknoroma.WinFormUI
{
    partial class UserCreateForm
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
            cmbEmployees = new ComboBox();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDeactivate = new Button();
            button1 = new Button();
            lstUsers = new ListBox();
            SuspendLayout();
            // 
            // cmbEmployees
            // 
            cmbEmployees.FormattingEnabled = true;
            cmbEmployees.Location = new Point(39, 60);
            cmbEmployees.Name = "cmbEmployees";
            cmbEmployees.Size = new Size(121, 23);
            cmbEmployees.TabIndex = 0;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(39, 98);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(100, 23);
            txtUserName.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(39, 127);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 2;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(39, 230);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(146, 22);
            btnCreate.TabIndex = 3;
            btnCreate.Text = "Kullanıcı Oluştur";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(39, 270);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(146, 22);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Kullanıcı Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDeactivate
            // 
            btnDeactivate.Location = new Point(39, 312);
            btnDeactivate.Name = "btnDeactivate";
            btnDeactivate.Size = new Size(146, 22);
            btnDeactivate.TabIndex = 5;
            btnDeactivate.Text = "Kullanıcıyı Pasife Çek";
            btnDeactivate.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(39, 356);
            button1.Name = "button1";
            button1.Size = new Size(146, 22);
            button1.TabIndex = 6;
            button1.Text = "Kullanıcıyı Aktif Et";
            button1.UseVisualStyleBackColor = true;
            // 
            // lstUsers
            // 
            lstUsers.FormattingEnabled = true;
            lstUsers.ItemHeight = 15;
            lstUsers.Location = new Point(283, 12);
            lstUsers.Name = "lstUsers";
            lstUsers.Size = new Size(505, 409);
            lstUsers.TabIndex = 7;
            // 
            // UserCreateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstUsers);
            Controls.Add(button1);
            Controls.Add(btnDeactivate);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(cmbEmployees);
            Name = "UserCreateForm";
            Text = "UserCreateForm";
            Load += UserCreateForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbEmployees;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnDeactivate;
        private Button button1;
        private ListBox lstUsers;
    }
}
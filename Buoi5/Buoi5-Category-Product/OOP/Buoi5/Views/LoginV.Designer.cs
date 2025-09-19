namespace Buoi51.Views
{
    partial class LoginV
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
            panel2 = new Panel();
            txtPass = new TextBox();
            txtUser = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            btnLogin = new Button();
            btnReset = new Button();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(192, 255, 255);
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(panel1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(351, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Đăng nhập";
            // 
            // panel2
            // 
            panel2.Controls.Add(txtPass);
            panel2.Controls.Add(txtUser);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 19);
            panel2.Name = "panel2";
            panel2.Size = new Size(345, 73);
            panel2.TabIndex = 6;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(144, 42);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(190, 23);
            txtPass.TabIndex = 2;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(144, 11);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(190, 23);
            txtUser.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(9, 40);
            label2.Name = "label2";
            label2.Size = new Size(72, 21);
            label2.TabIndex = 0;
            label2.Text = "Mật mã:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(9, 9);
            label1.Name = "label1";
            label1.Size = new Size(129, 21);
            label1.TabIndex = 0;
            label1.Text = "Tên Đăng nhập:";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(btnReset);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 92);
            panel1.Name = "panel1";
            panel1.Size = new Size(345, 30);
            panel1.TabIndex = 5;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ActiveCaption;
            btnLogin.Dock = DockStyle.Right;
            btnLogin.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnLogin.Location = new Point(144, 0);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(101, 30);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "&Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnlogin_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = SystemColors.ActiveCaption;
            btnReset.Dock = DockStyle.Right;
            btnReset.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnReset.Location = new Point(245, 0);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(100, 30);
            btnReset.TabIndex = 4;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // LoginV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 125);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "LoginV";
            Text = "LoginV";
            Load += LoginV_Load;
            Shown += LoginV_Shown;
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtPass;
        private TextBox txtUser;
        private Button btnReset;
        private Button btnLogin;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Panel panel1;
    }
}
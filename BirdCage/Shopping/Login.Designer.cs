namespace Shopping
{
    partial class Login
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
            txtName = new System.Windows.Forms.TextBox();
            txtPass = new System.Windows.Forms.TextBox();
            UserName = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            btnLogin = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(221, 102);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(152, 23);
            txtName.TabIndex = 0;
            // 
            // txtPass
            // 
            txtPass.Location = new System.Drawing.Point(221, 149);
            txtPass.Name = "txtPass";
            txtPass.Size = new System.Drawing.Size(152, 23);
            txtPass.TabIndex = 1;
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.Location = new System.Drawing.Point(132, 110);
            UserName.Name = "UserName";
            UserName.Size = new System.Drawing.Size(62, 15);
            UserName.TabIndex = 2;
            UserName.Text = "UserName";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(137, 152);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(57, 15);
            label1.TabIndex = 3;
            label1.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.Location = new System.Drawing.Point(233, 201);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(102, 28);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += BtnLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(547, 318);
            Controls.Add(btnLogin);
            Controls.Add(label1);
            Controls.Add(UserName);
            Controls.Add(txtPass);
            Controls.Add(txtName);
            Name = "Login";
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
    }
}

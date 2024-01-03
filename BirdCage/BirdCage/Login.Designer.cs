namespace BirdCage
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            txtName = new System.Windows.Forms.TextBox();
            txtPass = new System.Windows.Forms.TextBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(33, 17);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "UserName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(33, 60);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "PassWord";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(116, 107);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnLogin;
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(116, 17);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(143, 23);
            txtName.TabIndex = 3;
            // 
            // txtPass
            // 
            txtPass.Location = new System.Drawing.Point(116, 68);
            txtPass.Name = "txtPass";
            txtPass.Size = new System.Drawing.Size(143, 23);
            txtPass.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            groupBox1.Controls.Add(txtPass);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            groupBox1.Location = new System.Drawing.Point(147, 73);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(339, 163);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(634, 296);
            Controls.Add(groupBox1);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

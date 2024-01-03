namespace Shopping
{
    partial class ListAllAccount
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
            dataAllAccount = new System.Windows.Forms.DataGridView();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            txtID = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            btnBlock = new System.Windows.Forms.Button();
            txtStatus = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            txtPoint = new System.Windows.Forms.TextBox();
            txtEmail = new System.Windows.Forms.TextBox();
            txtAddress = new System.Windows.Forms.TextBox();
            txtPhone = new System.Windows.Forms.TextBox();
            txtName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)dataAllAccount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataAllAccount
            // 
            dataAllAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataAllAccount.Location = new System.Drawing.Point(10, 47);
            dataAllAccount.Name = "dataAllAccount";
            dataAllAccount.RowHeadersWidth = 51;
            dataAllAccount.RowTemplate.Height = 25;
            dataAllAccount.Size = new System.Drawing.Size(330, 189);
            dataAllAccount.TabIndex = 0;
            dataAllAccount.SelectionChanged += ViewAAcc;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new System.Drawing.Point(358, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(176, 149);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 34);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(25, 15);
            label1.TabIndex = 2;
            label1.Text = "Tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 63);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(76, 15);
            label2.TabIndex = 3;
            label2.Text = "Số điện thoại";
            label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(5, 95);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(43, 15);
            label3.TabIndex = 4;
            label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(5, 129);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(36, 15);
            label4.TabIndex = 5;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(5, 168);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(35, 15);
            label5.TabIndex = 6;
            label5.Text = "Điểm";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btnBlock);
            groupBox1.Controls.Add(txtStatus);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtPoint);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new System.Drawing.Point(559, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(237, 287);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // txtID
            // 
            txtID.Location = new System.Drawing.Point(29, 10);
            txtID.Name = "txtID";
            txtID.Size = new System.Drawing.Size(28, 23);
            txtID.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(6, 13);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(17, 15);
            label7.TabIndex = 15;
            label7.Text = "Id";
            // 
            // btnBlock
            // 
            btnBlock.Location = new System.Drawing.Point(162, 264);
            btnBlock.Name = "btnBlock";
            btnBlock.Size = new System.Drawing.Size(75, 23);
            btnBlock.TabIndex = 14;
            btnBlock.Text = "Block";
            btnBlock.UseVisualStyleBackColor = true;
            btnBlock.Click += BtnBlockAcc;
            // 
            // txtStatus
            // 
            txtStatus.Location = new System.Drawing.Point(88, 195);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new System.Drawing.Size(89, 23);
            txtStatus.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(6, 198);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(59, 15);
            label6.TabIndex = 12;
            label6.Text = "Trạng thái";
            // 
            // txtPoint
            // 
            txtPoint.Location = new System.Drawing.Point(88, 160);
            txtPoint.Name = "txtPoint";
            txtPoint.Size = new System.Drawing.Size(129, 23);
            txtPoint.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(88, 121);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(129, 23);
            txtEmail.TabIndex = 10;
            // 
            // txtAddress
            // 
            txtAddress.Location = new System.Drawing.Point(88, 92);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new System.Drawing.Size(129, 23);
            txtAddress.TabIndex = 9;
            // 
            // txtPhone
            // 
            txtPhone.Location = new System.Drawing.Point(88, 60);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new System.Drawing.Size(129, 23);
            txtPhone.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(75, 31);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(129, 23);
            txtName.TabIndex = 7;
            // 
            // ListAllAccount
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(813, 340);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(dataAllAccount);
            Name = "ListAllAccount";
            Text = "ListAllAccount";
            ((System.ComponentModel.ISupportInitialize)dataAllAccount).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataAllAccount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPoint;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBlock;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label7;
    }
}
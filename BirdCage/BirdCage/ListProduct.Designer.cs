namespace BirdCage
{
    partial class ListProduct
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
            dataGridViewProduct = new System.Windows.Forms.DataGridView();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            txtNamePro = new System.Windows.Forms.TextBox();
            txtPrice = new System.Windows.Forms.TextBox();
            txtquantity = new System.Windows.Forms.TextBox();
            txtdecrip = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProduct
            // 
            dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProduct.Location = new System.Drawing.Point(318, 12);
            dataGridViewProduct.Name = "dataGridViewProduct";
            dataGridViewProduct.RowTemplate.Height = 25;
            dataGridViewProduct.Size = new System.Drawing.Size(477, 297);
            dataGridViewProduct.TabIndex = 0;
            dataGridViewProduct.SelectionChanged += ViewAStudent;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(318, 326);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(113, 40);
            button1.TabIndex = 1;
            button1.Text = "Load";
            button1.UseVisualStyleBackColor = true;
            button1.Click += BtnLoadingPro;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(455, 326);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(113, 40);
            button2.TabIndex = 2;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnAddpro;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 12);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(39, 15);
            label1.TabIndex = 3;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 55);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(33, 15);
            label2.TabIndex = 4;
            label2.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 92);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(53, 15);
            label3.TabIndex = 5;
            label3.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 136);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(62, 15);
            label4.TabIndex = 6;
            label4.Text = "Decription";
            // 
            // txtNamePro
            // 
            txtNamePro.Location = new System.Drawing.Point(67, 9);
            txtNamePro.Name = "txtNamePro";
            txtNamePro.Size = new System.Drawing.Size(156, 23);
            txtNamePro.TabIndex = 7;
            // 
            // txtPrice
            // 
            txtPrice.Location = new System.Drawing.Point(67, 47);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(156, 23);
            txtPrice.TabIndex = 8;
            // 
            // txtquantity
            // 
            txtquantity.Location = new System.Drawing.Point(71, 84);
            txtquantity.Name = "txtquantity";
            txtquantity.Size = new System.Drawing.Size(156, 23);
            txtquantity.TabIndex = 9;
            // 
            // txtdecrip
            // 
            txtdecrip.Location = new System.Drawing.Point(80, 128);
            txtdecrip.Name = "txtdecrip";
            txtdecrip.Size = new System.Drawing.Size(156, 23);
            txtdecrip.TabIndex = 10;
            // 
            // ListProduct
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(txtdecrip);
            Controls.Add(txtquantity);
            Controls.Add(txtPrice);
            Controls.Add(txtNamePro);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridViewProduct);
            Name = "ListProduct";
            Text = "ListProduct";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNamePro;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.TextBox txtdecrip;
    }
}
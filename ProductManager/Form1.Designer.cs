﻿namespace ProductManager
{
    partial class Form1
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
            lblProductName = new Label();
            txtProductName = new TextBox();
            btnAddProduct = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(45, 69);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(84, 15);
            lblProductName.TabIndex = 0;
            lblProductName.Text = "Product Name";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(149, 66);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(100, 23);
            txtProductName.TabIndex = 1;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(56, 155);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(96, 61);
            btnAddProduct.TabIndex = 2;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(195, 155);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 61);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 309);
            Controls.Add(btnExit);
            Controls.Add(btnAddProduct);
            Controls.Add(txtProductName);
            Controls.Add(lblProductName);
            Name = "Form1";
            Text = "Product Manager";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProductName;
        private TextBox txtProductName;
        private Button btnAddProduct;
        private Button btnExit;
    }
}

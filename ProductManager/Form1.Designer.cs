namespace ProductManager
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
            label1 = new Label();
            txt = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 69);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "Product Name";
            // 
            // txt
            // 
            txt.Location = new Point(149, 66);
            txt.Name = "txt";
            txt.Size = new Size(100, 23);
            txt.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(121, 153);
            button1.Name = "button1";
            button1.Size = new Size(96, 61);
            button1.TabIndex = 2;
            button1.Text = "Add Product";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 309);
            Controls.Add(button1);
            Controls.Add(txt);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Product Manager";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt;
        private Button button1;
    }
}

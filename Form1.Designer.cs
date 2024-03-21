namespace Winforms.Inventory
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
            listBox1 = new ListBox();
            addBtn = new Button();
            deleteBtn = new Button();
            exitBtn = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(35, 33);
            listBox1.Margin = new Padding(2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(441, 204);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(530, 48);
            addBtn.Margin = new Padding(2);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(111, 55);
            addBtn.TabIndex = 1;
            addBtn.Text = "Add Item";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(530, 124);
            deleteBtn.Margin = new Padding(2);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(111, 50);
            deleteBtn.TabIndex = 2;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(530, 203);
            exitBtn.Margin = new Padding(2);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(111, 50);
            exitBtn.TabIndex = 3;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 335);
            Controls.Add(exitBtn);
            Controls.Add(deleteBtn);
            Controls.Add(addBtn);
            Controls.Add(listBox1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Inventory";
            Load += Form1_Load_1;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button addBtn;
        private Button deleteBtn;
        private Button exitBtn;
    }
}

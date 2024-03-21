namespace Winforms.Inventory
{
    partial class NewInventoryItem
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
            itemLabel = new Label();
            descLabel = new Label();
            priceLabel = new Label();
            SaveBtn = new Button();
            CancelBtn = new Button();
            itemTxt = new TextBox();
            descTxt = new TextBox();
            priceTxt = new TextBox();
            SuspendLayout();
            // 
            // itemLabel
            // 
            itemLabel.AutoSize = true;
            itemLabel.Location = new Point(107, 63);
            itemLabel.Margin = new Padding(2, 0, 2, 0);
            itemLabel.Name = "itemLabel";
            itemLabel.Size = new Size(67, 20);
            itemLabel.TabIndex = 0;
            itemLabel.Text = "Item no :";
            // 
            // descLabel
            // 
            descLabel.AutoSize = true;
            descLabel.Location = new Point(107, 121);
            descLabel.Margin = new Padding(2, 0, 2, 0);
            descLabel.Name = "descLabel";
            descLabel.Size = new Size(92, 20);
            descLabel.TabIndex = 1;
            descLabel.Text = "Description :";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(107, 172);
            priceLabel.Margin = new Padding(2, 0, 2, 0);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(48, 20);
            priceLabel.TabIndex = 2;
            priceLabel.Text = "Price :";
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(107, 249);
            SaveBtn.Margin = new Padding(2);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(103, 39);
            SaveBtn.TabIndex = 3;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(279, 249);
            CancelBtn.Margin = new Padding(2);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(106, 39);
            CancelBtn.TabIndex = 4;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // itemTxt
            // 
            itemTxt.Location = new Point(254, 63);
            itemTxt.Margin = new Padding(2);
            itemTxt.Name = "itemTxt";
            itemTxt.Size = new Size(116, 27);
            itemTxt.TabIndex = 5;
            // 
            // descTxt
            // 
            descTxt.Location = new Point(254, 121);
            descTxt.Margin = new Padding(2);
            descTxt.Name = "descTxt";
            descTxt.Size = new Size(116, 27);
            descTxt.TabIndex = 6;
            // 
            // priceTxt
            // 
            priceTxt.Location = new Point(254, 172);
            priceTxt.Margin = new Padding(2);
            priceTxt.Name = "priceTxt";
            priceTxt.Size = new Size(116, 27);
            priceTxt.TabIndex = 7;
            // 
            // NewInventoryItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 343);
            Controls.Add(priceTxt);
            Controls.Add(descTxt);
            Controls.Add(itemTxt);
            Controls.Add(CancelBtn);
            Controls.Add(SaveBtn);
            Controls.Add(priceLabel);
            Controls.Add(descLabel);
            Controls.Add(itemLabel);
            Margin = new Padding(2);
            Name = "NewInventoryItem";
            Text = "NewInventoryItem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label itemLabel;
        private Label descLabel;
        private Label priceLabel;
        private Button SaveBtn;
        private Button CancelBtn;
        private TextBox itemTxt;
        private TextBox descTxt;
        private TextBox priceTxt;
    }
}
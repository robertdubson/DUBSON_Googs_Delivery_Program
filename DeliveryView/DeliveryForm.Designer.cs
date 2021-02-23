namespace DeliveryView
{
    partial class DeliveryForm
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
            this.ChooseProductButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ChooseProductButton
            // 
            this.ChooseProductButton.Location = new System.Drawing.Point(264, 295);
            this.ChooseProductButton.Name = "ChooseProductButton";
            this.ChooseProductButton.Size = new System.Drawing.Size(120, 45);
            this.ChooseProductButton.TabIndex = 0;
            this.ChooseProductButton.Text = "ЗАМОВИТИ";
            this.ChooseProductButton.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(30, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(267, 173);
            this.listBox1.TabIndex = 1;
            // 
            // DeliveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 365);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ChooseProductButton);
            this.Name = "DeliveryForm";
            this.Text = "Delivery";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ChooseProductButton;
        private System.Windows.Forms.ListBox listBox1;
    }
}


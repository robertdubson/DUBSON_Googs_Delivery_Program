namespace DeliveryViewForms
{
    partial class RecentOrdersForm
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
            this.buttonGetBack = new System.Windows.Forms.Button();
            this.buttonCancelTheOrder = new System.Windows.Forms.Button();
            this.listBoxRecentOrders = new System.Windows.Forms.ListBox();
            this.labelOrders = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGetBack
            // 
            this.buttonGetBack.Location = new System.Drawing.Point(59, 317);
            this.buttonGetBack.Name = "buttonGetBack";
            this.buttonGetBack.Size = new System.Drawing.Size(160, 34);
            this.buttonGetBack.TabIndex = 0;
            this.buttonGetBack.Text = "НАЗАД";
            this.buttonGetBack.UseVisualStyleBackColor = true;
            this.buttonGetBack.Click += new System.EventHandler(this.buttonGetBack_Click);
            // 
            // buttonCancelTheOrder
            // 
            this.buttonCancelTheOrder.Location = new System.Drawing.Point(249, 317);
            this.buttonCancelTheOrder.Name = "buttonCancelTheOrder";
            this.buttonCancelTheOrder.Size = new System.Drawing.Size(160, 34);
            this.buttonCancelTheOrder.TabIndex = 1;
            this.buttonCancelTheOrder.Text = "СКАСУВАТИ ЗАМОВЛЕННЯ";
            this.buttonCancelTheOrder.UseVisualStyleBackColor = true;
            this.buttonCancelTheOrder.Click += new System.EventHandler(this.buttonCancelTheOrder_Click);
            // 
            // listBoxRecentOrders
            // 
            this.listBoxRecentOrders.FormattingEnabled = true;
            this.listBoxRecentOrders.Location = new System.Drawing.Point(26, 45);
            this.listBoxRecentOrders.Name = "listBoxRecentOrders";
            this.listBoxRecentOrders.Size = new System.Drawing.Size(423, 251);
            this.listBoxRecentOrders.TabIndex = 2;
            // 
            // labelOrders
            // 
            this.labelOrders.AutoSize = true;
            this.labelOrders.Location = new System.Drawing.Point(23, 19);
            this.labelOrders.Name = "labelOrders";
            this.labelOrders.Size = new System.Drawing.Size(98, 13);
            this.labelOrders.TabIndex = 3;
            this.labelOrders.Text = "Ваші замовлення:";
            // 
            // RecentOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 363);
            this.Controls.Add(this.labelOrders);
            this.Controls.Add(this.listBoxRecentOrders);
            this.Controls.Add(this.buttonCancelTheOrder);
            this.Controls.Add(this.buttonGetBack);
            this.Name = "RecentOrdersForm";
            this.Text = "RecentOrdersForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGetBack;
        private System.Windows.Forms.Button buttonCancelTheOrder;
        private System.Windows.Forms.ListBox listBoxRecentOrders;
        private System.Windows.Forms.Label labelOrders;
    }
}
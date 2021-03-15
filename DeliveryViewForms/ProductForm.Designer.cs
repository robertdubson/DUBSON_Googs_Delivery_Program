namespace DeliveryViewForms
{
    partial class ProductForm
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
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonSelectProduct = new System.Windows.Forms.Button();
            this.listBoxDeliveryTypes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.ItemHeight = 19;
            this.listBoxProducts.Location = new System.Drawing.Point(40, 45);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(218, 232);
            this.listBoxProducts.TabIndex = 0;
            this.listBoxProducts.SelectedIndexChanged += new System.EventHandler(this.listBoxProducts_SelectedIndexChanged);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(40, 304);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(218, 40);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "НАЗАД";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // buttonSelectProduct
            // 
            this.buttonSelectProduct.Location = new System.Drawing.Point(284, 304);
            this.buttonSelectProduct.Name = "buttonSelectProduct";
            this.buttonSelectProduct.Size = new System.Drawing.Size(218, 40);
            this.buttonSelectProduct.TabIndex = 3;
            this.buttonSelectProduct.Text = "ОБРАТИ";
            this.buttonSelectProduct.UseVisualStyleBackColor = true;
            // 
            // listBoxDeliveryTypes
            // 
            this.listBoxDeliveryTypes.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxDeliveryTypes.FormattingEnabled = true;
            this.listBoxDeliveryTypes.ItemHeight = 19;
            this.listBoxDeliveryTypes.Location = new System.Drawing.Point(284, 45);
            this.listBoxDeliveryTypes.Name = "listBoxDeliveryTypes";
            this.listBoxDeliveryTypes.Size = new System.Drawing.Size(218, 232);
            this.listBoxDeliveryTypes.TabIndex = 4;
            this.listBoxDeliveryTypes.SelectedIndexChanged += new System.EventHandler(this.listBoxDeliveryTypes_SelectedIndexChanged);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 367);
            this.Controls.Add(this.listBoxDeliveryTypes);
            this.Controls.Add(this.buttonSelectProduct);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.listBoxProducts);
            this.Name = "ProductForm";
            this.Text = "Available Products";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxProducts;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonSelectProduct;
        private System.Windows.Forms.ListBox listBoxDeliveryTypes;
    }
}
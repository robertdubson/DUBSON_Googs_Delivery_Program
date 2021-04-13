namespace DeliveryViewForms
{
    partial class StartForm
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
            this.seeAllProducts = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelFront = new System.Windows.Forms.Label();
            this.buttonRecentOrders = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // seeAllProducts
            // 
            this.seeAllProducts.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seeAllProducts.Location = new System.Drawing.Point(156, 124);
            this.seeAllProducts.Name = "seeAllProducts";
            this.seeAllProducts.Size = new System.Drawing.Size(161, 47);
            this.seeAllProducts.TabIndex = 0;
            this.seeAllProducts.Text = "Переглянути каталог";
            this.seeAllProducts.UseVisualStyleBackColor = true;
            this.seeAllProducts.Click += new System.EventHandler(this.seeAllProducts_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAbout.Location = new System.Drawing.Point(156, 223);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(161, 41);
            this.buttonAbout.TabIndex = 1;
            this.buttonAbout.Text = "About";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(156, 270);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(161, 41);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "EXIT";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelFront
            // 
            this.labelFront.AutoSize = true;
            this.labelFront.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFront.Location = new System.Drawing.Point(62, 61);
            this.labelFront.Name = "labelFront";
            this.labelFront.Size = new System.Drawing.Size(330, 39);
            this.labelFront.TabIndex = 3;
            this.labelFront.Text = "DELIVERY SERVICE";
            // 
            // buttonRecentOrders
            // 
            this.buttonRecentOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRecentOrders.Location = new System.Drawing.Point(156, 177);
            this.buttonRecentOrders.Name = "buttonRecentOrders";
            this.buttonRecentOrders.Size = new System.Drawing.Size(161, 41);
            this.buttonRecentOrders.TabIndex = 4;
            this.buttonRecentOrders.Text = "Замовлення";
            this.buttonRecentOrders.UseVisualStyleBackColor = true;
            this.buttonRecentOrders.Click += new System.EventHandler(this.buttonRecentOrders_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 339);
            this.Controls.Add(this.buttonRecentOrders);
            this.Controls.Add(this.labelFront);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.seeAllProducts);
            this.Name = "StartForm";
            this.Text = "DubsonDelivery";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button seeAllProducts;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelFront;
        private System.Windows.Forms.Button buttonRecentOrders;
    }
}


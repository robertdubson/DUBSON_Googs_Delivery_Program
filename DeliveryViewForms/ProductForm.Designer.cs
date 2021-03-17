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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDownMinWeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxWeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinVolume = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxVolume = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinPrice = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxPrice = new System.Windows.Forms.NumericUpDown();
            this.labelSearch = new System.Windows.Forms.Label();
            this.minWeightLabel = new System.Windows.Forms.Label();
            this.maxWeightLabel = new System.Windows.Forms.Label();
            this.minVolumeLable = new System.Windows.Forms.Label();
            this.maxVolumeLabel = new System.Windows.Forms.Label();
            this.minPriceLabel = new System.Windows.Forms.Label();
            this.maxPriceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.ItemHeight = 19;
            this.listBoxProducts.Location = new System.Drawing.Point(12, 166);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(481, 232);
            this.listBoxProducts.TabIndex = 0;
            //this.listBoxProducts.SelectedIndexChanged += new System.EventHandler(this.listBoxProducts_SelectedIndexChanged);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(250, 404);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(218, 40);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "НАЗАД";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonSelectProduct
            // 
            this.buttonSelectProduct.Location = new System.Drawing.Point(474, 404);
            this.buttonSelectProduct.Name = "buttonSelectProduct";
            this.buttonSelectProduct.Size = new System.Drawing.Size(218, 40);
            this.buttonSelectProduct.TabIndex = 3;
            this.buttonSelectProduct.Text = "ЗАМОВИТИ";
            this.buttonSelectProduct.UseVisualStyleBackColor = true;
            this.buttonSelectProduct.Click += new System.EventHandler(this.buttonSelectProduct_Click);
            // 
            // listBoxDeliveryTypes
            // 
            this.listBoxDeliveryTypes.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxDeliveryTypes.FormattingEnabled = true;
            this.listBoxDeliveryTypes.ItemHeight = 19;
            this.listBoxDeliveryTypes.Location = new System.Drawing.Point(499, 166);
            this.listBoxDeliveryTypes.Name = "listBoxDeliveryTypes";
            this.listBoxDeliveryTypes.Size = new System.Drawing.Size(327, 232);
            this.listBoxDeliveryTypes.TabIndex = 4;
            //this.listBoxDeliveryTypes.SelectedIndexChanged += new System.EventHandler(this.listBoxDeliveryTypes_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(680, 27);
            this.textBox1.TabIndex = 5;
            //this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // numericUpDownMinWeight
            // 
            this.numericUpDownMinWeight.Location = new System.Drawing.Point(12, 131);
            this.numericUpDownMinWeight.Name = "numericUpDownMinWeight";
            this.numericUpDownMinWeight.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMinWeight.TabIndex = 6;
            //this.numericUpDownMinWeight.ValueChanged += new System.EventHandler(this.numericUpDownMinWeight_ValueChanged);
            // 
            // numericUpDownMaxWeight
            // 
            this.numericUpDownMaxWeight.Location = new System.Drawing.Point(138, 131);
            this.numericUpDownMaxWeight.Name = "numericUpDownMaxWeight";
            this.numericUpDownMaxWeight.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMaxWeight.TabIndex = 7;
            //this.numericUpDownMaxWeight.ValueChanged += new System.EventHandler(this.numericUpDownMaxWeight_ValueChanged);
            // 
            // numericUpDownMinVolume
            // 
            this.numericUpDownMinVolume.Location = new System.Drawing.Point(264, 131);
            this.numericUpDownMinVolume.Name = "numericUpDownMinVolume";
            this.numericUpDownMinVolume.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMinVolume.TabIndex = 8;
            //this.numericUpDownMinVolume.ValueChanged += new System.EventHandler(this.numericUpDownMinVolume_ValueChanged);
            // 
            // numericUpDownMaxVolume
            // 
            this.numericUpDownMaxVolume.Location = new System.Drawing.Point(390, 131);
            this.numericUpDownMaxVolume.Name = "numericUpDownMaxVolume";
            this.numericUpDownMaxVolume.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMaxVolume.TabIndex = 9;
            //this.numericUpDownMaxVolume.ValueChanged += new System.EventHandler(this.numericUpDownMaxVolume_ValueChanged);
            // 
            // numericUpDownMinPrice
            // 
            this.numericUpDownMinPrice.Location = new System.Drawing.Point(516, 131);
            this.numericUpDownMinPrice.Name = "numericUpDownMinPrice";
            this.numericUpDownMinPrice.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMinPrice.TabIndex = 10;
            //this.numericUpDownMinPrice.ValueChanged += new System.EventHandler(this.numericUpDownMinPrice_ValueChanged);
            // 
            // numericUpDownMaxPrice
            // 
            this.numericUpDownMaxPrice.Location = new System.Drawing.Point(642, 131);
            this.numericUpDownMaxPrice.Name = "numericUpDownMaxPrice";
            this.numericUpDownMaxPrice.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMaxPrice.TabIndex = 11;
            //this.numericUpDownMaxPrice.ValueChanged += new System.EventHandler(this.numericUpDownMaxPrice_ValueChanged);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(13, 13);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(101, 22);
            this.labelSearch.TabIndex = 12;
            this.labelSearch.Text = "SEARCH";
            // 
            // minWeightLabel
            // 
            this.minWeightLabel.AutoSize = true;
            this.minWeightLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minWeightLabel.Location = new System.Drawing.Point(14, 102);
            this.minWeightLabel.Name = "minWeightLabel";
            this.minWeightLabel.Size = new System.Drawing.Size(93, 20);
            this.minWeightLabel.TabIndex = 13;
            this.minWeightLabel.Text = "мін. Вага:";
            // 
            // maxWeightLabel
            // 
            this.maxWeightLabel.AutoSize = true;
            this.maxWeightLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxWeightLabel.Location = new System.Drawing.Point(146, 102);
            this.maxWeightLabel.Name = "maxWeightLabel";
            this.maxWeightLabel.Size = new System.Drawing.Size(106, 20);
            this.maxWeightLabel.TabIndex = 14;
            this.maxWeightLabel.Text = "макс. Вага:";
            // 
            // minVolumeLable
            // 
            this.minVolumeLable.AutoSize = true;
            this.minVolumeLable.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minVolumeLable.Location = new System.Drawing.Point(269, 102);
            this.minVolumeLable.Name = "minVolumeLable";
            this.minVolumeLable.Size = new System.Drawing.Size(95, 20);
            this.minVolumeLable.TabIndex = 15;
            this.minVolumeLable.Text = "мін Об\'єм:";
            // 
            // maxVolumeLabel
            // 
            this.maxVolumeLabel.AutoSize = true;
            this.maxVolumeLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxVolumeLabel.Location = new System.Drawing.Point(387, 102);
            this.maxVolumeLabel.Name = "maxVolumeLabel";
            this.maxVolumeLabel.Size = new System.Drawing.Size(114, 20);
            this.maxVolumeLabel.TabIndex = 16;
            this.maxVolumeLabel.Text = "макс. Об\'єм:";
            // 
            // minPriceLabel
            // 
            this.minPriceLabel.AutoSize = true;
            this.minPriceLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minPriceLabel.Location = new System.Drawing.Point(521, 102);
            this.minPriceLabel.Name = "minPriceLabel";
            this.minPriceLabel.Size = new System.Drawing.Size(91, 20);
            this.minPriceLabel.TabIndex = 17;
            this.minPriceLabel.Text = "мін. Ціна:";
            // 
            // maxPriceLabel
            // 
            this.maxPriceLabel.AutoSize = true;
            this.maxPriceLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxPriceLabel.Location = new System.Drawing.Point(647, 102);
            this.maxPriceLabel.Name = "maxPriceLabel";
            this.maxPriceLabel.Size = new System.Drawing.Size(104, 20);
            this.maxPriceLabel.TabIndex = 18;
            this.maxPriceLabel.Text = "макс. Ціна:";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 482);
            this.Controls.Add(this.maxPriceLabel);
            this.Controls.Add(this.minPriceLabel);
            this.Controls.Add(this.maxVolumeLabel);
            this.Controls.Add(this.minVolumeLable);
            this.Controls.Add(this.maxWeightLabel);
            this.Controls.Add(this.minWeightLabel);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.numericUpDownMaxPrice);
            this.Controls.Add(this.numericUpDownMinPrice);
            this.Controls.Add(this.numericUpDownMaxVolume);
            this.Controls.Add(this.numericUpDownMinVolume);
            this.Controls.Add(this.numericUpDownMaxWeight);
            this.Controls.Add(this.numericUpDownMinWeight);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBoxDeliveryTypes);
            this.Controls.Add(this.buttonSelectProduct);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.listBoxProducts);
            this.Name = "ProductForm";
            this.Text = "Available Products";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxProducts;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonSelectProduct;
        private System.Windows.Forms.ListBox listBoxDeliveryTypes;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownMinWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownMinVolume;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxVolume;
        private System.Windows.Forms.NumericUpDown numericUpDownMinPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxPrice;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Label minWeightLabel;
        private System.Windows.Forms.Label maxWeightLabel;
        private System.Windows.Forms.Label minVolumeLable;
        private System.Windows.Forms.Label maxVolumeLabel;
        private System.Windows.Forms.Label minPriceLabel;
        private System.Windows.Forms.Label maxPriceLabel;
    }
}
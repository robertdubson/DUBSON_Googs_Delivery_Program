namespace DeliveryViewForms
{
    partial class DestinationsForm
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSelectDestination = new System.Windows.Forms.Button();
            this.listBoxDestinations = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(62, 319);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(204, 37);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "СКАСУВАТИ";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSelectDestination
            // 
            this.buttonSelectDestination.Location = new System.Drawing.Point(286, 319);
            this.buttonSelectDestination.Name = "buttonSelectDestination";
            this.buttonSelectDestination.Size = new System.Drawing.Size(204, 37);
            this.buttonSelectDestination.TabIndex = 1;
            this.buttonSelectDestination.Text = "ОБРАТИ";
            this.buttonSelectDestination.UseVisualStyleBackColor = true;
            // 
            // listBoxDestinations
            // 
            this.listBoxDestinations.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxDestinations.FormattingEnabled = true;
            this.listBoxDestinations.ItemHeight = 16;
            this.listBoxDestinations.Location = new System.Drawing.Point(62, 72);
            this.listBoxDestinations.Name = "listBoxDestinations";
            this.listBoxDestinations.Size = new System.Drawing.Size(428, 212);
            this.listBoxDestinations.TabIndex = 2;
            this.listBoxDestinations.SelectedIndexChanged += new System.EventHandler(this.listBoxDestinations_SelectedIndexChanged);
            // 
            // DestinationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 368);
            this.Controls.Add(this.listBoxDestinations);
            this.Controls.Add(this.buttonSelectDestination);
            this.Controls.Add(this.buttonCancel);
            this.Name = "DestinationsForm";
            this.Text = "DestinationsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSelectDestination;
        private System.Windows.Forms.ListBox listBoxDestinations;
    }
}
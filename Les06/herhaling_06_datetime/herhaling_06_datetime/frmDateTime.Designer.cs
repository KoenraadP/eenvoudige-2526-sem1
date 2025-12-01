namespace herhaling_06_datetime
{
    partial class frmDateTime
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
            this.dtpHerhaling = new System.Windows.Forms.DateTimePicker();
            this.btnHerhaling = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpHerhaling
            // 
            this.dtpHerhaling.Location = new System.Drawing.Point(12, 12);
            this.dtpHerhaling.Name = "dtpHerhaling";
            this.dtpHerhaling.Size = new System.Drawing.Size(200, 20);
            this.dtpHerhaling.TabIndex = 0;
            // 
            // btnHerhaling
            // 
            this.btnHerhaling.Location = new System.Drawing.Point(13, 39);
            this.btnHerhaling.Name = "btnHerhaling";
            this.btnHerhaling.Size = new System.Drawing.Size(199, 23);
            this.btnHerhaling.TabIndex = 1;
            this.btnHerhaling.Text = "Datum controleren";
            this.btnHerhaling.UseVisualStyleBackColor = true;
            this.btnHerhaling.Click += new System.EventHandler(this.BtnHerhaling_Click);
            // 
            // frmDateTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 68);
            this.Controls.Add(this.btnHerhaling);
            this.Controls.Add(this.dtpHerhaling);
            this.Name = "frmDateTime";
            this.Text = "DateTime";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpHerhaling;
        private System.Windows.Forms.Button btnHerhaling;
    }
}


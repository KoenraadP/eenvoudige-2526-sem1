namespace Les08_herhaling
{
    partial class FrmHerhalingLes08
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnRepeatText = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(13, 13);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(400, 20);
            this.txtInput.TabIndex = 0;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(12, 69);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(453, 151);
            this.txtOutput.TabIndex = 1;
            // 
            // btnRepeatText
            // 
            this.btnRepeatText.Location = new System.Drawing.Point(13, 40);
            this.btnRepeatText.Name = "btnRepeatText";
            this.btnRepeatText.Size = new System.Drawing.Size(452, 23);
            this.btnRepeatText.TabIndex = 2;
            this.btnRepeatText.Text = "Tekst tonen";
            this.btnRepeatText.UseVisualStyleBackColor = true;
            this.btnRepeatText.Click += new System.EventHandler(this.BtnRepeatText_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(420, 12);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(45, 20);
            this.txtAmount.TabIndex = 3;
            // 
            // FrmHerhalingLes08
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 236);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.btnRepeatText);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput);
            this.Name = "FrmHerhalingLes08";
            this.Text = "Les08Herhaling";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnRepeatText;
        private System.Windows.Forms.TextBox txtAmount;
    }
}


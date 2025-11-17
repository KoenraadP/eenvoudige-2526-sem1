namespace les02_03
{
    partial class Form1
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
            this.txtNr1 = new System.Windows.Forms.TextBox();
            this.txtNr2 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnDivide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNr1
            // 
            this.txtNr1.Location = new System.Drawing.Point(13, 13);
            this.txtNr1.Name = "txtNr1";
            this.txtNr1.Size = new System.Drawing.Size(100, 20);
            this.txtNr1.TabIndex = 0;
            // 
            // txtNr2
            // 
            this.txtNr2.Location = new System.Drawing.Point(13, 39);
            this.txtNr2.Name = "txtNr2";
            this.txtNr2.Size = new System.Drawing.Size(100, 20);
            this.txtNr2.TabIndex = 1;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(13, 95);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 20);
            this.txtResult.TabIndex = 2;
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(13, 66);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(100, 23);
            this.btnDivide.TabIndex = 3;
            this.btnDivide.Text = "Delen";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.BtnDivide_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(126, 127);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtNr2);
            this.Controls.Add(this.txtNr1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNr1;
        private System.Windows.Forms.TextBox txtNr2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnDivide;
    }
}


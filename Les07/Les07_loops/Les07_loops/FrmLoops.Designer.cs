namespace Les07_loops
{
    partial class FrmLoops
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
            this.txtNumbers = new System.Windows.Forms.TextBox();
            this.btnShowNumbers1 = new System.Windows.Forms.Button();
            this.btnShowNumbers2 = new System.Windows.Forms.Button();
            this.btnShowNumbers3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumbers
            // 
            this.txtNumbers.Location = new System.Drawing.Point(13, 99);
            this.txtNumbers.Multiline = true;
            this.txtNumbers.Name = "txtNumbers";
            this.txtNumbers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNumbers.Size = new System.Drawing.Size(100, 243);
            this.txtNumbers.TabIndex = 0;
            // 
            // btnShowNumbers1
            // 
            this.btnShowNumbers1.Location = new System.Drawing.Point(13, 12);
            this.btnShowNumbers1.Name = "btnShowNumbers1";
            this.btnShowNumbers1.Size = new System.Drawing.Size(100, 23);
            this.btnShowNumbers1.TabIndex = 1;
            this.btnShowNumbers1.Text = "1 - 10";
            this.btnShowNumbers1.UseVisualStyleBackColor = true;
            this.btnShowNumbers1.Click += new System.EventHandler(this.BtnShowNumbers_Click);
            // 
            // btnShowNumbers2
            // 
            this.btnShowNumbers2.Location = new System.Drawing.Point(13, 41);
            this.btnShowNumbers2.Name = "btnShowNumbers2";
            this.btnShowNumbers2.Size = new System.Drawing.Size(100, 23);
            this.btnShowNumbers2.TabIndex = 2;
            this.btnShowNumbers2.Text = "1 - 100";
            this.btnShowNumbers2.UseVisualStyleBackColor = true;
            this.btnShowNumbers2.Click += new System.EventHandler(this.BtnShowNumbers2_Click);
            // 
            // btnShowNumbers3
            // 
            this.btnShowNumbers3.Location = new System.Drawing.Point(13, 70);
            this.btnShowNumbers3.Name = "btnShowNumbers3";
            this.btnShowNumbers3.Size = new System.Drawing.Size(100, 23);
            this.btnShowNumbers3.TabIndex = 3;
            this.btnShowNumbers3.Text = "1 - 1000";
            this.btnShowNumbers3.UseVisualStyleBackColor = true;
            this.btnShowNumbers3.Click += new System.EventHandler(this.BtnShowNumbers3_Click);
            // 
            // FrmLoops
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 356);
            this.Controls.Add(this.btnShowNumbers3);
            this.Controls.Add(this.btnShowNumbers2);
            this.Controls.Add(this.btnShowNumbers1);
            this.Controls.Add(this.txtNumbers);
            this.Name = "FrmLoops";
            this.Text = "Loops";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumbers;
        private System.Windows.Forms.Button btnShowNumbers1;
        private System.Windows.Forms.Button btnShowNumbers2;
        private System.Windows.Forms.Button btnShowNumbers3;
    }
}


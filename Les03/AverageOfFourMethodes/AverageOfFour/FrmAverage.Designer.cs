namespace AverageOfFour
{
    partial class FrmAverage
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
            this.txtOne = new System.Windows.Forms.TextBox();
            this.txtTwo = new System.Windows.Forms.TextBox();
            this.txtThree = new System.Windows.Forms.TextBox();
            this.txtFour = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnAvg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOne
            // 
            this.txtOne.Location = new System.Drawing.Point(51, 57);
            this.txtOne.Name = "txtOne";
            this.txtOne.Size = new System.Drawing.Size(100, 20);
            this.txtOne.TabIndex = 0;
            // 
            // txtTwo
            // 
            this.txtTwo.Location = new System.Drawing.Point(169, 57);
            this.txtTwo.Name = "txtTwo";
            this.txtTwo.Size = new System.Drawing.Size(100, 20);
            this.txtTwo.TabIndex = 1;
            // 
            // txtThree
            // 
            this.txtThree.Location = new System.Drawing.Point(285, 57);
            this.txtThree.Name = "txtThree";
            this.txtThree.Size = new System.Drawing.Size(100, 20);
            this.txtThree.TabIndex = 2;
            // 
            // txtFour
            // 
            this.txtFour.Location = new System.Drawing.Point(405, 57);
            this.txtFour.Name = "txtFour";
            this.txtFour.Size = new System.Drawing.Size(100, 20);
            this.txtFour.TabIndex = 3;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(51, 177);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(454, 20);
            this.txtResult.TabIndex = 5;
            // 
            // btnAvg
            // 
            this.btnAvg.Location = new System.Drawing.Point(51, 118);
            this.btnAvg.Name = "btnAvg";
            this.btnAvg.Size = new System.Drawing.Size(75, 23);
            this.btnAvg.TabIndex = 4;
            this.btnAvg.Text = "Gemiddelde";
            this.btnAvg.UseVisualStyleBackColor = true;
            // 
            // frmAverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 232);
            this.Controls.Add(this.btnAvg);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtFour);
            this.Controls.Add(this.txtThree);
            this.Controls.Add(this.txtTwo);
            this.Controls.Add(this.txtOne);
            this.Name = "frmAverage";
            this.Text = "Gemiddelde";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOne;
        private System.Windows.Forms.TextBox txtTwo;
        private System.Windows.Forms.TextBox txtThree;
        private System.Windows.Forms.TextBox txtFour;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnAvg;
    }
}


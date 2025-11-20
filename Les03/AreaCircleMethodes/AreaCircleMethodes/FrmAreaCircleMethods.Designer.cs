namespace AreaCircleMethodes
{
    partial class FrmAreaCircleMethods
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnArea = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Straal cirkel";
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(13, 44);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(188, 23);
            this.btnArea.TabIndex = 2;
            this.btnArea.Text = "bereken oppervlakte";
            this.btnArea.UseVisualStyleBackColor = true;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(16, 83);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(185, 20);
            this.txtResult.TabIndex = 3;
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(82, 13);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(119, 20);
            this.txtRadius.TabIndex = 4;
            // 
            // frmAreaCircleMethods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 120);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.label1);
            this.Name = "frmAreaCircleMethods";
            this.Text = "AreaCircle Methodes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtRadius;
    }
}


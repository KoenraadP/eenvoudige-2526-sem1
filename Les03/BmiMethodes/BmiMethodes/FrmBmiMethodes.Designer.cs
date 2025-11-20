namespace BmiMethodes
{
    partial class FrmBmiMethodes
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnBmi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBmi = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gewicht (in kg)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lengte (in centimeter)";
            // 
            // btnBmi
            // 
            this.btnBmi.Location = new System.Drawing.Point(16, 95);
            this.btnBmi.Name = "btnBmi";
            this.btnBmi.Size = new System.Drawing.Size(83, 23);
            this.btnBmi.TabIndex = 4;
            this.btnBmi.Text = "Bereken BMI";
            this.btnBmi.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "BMI";
            // 
            // txtBmi
            // 
            this.txtBmi.Location = new System.Drawing.Point(162, 96);
            this.txtBmi.Name = "txtBmi";
            this.txtBmi.Size = new System.Drawing.Size(100, 20);
            this.txtBmi.TabIndex = 7;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(162, 12);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 20);
            this.txtWeight.TabIndex = 8;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(162, 51);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 20);
            this.txtLength.TabIndex = 9;
            // 
            // FrmBmiMethodes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 129);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtBmi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBmi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmBmiMethodes";
            this.Text = "Bmi Methodes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBmi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBmi;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtLength;
    }
}


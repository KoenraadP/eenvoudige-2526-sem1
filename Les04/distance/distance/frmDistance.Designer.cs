namespace distance
{
    partial class frmDistance
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
            this.txtAvgSpeed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.btnDistance = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gemiddelde snelheid in km/u";
            // 
            // txtAvgSpeed
            // 
            this.txtAvgSpeed.Location = new System.Drawing.Point(163, 10);
            this.txtAvgSpeed.Name = "txtAvgSpeed";
            this.txtAvgSpeed.Size = new System.Drawing.Size(42, 20);
            this.txtAvgSpeed.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tijd gereden";
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(163, 43);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(42, 20);
            this.txtDuration.TabIndex = 3;
            // 
            // btnDistance
            // 
            this.btnDistance.Location = new System.Drawing.Point(16, 80);
            this.btnDistance.Name = "btnDistance";
            this.btnDistance.Size = new System.Drawing.Size(189, 23);
            this.btnDistance.TabIndex = 4;
            this.btnDistance.Text = "Bereken afstand";
            this.btnDistance.UseVisualStyleBackColor = true;
            this.btnDistance.Click += new System.EventHandler(this.BtnDistance_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(16, 110);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(189, 85);
            this.txtOutput.TabIndex = 5;
            // 
            // frmDistance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 207);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnDistance);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAvgSpeed);
            this.Controls.Add(this.label1);
            this.Name = "frmDistance";
            this.Text = "Distance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAvgSpeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Button btnDistance;
        private System.Windows.Forms.TextBox txtOutput;
    }
}


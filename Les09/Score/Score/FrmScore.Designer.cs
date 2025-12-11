namespace Score
{
    partial class FrmScore
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
            this.txtScore1 = new System.Windows.Forms.TextBox();
            this.txtScore3 = new System.Windows.Forms.TextBox();
            this.txtScore2 = new System.Windows.Forms.TextBox();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.btnAverage = new System.Windows.Forms.Button();
            this.lblGrade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtScore1
            // 
            this.txtScore1.Location = new System.Drawing.Point(13, 13);
            this.txtScore1.Name = "txtScore1";
            this.txtScore1.Size = new System.Drawing.Size(100, 20);
            this.txtScore1.TabIndex = 0;
            // 
            // txtScore3
            // 
            this.txtScore3.Location = new System.Drawing.Point(13, 65);
            this.txtScore3.Name = "txtScore3";
            this.txtScore3.Size = new System.Drawing.Size(100, 20);
            this.txtScore3.TabIndex = 1;
            // 
            // txtScore2
            // 
            this.txtScore2.Location = new System.Drawing.Point(13, 39);
            this.txtScore2.Name = "txtScore2";
            this.txtScore2.Size = new System.Drawing.Size(100, 20);
            this.txtScore2.TabIndex = 2;
            // 
            // txtAverage
            // 
            this.txtAverage.Location = new System.Drawing.Point(13, 121);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.Size = new System.Drawing.Size(100, 20);
            this.txtAverage.TabIndex = 3;
            // 
            // btnAverage
            // 
            this.btnAverage.Location = new System.Drawing.Point(13, 92);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(100, 23);
            this.btnAverage.TabIndex = 4;
            this.btnAverage.Text = "Gemiddelde";
            this.btnAverage.UseVisualStyleBackColor = true;
            this.btnAverage.Click += new System.EventHandler(this.BtnAverage_Click);
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(12, 153);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(35, 13);
            this.lblGrade.TabIndex = 5;
            this.lblGrade.Text = "label1";
            // 
            // FrmScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(121, 170);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.btnAverage);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.txtScore2);
            this.Controls.Add(this.txtScore3);
            this.Controls.Add(this.txtScore1);
            this.Name = "FrmScore";
            this.Text = "Score";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtScore1;
        private System.Windows.Forms.TextBox txtScore3;
        private System.Windows.Forms.TextBox txtScore2;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.Label lblGrade;
    }
}


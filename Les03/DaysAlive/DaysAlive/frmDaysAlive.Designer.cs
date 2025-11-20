namespace DaysAlive
{
    partial class frmDaysAlive
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
            this.txtDay = new System.Windows.Forms.TextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.btnDays = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnDaysAlive2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(30, 49);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(60, 20);
            this.txtDay.TabIndex = 0;
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(112, 49);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(60, 20);
            this.txtMonth.TabIndex = 1;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(194, 49);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(60, 20);
            this.txtYear.TabIndex = 2;
            // 
            // btnDays
            // 
            this.btnDays.Location = new System.Drawing.Point(30, 91);
            this.btnDays.Name = "btnDays";
            this.btnDays.Size = new System.Drawing.Size(224, 23);
            this.btnDays.TabIndex = 3;
            this.btnDays.Text = "Hoe veel dagen leef ik al?";
            this.btnDays.UseVisualStyleBackColor = true;
            this.btnDays.Click += new System.EventHandler(this.BtnDays_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(30, 140);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(224, 20);
            this.txtResult.TabIndex = 4;
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(27, 23);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(27, 13);
            this.lblDay.TabIndex = 5;
            this.lblDay.Text = "Dag";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(109, 23);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(40, 13);
            this.lblMonth.TabIndex = 6;
            this.lblMonth.Text = "Maand";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(191, 23);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(27, 13);
            this.lblYear.TabIndex = 7;
            this.lblYear.Text = "Jaar";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(30, 180);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(224, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // btnDaysAlive2
            // 
            this.btnDaysAlive2.Location = new System.Drawing.Point(30, 219);
            this.btnDaysAlive2.Name = "btnDaysAlive2";
            this.btnDaysAlive2.Size = new System.Drawing.Size(224, 23);
            this.btnDaysAlive2.TabIndex = 10;
            this.btnDaysAlive2.Text = "Hoe veel dagen leef ik al? (v2)";
            this.btnDaysAlive2.UseVisualStyleBackColor = true;
            this.btnDaysAlive2.Click += new System.EventHandler(this.BtnDaysAlive2_Click);
            // 
            // frmDaysAlive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 256);
            this.Controls.Add(this.btnDaysAlive2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnDays);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.txtDay);
            this.Name = "frmDaysAlive";
            this.Text = "Dagen dat je leeft";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Button btnDays;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnDaysAlive2;
    }
}


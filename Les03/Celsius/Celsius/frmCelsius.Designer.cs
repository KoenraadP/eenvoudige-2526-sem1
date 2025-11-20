namespace Celsius
{
    partial class frmCelsius
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
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.txtFahrenheit = new System.Windows.Forms.TextBox();
            this.btnCelsius = new System.Windows.Forms.Button();
            this.btnFahrenheit = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCelsius
            // 
            this.txtCelsius.Location = new System.Drawing.Point(52, 61);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.Size = new System.Drawing.Size(100, 20);
            this.txtCelsius.TabIndex = 0;
            // 
            // txtFahrenheit
            // 
            this.txtFahrenheit.Location = new System.Drawing.Point(177, 60);
            this.txtFahrenheit.Name = "txtFahrenheit";
            this.txtFahrenheit.Size = new System.Drawing.Size(100, 20);
            this.txtFahrenheit.TabIndex = 1;
            // 
            // btnCelsius
            // 
            this.btnCelsius.Location = new System.Drawing.Point(52, 114);
            this.btnCelsius.Name = "btnCelsius";
            this.btnCelsius.Size = new System.Drawing.Size(100, 23);
            this.btnCelsius.TabIndex = 2;
            this.btnCelsius.Text = "Naar Fahrenheit";
            this.btnCelsius.UseVisualStyleBackColor = true;
            this.btnCelsius.Click += new System.EventHandler(this.BtnCelsius_Click);
            // 
            // btnFahrenheit
            // 
            this.btnFahrenheit.Location = new System.Drawing.Point(177, 114);
            this.btnFahrenheit.Name = "btnFahrenheit";
            this.btnFahrenheit.Size = new System.Drawing.Size(100, 23);
            this.btnFahrenheit.TabIndex = 3;
            this.btnFahrenheit.Text = "Naar Celsius";
            this.btnFahrenheit.UseVisualStyleBackColor = true;
            this.btnFahrenheit.Click += new System.EventHandler(this.BtnFahrenheit_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(111, 164);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 20);
            this.txtResult.TabIndex = 4;
            // 
            // frmCelsius
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 215);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnFahrenheit);
            this.Controls.Add(this.btnCelsius);
            this.Controls.Add(this.txtFahrenheit);
            this.Controls.Add(this.txtCelsius);
            this.Name = "frmCelsius";
            this.Text = "Temperatuur converteren";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.TextBox txtFahrenheit;
        private System.Windows.Forms.Button btnCelsius;
        private System.Windows.Forms.Button btnFahrenheit;
        private System.Windows.Forms.TextBox txtResult;
    }
}


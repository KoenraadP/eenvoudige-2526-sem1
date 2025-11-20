namespace CelsiusMethodes
{
    partial class FrmCelsiusMethodes
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
            this.btnToFahrenheit = new System.Windows.Forms.Button();
            this.btnToCelsius = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.txtFahrenheit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnToFahrenheit
            // 
            this.btnToFahrenheit.Location = new System.Drawing.Point(188, 15);
            this.btnToFahrenheit.Name = "btnToFahrenheit";
            this.btnToFahrenheit.Size = new System.Drawing.Size(97, 23);
            this.btnToFahrenheit.TabIndex = 1;
            this.btnToFahrenheit.Text = "naar Fahrenheit";
            this.btnToFahrenheit.UseVisualStyleBackColor = true;
            // 
            // btnToCelsius
            // 
            this.btnToCelsius.Location = new System.Drawing.Point(188, 43);
            this.btnToCelsius.Name = "btnToCelsius";
            this.btnToCelsius.Size = new System.Drawing.Size(97, 23);
            this.btnToCelsius.TabIndex = 3;
            this.btnToCelsius.Text = "naar Celsius";
            this.btnToCelsius.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Celsius";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fahrenheit";
            // 
            // txtCelsius
            // 
            this.txtCelsius.Location = new System.Drawing.Point(82, 16);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.Size = new System.Drawing.Size(100, 20);
            this.txtCelsius.TabIndex = 6;
            // 
            // txtFahrenheit
            // 
            this.txtFahrenheit.Location = new System.Drawing.Point(82, 44);
            this.txtFahrenheit.Name = "txtFahrenheit";
            this.txtFahrenheit.Size = new System.Drawing.Size(100, 20);
            this.txtFahrenheit.TabIndex = 7;
            // 
            // frmCelsiusMethodes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 77);
            this.Controls.Add(this.txtFahrenheit);
            this.Controls.Add(this.txtCelsius);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnToCelsius);
            this.Controls.Add(this.btnToFahrenheit);
            this.Name = "frmCelsiusMethodes";
            this.Text = "Celsius Methodes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnToFahrenheit;
        private System.Windows.Forms.Button btnToCelsius;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.TextBox txtFahrenheit;
    }
}


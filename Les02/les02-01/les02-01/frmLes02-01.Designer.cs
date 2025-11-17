namespace les02_01
{
    partial class frmLes02_01
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnHello = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(13, 13);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(174, 20);
            this.txtName.TabIndex = 0;
            // 
            // btnHello
            // 
            this.btnHello.Location = new System.Drawing.Point(13, 40);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(174, 24);
            this.btnHello.TabIndex = 1;
            this.btnHello.Text = "click me";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.BtnHello_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(13, 70);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(174, 20);
            this.txtOutput.TabIndex = 2;
            this.txtOutput.TextChanged += new System.EventHandler(this.txtOutput_TextChanged);
            // 
            // frmLes02_01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 95);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnHello);
            this.Controls.Add(this.txtName);
            this.Name = "frmLes02_01";
            this.Text = "Les02_01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.TextBox txtOutput;
    }
}


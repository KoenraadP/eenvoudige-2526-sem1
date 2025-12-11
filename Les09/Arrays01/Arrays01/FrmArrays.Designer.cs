namespace Arrays01
{
    partial class FrmArrays
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
            this.btnNumbers = new System.Windows.Forms.Button();
            this.lbxData = new System.Windows.Forms.ListBox();
            this.btnNames = new System.Windows.Forms.Button();
            this.btnFetch = new System.Windows.Forms.Button();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnNumbers
            // 
            this.btnNumbers.Location = new System.Drawing.Point(13, 13);
            this.btnNumbers.Name = "btnNumbers";
            this.btnNumbers.Size = new System.Drawing.Size(120, 23);
            this.btnNumbers.TabIndex = 0;
            this.btnNumbers.Text = "Numbers";
            this.btnNumbers.UseVisualStyleBackColor = true;
            this.btnNumbers.Click += new System.EventHandler(this.BtnNumbers_Click);
            // 
            // lbxData
            // 
            this.lbxData.FormattingEnabled = true;
            this.lbxData.Location = new System.Drawing.Point(13, 42);
            this.lbxData.Name = "lbxData";
            this.lbxData.Size = new System.Drawing.Size(120, 95);
            this.lbxData.TabIndex = 1;
            // 
            // btnNames
            // 
            this.btnNames.Location = new System.Drawing.Point(13, 143);
            this.btnNames.Name = "btnNames";
            this.btnNames.Size = new System.Drawing.Size(120, 23);
            this.btnNames.TabIndex = 2;
            this.btnNames.Text = "Names";
            this.btnNames.UseVisualStyleBackColor = true;
            this.btnNames.Click += new System.EventHandler(this.BtnNames_Click);
            // 
            // btnFetch
            // 
            this.btnFetch.Location = new System.Drawing.Point(13, 172);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(84, 23);
            this.btnFetch.TabIndex = 3;
            this.btnFetch.Text = "Fetch name";
            this.btnFetch.UseVisualStyleBackColor = true;
            this.btnFetch.Click += new System.EventHandler(this.BtnFetch_Click);
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(103, 175);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(33, 20);
            this.txtIndex.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(13, 201);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(120, 20);
            this.txtName.TabIndex = 5;
            // 
            // FrmArrays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(148, 227);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtIndex);
            this.Controls.Add(this.btnFetch);
            this.Controls.Add(this.btnNames);
            this.Controls.Add(this.lbxData);
            this.Controls.Add(this.btnNumbers);
            this.Name = "FrmArrays";
            this.Text = "Arrays01";
            this.Load += new System.EventHandler(this.FrmArrays_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNumbers;
        private System.Windows.Forms.ListBox lbxData;
        private System.Windows.Forms.Button btnNames;
        private System.Windows.Forms.Button btnFetch;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.TextBox txtName;
    }
}


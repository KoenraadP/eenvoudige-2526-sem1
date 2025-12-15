namespace Arrays_Les10
{
    partial class Frm_Arrays_Les10
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
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnFirst3 = new System.Windows.Forms.Button();
            this.lbxRandom = new System.Windows.Forms.ListBox();
            this.lbxSorted = new System.Windows.Forms.ListBox();
            this.lbxFirst3 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(13, 13);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(75, 23);
            this.btnRandom.TabIndex = 0;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.BtnRandom_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(94, 13);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 1;
            this.btnSort.Text = "Sorteren";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.BtnSort_Click);
            // 
            // btnFirst3
            // 
            this.btnFirst3.Location = new System.Drawing.Point(175, 13);
            this.btnFirst3.Name = "btnFirst3";
            this.btnFirst3.Size = new System.Drawing.Size(75, 23);
            this.btnFirst3.TabIndex = 2;
            this.btnFirst3.Text = "Eerste drie";
            this.btnFirst3.UseVisualStyleBackColor = true;
            this.btnFirst3.Click += new System.EventHandler(this.BtnFirst3_Click);
            // 
            // lbxRandom
            // 
            this.lbxRandom.FormattingEnabled = true;
            this.lbxRandom.Location = new System.Drawing.Point(12, 42);
            this.lbxRandom.Name = "lbxRandom";
            this.lbxRandom.Size = new System.Drawing.Size(75, 147);
            this.lbxRandom.TabIndex = 3;
            // 
            // lbxSorted
            // 
            this.lbxSorted.FormattingEnabled = true;
            this.lbxSorted.Location = new System.Drawing.Point(94, 42);
            this.lbxSorted.Name = "lbxSorted";
            this.lbxSorted.Size = new System.Drawing.Size(75, 147);
            this.lbxSorted.TabIndex = 4;
            // 
            // lbxFirst3
            // 
            this.lbxFirst3.FormattingEnabled = true;
            this.lbxFirst3.Location = new System.Drawing.Point(175, 42);
            this.lbxFirst3.Name = "lbxFirst3";
            this.lbxFirst3.Size = new System.Drawing.Size(75, 147);
            this.lbxFirst3.TabIndex = 5;
            // 
            // Frm_Arrays_Les10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 201);
            this.Controls.Add(this.lbxFirst3);
            this.Controls.Add(this.lbxSorted);
            this.Controls.Add(this.lbxRandom);
            this.Controls.Add(this.btnFirst3);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnRandom);
            this.Name = "Frm_Arrays_Les10";
            this.Text = "Arrays Les 10";
            this.Load += new System.EventHandler(this.Frm_Arrays_Les10_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnFirst3;
        private System.Windows.Forms.ListBox lbxRandom;
        private System.Windows.Forms.ListBox lbxSorted;
        private System.Windows.Forms.ListBox lbxFirst3;
    }
}


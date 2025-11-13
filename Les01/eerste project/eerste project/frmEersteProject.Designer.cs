namespace eerste_project
{
    partial class frmEersteProject
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
            this.btnFirstProject = new System.Windows.Forms.Button();
            this.txtFirstProject = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnFirstProject
            // 
            this.btnFirstProject.Location = new System.Drawing.Point(12, 12);
            this.btnFirstProject.Name = "btnFirstProject";
            this.btnFirstProject.Size = new System.Drawing.Size(100, 23);
            this.btnFirstProject.TabIndex = 0;
            this.btnFirstProject.Text = "Klik hier!";
            this.btnFirstProject.UseVisualStyleBackColor = true;
            this.btnFirstProject.Click += new System.EventHandler(this.BtnFirstProject_Click);
            // 
            // txtFirstProject
            // 
            this.txtFirstProject.Location = new System.Drawing.Point(12, 41);
            this.txtFirstProject.Name = "txtFirstProject";
            this.txtFirstProject.Size = new System.Drawing.Size(100, 20);
            this.txtFirstProject.TabIndex = 1;
            // 
            // frmEersteProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 73);
            this.Controls.Add(this.txtFirstProject);
            this.Controls.Add(this.btnFirstProject);
            this.Name = "frmEersteProject";
            this.Text = "Eerste project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFirstProject;
        private System.Windows.Forms.TextBox txtFirstProject;
    }
}


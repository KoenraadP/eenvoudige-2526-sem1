namespace Bestelling
{
    partial class FrmBestelling
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
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbxOrder = new System.Windows.Forms.ListBox();
            this.btnSummary = new System.Windows.Forms.Button();
            this.txtSummary = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Location = new System.Drawing.Point(13, 13);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(246, 23);
            this.btnNewOrder.TabIndex = 6;
            this.btnNewOrder.Text = "Nieuwe bestelling";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(13, 43);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(83, 20);
            this.txtItem.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 69);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Toevoegen";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(13, 98);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Verwijderen";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // lbxOrder
            // 
            this.lbxOrder.FormattingEnabled = true;
            this.lbxOrder.Location = new System.Drawing.Point(13, 128);
            this.lbxOrder.Name = "lbxOrder";
            this.lbxOrder.Size = new System.Drawing.Size(83, 134);
            this.lbxOrder.TabIndex = 5;
            // 
            // btnSummary
            // 
            this.btnSummary.Location = new System.Drawing.Point(102, 43);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(157, 23);
            this.btnSummary.TabIndex = 3;
            this.btnSummary.Text = "Overzicht bestelling";
            this.btnSummary.UseVisualStyleBackColor = true;
            // 
            // txtSummary
            // 
            this.txtSummary.Location = new System.Drawing.Point(103, 71);
            this.txtSummary.Multiline = true;
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.Size = new System.Drawing.Size(156, 191);
            this.txtSummary.TabIndex = 4;
            // 
            // FrmBestelling
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 276);
            this.Controls.Add(this.txtSummary);
            this.Controls.Add(this.btnSummary);
            this.Controls.Add(this.lbxOrder);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.btnNewOrder);
            this.Name = "FrmBestelling";
            this.Text = "Bestelling";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox lbxOrder;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.TextBox txtSummary;
    }
}


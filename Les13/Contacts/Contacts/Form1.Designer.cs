namespace Contacts
{
    partial class Form1
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
            this.lbxContacts = new System.Windows.Forms.ListBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtBirthDate = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.cbxColleague = new System.Windows.Forms.ComboBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbxContacts
            // 
            this.lbxContacts.FormattingEnabled = true;
            this.lbxContacts.Location = new System.Drawing.Point(13, 13);
            this.lbxContacts.Name = "lbxContacts";
            this.lbxContacts.Size = new System.Drawing.Size(137, 264);
            this.lbxContacts.TabIndex = 0;
            this.lbxContacts.SelectedIndexChanged += new System.EventHandler(this.LbxContacts_SelectedIndexChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(156, 13);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(156, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.Location = new System.Drawing.Point(156, 65);
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.Size = new System.Drawing.Size(156, 20);
            this.txtBirthDate.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(156, 91);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(156, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // txtPlace
            // 
            this.txtPlace.Location = new System.Drawing.Point(156, 117);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(156, 20);
            this.txtPlace.TabIndex = 5;
            // 
            // cbxColleague
            // 
            this.cbxColleague.FormattingEnabled = true;
            this.cbxColleague.Items.AddRange(new object[] {
            "Geen collega",
            "Collega"});
            this.cbxColleague.Location = new System.Drawing.Point(156, 143);
            this.cbxColleague.Name = "cbxColleague";
            this.cbxColleague.Size = new System.Drawing.Size(156, 21);
            this.cbxColleague.TabIndex = 6;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(156, 170);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(156, 23);
            this.btnNew.TabIndex = 7;
            this.btnNew.Text = "Nieuwe persoon";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(156, 199);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(156, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Toevoegen";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(156, 228);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(156, 23);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Wijzigen";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(156, 257);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(156, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Verwijderen";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(156, 39);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(156, 20);
            this.txtLastName.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 295);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.cbxColleague);
            this.Controls.Add(this.txtPlace);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtBirthDate);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lbxContacts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxContacts;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtBirthDate;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPlace;
        private System.Windows.Forms.ComboBox cbxColleague;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtLastName;
    }
}



namespace Question2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblFullNames = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblApplicationResults = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(34, 39);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(70, 20);
            this.lblSurname.TabIndex = 0;
            this.lblSurname.Text = "Surname:";
            // 
            // lblFullNames
            // 
            this.lblFullNames.AutoSize = true;
            this.lblFullNames.Location = new System.Drawing.Point(34, 89);
            this.lblFullNames.Name = "lblFullNames";
            this.lblFullNames.Size = new System.Drawing.Size(85, 20);
            this.lblFullNames.TabIndex = 1;
            this.lblFullNames.Text = "Full Names:";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(34, 134);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(131, 20);
            this.lblContact.TabIndex = 2;
            this.lblContact.Text = "Contact Numbers :";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(34, 184);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(60, 20);
            this.lblGender.TabIndex = 3;
            this.lblGender.Text = "Gender:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(199, 36);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(213, 27);
            this.txtSurname.TabIndex = 4;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(199, 86);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(213, 27);
            this.txtFullName.TabIndex = 5;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(199, 131);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(213, 27);
            this.txtContact.TabIndex = 6;
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male ",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(199, 184);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(213, 28);
            this.cmbGender.TabIndex = 7;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(458, 54);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(308, 279);
            this.txtResult.TabIndex = 8;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(34, 304);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(94, 29);
            this.btnCreate.TabIndex = 9;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(148, 304);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(109, 29);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblApplicationResults
            // 
            this.lblApplicationResults.AutoSize = true;
            this.lblApplicationResults.Location = new System.Drawing.Point(458, 9);
            this.lblApplicationResults.Name = "lblApplicationResults";
            this.lblApplicationResults.Size = new System.Drawing.Size(135, 20);
            this.lblApplicationResults.TabIndex = 11;
            this.lblApplicationResults.Text = "ApplicationResults:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(291, 303);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 29);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear ";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblApplicationResults);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblFullNames);
            this.Controls.Add(this.lblSurname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblFullNames;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblApplicationResults;
        private System.Windows.Forms.Button btnClear;
    }
}


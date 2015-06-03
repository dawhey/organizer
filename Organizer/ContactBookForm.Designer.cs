namespace Organizer
{
    partial class ContactBookForm
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
            this.ButtonAddContact = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonAddContact
            // 
            this.ButtonAddContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonAddContact.Location = new System.Drawing.Point(132, 603);
            this.ButtonAddContact.Name = "ButtonAddContact";
            this.ButtonAddContact.Size = new System.Drawing.Size(257, 43);
            this.ButtonAddContact.TabIndex = 0;
            this.ButtonAddContact.Text = "Add New Contact";
            this.ButtonAddContact.UseVisualStyleBackColor = true;
            this.ButtonAddContact.Click += new System.EventHandler(this.AddContactClick);
            // 
            // ContactBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 682);
            this.Controls.Add(this.ButtonAddContact);
            this.Name = "ContactBookForm";
            this.Text = "Contact Book";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ContactBook_FormClosing);
            this.Load += new System.EventHandler(this.ContactBook_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonAddContact;
    }
}
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.ContactListBox = new System.Windows.Forms.GroupBox();
            this.ContactListView = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.ContactListBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonAddContact
            // 
            this.ButtonAddContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonAddContact.Location = new System.Drawing.Point(84, 615);
            this.ButtonAddContact.Name = "ButtonAddContact";
            this.ButtonAddContact.Size = new System.Drawing.Size(257, 43);
            this.ButtonAddContact.TabIndex = 0;
            this.ButtonAddContact.Text = "Add New Contact";
            this.ButtonAddContact.UseVisualStyleBackColor = true;
            this.ButtonAddContact.Click += new System.EventHandler(this.AddContactClick);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // ContactListBox
            // 
            this.ContactListBox.Controls.Add(this.ContactListView);
            this.ContactListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ContactListBox.Location = new System.Drawing.Point(12, 12);
            this.ContactListBox.Name = "ContactListBox";
            this.ContactListBox.Size = new System.Drawing.Size(428, 586);
            this.ContactListBox.TabIndex = 1;
            this.ContactListBox.TabStop = false;
            this.ContactListBox.Text = "Contact List";
            // 
            // ContactListView
            // 
            this.ContactListView.Location = new System.Drawing.Point(6, 25);
            this.ContactListView.Name = "ContactListView";
            this.ContactListView.Size = new System.Drawing.Size(407, 452);
            this.ContactListView.TabIndex = 0;
            this.ContactListView.UseCompatibleStateImageBehavior = false;
            this.ContactListView.View = System.Windows.Forms.View.List;
            this.ContactListView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ContactBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 682);
            this.Controls.Add(this.ContactListBox);
            this.Controls.Add(this.ButtonAddContact);
            this.Name = "ContactBookForm";
            this.Text = "Contact Book";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ContactBook_FormClosing);
            this.Load += new System.EventHandler(this.ContactBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ContactListBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonAddContact;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.GroupBox ContactListBox;
        public System.Windows.Forms.ListView ContactListView;
    }
}
﻿namespace Organizer
{
    partial class OpeningForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_contacts = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(184, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Module:  ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_contacts
            // 
            this.button_contacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_contacts.Location = new System.Drawing.Point(12, 151);
            this.button_contacts.Name = "button_contacts";
            this.button_contacts.Size = new System.Drawing.Size(173, 225);
            this.button_contacts.TabIndex = 1;
            this.button_contacts.Text = "Contact Book";
            this.button_contacts.UseVisualStyleBackColor = true;
            this.button_contacts.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(191, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 225);
            this.button2.TabIndex = 2;
            this.button2.Text = "Calendar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(380, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(181, 225);
            this.button3.TabIndex = 3;
            this.button3.Text = "Shopping List";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // OpeningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 472);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_contacts);
            this.Controls.Add(this.label1);
            this.Name = "OpeningForm";
            this.Text = "Organizer";
            this.Load += new System.EventHandler(this.Select_module_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_contacts;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}


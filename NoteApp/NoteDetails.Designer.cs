
namespace NoteApp
{
    partial class NoteDetails
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
            this.saveNoteBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.noteTitleTB = new System.Windows.Forms.TextBox();
            this.noteBodyTB = new System.Windows.Forms.TextBox();
            this.noteDateTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // saveNoteBtn
            // 
            this.saveNoteBtn.Location = new System.Drawing.Point(586, 301);
            this.saveNoteBtn.Name = "saveNoteBtn";
            this.saveNoteBtn.Size = new System.Drawing.Size(90, 25);
            this.saveNoteBtn.TabIndex = 3;
            this.saveNoteBtn.Text = "Save";
            this.saveNoteBtn.UseVisualStyleBackColor = true;
            this.saveNoteBtn.Click += new System.EventHandler(this.editNoteBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(682, 301);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(90, 25);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.closeNoteBtn_Click);
            // 
            // noteTitleTB
            // 
            this.noteTitleTB.BackColor = System.Drawing.Color.White;
            this.noteTitleTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.noteTitleTB.ForeColor = System.Drawing.Color.Black;
            this.noteTitleTB.Location = new System.Drawing.Point(12, 12);
            this.noteTitleTB.Name = "noteTitleTB";
            this.noteTitleTB.ReadOnly = true;
            this.noteTitleTB.Size = new System.Drawing.Size(760, 26);
            this.noteTitleTB.TabIndex = 12;
            this.noteTitleTB.TabStop = false;
            // 
            // noteBodyTB
            // 
            this.noteBodyTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.noteBodyTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.noteBodyTB.ForeColor = System.Drawing.Color.White;
            this.noteBodyTB.Location = new System.Drawing.Point(12, 44);
            this.noteBodyTB.Multiline = true;
            this.noteBodyTB.Name = "noteBodyTB";
            this.noteBodyTB.ReadOnly = true;
            this.noteBodyTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.noteBodyTB.Size = new System.Drawing.Size(760, 251);
            this.noteBodyTB.TabIndex = 11;
            this.noteBodyTB.TabStop = false;
            // 
            // noteDateTB
            // 
            this.noteDateTB.BackColor = System.Drawing.Color.Black;
            this.noteDateTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.noteDateTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.noteDateTB.ForeColor = System.Drawing.Color.White;
            this.noteDateTB.Location = new System.Drawing.Point(12, 301);
            this.noteDateTB.Name = "noteDateTB";
            this.noteDateTB.ReadOnly = true;
            this.noteDateTB.Size = new System.Drawing.Size(481, 22);
            this.noteDateTB.TabIndex = 13;
            this.noteDateTB.TabStop = false;
            this.noteDateTB.Text = "Note date";
            // 
            // NoteDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(783, 339);
            this.Controls.Add(this.noteDateTB);
            this.Controls.Add(this.noteTitleTB);
            this.Controls.Add(this.noteBodyTB);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveNoteBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NoteDetails";
            this.Text = "Note details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveNoteBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TextBox noteTitleTB;
        private System.Windows.Forms.TextBox noteBodyTB;
        private System.Windows.Forms.TextBox noteDateTB;
    }
}
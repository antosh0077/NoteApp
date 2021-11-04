
namespace NoteApp
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.notesPanel = new System.Windows.Forms.Panel();
            this.showAllNotesBtn = new System.Windows.Forms.Button();
            this.addNoteBtn = new System.Windows.Forms.Button();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.infoTB = new System.Windows.Forms.TextBox();
            this.hintTB = new System.Windows.Forms.TextBox();
            this.HelpToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // notesPanel
            // 
            this.notesPanel.AutoScroll = true;
            this.notesPanel.Location = new System.Drawing.Point(0, 83);
            this.notesPanel.Name = "notesPanel";
            this.notesPanel.Size = new System.Drawing.Size(883, 326);
            this.notesPanel.TabIndex = 0;
            // 
            // showAllNotesBtn
            // 
            this.showAllNotesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showAllNotesBtn.Location = new System.Drawing.Point(83, 12);
            this.showAllNotesBtn.Name = "showAllNotesBtn";
            this.showAllNotesBtn.Size = new System.Drawing.Size(123, 65);
            this.showAllNotesBtn.TabIndex = 2;
            this.showAllNotesBtn.Text = "Show all";
            this.HelpToolTip.SetToolTip(this.showAllNotesBtn, "Show all saved notes");
            this.showAllNotesBtn.UseVisualStyleBackColor = true;
            this.showAllNotesBtn.Visible = false;
            this.showAllNotesBtn.Click += new System.EventHandler(this.showAllNotesBtn_Click);
            // 
            // addNoteBtn
            // 
            this.addNoteBtn.BackColor = System.Drawing.Color.Black;
            this.addNoteBtn.FlatAppearance.BorderSize = 0;
            this.addNoteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNoteBtn.ForeColor = System.Drawing.Color.Black;
            this.addNoteBtn.Image = global::NoteApp.Properties.Resources.add;
            this.addNoteBtn.Location = new System.Drawing.Point(12, 12);
            this.addNoteBtn.Name = "addNoteBtn";
            this.addNoteBtn.Size = new System.Drawing.Size(65, 65);
            this.addNoteBtn.TabIndex = 1;
            this.HelpToolTip.SetToolTip(this.addNoteBtn, "Create new note");
            this.addNoteBtn.UseVisualStyleBackColor = false;
            this.addNoteBtn.Click += new System.EventHandler(this.addNoteBtn_Click);
            // 
            // searchTB
            // 
            this.searchTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 38.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.searchTB.Location = new System.Drawing.Point(212, 12);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(531, 65);
            this.searchTB.TabIndex = 3;
            this.searchTB.Text = "search...";
            this.HelpToolTip.SetToolTip(this.searchTB, "Enter your search keyword");
            this.searchTB.Click += new System.EventHandler(this.searchTB_Click);
            this.searchTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTB_SomeKeyPressed);
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchBtn.Location = new System.Drawing.Point(749, 12);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(123, 65);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.Text = "Search";
            this.HelpToolTip.SetToolTip(this.searchBtn, "Click to search in all notes");
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // infoTB
            // 
            this.infoTB.BackColor = System.Drawing.Color.Black;
            this.infoTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.infoTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoTB.ForeColor = System.Drawing.Color.White;
            this.infoTB.Location = new System.Drawing.Point(12, 419);
            this.infoTB.Name = "infoTB";
            this.infoTB.ReadOnly = true;
            this.infoTB.Size = new System.Drawing.Size(251, 19);
            this.infoTB.TabIndex = 1;
            // 
            // hintTB
            // 
            this.hintTB.BackColor = System.Drawing.Color.Black;
            this.hintTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hintTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hintTB.ForeColor = System.Drawing.Color.White;
            this.hintTB.Location = new System.Drawing.Point(387, 419);
            this.hintTB.Name = "hintTB";
            this.hintTB.ReadOnly = true;
            this.hintTB.Size = new System.Drawing.Size(485, 19);
            this.hintTB.TabIndex = 5;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(884, 450);
            this.Controls.Add(this.hintTB);
            this.Controls.Add(this.infoTB);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.showAllNotesBtn);
            this.Controls.Add(this.addNoteBtn);
            this.Controls.Add(this.notesPanel);
            this.Name = "Main";
            this.Text = "Notes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel notesPanel;
        private System.Windows.Forms.Button addNoteBtn;
        private System.Windows.Forms.Button showAllNotesBtn;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox infoTB;
        private System.Windows.Forms.TextBox hintTB;
        private System.Windows.Forms.ToolTip HelpToolTip;
    }
}


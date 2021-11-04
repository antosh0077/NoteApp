
namespace NoteApp
{
    partial class NoteForm
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
            this.titleTB = new System.Windows.Forms.TextBox();
            this.noteBodyTB = new System.Windows.Forms.TextBox();
            this.noteDateTB = new System.Windows.Forms.TextBox();
            this.noteDeleteBtn = new System.Windows.Forms.Button();
            this.noteEditBtn = new System.Windows.Forms.Button();
            this.noteDetailsBtn = new System.Windows.Forms.Button();
            this.helpToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // titleTB
            // 
            this.titleTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.titleTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titleTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleTB.ForeColor = System.Drawing.Color.White;
            this.titleTB.Location = new System.Drawing.Point(12, 12);
            this.titleTB.Name = "titleTB";
            this.titleTB.ReadOnly = true;
            this.titleTB.Size = new System.Drawing.Size(581, 28);
            this.titleTB.TabIndex = 0;
            this.titleTB.Text = "Title";
            // 
            // noteBodyTB
            // 
            this.noteBodyTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.noteBodyTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.noteBodyTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.noteBodyTB.ForeColor = System.Drawing.Color.White;
            this.noteBodyTB.Location = new System.Drawing.Point(12, 44);
            this.noteBodyTB.Name = "noteBodyTB";
            this.noteBodyTB.ReadOnly = true;
            this.noteBodyTB.Size = new System.Drawing.Size(581, 19);
            this.noteBodyTB.TabIndex = 2;
            this.noteBodyTB.Text = "Note body";
            // 
            // noteDateTB
            // 
            this.noteDateTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.noteDateTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.noteDateTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.noteDateTB.ForeColor = System.Drawing.Color.White;
            this.noteDateTB.Location = new System.Drawing.Point(12, 73);
            this.noteDateTB.Name = "noteDateTB";
            this.noteDateTB.ReadOnly = true;
            this.noteDateTB.Size = new System.Drawing.Size(581, 15);
            this.noteDateTB.TabIndex = 6;
            this.noteDateTB.Text = "Note date";
            // 
            // noteDeleteBtn
            // 
            this.noteDeleteBtn.FlatAppearance.BorderSize = 0;
            this.noteDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noteDeleteBtn.Image = global::NoteApp.Properties.Resources.delete;
            this.noteDeleteBtn.Location = new System.Drawing.Point(763, 12);
            this.noteDeleteBtn.Name = "noteDeleteBtn";
            this.noteDeleteBtn.Size = new System.Drawing.Size(76, 76);
            this.noteDeleteBtn.TabIndex = 5;
            this.helpToolTip.SetToolTip(this.noteDeleteBtn, "Click to delete this note");
            this.noteDeleteBtn.UseVisualStyleBackColor = true;
            this.noteDeleteBtn.Click += new System.EventHandler(this.noteDeleteBtn_Click);
            // 
            // noteEditBtn
            // 
            this.noteEditBtn.FlatAppearance.BorderSize = 0;
            this.noteEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noteEditBtn.Image = global::NoteApp.Properties.Resources.edit;
            this.noteEditBtn.Location = new System.Drawing.Point(681, 12);
            this.noteEditBtn.Name = "noteEditBtn";
            this.noteEditBtn.Size = new System.Drawing.Size(76, 76);
            this.noteEditBtn.TabIndex = 4;
            this.helpToolTip.SetToolTip(this.noteEditBtn, "Click to edit this note");
            this.noteEditBtn.UseVisualStyleBackColor = true;
            this.noteEditBtn.Click += new System.EventHandler(this.noteDetailsOrEditBtn_Click);
            // 
            // noteDetailsBtn
            // 
            this.noteDetailsBtn.FlatAppearance.BorderSize = 0;
            this.noteDetailsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noteDetailsBtn.Image = global::NoteApp.Properties.Resources.details;
            this.noteDetailsBtn.Location = new System.Drawing.Point(599, 12);
            this.noteDetailsBtn.Name = "noteDetailsBtn";
            this.noteDetailsBtn.Size = new System.Drawing.Size(76, 76);
            this.noteDetailsBtn.TabIndex = 3;
            this.helpToolTip.SetToolTip(this.noteDetailsBtn, "Click to see details");
            this.noteDetailsBtn.UseVisualStyleBackColor = true;
            this.noteDetailsBtn.Click += new System.EventHandler(this.noteDetailsOrEditBtn_Click);
            // 
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(850, 100);
            this.Controls.Add(this.noteDateTB);
            this.Controls.Add(this.noteDeleteBtn);
            this.Controls.Add(this.noteEditBtn);
            this.Controls.Add(this.noteDetailsBtn);
            this.Controls.Add(this.noteBodyTB);
            this.Controls.Add(this.titleTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NoteForm";
            this.Text = "Note";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox titleTB;
        public System.Windows.Forms.TextBox noteBodyTB;
        public System.Windows.Forms.Button noteDetailsBtn;
        public System.Windows.Forms.Button noteEditBtn;
        public System.Windows.Forms.Button noteDeleteBtn;
        public System.Windows.Forms.TextBox noteDateTB;
        private System.Windows.Forms.ToolTip helpToolTip;
    }
}
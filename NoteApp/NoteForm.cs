using NoteApp.Library;
using NoteApp.Library.Models;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace NoteApp
{
    public partial class NoteForm : Form
    {
        NoteManager noteManager = new NoteManager();
        /// <summary>
        /// For rounded form
        /// </summary>        
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        public NoteForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;// For rounded form
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));// For rounded form 
            this.TopLevel = false;
        }
        public int Id { get; set; }
        private void noteDetailsOrEditBtn_Click(object sender, EventArgs e)
        {
            Note note = noteManager.Get(Id);
            NoteDetails noteDetails = new NoteDetails(sender, note);
            noteDetails.Show();
        }

        private void noteDeleteBtn_Click(object sender, EventArgs e)
        {
            Note note = noteManager.Get(Id);
            string noteInfo = "Title: " + note.Title + Environment.NewLine + "Crtated: " + note.Date.ToString() + Environment.NewLine + Environment.NewLine;
            DialogResult dialogResult = MessageBox.Show(noteInfo + "Are you sure want to delete this note?", "Delete note", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                noteManager.Remove(note);
            }
        }
    }
}

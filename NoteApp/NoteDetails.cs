using NoteApp.Library;
using NoteApp.Library.Models;
using System;
using System.Windows.Forms;

namespace NoteApp
{
    public partial class NoteDetails : Form
    {
        Note _note;        
        Button button;
        
        public NoteDetails(object sender, Note note)
        {
            InitializeComponent();
            button = (Button)sender;
            Init(button, note);
            _note = note;
        }

        private void Init(Button button, Note note)
        {

            if (button.Name == "noteDetailsBtn")
            {
                this.Text = "Note details";
                saveNoteBtn.Visible = false;
                cancelBtn.Text = "Close";
                noteTitleTB.Text = note.Title;
                noteBodyTB.Text = note.Body;
                noteDateTB.Text = "Note created: " + note.Date.ToString();
                noteBodyTB.ReadOnly = true;
                noteTitleTB.ReadOnly = true;
            }
            else if ((button.Name == "noteEditBtn"))
            {
                this.Text = "Edit note";
                noteTitleTB.Text = note.Title;
                noteBodyTB.Text = note.Body;
                noteDateTB.Text = "Note created: " + note.Date.ToString();
                noteBodyTB.ReadOnly = false;
                noteTitleTB.ReadOnly = false;
            }
            else if ((button.Name == "addNoteBtn"))
            {
                this.Text = "Create note";
                noteDateTB.Text = "";
                noteBodyTB.ReadOnly = false;
                noteTitleTB.ReadOnly = false;
            }
            else return;
        }

        private void editNoteBtn_Click(object sender, System.EventArgs e)
        {
            NoteManager noteManager = new NoteManager();
            if (noteTitleTB.Text == string.Empty && noteBodyTB.Text == string.Empty) return;
            if (noteTitleTB.Text == string.Empty)
                _note.Title = "Untitled";
            else
                _note.Title = noteTitleTB.Text;
            _note.Body = noteBodyTB.Text;
            if (_note.Id == 0)
            {
                _note.Date = DateTime.Now;
                noteManager.Add(_note);
            }
            else
                noteManager.Update(_note);
            this.Close();
        }

        private void closeNoteBtn_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}

using NoteApp.Library;
using NoteApp.Library.Helpers;
using NoteApp.Library.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteApp
{
    public partial class Main : Form
    {
        NoteFormManager formManager = new NoteFormManager();
        NoteManager noteManager;
        public Main()
        {
            InitializeComponent();
            noteManager = new NoteManager();
            SQLHelper.DatabaseChanged += ShowAllNotes;
            ShowAllNotes();
            searchBtn.Enabled = false;
            infoTB.Text = $"You have {noteManager.GetAll().Count} saved notes.";
        }      

        private void addNoteBtn_Click(object sender, EventArgs e)
        {
            Note note = new Note();
            NoteDetails noteDetails = new NoteDetails(sender, note);
            noteDetails.Show();
        }

        private void showAllNotesBtn_Click(object sender, EventArgs e)
        {
            ShowAllNotes();
            showAllNotesBtn.Visible = false;
            hintTB.Text = string.Empty;
        }

        private void searchTB_Click(object sender, EventArgs e)
        {
            searchTB.Text = string.Empty;
            searchTB.ForeColor = Color.Black;
            searchTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 38.25F, System.Drawing.FontStyle.Regular);
            hintTB.Text = "Hint: If you wona search by note date, please type like 08/17/2012";
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            ShowSearchResults(searchTB.Text);
            showAllNotesBtn.Visible = true;
            hintTB.Text = string.Empty;
        }

        private void searchTB_SomeKeyPressed(object sender, KeyEventArgs e)
        {
            searchTB.ForeColor = Color.Black;
            searchTB.Font = new Font("Microsoft Sans Serif", 38.25F, System.Drawing.FontStyle.Regular);

            if (searchTB.Text != "search..." && searchTB.Text != string.Empty)
            {
                searchBtn.Enabled = true;
            }
            if (e.KeyCode == Keys.Enter)
                searchBtn_Click(sender, e);
        }

        public void ShowAllNotes()
        {
            var allNotes = noteManager.GetAll();
            var notesAsForms = formManager.GetNotesAsForms(allNotes).ToArray();
            UpdatePanel(notesAsForms);
            infoTB.Text = $"You have {allNotes.Count} saved notes.";
        }

        private void ShowSearchResults(string keyword)
        {
            var searchResults = noteManager.Search(keyword);
            var notesAsForms = formManager.GetNotesAsForms(searchResults).ToArray();
            UpdatePanel(notesAsForms);
            infoTB.Text = $"Search result {searchResults.Count} notes.";
        }

        private void UpdatePanel(NoteForm[] notes)
        {
            notesPanel.Controls.Clear();
            notesPanel.Controls.AddRange(notes);
        }
    }
}

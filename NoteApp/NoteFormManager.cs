using NoteApp.Library.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteApp
{
    class NoteFormManager
    {      
        public List<NoteForm> GetNotesAsForms(List<Note> notes)
        {
            List<NoteForm> noteForms = new List<NoteForm>();
            int currentIndx = 0;
            noteForms.Clear();
            foreach (var note in notes)
            {
                NoteForm form = new NoteForm();
                int titleLblCanHoldSymbols = HowManySymbolsCanHold(form.titleTB, note.Title);
                if (note.Title.Length > titleLblCanHoldSymbols)
                    form.titleTB.Text = note.Title.Substring(0, titleLblCanHoldSymbols - 3) + "...";
                else
                    form.titleTB.Text = note.Title;

                int bodyLblCanHoldSymbols = HowManySymbolsCanHold(form.noteBodyTB, note.Body);
                if (note.Body.Length > bodyLblCanHoldSymbols)
                    form.noteBodyTB.Text = note.Body.Substring(0, bodyLblCanHoldSymbols - 3) + "...";
                else
                    form.noteBodyTB.Text = note.Body;
                form.noteDateTB.Text = note.Date.ToString();
                form.Location = new Point(10, 10 + (form.Height + 10) * currentIndx++);
                form.Id = note.Id;
                form.Show();
                noteForms.Add(form);
            }
            return noteForms;
        }
        private int HowManySymbolsCanHold(TextBox label, string text)
        {
            int count = 0;
            Size avg;

            for (int i = 0; i < text.Length; i++)
            {
                avg = TextRenderer.MeasureText(text.Substring(0, i), label.Font);
                if (avg.Width > label.Size.Width)
                {
                    count = i;
                    break;
                }
            }
            if (count == 0)
                return text.Length;
            else
                return count;
        }
    }
}

using NoteApp.Library.Helpers;
using NoteApp.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp.Library
{
    public class NoteManager
    {
        public void Add(Note note)
        {
            SQLHelper.Add(note);
        }

        public Note Get(int id)
        {
            return SQLHelper.Get(id);
        }

        public List<Note> GetAll()
        {
            return SQLHelper.GetAll();
        }

        public void Remove(Note note)
        {
            SQLHelper.Delete(note);
        }

        public List<Note> Search(string keyword)
        {
            return SQLHelper.Search(keyword);
        }

        public void Update(Note note)
        {
            SQLHelper.Edit(note);
        }
    }

    //public interface INoteManager
    //{
    //    void Add(Note note);
    //    void Remove(Note note);
    //    void Update(Note note);
    //    List<Note> GetAll();
    //    Note Get(int id);
    //    List<Note> Search(string keyword);
    //}
}

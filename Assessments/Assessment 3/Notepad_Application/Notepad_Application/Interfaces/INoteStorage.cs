using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Notepad_Application.Models;

namespace Notepad_Application.Interfaces
{
    internal interface INoteStorage
    {
        void CreateNote(Note note);
        List<Note> ViewAllNotes();
        void UpdateNote(int noteId, string title, string content, DateTime updatedAt);
        void DeleteNote(int noteId);
    }
}

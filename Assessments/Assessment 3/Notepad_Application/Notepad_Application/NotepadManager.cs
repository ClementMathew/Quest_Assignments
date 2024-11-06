using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Appender;
using log4net.Config;
using log4net.Layout;
using log4net.Repository;
using Notepad_Application.Interfaces;
using Notepad_Application.Models;
using Notepad_Application.Services;

namespace Notepad_Application
{
    internal class NotepadManager
    {
        private readonly INoteStorage _noteStorage;
        private static readonly ILog log = LogManager.GetLogger(typeof(NotepadManager));

        public NotepadManager(INoteStorage noteStorage)
        {
            _noteStorage = noteStorage;
            LoggingService.ConfigureLogging();
        }

        public void CreateNote()
        {
            try
            {
                var note = new Note();

                Console.Write("\nEnter Note Id : ");
                note.NoteId = int.Parse(Console.ReadLine());

                Console.Write("Enter Title : ");
                note.Title = Console.ReadLine();

                Console.Write("Enter Content : ");
                note.Content = Console.ReadLine();

                note.CreatedAt = DateTime.Now;
                note.UpdatedAt = DateTime.Now;

                _noteStorage.CreateNote(note);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                log.Error("Error in Adding Note", e);
            }
        }
        public void ViewAllNotes()
        {
            try
            {
                var notes = _noteStorage.ViewAllNotes();

                Console.WriteLine("\n--- Notes ---\n");

                foreach (var note in notes)
                {
                    var content = FormatService.FormatText(note.Content);
                    Console.WriteLine($"{note.NoteId} - {note.Title} - {content} - {note.CreatedAt} - {note.UpdatedAt}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                log.Error("Error in Viewing Note", e);
            }
        }

        public void UpdateNote()
        {
            try
            {
                var notes = _noteStorage.ViewAllNotes();

                Console.WriteLine("\n--- Notes ---\n");

                foreach (var note in notes)
                {
                    var contentView = FormatService.FormatText(note.Content);
                    Console.WriteLine($"{note.NoteId} - {note.Title} - {contentView}");
                }

                Console.Write("\nEnter Note Id : ");
                int noteId = int.Parse(Console.ReadLine());

                Console.WriteLine($"\n--- Note - {noteId} ---\n");

                bool noteFound = false;

                foreach (var note in notes)
                {
                    if (noteId == note.NoteId)
                    {
                        var contentUpdate = FormatService.FormatText(note.Content);
                        Console.WriteLine($"{note.Title} - {contentUpdate}");
                        noteFound = true;
                        break;
                    }
                }

                if (!noteFound)
                {
                    Console.WriteLine("No such note...");
                    return;
                }

                Console.Write("\nEnter new Title : ");
                string title = Console.ReadLine();

                Console.Write("Enter new Content : ");
                string content = Console.ReadLine();

                DateTime updatedAt = DateTime.Now;

                _noteStorage.UpdateNote(noteId, title, content, updatedAt);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                log.Error("Error in Updating Note", e);
            }
        }
        public void DeleteNote()
        {
            try
            {
                var notes = _noteStorage.ViewAllNotes();

                Console.WriteLine("\n--- Notes ---\n");

                foreach (var note in notes)
                {
                    var contentView = FormatService.FormatText(note.Content);
                    Console.WriteLine($"{note.NoteId} - {note.Title} - {contentView}");
                }

                Console.Write("\nEnter Note Id : ");
                int noteId = int.Parse(Console.ReadLine());

                Console.WriteLine("\nAre you sure...?\n1. Yes\n2. No");

                Console.Write("\nEnter option : ");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    _noteStorage.DeleteNote(noteId);
                }
                else
                {
                    return;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                log.Error("Error in Deleting Note", e);
            }
        }
    }
}

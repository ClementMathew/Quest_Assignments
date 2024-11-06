using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Notepad_Application.Interfaces;
using Notepad_Application.Repositories;

namespace Notepad_Application
{
    internal class UserManager
    {
        public NotepadManager manager;

        public void InitiateRepository()
        {
            var noteStorage = new DatabaseNoteStorage();
            manager = new NotepadManager(noteStorage);
        }

        public void DisplayOptions()
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n1. Create a new note");
                Console.WriteLine("2. View all notes");
                Console.WriteLine("3. Update an existing note");
                Console.WriteLine("4. Delete a note");
                Console.WriteLine("5. Exit the application");

                Console.Write("\nChoose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        manager.CreateNote();
                        break;

                    case "2":
                        manager.ViewAllNotes();
                        break;

                    case "3":
                        manager.UpdateNote();
                        break;

                    case "4":
                        manager.DeleteNote();
                        break;

                    case "5":
                        running = false;
                        Console.WriteLine("Exiting the application.");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please choose again.");
                        break;
                }
            }
        }
    }
}

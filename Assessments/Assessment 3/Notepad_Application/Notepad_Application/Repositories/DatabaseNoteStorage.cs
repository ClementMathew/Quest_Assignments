using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Xml.Linq;
using log4net;
using Notepad_Application.Interfaces;
using Notepad_Application.Models;
using Notepad_Application.Settings;

namespace Notepad_Application.Repositories
{
    internal class DatabaseNoteStorage : INoteStorage
    {
        private readonly SqlConnection _connection;
        private static readonly ILog log = LogManager.GetLogger(typeof(DatabaseNoteStorage));

        public DatabaseNoteStorage()
        {
            _connection = new SqlConnection(AppSettings.ConnectionString);
        }

        private void ConnectionCheck()
        {
            if (_connection.State != ConnectionState.Open)
            {
                _connection.Open();
            }
        }

        public void CreateNote(Note note)
        {
            try
            {
                ConnectionCheck();

                var sql = "INSERT INTO Notes (NoteId, Title, Content, CreatedAt, UpdatedAt) VALUES (@NoteId, @Title, @Content, @CreatedAt, @UpdatedAt)";
                var command = new SqlCommand(sql, _connection);

                command.Parameters.AddWithValue("@NoteId", note.NoteId);
                command.Parameters.AddWithValue("@Title", note.Title);
                command.Parameters.AddWithValue("@Content", note.Content);
                command.Parameters.AddWithValue("@CreatedAt", note.CreatedAt);
                command.Parameters.AddWithValue("@UpdatedAt", note.UpdatedAt);

                command.ExecuteNonQuery();

                log.Info($"Created note with ID {note.NoteId}.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                log.Error("Error in CreateNote", e);
            }
            finally
            {
                _connection.Close();
            }
        }

        public List<Note> ViewAllNotes()
        {
            var notes = new List<Note>();

            try
            {
                ConnectionCheck();

                var sql = "SELECT NoteId, Title, Content, CreatedAt, UpdatedAt FROM Notes";
                var command = new SqlCommand(sql, _connection);

                var reader = command.ExecuteReader();


                while (reader.Read())
                {
                    notes.Add(new Note
                    {
                        NoteId = (int)reader["NoteId"],
                        Title = (string)reader["Title"],
                        Content = (string)reader["Content"],
                        CreatedAt = (DateTime)reader["CreatedAt"],
                        UpdatedAt = (DateTime)reader["UpdatedAt"],
                    });
                    log.Info($"Viewed Note : {(int)reader["NoteId"]}.");
                }
                log.Info($"Viewed all Notes.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                log.Error("Error in ViewAllNotes", e);
            }
            finally
            {
                _connection.Close();
            }
            return notes;
        }

        public void UpdateNote(int noteId, string title, string content, DateTime updatedAt)
        {
            try
            {
                ConnectionCheck();

                string sql = "UPDATE Notes SET Title=@NewTitle, Content=@NewContent, UpdatedAt=@UpdatedAt WHERE NoteId=@NoteId";

                var command = new SqlCommand(sql, _connection);

                command.Parameters.AddWithValue("@NewTitle", title);
                command.Parameters.AddWithValue("@NewContent", content);
                command.Parameters.AddWithValue("@UpdatedAt", updatedAt);
                command.Parameters.AddWithValue("@NoteId", noteId);

                command.ExecuteNonQuery();

                log.Info($"Updated Note :{noteId}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                log.Error($"Error in UpdateNote", e);
            }
            finally
            {
                _connection.Close();
            }
        }

        public void DeleteNote(int noteId)
        {
            try
            {
                ConnectionCheck();

                string sql = "DELETE FROM Notes WHERE NoteId=@NoteId";
                var command = new SqlCommand(sql, _connection);

                command.Parameters.AddWithValue("@NoteId", noteId);

                command.ExecuteNonQuery();

                log.Info($"Deleted Note :{noteId}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                log.Error($"Error in UpdateNote", e);
            }
            finally
            {
                _connection.Close();
            }
        }
    }
}

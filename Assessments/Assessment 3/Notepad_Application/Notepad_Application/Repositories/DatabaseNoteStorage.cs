using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Xml.Linq;
using Notepad_Application.Interfaces;
using Notepad_Application.Models;
using Notepad_Application.Settings;

namespace Notepad_Application.Repositories
{
    internal class DatabaseNoteStorage : INoteStorage
    {
        private readonly SqlConnection _connection;

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
            ConnectionCheck();

            var sql = "INSERT INTO Notes (NoteId, Title, Content, CreatedAt, UpdatedAt) VALUES (@NoteId, @Title, @Content, @CreatedAt, @UpdatedAt)";
            var command = new SqlCommand(sql, _connection);

            command.Parameters.AddWithValue("@NoteId", note.NoteId);
            command.Parameters.AddWithValue("@Title", note.Title);
            command.Parameters.AddWithValue("@Content", note.Content);
            command.Parameters.AddWithValue("@CreatedAt", note.CreatedAt);
            command.Parameters.AddWithValue("@UpdatedAt", note.UpdatedAt);

            command.ExecuteNonQuery();
            _connection.Close();
        }

        public List<Note> ViewAllNotes()
        {
            ConnectionCheck();

            var sql = "SELECT Title,Content,CreatedAt FROM Notes";
            var command = new SqlCommand(sql, _connection);

            var reader = command.ExecuteReader();

            var notes = new List<Note>();

            while (reader.Read())
            {
                notes.Add(new Note
                {
                    Title = (string)reader["Title"],
                    Content = (string)reader["Content"],
                    CreatedAt = (DateTime)reader["CreatedAt"],
                });
            }
            _connection.Close();

            return notes;
        }

        public void UpdateNote(int noteId, string title, string content, DateTime updatedAt)
        {
            ConnectionCheck();

            string sql = "UPDATE Notes SET Title=@NewTitle, Content=@NewContent, UpdatedAt=@UpdatedAt WHERE NoteId=@NoteId";

            var command = new SqlCommand(sql, _connection);

            command.Parameters.AddWithValue("@NewTitle", title);
            command.Parameters.AddWithValue("@NewContent", content);
            command.Parameters.AddWithValue("@UpdatedAt", updatedAt);
            command.Parameters.AddWithValue("@NoteId", noteId);

            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void DeleteNote(int noteId)
        {
            ConnectionCheck();

            string sql = "DELETE FROM Notes WHERE NoteId=@NoteId";
            var command = new SqlCommand(sql, _connection);

            command.Parameters.AddWithValue("@NoteId", noteId);

            command.ExecuteNonQuery();
            _connection.Close();
        }
    }
}

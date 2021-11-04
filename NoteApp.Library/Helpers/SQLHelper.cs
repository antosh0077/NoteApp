using NoteApp.Library.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteApp.Library.Helpers
{
    public delegate void Del();
    public class SQLHelper
    {
        public static event Del DatabaseChanged;
        //const string connetionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Notes;User ID=antosh;Password=Test777";
        //static string connetionString = ConfigurationManager.ConnectionStrings["Notes"].ConnectionString;
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["Notes"].ConnectionString;
        }

        static string connetionString = GetConnectionString();
        
        public static void Add(Note note)
        {
            string request = "insert into Notes (Title,Date,Body) values(@Title,@Date,@Body)";
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                try
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand(request, cnn))
                    {
                        cmd.Parameters.Add("@Title", SqlDbType.NVarChar).Value = note.Title;
                        cmd.Parameters.Add("@Date", SqlDbType.DateTime).Value = note.Date;
                        cmd.Parameters.Add("@Body", SqlDbType.NVarChar).Value = note.Body;
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR:" + ex.Message);
                }
            }
           DatabaseChanged.Invoke();
        }
        public static void Edit(Note note)
        {
            string request = "UPDATE Notes SET Title=@Title, Date=@Date, Body=@Body where Id=@Id";
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                try
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand(request, cnn))
                    {
                        cmd.Parameters.Add("@Title", SqlDbType.NVarChar).Value = note.Title;
                        cmd.Parameters.Add("@Date", SqlDbType.DateTime).Value = note.Date;
                        cmd.Parameters.Add("@Body", SqlDbType.NVarChar).Value = note.Body;
                        cmd.Parameters.Add("@Id", SqlDbType.Int).Value = note.Id;
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR:" + ex.Message);
                }
            }
           DatabaseChanged.Invoke();
        }
        public static void Delete(Note note)
        {
            string request = "Delete Notes where Id=@Id";
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                try
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand(request, cnn))
                    {
                        cmd.Parameters.Add("@Id", SqlDbType.Int).Value = note.Id;
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR:" + ex.Message);
                }
            }
            DatabaseChanged.Invoke();
        }
        public static List<Note> GetAll()
        {
            List<Note> notes = new List<Note>();
            string request = "Select* from Notes ";
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                try
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand(request, cnn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            Note note = new Note();
                            note.Id = (int)reader["Id"];
                            note.Title = (string)reader["Title"];
                            note.Date = (DateTime)reader["Date"];
                            note.Body = (string)reader["Body"];
                            notes.Add(note);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR:" + ex.Message);
                }
            }
            return notes;
        }
        public static Note Get(int id)
        {
            Note note = new Note();
            string request = "Select * from Notes where Id=@Id";
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                try
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand(request, cnn))
                    {
                        cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                            reader.Read();
                        else return note;
                        note.Id = (int)reader["Id"];
                        note.Title = (string)reader["Title"];
                        note.Date = (DateTime)reader["Date"];
                        note.Body = (string)reader["Body"];
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR:" + ex.Message);
                }
            }
            return note;
        }
        public static List<Note> Search(string keyword)
        {
            string request = string.Empty;
            List<Note> notes = new List<Note>();
            if (DateTime.TryParse(keyword, out DateTime dateTime))
                request = $" Select* from Notes where cast([Date] as date)= '{keyword}'";
            else
                request = $" Select* from Notes where Title LIKE '%{keyword}%' or Body LIKE '%{keyword}%'";            

            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                try
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand(request, cnn))
                    {
                        //cmd.Parameters.Add("@Keyword", SqlDbType.Text).Value = $"'%{keyword}%'";
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            Note note = new Note();
                            note.Id = (int)reader["Id"];
                            note.Title = (string)reader["Title"];
                            note.Date = (DateTime)reader["Date"];
                            note.Body = (string)reader["Body"];
                            notes.Add(note);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR:" + ex.Message);
                }
            }
            return notes;
        }
    }
}

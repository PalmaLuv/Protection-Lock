using System;
using System.Data.SQLite;

namespace ProtectionLock.Methods
{

    class MethodSQLite
    {
        string Path = @"URI=file:..\base.db";
        SQLiteConnection sql { get; set; }

        public MethodSQLite()
        {
            sql = new SQLiteConnection(Path);
        }
        
        public void CreateSQLite ()
        {
            sql.Open();
            var cmd = new SQLiteCommand(sql);
            cmd.CommandText = "DROP TABLE IF EXISTS ProgramInfo";
            cmd.ExecuteNonQuery();
            cmd.CommandText = @"CREATE TABLE ProgramInfo(id INTEGER PRIMARY KEY, ProcessName TEXT,
                                ProgramName TEXT, FilePath TEXT, IconPath TEXT, Protection INTEGER)";
            cmd.ExecuteNonQuery();
            sql.Close();
        }

        public void AddInfoSQLite (string ProcessName, string ProgramName, string FilePath, string IconPath, bool Protection)
        {
            var cmd = new SQLiteCommand(sql);
            cmd.CommandText = "INSERT INTO ProgramInfo(ProcessName, ProgramName, FilePath, IconPath, Protection) " +
                              "VALUES(@ProcessName, @ProgramName, @FilePath, @IconPath, @Protection)";
            cmd.Parameters.AddWithValue("@ProcessName", ProcessName);
            cmd.Parameters.AddWithValue("@ProgramName", ProgramName);
            cmd.Parameters.AddWithValue("@FilePath", FilePath);
            cmd.Parameters.AddWithValue("@IconPath", IconPath);
            cmd.Parameters.AddWithValue("@Protection", Protection);

            sql.Open();
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            sql.Close();
        }

        public void GetInfoSQLite()
        {
            sql.Open();
            var cmd = new SQLiteCommand("SELECT * FROM ProgramInfo;", sql);
            using SQLiteDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
                Console.WriteLine($"{rdr.GetInt32(0)} {rdr.GetString(1)} {rdr.GetString(2)} {rdr.GetString(3)} {rdr.GetString(4)} {rdr.GetByte(5)}");
            sql.Close();
        }
    }
}

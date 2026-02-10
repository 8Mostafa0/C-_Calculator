using Calculator.Backend.Classes;
using System.Data.SQLite;
namespace Calculator.Backend.Database
{
    internal class History
    {
        private static string database_file = "history.db";

        private static string database { get { return $"DataSource={database_file}"; } set { } }
        // check database file exist or not
        private bool check_files()
        {
            if (!Path.Exists(database_file))
            {
                File.Create(database_file).Dispose();
            }
            return true;
        }

        //create connection to database
        private SQLiteConnection Connection()
        {
            return new SQLiteConnection(database);
        }


        //execute sql querys
        private bool execute_sql_command(string sql)
        {
            try
            {

                using (SQLiteConnection conn = Connection())
                {
                    conn.Open();
                    using (var command = new SQLiteCommand(sql, conn))
                    {
                        command.ExecuteNonQuery();
                    }
                    conn.Close();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //check tables exists if not create theme
        public bool check_tables()
        {
            try
            {

                bool files = check_files();
                if (files)
                {
                    string sql_history_table = "CREATE TABLE 'history'(id INT PRIMERY KEY NOT NULL,equation TEXT NOT NULL,result NOT NULL)";
                    return execute_sql_command(sql_history_table);
                }
                else
                {
                    return false;
                }

            }
            catch (Exception)
            {
                return false;
            }
        }

        //get last id in the table
        private int get_last_id()
        {
            int last_id = 0;
            try
            {

                string sql_command = "SELECT MAX(id) FROM 'history' ORDER BY id DESC LIMIT 1";
                var con = Connection();
                con.Open();
                using (var command = new SQLiteCommand(sql_command, con))
                {
                    using (var adaptor = command.ExecuteReader())
                    {
                        while (adaptor.Read())
                        {
                            last_id = adaptor.GetInt32(0);
                        }
                    }
                }
                con.Close();
            }
            catch (Exception)
            {
                return 1;
            }
            return last_id + 1;
        }
        // insert equation data to table
        public bool insert_to_history(string equation, string result)
        {
            int last_id = get_last_id();
            string sql = $"INSERT INTO 'history'('id','equation','result')VALUES('{last_id}','{equation}','{result}')";
            return execute_sql_command(sql);
        }

        //get equation heistory from table
        public List<Equation> GetHistory()
        {
            var con = Connection();
            string sql_command = "SELECT * FROM 'history' LIMIT 10";
            List<Equation> list = new List<Equation>();
            using (var command = new SQLiteCommand(sql_command, con))
            {
                con.Open();
                using (var adaptor = command.ExecuteReader())
                {
                    while (adaptor.Read())
                    {
                        list.Add(
                            new Equation(
                                    adaptor.GetInt32(0),
                                    adaptor.GetString(1),
                                    adaptor.GetString(2)
                                )
                            );
                    }
                }
                con.Close();
            }
            return list;
        }
        //clear all equations in table
        public bool delete_history()
        {
            string sql = "DELETE FROM 'history'";
            return execute_sql_command(sql);
        }
    }
}

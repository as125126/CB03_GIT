using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace bus0917_CS
{
    class SQLClass : IDisposable
    {
        public readonly MySqlDataReader Reader;
        MySqlConnection databaseConnection;
        MySqlCommand commandDatabase;

        public SQLClass(string command, string SQLConnectionString)
        //command :sql指令 例如 select * from tb1 
        //SQLConnectionString : 欲連接之資料庫 例如 "datasource=127.0.0.1;port=3306;username=root;password=;database=db;sslmode = none;";
        {
            databaseConnection = new MySqlConnection(SQLConnectionString);
            commandDatabase = new MySqlCommand(command, databaseConnection);
            try
            {
                databaseConnection.Open();
                Reader = commandDatabase.ExecuteReader();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                databaseConnection.Close();
                MySqlConnection.ClearPool(databaseConnection);
            }
        }

        #region 關閉DB連線
        private bool disposedValue = false; // 偵測多餘的呼叫
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    databaseConnection.Close();
                    MySqlConnection.ClearPool(databaseConnection);
                }
                disposedValue = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
        }
        #endregion
    }
}

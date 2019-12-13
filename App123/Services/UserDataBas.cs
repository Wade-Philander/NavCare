using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using App123.Models;
using App123.Services.Inter;
using SQLite;


namespace App123.Services
{
    public class UserDataBas : IUserdatabase
    {
        private SQLiteAsyncConnection _database;
            public UserDataBas()
        {
            string dbPath = GetDbPath();
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Users>().Wait();
            
        }

        private string GetDbPath()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "VegDetail.db3");
        }

        public async Task<int> DeleteUser(Users users)
        {
            return await _database.DeleteAsync(users);

        }

        public async Task<Users> GetUser()
        {
            return await _database.Table<Users>().FirstOrDefaultAsync();
        }

        public async Task<int> InsertUser(Users users)
        {
            return await _database.InsertAsync(users);
        }

        public async Task<int> UpdateUser(Users users)
        {
            return await _database.UpdateAsync(users);
        }
    }
}

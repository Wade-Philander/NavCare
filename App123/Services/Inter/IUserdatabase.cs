using App123.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App123.Services.Inter
{
    public interface IUserdatabase
    {
        Task<Users> GetUser();

        Task<int> DeleteUser(Users users);
        Task<int> UpdateUser(Users users);
        Task<int> InsertUser(Users Users);
            
    }
}

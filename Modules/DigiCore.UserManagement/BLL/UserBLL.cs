using DigiCore.Common.Helper;
using DigiCore.Entities.UserManagement.Models;
using DigiCore.Entities.UserManagement.ViewModels.AccountViewModels;
using DigiCore.UserManagement.DLL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiCore.UserManagement.BLL
{
    public class UserBLL
    {
        private UserDLL dll = new UserDLL();
        public IQueryable<ApplicationUser> List()
        {
            return dll.GetModelList();
        }

        public async Task<ApplicationUser> GetListByName(string name)
        {
            return await List().Where(a => a.UserName == name).FirstOrDefaultAsync();
        }

        public async Task<AppResult> CreateUpdateToken(ApplicationUser model,string token)
        {
            return await dll.CreateUpdateToken(model, token);
        }

    }
}

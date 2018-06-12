using DigiCore.Common.DbConnection;
using DigiCore.Common.Helper;
using DigiCore.Entities.UserManagement.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiCore.UserManagement.DLL
{
    internal class UserDLL
    {
        private Context context;

        public UserDLL()
        {
            context = new Context();
        }

        internal IQueryable<ApplicationUser> GetModelList()
        {
            return context.AspNetUsers;
        }

        internal async Task<AppResult> CreateUpdateToken(ApplicationUser model, string token)
        {
            AppResult result = null;
            using (var context = new Context())
            {
                using (var dbContextTransaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        context.Set<ApplicationUserToken>().Add(new ApplicationUserToken
                        {
                            UserId = model.Id,
                            LoginProvider = "DigiCore",
                            Name = model.UserName,
                            Value = token

                        });
                        await context.SaveChangesAsync();
                        result = new AppResult { ResultType = ResultType.Success, Message = "Message -! Successfully Inserted." };
                        dbContextTransaction.Commit();

                    }
                    catch (Exception ex)
                    {
                        dbContextTransaction.Rollback();
                        result = new AppResult { ResultType = ResultType.Exception, Message = ex.Message.ToString() };
                    }
                }
            }
            return result;
        }
    }
}

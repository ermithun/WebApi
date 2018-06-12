using DigiCore.Common.DbConnection;
using DigiCore.Entities.CoreManagement;
using DigiCore.Entities.CoreManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiCore.Common.Helper
{
    public static class CustomHelper
    {
        public static DateTime GetAppDate()
        {
            return System.DateTime.Now.Date;
        }

        //public static CompanySetup GetCompanyInfo()
        //{
        //    Context context = new Context();
        //    return context.CompanySetup.FirstOrDefault();
        //}

        public static DateTime GetLoginHist(string UserName)
        {
            Context context = new Context();
            return context.UserLoginHist.Where(a => a.UserName == UserName).OrderByDescending(a => a.Id).Skip(1).FirstOrDefault().LoginDate;
        }
        //Generatepassword
        public static string GeneratePassword()
        {
            string password = "";
            string _allowedchar = "abcdefghijkmnopqrstuvwxyz";
            password = string.Concat(password, GetRandomchar(_allowedchar, _allowedchar.Count()).Trim());
            _allowedchar = "ABCDEFGHJKLMNOPQRSTUVWXYZ";
            password = string.Concat(password, GetRandomchar(_allowedchar, _allowedchar.Count()).Trim());
            _allowedchar = "0123456789";
            password = string.Concat(password, GetRandomchar(_allowedchar, _allowedchar.Count()).Trim());
            _allowedchar = "!@$?_-";
            password = string.Concat(password, GetRandomchar(_allowedchar, _allowedchar.Count()).Trim());
            return password;
        }
        public static string GetRandomchar(string _allowedchar, int charcount)
        {
            Random randNum = new Random();
            char[] chars = new char[2];
            for (int i = 0; i < 2; i++)
            {
                chars[i] = _allowedchar[(int)((charcount) * randNum.NextDouble())];
            }
            return new string(chars);
        }

       

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using DigiCore.Entities.UserManagement.Models;
using Microsoft.AspNetCore.Authorization;
using DigiCore.Entities.UserManagement.ViewModels.AccountViewModels;
using DigiCore.Common.Helper;
using DigiCore.UserManagement.BLL;
using DigiCore.Entities.Enum;

namespace WebApi.Controllers
{

    [Route("api/[controller]")]
    public class AccountController : Controller
    {
        private UserBLL bll = new UserBLL();

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountController(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager
           )
        {
            _userManager = userManager;
            _signInManager = signInManager;

        }

        [HttpPost]
        [Route("Login")]
        public async Task<JsonResult> Login([FromBody] LoginViewModel model)
        {
            AppResult appresult = new AppResult();
            try
            {
                if (ModelState.IsValid)
                {
                    ApplicationUser appuser = await bll.GetListByName(model.UserName);
                    if (appuser == null)
                    {
                        return Json(new AppResult { ResultType = ResultType.Failed, Message = "Invalid User Login!!!" });
                    }
                    var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password,false, lockoutOnFailure: false);
                    if (result.Succeeded)
                    {
                        string token = ""; // await _userManager.GenerateUserTokenAsync(appuser,"Applic","Report");
                        //string ttoken = ToString(token);

                        var createupdateToken = bll.CreateUpdateToken(appuser, token);
                        if (createupdateToken.Result.ResultType == ResultType.Success)
                        {
                            var userdata = new { UserName = model.UserName, Token = token};
                            return Json(new AppResult { ResultType = ResultType.Success, Message = "Successfully Login!!!", Data = userdata });
                        }
                        return Json(new AppResult { ResultType = ResultType.Success, Message = "Login Failed!!!" });
                    }
                    else
                    {
                        return Json(new AppResult { ResultType = ResultType.Failed, Message = "Invalid User Login!!!" });
                    }
                }
                else
                {
                    return Json(new AppResult { ResultType = ResultType.Failed, Message = "Invalid Data Provided!!!" });
                }
            }
            catch (Exception ex)
            {
                appresult = new AppResult { ResultType = ResultType.Failed, Message = "Exception occur with the system. please contact to vendor." };
                return Json(appresult);
            }
        }


        private string ToString(byte[] bytes)
        {
            string response = string.Empty;

            foreach (byte b in bytes)
                response += (Char)b;

            return response;
        }


        [HttpPost]
        [Route("Register")]
        public async Task<JsonResult> Register([FromBody] LoginViewModel model)
        {
            AppResult appresult = new AppResult();
            try
            {
                if (ModelState.IsValid)
                {
                    ApplicationUser systemUser = new ApplicationUser();
                    systemUser.UserName = model.UserName;
                    systemUser.Email = "";
                    systemUser.PhoneNumber = "";
                    systemUser.IsActive = true;
                    systemUser.IsSystemUser = true;
                    systemUser.AddedBy = 1;
                    systemUser.AddedOn = DateTime.Today;
                    systemUser.Status = RowStatus.Approved;
                    systemUser.UpdatedBy = 1;
                    systemUser.UpdatedOn = DateTime.Now;
                    systemUser.LockoutEnabled = true;
                    systemUser.LockoutEnd = DateTime.MaxValue;

                    var result = await _userManager.CreateAsync(systemUser, model.Password);
                    if (result.Succeeded)
                    {
                        var userdata = Json(new { UserName = model.UserName });
                        return Json(new AppResult { ResultType = ResultType.Success, Message = "Successfully Registered!!!", Data = userdata });
                    }
                    else
                    {
                        return Json(new AppResult { ResultType = ResultType.Failed, Message = "Invalid User Login!!!" });
                    }
                }
                else
                {
                    return Json(new AppResult { ResultType = ResultType.Failed, Message = "Invalid Data Provided!!!" });
                }
            }
            catch (Exception ex)
            {
                appresult = new AppResult { ResultType = ResultType.Failed, Message = "Exception occur with the system. please contact to vendor." };
                return Json(appresult);
            }
        }
    }
}
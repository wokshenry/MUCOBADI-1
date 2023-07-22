using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MUCOBADI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MUCOBADI.Data
{
    public class UserManagement
    {
        private IHttpContextAccessor _httpContextAccessor;
        private MUCOBADIContext _contex;
        private SignInManager<IdentityUser> SignInManager;
        private UserManager<IdentityUser> UserManager;
        public UserManagement(IHttpContextAccessor httpContextAccessor, MUCOBADIContext context,
            SignInManager<IdentityUser> _SignInManager, UserManager<IdentityUser> _UserManager)
        {
            _httpContextAccessor = httpContextAccessor;
            _contex = context;
            SignInManager = _SignInManager;
            UserManager = _UserManager;
        }
        public string GetStaffName()
        {
            string name = string.Empty;
            var person = _contex.AspNetUsers.FirstOrDefault(o => o.UserName == _httpContextAccessor.HttpContext.User.Identity.Name);
            if (person != null)
            {
               name = person.AccountHolderName;
            }
            return name;
        }
        //public string GetStaffId()
        //{
        //    string name = string.Empty;
        //    var person = _contex.ViewUserManagements.FirstOrDefault(o => o.UserName == _httpContextAccessor.HttpContext.User.Identity.Name);
        //    if (person != null)
        //    {
        //        name = person.StaffId;
        //    }
        //    return name;
        //}
        public int? GetServiceProviderId()
        {
            int? serviceproviderid = 0;
            using (var dbContext = new MUCOBADIContext())
            {
                var person = dbContext.ViewUserManagement.FirstOrDefault(o => o.UserName == _httpContextAccessor.HttpContext.User.Identity.Name);
                if (person != null)
                {
                    serviceproviderid = person.ServiceProviderId;
                }
            }
            return serviceproviderid;
        }


        public string GetServiceProviderDesc()
        {
            string ServiceProviderDesc = null;
            var person = _contex.ViewUserManagement.FirstOrDefault(o => o.UserName == _httpContextAccessor.HttpContext.User.Identity.Name);
            if (person != null)
            {
                ServiceProviderDesc = person.ServiceProviderDesc;
            }
            return ServiceProviderDesc;
        }

        public string GetStaffEmail()
        {
            string name = string.Empty;
            var person = _contex.AspNetUsers.FirstOrDefault(o => o.UserName == _httpContextAccessor.HttpContext.User.Identity.Name);
            if (person != null)
            {
                name = person.Email;
            }
            return name;
        }
        public string GetUserName()
        {
            //string name = string.Empty;
            //var person = _contex.AspNetUsers.FirstOrDefault(o => o.UserName == _httpContextAccessor.HttpContext.User.Identity.Name);
            //if (person != null)
            //{
            //    name = person.UserName;
            //}
            //return name;
            return _httpContextAccessor.HttpContext.User.Identity.Name;
        }
        public string GetStaffNumber()
        {
            string name = string.Empty;
            var person = _contex.AspNetUsers.FirstOrDefault(o => o.UserName == _httpContextAccessor.HttpContext.User.Identity.Name);
            if (person != null)
            {
                name = person.PhoneNumber;
            }
            return name;
        }
        public List<int> GetUserDistrict()
        {
            List<int> data = new List<int>();
            var person = _contex.AspNetUsers.FirstOrDefault(o => o.UserName == _httpContextAccessor.HttpContext.User.Identity.Name);
            if (person != null && !string.IsNullOrEmpty(person.DistrictId))
            {
                var a = person.DistrictId.Split(",");
                foreach(var n in a)
                {
                    if (!string.IsNullOrEmpty(n))
                    {
                        var b = Convert.ToInt32(n);
                        data.Add(b);
                    }
                }
            }
            return data;
        }
        public List<int> GetUserSubcounty()
        {
            List<int> data = new List<int>();
            var person = _contex.AspNetUsers.FirstOrDefault(o => o.UserName == _httpContextAccessor.HttpContext.User.Identity.Name);
            if (person != null && !string.IsNullOrEmpty(person.SubCountyId))
            {
                var a = person.SubCountyId.Split(",");
                foreach (var n in a)
                {
                    if (!string.IsNullOrEmpty(n))
                    {
                        var b = Convert.ToInt32(n);
                        data.Add(b);
                    }
                }
            }
            return data;
        }
        public bool IsSignedIn()
        {
            return SignInManager.IsSignedIn(_httpContextAccessor.HttpContext.User);
        }
        public async Task<bool> IsInRole(string UserRole)
        {
            var user = await UserManager.GetUserAsync(_httpContextAccessor.HttpContext.User);
            //var a =await UserManager.IsInRoleAsync(user, UserRole);
            return await UserManager.IsInRoleAsync(user, UserRole);
        }
    }
}

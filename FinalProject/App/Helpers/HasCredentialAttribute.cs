using App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Http.Controllers;

namespace App.Helpers
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class HasCredentialAttribute : AuthorizeAttribute
    {
        public string Permission { set; get; }

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            var PermissionKeys = this.GetCredentialByLoggedInUser();
            if (PermissionKeys.Contains(this.Permission))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            filterContext.Result = new PartialViewResult()
            {
                ViewName = "/Views/Shared/Error401.cshtml"
            };
        }
        
        private List<string> GetCredentialByLoggedInUser()
        {
            var creadentials = (List<string>)HttpContext.Current.Session[CommonConstants.PERMISSION];
            return creadentials;
        }
    }
}
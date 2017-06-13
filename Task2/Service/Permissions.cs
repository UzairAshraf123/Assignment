using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using Task2.Models;
using System.Web.Mvc;
using Task2.Models.ViewModels;
namespace Task2.Service
{
    public static class Permissions 
    {
        public static IEnumerable<UserPermission> Permission(string userID)
        {
            if (userID!=null)
            {
                hrplink_dbEntities _Context = new hrplink_dbEntities();
                return  _Context.UserPermissions.Where(s => s.UserID == userID).ToList();
                //return userPermissions.Select(s=> s.PermissionDetail).Select(w=>w.Name).ToList();
                //return _Context.PermissionDetails.Where(s => s.ID == userPermissions.PermissionDetailID).Select(s => s.Name).ToList();
            }
            else
            {
                return null;
            }
        }
    }
}
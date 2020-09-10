
using Microsoft.Ajax.Utilities;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vidly.Controllers
{
    public class ManageController : Controller
    {
        private AppllicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;
        
        public ManageController()
        {

        }

        public ManageController(AppllicationSignInManager signInManager, ApplicationUserManager userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public class ApplicationUserManager
        {
            
        }

        public class AppllicationSignInManager 
        {
            
        }
    }

    
}
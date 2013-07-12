using GiveIT.UI.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebMatrix.WebData;

namespace GiveIT.UI.Web.Controllers
{
    public class CharityRegisterController : Controller
    {
        UIWebDbContext db = new UIWebDbContext();


        //
        // GET: /CharityRegister/RegisterC
        [AllowAnonymous]
        public ActionResult RegisterC()
        {
            return View();
        }

        //
        // POST: /CharityRegister/RegisterC

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult RegisterC(Charity model)
        {

            //if (ModelState.IsValid)
            //{
                // Attempt to register the charity and store charity info to database
                //    try
                //    {

                //        WebSecurity.CreateUserAndAccount(model.CharityName, model.Password,
                //            propertyValues: new
                //            {
                //                ContactFirstName = model.ContactFirstName,
                //                ContactLastName = model.ContactLastName,
                //                Title = model.Title,
                //                PhoneNumber = model.PhoneNumber,
                //                PhoneNoExtension = model.PhoneNoExtension,
                //                EmailAddress = model.EmailAddress
                //            });

                //        db.Charities.Add(new Charity
                //        {
                //            CharityName = model.CharityName,
                //            MissionAndLocation = model.MissionAndLocation,
                //            EIN = model.EIN,
                //            StreetAddress = model.StreetAddress,
                //            StreetAddress2 = model.StreetAddress2,
                //            City = model.City,
                //            State = model.State,
                //            ZipCode = model.ZipCode
                //        });

                //        db.SaveChanges();

                //        WebSecurity.Login(model.CharityName, model.Password);


                //        ///////////////-Just test page, need to redirect to somewhere
                //        return RedirectToAction("Index", "Home");
                //        // return RedirectToAction("Detail", "RegisterC");
                //    }
                //    catch (MembershipCreateUserException e)
                //    {
                //        ModelState.AddModelError("", ErrorCodeToString(e.StatusCode));
                //    }
                //}

                //// If we got this far, something failed, redisplay form
                return View(model);
            }
        }


//        #region Helpers
//        private static string ErrorCodeToString(MembershipCreateStatus createStatus)
//        {
//            // See http://go.microsoft.com/fwlink/?LinkID=177550 for
//            // a full list of status codes.
//            switch (createStatus)
//            {
//                case MembershipCreateStatus.DuplicateUserName:
//                    return "User name already exists. Please enter a different user name.";

//                case MembershipCreateStatus.DuplicateEmail:
//                    return "A user name for that e-mail address already exists. Please enter a different e-mail address.";

//                case MembershipCreateStatus.InvalidPassword:
//                    return "The password provided is invalid. Please enter a valid password value.";

//                case MembershipCreateStatus.InvalidEmail:
//                    return "The e-mail address provided is invalid. Please check the value and try again.";

//                case MembershipCreateStatus.InvalidAnswer:
//                    return "The password retrieval answer provided is invalid. Please check the value and try again.";

//                case MembershipCreateStatus.InvalidQuestion:
//                    return "The password retrieval question provided is invalid. Please check the value and try again.";

//                case MembershipCreateStatus.InvalidUserName:
//                    return "The user name provided is invalid. Please check the value and try again.";

//                case MembershipCreateStatus.ProviderError:
//                    return "The authentication provider returned an error. Please verify your entry and try again. If the problem persists, please contact your system administrator.";

//                case MembershipCreateStatus.UserRejected:
//                    return "The user creation request has been canceled. Please verify your entry and try again. If the problem persists, please contact your system administrator.";

//                default:
//                    return "An unknown error occurred. Please verify your entry and try again. If the problem persists, please contact your system administrator.";
//            }
//        }
//        #endregion

//        protected override void Dispose(bool disposing)
//        {
//            if (db != null)
//            {
//                db.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//    }
}
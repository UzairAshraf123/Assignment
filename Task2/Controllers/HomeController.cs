using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task2.Models;
using Task2.Models.ViewModels;
using Task2.Repository;
using Task2.Service;

namespace Task2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string message)
        {
            //var userid = User.Identity.GetUserId();

            //hrplink_dbEntities _Context = new hrplink_dbEntities();
            //IEnumerable<UserElementPermission> userEP = _Context.UserElementPermissions.ToList();
            //IEnumerable<OrgDataAccess> data = _Context.OrgDataAccesses.Where(s=> s.TableDataAccesses.Any(w=> w.UserElementPermissions.Any(i=> i.UserID == userid))).ToList();

            //IEnumerable<TableDataAccess> fields = _Context.TableDataAccesses.Where(s=> s.UserElementPermissions.Any(i=> i.UserID == userid)).ToList();
            //var gender = _Context.OrgGenders.Select(s => new
            //{
            //    Text = s.Description,
            //    Value = s.GenderId
            //}).ToList();
            //ViewBag.Gender = new SelectList(gender, "Value", "Text");

            //var countries = _Context.OrgCountries.Select(s => new
            //{
            //    Text = s.Name,
            //    Value = s.CountryId
            //}).ToList();

            //ViewBag.Countries = new SelectList(countries, "Value", "Text");
            //return View(new AddEmployeeViewModel(){UserPermissions = userEP, ScreenElements = data , Fields = fields});
            


            ViewBag.Message = message;
            return View();
        }
        [HttpPost]
        public ActionResult Index(AddEmployeeViewModel viewModel)
        {

            var nas = viewModel.SIN.ToList();
            var check = "121212121".ToList();

            var result = "";
            for (int i = 0; i < nas.Count(); ++i)
            {
                int tmp = (int)(nas[i]) * (int)(check[i]);
                var val = tmp < 10 ? tmp : tmp - 9;
                result += val;
            }

            var sum = result.Aggregate(0, (acc, item) => acc + (int)(item));
            var finalResult = sum % 10;
            if ( finalResult!= 0)
            {
                return RedirectToAction("Index", "Home", new { message = "Enter a valid SIN..." });
            }

            hrplink_dbEntities _Context = new hrplink_dbEntities();
            var employees = new EmployeeRepository().Get();
            if(employees.Select(s => s.SocialInsuranceNumber).Contains(viewModel.SIN))
            {
                return RedirectToAction("Index", "Home", new { message = "SIN must b unique.." });
            }
            var employee = new Employee();
            employee.SocialInsuranceNumber = finalResult.ToString();
            employee.LastName = viewModel.LastName;
            employee.FirstName = viewModel.FirstName;
            employee.MiddleName = viewModel.MiddleName;
            employee.GenderId = viewModel.GenderID;
            employee.BirthDate = viewModel.DOB;
            employee.Address1 = viewModel.Address1;
            employee.Address2 = viewModel.Address2;
            employee.City = viewModel.City;
            employee.ProvinceId = viewModel.ProvinceID;
            employee.PostalCode = viewModel.PostalCode;
            employee.CountryId = viewModel.CountryID;
            employee.Telephone1 = viewModel.Telephone1;
            employee.Telephone2 = viewModel.Telephone2;
            employee.WorkTelephone = viewModel.WorkTelephone;
            employee.BankId = viewModel.BandID;
            employee.BankTransitNumber = viewModel.TransactionNumber;
            employee.BankAccountNumber = viewModel.AccountNumber;
            employee.PreferredLanguageId = viewModel.PreferedLanguageID;
            employee.PrintStatementInd = viewModel.PrintStatementInd;
            employee.UserId = User.Identity.GetUserId();
            employee.WorkEmailAddress = viewModel.WorkEmail;
            employee.PersonalEmailAddress = viewModel.PersonalEmail;
            employee.EmailPreferenceFlag = viewModel.EmailPreferenceFlag;
            employee.WebT4ConsentInd = viewModel.WebT4ConsentInd;
            employee.BenefitEligibilityDate = viewModel.BenefitEligibilityDate;
            employee.BenefitCarrierNumber = viewModel.BenefitCarrierNumber;
            employee.WorkTelephoneExt = viewModel.WorkTelephoneExt;
            var empID = new EmployeeRepository().Create(employee);
            return RedirectToAction("Display", "Home", new {  message = "Employee has been added..." });
        }

        public ActionResult Create()
        {
            var userid = User.Identity.GetUserId();

            hrplink_dbEntities _Context = new hrplink_dbEntities();
            IEnumerable<UserElementPermission> userEP = _Context.UserElementPermissions.ToList();
            IEnumerable<OrgDataAccess> data = _Context.OrgDataAccesses.Where(s => s.TableDataAccesses.Any(w => w.UserElementPermissions.Any(i => i.UserID == userid))).ToList();

            IEnumerable<TableDataAccess> fields = _Context.TableDataAccesses.Where(s => s.UserElementPermissions.Any(i => i.UserID == userid)).ToList();
            var gender = _Context.OrgGenders.Select(s => new
            {
                Text = s.Description,
                Value = s.GenderId
            }).ToList();
            ViewBag.Gender = new SelectList(gender, "Value", "Text");

            var countries = _Context.OrgCountries.Select(s => new
            {
                Text = s.Name,
                Value = s.CountryId
            }).ToList();
            ViewBag.Countries = new SelectList(countries, "Value", "Text");
            return View(new AddEmployeeViewModel() { UserPermissions = userEP, ScreenElements = data, Fields = fields });
        }

        public ActionResult Display(string message)
        {
            ViewBag.Message = message;
            var userid = User.Identity.GetUserId();
            hrplink_dbEntities _Context = new hrplink_dbEntities();
            IEnumerable<OrgDataAccess> data = _Context.OrgDataAccesses.Where(s => s.TableDataAccesses.Any(w => w.UserElementPermissions.Any(i => i.UserID == userid))).ToList();
            ViewBag.ScreenElements = data;
            return View(_Context.Employees.ToList());
        }

        public ActionResult Edit(int id)
        {
            hrplink_dbEntities _Context = new hrplink_dbEntities();
            var gender = _Context.OrgGenders.Select(s => new
            {
                Text = s.Description,
                Value = s.GenderId
            }).ToList();
            ViewBag.Gender = new SelectList(gender, "Value", "Text");

            var countries = _Context.OrgCountries.Select(s => new
            {
                Text = s.Name,
                Value = s.CountryId
            }).ToList();
            ViewBag.Countries = new SelectList(countries, "Value", "Text");

            var userid = User.Identity.GetUserId();
            var viewModel = _Context.Employees.FirstOrDefault(s => s.EmpId == id);
            IEnumerable<OrgDataAccess> data = _Context.OrgDataAccesses.Where(s => s.TableDataAccesses.Any(w => w.UserElementPermissions.Any(i => i.UserID == userid))).ToList();
            var employee = new AddEmployeeViewModel();
            employee.ScreenElements = data;

            employee.EmployeeID = viewModel.EmpId;
            employee.SIN = viewModel.SourceDocVerifiedInd;
            employee.LastName = viewModel.LastName;
            employee.FirstName = viewModel.FirstName;
            employee.MiddleName = viewModel.MiddleName;
            employee.GenderID = viewModel.GenderId;
            employee.DOB = viewModel.BirthDate;
            employee.Address1 = viewModel.Address1;
            employee.Address2 = viewModel.Address2;
            employee.City = viewModel.City;
            employee.ProvinceID = viewModel.ProvinceId;
            employee.PostalCode = viewModel.PostalCode;
            employee.CountryID = viewModel.CountryId;
            employee.Telephone1 = viewModel.Telephone1;
            employee.Telephone2 = viewModel.Telephone2;
            employee.WorkTelephone = viewModel.WorkTelephone;
            employee.BandID = viewModel.BankId;
            employee.TransactionNumber = viewModel.BankTransitNumber;
            employee.AccountNumber = viewModel.BankAccountNumber;
            employee.PreferedLanguageID = viewModel.PreferredLanguageId;
            employee.PrintStatementInd = viewModel.PrintStatementInd;
            employee.UserID = User.Identity.GetUserId();
            employee.WorkEmail = viewModel.WorkEmailAddress;
            employee.PersonalEmail = viewModel.PersonalEmailAddress;
            employee.EmailPreferenceFlag = viewModel.EmailPreferenceFlag;
            employee.WebT4ConsentInd = viewModel.WebT4ConsentInd;
            employee.BenefitEligibilityDate = viewModel.BenefitEligibilityDate;
            employee.BenefitCarrierNumber = viewModel.BenefitCarrierNumber;
            employee.WorkTelephoneExt = viewModel.WorkTelephoneExt;
            return View(employee);
        }
        [HttpPost]
        public ActionResult Edit(AddEmployeeViewModel viewModel)
        {
            hrplink_dbEntities _Context = new hrplink_dbEntities();

            viewModel.UserID = User.Identity.GetUserId();
            new EmployeeRepository().Update(viewModel);
            return RedirectToAction("Display", "Home", new {message = "Profile Updated Successfully..." });
        }

        public JsonResult ProvinceByCountryID(int id)
        {
            hrplink_dbEntities _Context = new hrplink_dbEntities();
            List<SelectListItem> list = new List<SelectListItem>();
            var states = _Context.OrgProvinces.Where(s=> s.OrgCountryId == id).Select(s => new
            {
                Text = s.Name,
                Id = s.ProvinceId
            }).ToList();
            var state = new SelectList(states, "Id", "Text");
            return Json(new { state }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
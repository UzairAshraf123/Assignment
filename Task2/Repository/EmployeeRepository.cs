using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Task2.Models;
using Task2.Models.ViewModels;
using Microsoft.AspNet.Identity;

namespace Task2.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly hrplink_dbEntities _Context;
        public EmployeeRepository()
        {
            _Context = new hrplink_dbEntities();
        }
        public int Create(Employee entity)
        {
            _Context.Employees.Add(entity);
            _Context.SaveChanges();
            return entity.EmpId;
        }

        public void Delete(int? id)
        {
            var employee = Get().Where(s=> s.EmpId == id).FirstOrDefault();
            _Context.Employees.Remove(employee);
            _Context.SaveChanges();
        }

        public IEnumerable<Employee> Get()
        {
            return _Context.Employees.ToList();
        }

        public void Update(AddEmployeeViewModel viewModel)
        {
            var employee = Get().Where(s => s.EmpId == viewModel.EmployeeID).FirstOrDefault();

            employee.SourceDocVerifiedInd = viewModel.SIN;
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
            employee.UserId = viewModel.UserID ;
            employee.WorkEmailAddress = viewModel.WorkEmail;
            employee.PersonalEmailAddress = viewModel.PersonalEmail;
            employee.EmailPreferenceFlag = viewModel.EmailPreferenceFlag;
            employee.WebT4ConsentInd = viewModel.WebT4ConsentInd;
            employee.BenefitEligibilityDate = viewModel.BenefitEligibilityDate;
            employee.BenefitCarrierNumber = viewModel.BenefitCarrierNumber;
            employee.WorkTelephoneExt = viewModel.WorkTelephoneExt;
            _Context.SaveChanges();
        }
    }
}
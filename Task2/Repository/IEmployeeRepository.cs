using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Models;
using Task2.Models.ViewModels;
namespace Task2.Repository
{
    interface IEmployeeRepository
    {
        int Create(Employee viewModel);

        void Update(AddEmployeeViewModel viewModel);

        void Delete(int? id);

        IEnumerable<Employee> Get();
    }
}

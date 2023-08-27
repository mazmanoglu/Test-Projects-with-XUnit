using XUnitWithASPWebApp.Models;

namespace XUnitWithASPWebApp.Repository
{
   public interface IEmployeeService
   {
      bool CreateEmployee(Employee employee, DateTime date);
   }
}

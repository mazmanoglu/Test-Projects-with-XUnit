using XUnitWithASPWebApp.Models;

namespace XUnitWithASPWebApp.Repository
{
   public class EmployeeService : IEmployeeService
   {
      public bool CreateEmployee(Employee employee, DateTime date)
      {
         if (employee.Id <= 0)
         {
            return false;
         }
         int employeeId = 101; //use this employee id as existing employee ID

         if (employee.Id == employeeId)
         {
            return false;
         }

         return true; 
      }
   }
}

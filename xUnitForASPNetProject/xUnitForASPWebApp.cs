using XUnitWithASPWebApp.Models;
using XUnitWithASPWebApp.Repository;
using Xunit;

namespace xUnitForASPNetProject
{
   public class xUnitForASPWebApp
   {
      [Fact]
      public void Test_Invalid_EmployeeId()
      {
         // arrange
         var employeeService = new EmployeeService();

         // act
         var result = employeeService.CreateEmployee(new Employee(), DateTime.Today);

         //assert
         Assert.False(result);
      }

      [Fact]
      public void Test_Existing_EmployeeId()
      {
         // arrange
         var employeeService = new EmployeeService();

         // act
         var result = employeeService.CreateEmployee(new Employee { Id=101}, DateTime.Today);

         //assert
         Assert.False(result);
      }

      [Fact]
      public void Test_valid_EmployeeId()
      {
         // arrange
         var employeeService = new EmployeeService();

         // act
         var result = employeeService.CreateEmployee(new Employee { Id=201}, DateTime.Today);

         //assert
         Assert.True(result);
      }
   }
}
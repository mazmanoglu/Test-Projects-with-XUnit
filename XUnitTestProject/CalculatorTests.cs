using Xunit.Sdk;

namespace XUnitTestProject
{
   // Let's assume we have a simple Calculator class with an Add/Delete/Multiply and Divide methods.
   public class Calculator
   {
      public static int Add(int a, int b)
      {
         return a + b;
      }
      public static int Delete(int a, int b)
      {
         return a - b;
      }
      public int Multiply(int a, int b)
      {
         return a * b;
      }
      public int Divide(int a, int b)
      {
         return a / b;
      }
   }

   // Now, we can write a corresponding xUnit test for the Calculator class.
   public class CalculatorTests
   {
      int a = 4;
      int b = 2;

      [Fact] // The Fact attribute indicates that this is a test method.
      public void Add_ShouldReturnCorrectSum()
      {
         // Act
         int result = Calculator.Add(a, b);

         // Assert
         Assert.Equal(6, result);
      }
      [Fact] 
      public void Delete_ShouldReturnCorrectSum()
      {
         // Act
         int result = Calculator.Delete(a, b);

         // Assert
         Assert.Equal(2, result);
      }
      [Fact] // The Fact attribute indicates that this is a test method.
      public void Multiply_ShouldReturnCorrectSum()
      {
         // Arrange
         var calculator = new Calculator();

         // Act
         int result = calculator.Multiply(a, b);

         // Assert
         Assert.Equal(8, result);
      }
      [Fact] // The Fact attribute indicates that this is a test method.
      public void Divide_ShouldReturnCorrectSum()
      {
         // Arrange
         var calculator = new Calculator();

         // Act
         int result = calculator.Divide(a, b);

         // Assert
         Assert.Equal(2, result);
      }
   }
}
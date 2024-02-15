using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPW211_UnitTestStarterCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_UnitTestStarterCode.Tests
{
    [TestClass()]
    public class SimpleMathTests
    {
        [TestMethod()]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        public void Add_TwoNumbers_ReturnsSum(double num1, double num2)
        {
            // Arrange
            double expected = num1 + num2;

            // Act
            double result = SimpleMath.Add(num1, num2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        public void Multiply_TwoNumbers_ReturnsProduct(double num1, double num2)
        {
            // Arrange
            double expected = num1 * num2;

            // Act
            double result = SimpleMath.Multiply(num1, num2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Divide_DenominatorZero_ThrowsArgumentException()
        {
            // Arrange
            double num1 = 10;
            double num2 = 0;

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => SimpleMath.Divide(num1, num2));
        }

        [TestMethod]
        [DataRow(10, 2, 5)]
        [DataRow(-10, 2, -5)]
        [DataRow(0, 5, 0)]
        public void Divide_TwoValidNumbers_ReturnsQuotient(double num1, double num2, double expected)
        {
            // Act
            double result = SimpleMath.Divide(num1, num2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(10, 5, 5)]
        [DataRow(-10, -5, -5)]
        [DataRow(0, 0, 0)]
        public void Subtract_TwoValidNumbers_ReturnsDifference(double num1, double num2, double expected)
        {
            // Act
            double result = SimpleMath.Subtract(num1, num2);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}

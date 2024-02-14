using UtilityLibraries;
namespace StringLibraryTest;

[TestClass]
public class UnitTest1
{
  
   [TestMethod]
    public void Test_Add_TwoPositiveNumbers_ReturnsCorrectSum()
    {
        // Arrange
        decimal number1 = 3.5m;
        decimal number2 = 4.2m;
        decimal expectedSum = 7.7m;

        // Act
        decimal actualSum = StringLibrary.Add(number1, number2);

        // Assert
        Assert.AreEqual(expectedSum, actualSum);
    }
  [TestMethod]
public void Test_Add_TwoNegativeNumbers_ReturnsCorrectSum()
{
    // Arrange
    decimal number1 = -5.3m;
    decimal number2 = -2.7m;
    decimal expectedSum = -8.0m;

    // Act
    decimal actualSum = StringLibrary.Add(number1, number2);

    // Assert
    Assert.AreEqual(expectedSum, actualSum);
}
[TestMethod]
public void Test_Add_PositiveAndNegativeNumber_ReturnsCorrectSum()
{
    // Arrange
    decimal number1 = 6.8m;
    decimal number2 = -3.2m;
    decimal expectedSum = 3.6m;

    // Act
    decimal actualSum = StringLibrary.Add(number1, number2);

    // Assert
    Assert.AreEqual(expectedSum, actualSum);
}
[TestMethod]
public void Test_Add_ZeroAndPositiveNumber_ReturnsCorrectSum()
{
    // Arrange
    decimal number1 = 0m;
    decimal number2 = 8.9m;
    decimal expectedSum = 8.9m;

    // Act
    decimal actualSum = StringLibrary.Add(number1, number2);

    // Assert
    Assert.AreEqual(expectedSum, actualSum);
}
[TestMethod]
public void Test_Add_ZeroAndNegativeNumber_ReturnsCorrectSum()
{
    // Arrange
    decimal number1 = 0m;
    decimal number2 = -4.5m;
    decimal expectedSum = -4.5m;

    // Act
    decimal actualSum = StringLibrary.Add(number1, number2);

    // Assert
    Assert.AreEqual(expectedSum, actualSum);
}
[TestMethod]
public void Test_Subtract_TwoPositiveNumbers_ReturnsCorrectDifference()
{
    // Arrange
    decimal number1 = 8.5m;
    decimal number2 = 3.2m;
    decimal expectedDifference = 5.3m;

    // Act
    decimal actualDifference = StringLibrary.Subtract(number1, number2);

    // Assert
    Assert.AreEqual(expectedDifference, actualDifference);
}
[TestMethod]
public void Test_Subtract_PositiveAndNegativeNumber_ReturnsCorrectDifference()
{
    // Arrange
    decimal number1 = 6.8m;
    decimal number2 = -3.2m;
    decimal expectedDifference = 10.0m;

    // Act
    decimal actualDifference = StringLibrary.Subtract(number1, number2);

    // Assert
    Assert.AreEqual(expectedDifference, actualDifference);
}
[TestMethod]
public void Test_Subtract_ZeroAndPositiveNumber_ReturnsCorrectDifference()
{
    // Arrange
    decimal number1 = 0m;
    decimal number2 = 8.9m;
    decimal expectedDifference = -8.9m;

    // Act
    decimal actualDifference = StringLibrary.Subtract(number1, number2);

    // Assert
    Assert.AreEqual(expectedDifference, actualDifference);
}
[TestMethod]
public void Test_Subtract_ZeroAndNegativeNumber_ReturnsCorrectDifference()
{
    // Arrange
    decimal number1 = 0m;
    decimal number2 = -4.5m;
    decimal expectedDifference = 4.5m;

    // Act
    decimal actualDifference = StringLibrary.Subtract(number1, number2);

    // Assert
    Assert.AreEqual(expectedDifference, actualDifference);
}

    

[TestMethod]
public void Test_Subtract_LargeAndSmallNumbers_ReturnsCorrectDifference()
{
    // Arrange
    decimal number1 = 1234567890.123m;
    decimal number2 = 456.789m;
    decimal expectedDifference = 1234567433.334m;

    // Act
    decimal actualDifference = StringLibrary.Subtract(number1, number2);

    // Assert
    Assert.AreEqual(expectedDifference, actualDifference);
}
[TestMethod]
public void Test_Multiply_TwoPositiveNumbers_ReturnsCorrectProduct()
{
    // Arrange
    decimal number1 = 3.5m;
    decimal number2 = 4.2m;
    decimal expectedProduct = 14.7m;

    // Act
    decimal actualProduct = StringLibrary.Multiply(number1, number2);

    // Assert
    Assert.AreEqual(expectedProduct, actualProduct);
}
[TestMethod]
public void Test_Multiply_PositiveAndNegativeNumber_ReturnsCorrectProduct()
{
    // Arrange
    decimal number1 = 6.8m;
    decimal number2 = -3.2m;
    decimal expectedProduct = -21.76m;

    // Act
    decimal actualProduct = StringLibrary.Multiply(number1, number2);

    // Assert
    Assert.AreEqual(expectedProduct, actualProduct);
}
[TestMethod]
public void Test_Multiply_ZeroAndPositiveNumber_ReturnsZero()
{
    // Arrange
    decimal number1 = 0m;
    decimal number2 = 8.9m;
    decimal expectedProduct = 0m;

    // Act
    decimal actualProduct = StringLibrary.Multiply(number1, number2);

    // Assert
    Assert.AreEqual(expectedProduct, actualProduct);
}
[TestMethod]
public void Test_Multiply_ZeroAndNegativeNumber_ReturnsZero()
{
    // Arrange
    decimal number1 = 0m;
    decimal number2 = -4.5m;
    decimal expectedProduct = 0m;

    // Act
    decimal actualProduct = StringLibrary.Multiply(number1, number2);

    // Assert
    Assert.AreEqual(expectedProduct, actualProduct);
}
[TestMethod]
public void Test_Multiply_PositiveAndZeroNumber_ReturnsZero()
{
    // Arrange
    decimal number1 = 10.5m;
    decimal number2 = 0m;
    decimal expectedProduct = 0m;

    // Act
    decimal actualProduct = StringLibrary.Multiply(number1, number2);

    // Assert
    Assert.AreEqual(expectedProduct, actualProduct);
}
[TestMethod]
public void Test_Divide_TwoPositiveNumbers_ReturnsCorrectQuotient()
{
    // Arrange
    decimal dividend = 10.5m;
    decimal divisor = 2.5m;
    decimal expectedQuotient = 4.2m;

    // Act
    decimal actualQuotient = StringLibrary.Divide(dividend, divisor);

    // Assert
    Assert.AreEqual(expectedQuotient, actualQuotient);
}
[TestMethod]
public void Test_Divide_PositiveAndNegativeNumber_ReturnsCorrectQuotient()
{
    // Arrange
    decimal dividend = 10.5m;
    decimal divisor = -2.5m;
    decimal expectedQuotient = -4.2m;

    // Act
    decimal actualQuotient = StringLibrary.Divide(dividend, divisor);

    // Assert
    Assert.AreEqual(expectedQuotient, actualQuotient);
}
[TestMethod]
[ExpectedException(typeof(DivideByZeroException))]
public void Test_Divide_DivideByZero_ThrowsDivideByZeroException()
{
    // Arrange
    decimal dividend = 10.5m;
    decimal divisor = 0m;

    // Act
    decimal actualQuotient = StringLibrary.Divide(dividend, divisor);

    // Assert
    // This test expects a DivideByZeroException to be thrown
}
[TestMethod]
public void Test_Divide_ZeroByPositiveNumber_ReturnsZero()
{
    // Arrange
    decimal dividend = 0m;
    decimal divisor = 3.5m;
    decimal expectedQuotient = 0m;

    // Act
    decimal actualQuotient = StringLibrary.Divide(dividend, divisor);

    // Assert
    Assert.AreEqual(expectedQuotient, actualQuotient);
}
[TestMethod]
public void Test_Divide_NegativeAndPositiveNumber_ReturnsCorrectQuotient()
{
    // Arrange
    decimal dividend = -10.5m;
    decimal divisor = 2.5m;
    decimal expectedQuotient = -4.2m;

    // Act
    decimal actualQuotient = StringLibrary.Divide(dividend, divisor);

    // Assert
    Assert.AreEqual(expectedQuotient, actualQuotient);
}


}



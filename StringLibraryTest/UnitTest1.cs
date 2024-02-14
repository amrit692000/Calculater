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
}
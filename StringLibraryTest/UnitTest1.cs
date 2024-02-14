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

    
}
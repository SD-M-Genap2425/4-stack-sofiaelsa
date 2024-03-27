using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution.BracketValidation;

namespace Solution.Tests;

[TestClass]
public class BracketValidatorTests
{
    [TestMethod]
    public void ValidasiEkspresi_WithCorrectExpression_ReturnsTrue()
    {
        // Arrange
        var validator = new BracketValidator();
        var expression = "{[()]}";

        // Act
        bool isValid = validator.ValidasiEkspresi(expression);

        // Assert
        Assert.IsTrue(isValid, "Expression should be valid");
    }

    [TestMethod]
    public void ValidasiEkspresi_WithIncorrectExpression_ReturnsFalse()
    {
        // Arrange
        var validator = new BracketValidator();
        var expression = "{[(])}";

        // Act
        bool isValid = validator.ValidasiEkspresi(expression);

        // Assert
        Assert.IsFalse(isValid, "Expression should be invalid");
    }

    [TestMethod]
    public void ValidasiEkspresi_WithEmptyExpression_ReturnsTrue()
    {
        // Arrange
        var validator = new BracketValidator();
        var expression = "";

        // Act
        bool isValid = validator.ValidasiEkspresi(expression);

        // Assert
        Assert.IsTrue(isValid, "Empty expression should be valid");
    }

    [TestMethod]
    public void ValidasiEkspresi_WithUnmatchedOpeningBrackets_ReturnsFalse()
    {
        // Arrange
        var validator = new BracketValidator();
        var expression = "(((";

        // Act
        bool isValid = validator.ValidasiEkspresi(expression);

        // Assert
        Assert.IsFalse(isValid, "Expression with unmatched opening brackets should be invalid");
    }

    [TestMethod]
    public void ValidasiEkspresi_WithUnmatchedClosingBrackets_ReturnsFalse()
    {
        // Arrange
        var validator = new BracketValidator();
        var expression = ")))";

        // Act
        bool isValid = validator.ValidasiEkspresi(expression);

        // Assert
        Assert.IsFalse(isValid, "Expression with unmatched closing brackets should be invalid");
    }
}
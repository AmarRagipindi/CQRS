using BooksPortal.UI.Models;
using FluentAssertions;
using FluentAssertions.Execution;

namespace BooksPortal.UI.Tests.Validators;

public class BookViewModelValidatorTests
{
    [Test]
    public void BookViewModelValidator_With_ValidBook_Returns_NoErrors()
    {
        //Arrange
        var bookVm = new BookViewModel()
        {
            Name = "Test",
            Author = "Thomas Miller",
            Code = "1234",
            Price = 900,
            Rating = 5

        };

        //Act
        var validator = new BookViewModelValidator();
        var result = validator.Validate(bookVm);

        //Assert
        using var scope = new AssertionScope();
        result.IsValid.Should().BeTrue();
        result.Errors.Should().BeEmpty();
    }
}

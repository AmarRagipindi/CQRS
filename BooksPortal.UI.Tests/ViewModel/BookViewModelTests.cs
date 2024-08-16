using BooksPortal.UI.Models;
using FluentAssertions;
using FluentAssertions.Execution;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace BooksPortal.UI.Tests.ViewModel;

public class BookViewModelTests
{

    [SetUp]
    public void SetUp()
    {

    }

    [Test]
    public void BookViewModel_Get_Set_Correctly()
    {
        var bookVm = new BookViewModel()
        {
            Name = "Test",
            Author = "Thomas Miller",
            Code = "1234",
            Price = 900,
            Rating = 5

        };

        using var scope = new AssertionScope();
        bookVm.Name.Should().Be("Test");
        bookVm.Author.Should().Be("Thomas Miller");
        bookVm.Code.Should().Be("1234");
        bookVm.Price.Should().Be(900);
        bookVm.Rating.Should().Be(5);
    }

    [Test]
    public void BookViewModel_Have_Right_Attributes()
    {
        var bookVm = new BookViewModel();
        PropertyInfo property = typeof(BookViewModel).GetProperty(nameof(BookViewModel.Name));
        property.Should().BeDecoratedWith<RequiredAttribute>();
    }
}

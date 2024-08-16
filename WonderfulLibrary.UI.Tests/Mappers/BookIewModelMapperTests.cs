using AutoMapper;
using DTO;
using FluentAssertions;
using FluentAssertions.Execution;
using WonderfulLibrary.UI.Mapping;
using WonderfulLibrary.UI.Models;

namespace BooksPortal.UI.Tests.Mappers
{

    public class BookIewModelMapperTests
    {
        private  IMapper _mapper;

        [SetUp]
        public void SetUp()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile<UIProfile>();
            });
            _mapper = config.CreateMapper(); 
        }

        [Test]
        public void BookViewModelMapper_Maps_ValidData()
        {
            //Arrange
            var book = new Book()
            {
                Name = "Test",
                Author = "Thomas Miller",
                Code = "1234",
                Price = 900,
                Rating = 5
            };
            //Act
            var bookVm = _mapper.Map<BookViewModel>(book);

            //Assert
            using var scope = new AssertionScope();
            bookVm.Should().BeOfType<BookViewModel>();
            bookVm.Name.Should().Be("Test");
            bookVm.Code.Should().Be("1234");
            bookVm.Author.Should().Be("Thomas Miller");
            bookVm.Price.Should().Be(900);
            bookVm.Rating.Should().Be(5);

        }
    }
}

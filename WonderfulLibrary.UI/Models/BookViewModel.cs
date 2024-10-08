﻿using FluentValidation;
using System.ComponentModel.DataAnnotations;
namespace WonderfulLibrary.UI.Models;

public class BookViewModel
{
    [Required()]
    public string? Name { get; set; }

    [Required()]
    public string? Author { get; set; }

    [Required()]
    public string? Code { get; set; }

    public decimal Price { get; set; }
    
    public decimal Rating { get; set; }
}
public class BookViewModelValidator : AbstractValidator<BookViewModel>
{
    public BookViewModelValidator() {
        RuleFor(book => book).NotNull();
        RuleFor(book=> book.Name).Length(1,20).WithMessage("Book name is too long");
        RuleFor(book => book.Rating).LessThanOrEqualTo(5).WithMessage("Raing should be between 1 to 5");
    }
}

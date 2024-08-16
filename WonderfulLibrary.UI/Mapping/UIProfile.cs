using AutoMapper;
using DTO;
using WonderfulLibrary.UI.Models;

namespace WonderfulLibrary.UI.Mapping;

public class UIProfile : Profile
{
    public UIProfile()
    {
        CreateMap<Book, BookViewModel>();
    }
}

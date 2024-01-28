using Acme.BookStore.Book;
using AutoMapper;

namespace Acme.BookStore
{
    public class BookStoreApplicationAutoMapperProfile : Profile
    {
        public BookStoreApplicationAutoMapperProfile()
        {
            CreateMap<Acme.BookStore.Books.Book, BookDto>();
            CreateMap<CreateUpdateDTO, Acme.BookStore.Books.Book>();
        }
    }
}

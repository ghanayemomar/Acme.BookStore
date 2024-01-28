using Acme.BookStore.Book;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Acme.BookStore
{
    public class BookService : ApplicationService,IBookService
    {
    }
}

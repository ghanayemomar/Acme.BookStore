﻿using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.Books
{
    public class Book : FullAuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }    
        public BookType Type { get; set; }  
        public DateTime PublishDate { get; set; }   
        public float Price { get; set; }    
    }
}

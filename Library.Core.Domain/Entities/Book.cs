﻿using Library.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Domain.Entities
{
   public class Book: AuditableBaseEntity
    {
        public string Title { get; set; }        
        public string ISBNCode { get; set; }
        public int GenderId { get; set; }
        public int AuthorId { get; set; }
        public string PageNumber { get; set; }
        public bool IsOnlineAvailable { get; set; }
        public string PublicationYear { get; set; }
        public string ProductCondition { get; set; }
        public string Price { get; set; }

        ///
        public OrderDetail OrderDetail { get; set; }
        public Author Author { get; set; }
        public Gender Gender { get; set; }
        public Inventory Inventory { get; set; }


    }
}

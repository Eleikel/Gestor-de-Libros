﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Applicantion.ViewModels.Book
{
   public class SaveBookViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ISBNCode { get; set; }
        public int AuthorId { get; set; }
        public int GenderId { get; set; }
        public string PageNumber { get; set; }
        public bool IsOnlineAvailable { get; set; }
        public string PublicationYear { get; set; }
        public string ProductCondition { get; set; }
        public string Price { get; set; }
    }
    
}

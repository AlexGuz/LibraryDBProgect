﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDBProgect
{
    public class BorrowBook
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public string AutorName { get; set; }        
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public DateTime BorrowedTime { get; set; }
        public bool IsReturned { get; set; }
    }
}
﻿namespace Entities
{
    public class BookCopy
    {
        public BookCopy(){}

        public BookCopy(int idBookCopy, int idBook)
        {
            BookCopyID = idBookCopy;
            BookID = idBook;
        }

        public BookCopy(int bookId)
        {
            BookID = bookId;
        }

        public int BookCopyID { get; set; }
        public int BookID { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study_1
{
    internal class Book : BookType
    {
        public int ISBN { get; set; }
        public string? author { get; set; }
        public string? title { get; set; }
        public int price { get; set; }
        int j = 0;
        public string? availability { get; set; }
        public static Book[] books = new Book[3];
        public void SearchBook(int isbn)
        {
           
                if (books[0].ISBN ==isbn)
                {
                    Console.WriteLine("Book is Present");
                }
                else
                {
                    Console.WriteLine("Book dose not exist");
                }
          
        }
        public void viewBooks()
        {

           
             //   Console.WriteLine(books[0].title);
                Console.WriteLine("ISBN : {0}\tAuthor : {1}\t title : {2} \t Price : {3} \t availability : {4}\t type {5}", books[0].ISBN, books[0].author, books[0].title, books[0].price, books[0].availability, books[0].type);
            
            // Console.WriteLine("ISBN : {0}\tAuthor : {1}\t title : {2} \t Price : {3} \t availability : {4}\t type {5}", book.ISBN,book.author, book.title, book.price, book.availability, book.type);

        }



        public void AddBook(Book book)
        {
           
            books[j] = book;
            j++;
            
            // Console.WriteLine("ISBN : {0}\tAuthor : {1}\t title : {2} \t Price : {3} \t availability : {4}\t type {5}", book.ISBN,book.author, book.title, book.price, book.availability, book.type);
            //Console.WriteLine("ISBN : {0}\tAuthor : {1}\t title : {2} \t Price : {3} \t availability : {4}\t type {5}", books[0].ISBN, books[0].author,books[0].title, books[0].price, books[0].availability, books[0].type);

        }

    }
}


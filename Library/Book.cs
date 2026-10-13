using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {

        private string title;
        private string author;
        private string isbn;



        public string Title
        {
            get { return title; }
            private set
            {
                if (value != null && value.Length > 0)
                {
                    title = value;
                }
                else
                {
                    Console.WriteLine("Error: Title cannot be empty.");
                }
            }
        }

        public string Author
        {
            get { return author; }
            private set
            {
                if (value != null && value.Length > 0)
                {
                    author = value;
                }
                else
                {
                    Console.WriteLine("Error: Author cannot be empty.");
                }
            }
        }

        public string ISBN
        {
            get { return isbn; }
            private set
            {
                if (value != null && value.Length > 0)
                {
                    isbn = value;
                }
                else
                {
                    Console.WriteLine("Error: ISBN cannot be empty.");
                }
            }
        }


        public Book(string bookTitle, string bookAuthor, string bookISBN)
        {
            this.Title = bookTitle;
            this.Author = bookAuthor;
            this.ISBN = bookISBN;
        }
                
        


        public void DisplayInfo()
        {
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();
        }
    }
} 
    

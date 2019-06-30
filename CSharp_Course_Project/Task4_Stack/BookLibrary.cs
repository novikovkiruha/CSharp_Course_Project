using CSharp_Course_Project.Task1_StudentList;
using System;
using System.Collections.Generic;

namespace CSharp_Course_Project.Task4_Stack
{
    public class BookLibrary
    {
        private Dictionary<int, string> books = new Dictionary<int, string>()
        {
            { 1, "It" },
            { 2, "The Shining" },
            { 3, "Cell" },
            { 4, "The Dark Tower" },
            { 5, "Pet Sematary" },
            { 6, "Misery" },
            { 7, "The Stand" },
            { 8, "Needful Things" },
            { 9, "11/22/63" },
            { 10, "The Green Mile" },
        };

        public Dictionary<int, string> Books
        {
            get
            {
                return this.books;
            }
            private set
            {
                this.books = value;
            }
        }

        public string GiveBook()
        {
            string selectedBook = "";
            foreach (var book in this.books)
            {
                Console.WriteLine($"{book.Key} - {book.Value}");
            }
            Console.Write("Enter a number to choose a book: ");
            bool bookNumber = Int32.TryParse(Console.ReadLine(), out int bookKey);

            if (this.books.ContainsKey(bookKey))
            {
                this.books.TryGetValue(bookKey, out selectedBook);
            }

            return selectedBook;
        }
    }
}

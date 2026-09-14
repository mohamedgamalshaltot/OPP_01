using System.Drawing;

namespace OPP_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 04 in session 05
            //4-Declare an enum Genre { Fiction, NonFiction, Science }. Add a Genre
            //property to Book, assign it Genre.Science, and print it.
            Book myBook = new Book();
            myBook.BookGenre = Genre.Science;
            Console.WriteLine(myBook.BookGenre);
            #endregion
        }
    }
}

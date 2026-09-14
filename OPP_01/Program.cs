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
            #region Question 05 in session 05
            //5-Using the Genre enum above, print the underlying int value of
            //Genre.Fiction, Genre.NonFiction, and Genre.Science by casting each to int.
            Console.WriteLine((int)Genre.Fiction);
            Console.WriteLine((int)Genre.NonFiction);
            Console.WriteLine((int)Genre.Science);
            #endregion
            #region 

            #endregion
        }
    }
}

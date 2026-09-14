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
            #region Question 06 in session 05
            //6-Given int genreNumber = 1;, cast it into a Genre value and print the result.
            int genreNumber = 1;
            Genre genre = (Genre)genreNumber;
            Console.WriteLine(genre);
            #endregion
            #region Question 07 in session 05
            //7-Given string genreText = "Science";, convert it into a Genre value using
            //             Enum.Parse() and print the result.
            string genreText = "Science";
            Genre genre01 = (Genre)Enum.Parse(typeof(Genre), genreText);
            Console.WriteLine(genre01);
            #endregion
            #region  Question 08 in session 05
            // 8-Given string genreText = "Mystery"; (not a valid Genre value), use
            // Enum.TryParse() to attempt the conversion. Print "Unknown genre" if it
            //fails.
            string genreText01 = "Mystery";
            if (Enum.TryParse(typeof(Genre), genreText01, out object result))
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Unknown genre");
            }
            #endregion

        }
    }
}

using System.Collections;
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

            #region opp01 Part01 Question01 (A)
            //a) What happens when a DeliveryAddress variable is copied into another variable and the copy is modified?
            //* Since ⁠DeliveryAddress⁠ is defined as a ⁠struct⁠, it is a Value Type.When copied, a completely independent copy of the value is created in memory(on the Stack).Modifying the copied variable will not affect the original variable.
            //(b)b) What happens when a Customer variable is copied into another variable and one variable modifies the object
            //* Since ⁠Customer⁠ is defined as a ⁠class⁠, it is a Reference Type.When copied, both variables point to the same object in memory(on the Heap).Modifying the object through one variable will affect the other variable since they reference the same object.
            #endregion
            #region opp01 Part01 Question02
            //a) a) Identify at least three problems with this design from an encapsulation perspective.
            //* The fields are public, which violates encapsulation principles.Encapsulation suggests that fields should be private and accessed through public methods or properties.
            //* The class lacks validation logic for the fields, which can lead to invalid states or data inconsistencies.
            //*Flexibility & Immutability: Properties allow creating read-only fields (by omitting the ⁠set⁠ accessor or making it ⁠private⁠/⁠init⁠), ensuring data integrity after initialization.
            #endregion

        }
    }
}

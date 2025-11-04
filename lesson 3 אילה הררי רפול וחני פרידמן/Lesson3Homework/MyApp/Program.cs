using Data;

namespace MyApp
{
    internal class Program
    {
        public static bool IsHard(Book b) => b.HardCover ;
        //public static bool IsHard2(Book b)
        //{// if (b.HardCover==true)
        ////      return true;
        ////  return false;
        //    return b.HardCover == true;
        //}

        
        static void Main(string[] args)
        {
            //Shelf shelf = new Shelf();
            Shelf shelf = new ();

            shelf.Books.Add(new Book()
            {
                Title = "Yaldey shay",
                Author = "David",
                HardCover = true,
                Price = 75
            });
            try
            {
                shelf.AddBook(new Book("Noach bar moach", "Naama", false, -5));
                // לכאן לא ממשיכים
                //shelf.Books.Add();
                shelf.Books.Add(new Book("Bedarkey raboteinu", "Yaakov", true, 120));
                shelf.Books.Add(new Book("Maagal sagur", "Chana", false, 40));
                shelf.Books.Add(new Book("Avigail bat hachail", "Yael", true, 80));
                shelf.Books.Add(new Book("Avigail", "Yael", true, 60));
            }
            catch (Exception ex)
            {
                // טיפול בשגיאה
               // return "status 404";
            }
            finally // בכל מקרה
            { 
            
            }
            //1
            var x= shelf.Books.FindAll(IsHard);

            var x2 = shelf.Books.FindAll(b => !b.HardCover && b.Price<60 );
            Console.WriteLine("כריכה רכה וקטנה מ 60"+x2);

            //2
            Console.WriteLine("Books by Yael:");
            foreach (var b in shelf.Books.Where(b => b.Author == "Yael"))
                Console.WriteLine(b.Title);



            //3
            var booksStartingWithT = shelf.Search(b => b.Title.StartsWith("T"));
            Console.WriteLine("Books starting with 'T':");
            booksStartingWithT.ForEach(Console.WriteLine);
            Console.ReadLine();

            //4
            Console.WriteLine("Books upe 50 ₪:");
            foreach (var b in shelf.Books.Where(b => b.Price > 50))
                Console.WriteLine(b);





            shelf.Search(IsHard);




        }
    }
}

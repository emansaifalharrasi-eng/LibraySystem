namespace LibraySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //phayse1: system storage
            string[] booktitles = new string[100];
            string[] bookISBNs = new string[100];
            string[] bookavailabilitystatus = new string[100];
            bool availability = false;
            string[] borrowernames = new string[100];
            string[] bookauthors = new string[100];
            int LastbookIndextracker = -1;

            //seed data
            booktitles[0] = "Ahmed";
            bookISBNs[0] = "1568";
            borrowernames[0] = "77";
            LastbookIndextracker++;


            booktitles[1] = "Ali";
            bookISBNs[1] = "1346";
            borrowernames[1] = "50";
            LastbookIndextracker++;



            bool exit = false;



            while (true)
            {
                Console.WriteLine("Welcome to the Libray System");
                Console.WriteLine("1.Add NewBook");
                Console.WriteLine("2.Borrow Book");
                Console.WriteLine("3. Return Book");
                Console.WriteLine("4. Search Book");
                Console.WriteLine("5.List All Availability Books ");
                Console.WriteLine("6.Transfer Book");
                Console.WriteLine("7 .Exit");
                Console.Write("Please select an option: ");

                int option = int.Parse(Console.ReadLine());




                switch (option)
                {
                    case 1:

                 
                        Console.Write("Enter the book title: ");
            
                        booktitle[LastbookIndextracker] = Console.ReadLine();

                        Console.Write("Enter the author name: ");
                        bookauthor[LastbookIndextracker ] = Console.ReadLine();

                        Console.Write("Enter the ISBN");
                        ISBN string [LastbookIndextracker] = string .Parse(Console.ReadLine());

                        [LastbookIndex + 1] =  + [LastbookIndex + 1];




                        Console.WriteLine("The book is Added sucssfully");
                        Console.WriteLine("ISBN is: " + LastbookIndextracker + 1  ");

                            LastbookIndextracker++;


                        break;

                    case 2:



                        Console.Write("Enter the book title: ");
                        string booktitle = Console.ReadLine();
                        Console.Write("Enter the author name: ");
                        string bookauthor =(Console.ReadLine());




                        break;

                    case 3:
                        break;

                    case 4:
                        break;

                    case 5:
                        break;

                    case 6:
                        break;

                    case 7:

                        Exit = true;
                        break;






                        Console.WriteLine("");
                }
            }
        }
    }
}

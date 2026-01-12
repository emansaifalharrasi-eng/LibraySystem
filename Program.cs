using System.Data;

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
            bool[] availability = new bool[100];
            string[] borrowernames = new string[100];
            string[] bookauthors = new string[100];
            int LastbookIndextracker = -1;

            //seed data
            booktitles[0] = "math";
            bookISBNs[0] = "1";
            borrowernames[0] = " ";
            availability[0] = true;
            LastbookIndextracker++;


            booktitles[1] = "cats";
            bookISBNs[1] = "2";
            borrowernames[1] = "asma";
            LastbookIndextracker++;
            availability[1] = false; ;


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


                        Console.Write("Enter the book title ");

                        booktitles[LastbookIndextracker] = Console.ReadLine();

                        Console.Write("Enter the author name ");
                        bookauthors[LastbookIndextracker] = Console.ReadLine();

                        Console.Write("Enter the ISBN");
                        bookISBNs[LastbookIndextracker] = Console.ReadLine();

                        bookISBNs[LastbookIndextracker] = "id" + LastbookIndextracker + 1;




                        Console.WriteLine("The new book is Added sucssfully");
                        Console.WriteLine("ISBN is: " + bookISBNs[LastbookIndextracker]);

                        LastbookIndextracker++;


                        break;

                    case 2:   

                        Console.Write("Enter the book title or the ISBN ");
                        string keybook = (Console.ReadLine());


                        bool bookfounded = false;

                        for (int i = 0; i < 100; i++)
                        {
                            if (keybook == booktitles[i] || keybook == booktitles[i])
                            {
                                borrowernames[i] = borrowername;
                                

                                bookfounded = true;
                              if ( availability[i] == true)
                                {
                                    Console.Write("Enter the borrower name ");
                                    string borrowername = (Console.ReadLine());
                                     availability[i] = false ;
                                    Console.WriteLine("Book borrowed succeful");
                                    

                                    }
                              else
                                {
                                    Console.WriteLine("book borrowed already");
                                }
                                break;


                            }



                            break;


                        }


                        if (bookfounded == false)

                        {
                            Console.WriteLine("sorry book not found");
                        }
                        else
                        {
                            Console.WriteLine(" the book is founded successful!");


                        }


                        break;


                    case 3:


                        Console.Write("Enter the book the ISBN ");
                        string ISBNs = (Console.ReadLine());


                        bool bookFounded = false;

                        for (int i = 0; i < 100; i++)
                        {
                            if (ISBNs == bookISBNs[i])
                            {



                                bookfounded = true;
                                if (availability[i] == false)
                                {
                                    Console.WriteLine("Enter the borrowname ");
                                    string borrowname = (Console.ReadLine());
                                    availability[i] = true;
                                    Console.WriteLine(" the book is returned successful!");

                                }

                                else
                                {
                                    Console.WriteLine("this book was no borrowed");
                                }

                                break;
                            }

                        }
                      if(bookFounded == false)
                        {
                            Console.WriteLine("sorry Book not found");
                        }
                        break;
                       

                            

                        
                            



                        



                 

                    case 4:

                        break;

                    case 5:
                        break;

                    case 6:
                        break;

                    case 7:

                      
                        break;






                        
                }
            }
        }
    }
}

        

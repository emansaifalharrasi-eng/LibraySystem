using System.ComponentModel.Design;
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
            int Lastindex = 0;

            //seed data
            booktitles[0] = "arabic";
            bookISBNs[0] = "1";
            bookauthors[0] = "Ahmed";
            borrowernames[0] = " ";
            availability[0] = true;
            Lastindex++;


            booktitles[1] = "cats";
            bookISBNs[1] = "2";
            borrowernames[1] ="Ali ";
            availability[1] = false;
            Lastindex++;




            booktitles[2] = "math";
            bookISBNs[2] = "3";
            borrowernames[0] = "Sara ";
            availability[2] = false;
            Lastindex++;




            bool exit = false;



            while (exit == false)
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

                        booktitles[Lastindex] = Console.ReadLine();

                        Console.Write("Enter the author name ");
                        bookauthors[Lastindex] = Console.ReadLine();

                        Console.Write("Enter the ISBN");
                        bookISBNs[Lastindex] = Console.ReadLine();

                        bookISBNs[Lastindex] = "id" + Lastindex + 1;




                        Console.WriteLine("The new book is Added sucssfully");
                        Console.WriteLine("ISBN is: " + bookISBNs[Lastindex]);



                        break;

                    case 2:

                        Console.Write("Enter the book title or the ISBN ");
                        string keybook = (Console.ReadLine());


                        bool bookfounded = false;

                        for (int i = 0; i < Lastindex; i++)
                        {
                            if (keybook == booktitles[i] || keybook == booktitles[i])
                            {
                                borrowernames[i] = keybook;


                                bookfounded = true;
                                if (availability[i] == true)
                                {
                                    Console.Write("Enter the borrower name ");
                                    string borrowername = (Console.ReadLine());
                                    availability[i] = false;
                                    Console.WriteLine("Book borrowed successfully");


                                }
                                else
                                {
                                    Console.WriteLine("book borrowed already");
                                }
                                break;


                            }


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

                        for (int i = 0; i < Lastindex; i++)
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

                                    borrowernames[i] = "";

                                }

                                else
                                {
                                    Console.WriteLine("this book was no borrowed");
                                }

                                break;
                            }

                        }
                        if (bookFounded == false)
                        {
                            Console.WriteLine(" Book retuned sucssfully");
                        }
                        break;


                    case 4:


                        Console.Write("Enter the book title or the ISBN ");
                        string searchbook = Console.ReadLine();

                        bool isbookFounded = false;

                        for (int i = 0; i < Lastindex; i++)
                        {
                            if (searchbook == booktitles[i])
                            {

                                bookFounded = true;

                                Console.WriteLine("booktitle" + booktitles[i]);
                                Console.WriteLine("bookauthor" + bookauthors[i]);
                                Console.WriteLine("available" + availability[i]);




                                {
                                    if (bookFounded == false)

                                        Console.WriteLine("the book not available");

                                }
                            }


                        }

                        break;

                    case 5:

                        Console.WriteLine("the available book");


                        bool BookAvailable = false;

                        for (int i = 0; i < Lastindex; i++)
                        {
                            if (availability[i] == true)

                            {
                                Console.WriteLine("Book Title:" + booktitles[i]);
                                Console.WriteLine("Book Author:" + bookauthors[i]);
                                Console.WriteLine("Book ISBNs:" + bookISBNs[i]);


                                BookAvailable = true;
                            }
                            break;
                        }
                        if (BookAvailable == false)
                        {
                            Console.WriteLine("the book not available");
                        }


                        break;

                    case 6:

                        Console.WriteLine("the first borrower");
                        string firstborrower = Console.ReadLine();

                        Console.WriteLine("the second borrower");
                        string secondborrower = Console.ReadLine();

                      

                        bool firstborrowerFound = false;
                        int firstborrowerindex = 0;

                        for (int i = 0; i < Lastindex; i++)
                        {
                            if (firstborrower == borrowernames[i])
                            {
                                firstborrowerindex = i;
                                firstborrowerFound = true;


                                break;
                            }
                        }

                        if (firstborrowerFound == false)

                        {
                            Console.WriteLine("first borrower not found");

                        }
                        else
                        {


                            bool secondBorrowerFound = false;

                            int secondborrowerindex = 0;
                            for (int i = 0; i < Lastindex; i++)
                            {
                                if (secondborrower == borrowernames[i])
                                {
                                    secondborrowerindex = i;

                                    secondBorrowerFound = true;
                                    break;

                                }
                            }

                            if (secondBorrowerFound == false)
                            {
                                Console.WriteLine("New borrower name not found");
                            }
                            else
                            {




                                string temp = "";
                                temp = borrowernames[firstborrowerindex];

                                borrowernames[firstborrowerindex] = borrowernames[secondborrowerindex];
                                borrowernames[secondborrowerindex] = temp;

                            }
                        }

                        break;

                    case 7:

                        if (exit = true)
                        {


                            Console.WriteLine("Thank you for using the Bank System, press any key");
                            Console.ReadLine();
                            Console.Clear();
                        }

                        break;

                    default:
                        Console.WriteLine("Invalid option.please try again");
                        break;

                }


                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }












                }
                                    }


                                }
                            
                        
               











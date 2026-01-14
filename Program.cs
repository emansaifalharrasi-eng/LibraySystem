using System.ComponentModel.Design;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

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


            string[] category = new string[100];
            int[] borrowCount = new int[100];
            double[] lateFees = new double[100];

            int LastIndex = 0;





            //seed data
            booktitles[LastIndex] = "arabic";
            bookISBNs[LastIndex] = "1";
            bookauthors[LastIndex] = "Ahmed";
            borrowernames[LastIndex] = " ";
            availability[LastIndex] = true;

            category[0] = "Ficiton";
            borrowCount[0] = 5;
            lateFees[LastIndex] = 0;

            LastIndex++;


            booktitles[1] = "cats";
            bookISBNs[1] = "2";
            borrowernames[1] = "Ali ";
            availability[1] = false;

            category[1] = "Science";
            borrowCount[1] = 2;
            lateFees[LastIndex] = 0;

            LastIndex++;


            booktitles[2] = "math";
            bookISBNs[2] = "3";
            borrowernames[2] = "Sara ";
            availability[2] = true;


            category[2] = "History";
            borrowCount[2] = 4;
            lateFees[LastIndex] = 0;

            LastIndex++;




            bool exit = false;



            while (exit == false)
            {
                Console.WriteLine("Welcome to the Libray System");
                Console.WriteLine("1. Add NewBook");
                Console.WriteLine("2. Borrow Book");
                Console.WriteLine("3. Return Book");
                Console.WriteLine("4. Search Book");
                Console.WriteLine("5. List All Availability Books ");
                Console.WriteLine("6. Transfer Book");
                Console.WriteLine("7. Search Books by Category ");
                Console.WriteLine("8. View Most Popular Books");
                Console.WriteLine("9. Calculate Total Late Fees  ");
                Console.WriteLine("10 .Exit");
                Console.Write("Please select an option: ");

                int option = int.Parse(Console.ReadLine());




                switch (option)
                {
                    case 1:


                        Console.Write("Enter the book title ");

                        booktitles[LastIndex] = Console.ReadLine();

                        Console.Write("Enter the author name ");
                        bookauthors[LastIndex] = Console.ReadLine();

                        Console.Write("Enter the ISBN");
                        bookISBNs[LastIndex] = Console.ReadLine();

                        bookISBNs[LastIndex] = "id" + LastIndex + 1;

                        Console.WriteLine("Enter the category of book");
                        category[LastIndex] = Console.ReadLine();




                        availability[LastIndex] = true;
                        borrowernames[LastIndex] = "";
                        borrowCount[LastIndex] = 0;
                        lateFees[LastIndex] = 0;



                        Console.WriteLine("The new book is Added sucssfully");


                        break;

                    case 2:

                        Console.Write("Enter the book title or the ISBN ");
                        string borrowInput = (Console.ReadLine());


                        bool borrowfound = false;

                        for (int i = 0; i < LastIndex; i++)
                        {
                            if (booktitles[i] == borrowInput || bookISBNs[i] == borrowInput)
                            {
                                borrowfound = true;


                                if (availability[i] == true)
                                {
                                    Console.Write("Borrower name: ");
                                    borrowernames[i] = Console.ReadLine();
                                    availability[i] = false;
                                    borrowCount[i]++;
                                    lateFees[i] = 0;

                                    Console.WriteLine("Book borrowed successfully!");
                                    Console.WriteLine("This book has been borrowed " + borrowCount[i] + " times"); 
                                }
                                else
                                {
                                    Console.WriteLine("Book already borrowed by: " + borrowernames[i]);
                                }
                            }
                        }

                        break;

                    case 3:


                        Console.Write("Enter the book the ISBN or Title ");
                        string returnInput = (Console.ReadLine());


                        bool returnFound = false;

                        for (int i = 0; i < LastIndex; i++)
                        {
                            if (booktitles[i] == returnInput || bookISBNs[i] == returnInput)
                            {



                                returnFound = true;

                                if (availability[i] == false)
                                {

                                    Console.Write("Is the book returned late? (yes/no): ");
                                    string isLate = Console.ReadLine().ToLower();

                                    if (isLate == "yes")
                                    {
                                        Console.Write("Enter number of days late: ");
                                        int daysLate = int.Parse(Console.ReadLine());
                                        double feePerDay = 0.5;
                                        lateFees[i] = daysLate * feePerDay;

                                        Console.WriteLine("Late fee calculated: " + lateFees[i] + " OMR");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Book returned on time");
                                        lateFees[i] = 0;
                                    }

                                    borrowernames[i] = "";
                                    availability[i] = true;
                                    Console.WriteLine("Book returned successfully!");
                                }
                                else
                                {
                                    Console.WriteLine("This book was not borrowed");
                                }

                                break;
                            }
                        }

                        if (returnFound == false)
                        {
                            Console.WriteLine("Book not found");
                        }


                        break;


                    case 4:


                        Console.Write("Enter the book title or the ISBN ");
                        string searchInput = Console.ReadLine();

                        bool searchFound = false;

                        for (int i = 0; i < LastIndex; i++)
                        {
                            if (booktitles[i] == searchInput || bookISBNs[i] == searchInput)

                            {

                                searchFound = true;

                                Console.WriteLine("booktitle" + booktitles[i]);
                                Console.WriteLine("bookauthor" + bookauthors[i]);
                                Console.WriteLine("bookISBNs " + bookISBNs[i]);
                                Console.WriteLine("available" + availability[i]);
                                Console.WriteLine("category of book" + category[i]);
                                Console.WriteLine("Times Borrowed: " + borrowCount[i]);

                                if (availability[i] == false)
                                {
                                    Console.WriteLine("Current Borrower: " + borrowernames[i]);
                                }

                                Console.WriteLine("----------------------------------------");

                                break;
                            }
                        }

                        if (searchFound == false)
                        {
                            Console.WriteLine("Book not found");
                        }


                        break;

                    case 5:


                        Console.WriteLine("Available Books:");


                        bool hasAvailable = false;
                        for (int i = 0; i <= LastIndex; i++)
                        {
                            if (availability[i] == true)
                            {
                                Console.WriteLine("Title: " + booktitles[i] + " | Author: " + bookauthors[i] + " | ISBN: " + bookISBNs[i] + " | Category: " + category[i]);
                                hasAvailable = true;
                            }
                        }

                        if (hasAvailable == false)
                        {
                            Console.WriteLine("No books available at the moment");
                        }

                        break;





                    case 6:


                        Console.WriteLine("the first borrower");
                        string firstborrower = Console.ReadLine();

                        Console.WriteLine("the second borrower");
                        string secondborrower = Console.ReadLine();



                        bool firstborrowerFound = false;
                        int firstborrowerindex = 0;

                        for (int i = 0; i < LastIndex; i++)
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
                            for (int i = 0; i < LastIndex; i++)
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


                        Console.Write("Enter the book category ");

                        string searchCat = Console.ReadLine();


                        bool catFound = false;


                        Console.WriteLine("Books in category '" + searchCat + "':");



                        for (int i = 0; i < LastIndex; i++)
                        {
                            if (category[i].ToLower() == searchCat.ToLower())

                            {

                                catFound = true;
                                string availabilityStatus = availability[i] ? "Available" : "Borrowed";
                                Console.WriteLine("ISBN: " + bookISBNs[i] + " | Title: " + booktitles[i] + " | Author: " + bookauthors[i] + " | Status: " + availabilityStatus);
                            }
                        }

                        if (catFound == false)
                        {
                            Console.WriteLine("No books found in this category");
                        }


                        break;


                    case 8:

                        Console.WriteLine("Most Popular Books (by borrow count):");


                        // Simple sorting by displaying in order
                        for (int count = 100; count >= 0; count--) // Start from highest possible count
                        {
                            for (int i = 0; i <= LastIndex; i++)
                            {
                                if (borrowCount[i] == count)
                                {
                                    Console.WriteLine("ISBN: " + bookISBNs[i] + " | Title: " + booktitles[i] + " | Author: " + bookauthors[i] + " | Category: " + category[i] + " | Times Borrowed: " + borrowCount[i]);
                                }
                            }
                        }


                        break;

                    case 9:

                        Console.WriteLine("Late Fees Report:");
                        Console.WriteLine("1. System-wide total");
                        Console.WriteLine("2. Individual borrower");
                        Console.Write("Choose option: ");
                        int feeOption = int.Parse(Console.ReadLine());

                        if (feeOption == 1)
                        {
                            // System-wide total
                            double totalFees = 0;

                            for (int i = 0; i <= LastIndex; i++)
                            {
                                totalFees += lateFees[i];
                            }

                            Console.WriteLine("----------------------------------------");
                            Console.WriteLine("Total late fees collected: " + totalFees + " OMR");
                        }
                        else if (feeOption == 2)
                        {
                            // Individual borrower
                            Console.Write("Enter borrower name: ");
                            string borrowerName = Console.ReadLine();

                            double borrowerFees = 0;
                            bool borrowerFoundForFees = false;

                            for (int i = 0; i <= LastIndex; i++)
                            {
                                if (borrowernames[i] == borrowerName || (borrowernames[i] == "" && lateFees[i] > 0))
                                {
                                    // Check if this borrower had late fees
                                    borrowerFees += lateFees[i];
                                    borrowerFoundForFees = true;
                                }
                            }

                            Console.WriteLine("----------------------------------------");
                            if (borrowerFoundForFees == true)
                            {
                                Console.WriteLine("Late fees for " + borrowerName + ": " + borrowerFees + " OMR");
                            }
                            else
                            {
                                Console.WriteLine("No late fees found for this borrower");
                            }
                        }

                        break;


                    case 10:


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



                break;
            }
        }
    }
}

                            












                        
                
            
        
    

    

                                    


                                
                            
                        
               











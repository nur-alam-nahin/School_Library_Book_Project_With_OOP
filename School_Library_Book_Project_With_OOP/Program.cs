using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Library_Book_Project_With_OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Entites.Book> book = new List<Entites.Book>();

           

            int num;
            do
            {
                Console.WriteLine("-----Book managment system----");
                Console.WriteLine("1. add book ");
                Console.WriteLine("2. print book ");
                Console.WriteLine("3. Exit");
                Console.Write("Chose num = ");
                num = Convert.ToInt32(Console.ReadLine());
                if(num > 0 && num < 3)
                {

                    switch (num)
                    {
                        case 1:
                            Console.Write("Book Name = ");
                            string bookName = Console.ReadLine();

                            Console.Write("Category (Printed/Digital): ");
                            string category = Console.ReadLine();

                            Console.Write("Price = ");
                            double price = Convert.ToDouble(Console.ReadLine());

                            Entites.BookCategory BookCategory = new Entites.BookCategory(category);
                            Entites.Book newBook = new Entites.Book(bookName, price, BookCategory);

                            book.Add(newBook);
                            break;


                        case 2:
                            foreach(var b in book)
                            {
                                Services.PriceCalculator calculator;
                                if(b.getCategory().getCategoryName() == "Printed")
                                {
                                    calculator = new Services.PrintedBookCalculator(b);
                                }
                                else
                                {
                                    calculator = new Services.DigitalBookCalculator(b);
                                }

                                Console.WriteLine("Book = " + b.getTitle());
                                Console.WriteLine("Category = " + b.getCategory().getCategoryName());
                                Console.WriteLine("Price = " + b.getPrice());
                                Console.WriteLine("Final price = " + calculator.calculateFinalPrice());
                                Console.WriteLine();
                            }
                            break;
                    }
                }
                else
                {
                    if(num == 3)
                    Environment.Exit(3);
                }


            } while (true);






            //Entites.BookCategory printedBookCategory = new Entites.BookCategory("Printed");
            //Entites.BookCategory digitalBookCategory = new Entites.BookCategory("Digital");


            //Entites.Book book1 = new Entites.Book("the Philosopher's Stone", 500, printedBookCategory);
            //Entites.Book book2 = new Entites.Book("the Philosopher's Stone", 450, digitalBookCategory);

            //Services.PriceCalculator printedBookCalculator = new Services.PrintedBookCalculator(book1);
            //Services.PriceCalculator digitalBookCalculator = new Services.DigitalBookCalculator(book2);

            //Console.WriteLine("Book = " + book1.getTitle());
            //Console.WriteLine("Category = " + book1.getCategory());
            //Console.WriteLine("Base Price = " + book1.getPrice());
            //Console.WriteLine("Final Book = " + printedBookCalculator.calculateFinalPrice());
            //Console.WriteLine();

            //Console.WriteLine("Book = " + book2.getTitle());
            //Console.WriteLine("Category = " + book2.getCategory().getCategoryName());
            //Console.WriteLine("Base Price = " + book2.getPrice());
            //Console.WriteLine("Final Book = " + digitalBookCalculator.calculateFinalPrice());



           

        }
    }
}

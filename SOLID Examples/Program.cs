using SOLID_Examples.LSP_Applied;
using SOLID_Examples.LSP_Violation;
using SOLID_Examples.OCP_Applied_Example;
using SOLID_Examples.SRP_Applied_Example;
using System;
using System.Collections.Generic;
using SOLID_Examples.ISP_Applied;
using SOLID_Examples.DSP_Applied;

namespace SOLID_Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region SRP examples

            // Example 1 with SRP
            SRP_Applied_Example.BankAccount johnsAccount = new SRP_Applied_Example.BankAccount(123456);
            johnsAccount.Deposit(500);
            johnsAccount.Withdraw(100);
            StatementPrinter printer = new StatementPrinter();
            printer.Print(johnsAccount);
            
            // Example 2 with SRP
            Student alice = new Student { Name = "Alice" };
            alice.EnrollCourse("Mathematics");
            alice.AssignGrade("Mathematics", 90);
            GPACalculator gpaCalc = new GPACalculator();
            TranscriptGenerator transcriptGen = new TranscriptGenerator(gpaCalc);
            transcriptGen.PrintTranscript(alice);

            #endregion

            #region  OCP examples

            // Example 1 with SRP
            Console.WriteLine("Invoice Amount: 10000");
            Invoice FInvoice = new FinalInvoice();
            double FInvoiceAmount = FInvoice.GetInvoiceDiscount(10000);
            Console.WriteLine($"Final Invoice : {FInvoiceAmount}");
            Invoice PInvoice = new ProposedInvoice();
            double PInvoiceAmount = PInvoice.GetInvoiceDiscount(10000);
            Console.WriteLine($"Proposed Invoice : {PInvoiceAmount}");
            Invoice RInvoice = new RecurringInvoice();
            double RInvoiceAmount = RInvoice.GetInvoiceDiscount(10000);
            Console.WriteLine($"Recurring Invoice : {RInvoiceAmount}");
            
            // Example 2 with SRP
            var regularDiscount = new RegularDiscount();
            var calculator = new DiscountCalculator(regularDiscount);
            double discountedPrice = calculator.CalculateDiscount(100); // 10% discount applied
            var premiumDiscount = new PremiumDiscount();
            calculator = new DiscountCalculator(premiumDiscount);
            discountedPrice = calculator.CalculateDiscount(100); // 30% discount applied

            #endregion

            #region  LSP examples

            // Example 1 violating LSP
            LSP_Violation.Apple apple = new LSP_Violation.Orange();
            Console.WriteLine(apple.GetColor());

            // Example 2 with LSP
            LSP_Applied.IFruit fruit = new LSP_Applied.Orange();
            Console.WriteLine($"Color of Orange: {fruit.GetColor()}");
            fruit = new LSP_Applied.Apple();
            Console.WriteLine($"Color of Apple: {fruit.GetColor()}");

            // Example 3 with LSP
            Console.WriteLine("RegularAccount:");
            var RegularBankAccount = new RegularAccount();
            RegularBankAccount.Deposit(1000);
            RegularBankAccount.Deposit(500);
            RegularBankAccount.Withdraw(900);
            RegularBankAccount.Withdraw(800);
            Console.WriteLine("\nFixedTermDepositAccount:");
            var FixedTermDepositBankAccount = new LSP_Applied.FixedTermDepositAccount();
            FixedTermDepositBankAccount.Deposit(1000);
            FixedTermDepositBankAccount.Withdraw(500);

            #endregion

            #region  ISP examples

            // Example 1 with ISP
            //Using HPLaserJetPrinter we can access all Printer Services
            HPLaserJetPrinter hPLaserJetPrinter = new HPLaserJetPrinter();
            hPLaserJetPrinter.Print("Printing");
            hPLaserJetPrinter.Scan("Scanning");
            hPLaserJetPrinter.Fax("Faxing");
            hPLaserJetPrinter.PrintDuplex("PrintDuplex");
            //Using LiquidInkjetPrinter we can only Access Print and Scan Printer Services
            LiquidInkjetPrinter liquidInkjetPrinter = new LiquidInkjetPrinter();
            liquidInkjetPrinter.Print("Printing");
            liquidInkjetPrinter.Scan("Scanning");

            // Example 2 with ISP
            Console.WriteLine("Librarian:");
            Librarian librarian = new Librarian();
            Book book = new Book()
            {
                BookId = "BK-10001",
                Title = "SOLID Principle using C#",
                Author = "Jamie King",
                ISBN = "ISBN-Demo"
            };
            librarian.AddBook(book);
            librarian.BorrowBook(book.BookId);
            librarian.SearchCatalog("SOLID");
            librarian.ReturnBook(book.BookId);
            librarian.RemoveBook(book.BookId);
            Console.WriteLine("\nMember:");
            Member member = new Member();
            //member.AddBook(book); //Compile Time Error
            member.BorrowBook(book.BookId);
            member.SearchCatalog("SOLID");
            member.ReturnBook(book.BookId);
            //member.RemoveBook(book.BookId); //Compile Time Error
            Console.WriteLine("\nMember:");
            Guest guest = new Guest();
            //guest.AddBook(book); //Compile Time Error
            //guest.BorrowBook(book.BookId); //Compile Time Error
            guest.SearchCatalog("SOLID");
            //guest.ReturnBook(book.BookId); //Compile Time Error
            //guest.RemoveBook(book.BookId); //Compile Time Error

            #endregion

            #region  DSP examples

            // Example 1 with DSP
            //Now, when initializing the NotificationService, 
            //we can decide which logger to use:
            var consoleLogger = new ConsoleLogger();
            var notificationService1 = new NotificationService(consoleLogger);

            var fileLogger = new FileLogger("path_to_log_file.txt");
            var notificationService2 = new NotificationService(fileLogger);

            // Example 2 with DSP
            var creditCardPayment = new CreditCard();
            var paymentProcessor1 = new PaymentProcessor(creditCardPayment);
            paymentProcessor1.ExecutePayment(100m);

            var paypalPayment = new PayPal();
            var paymentProcessor2 = new PaymentProcessor(paypalPayment);
            paymentProcessor2.ExecutePayment(100m);

            #endregion

            Console.ReadKey();
        }
    }
}

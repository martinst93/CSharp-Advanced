using Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InvoiceApp
{
    public class EntryPoint
    {
        public static void Main(string[] args)
        {
            List<User> users = new List<User>();

            User Peter = new User("Peter", "Thomson", "PT", "444", 400, RoleEnum.User);
            User Richard = new User("Richard", "Harris", "RH", "000", 500, RoleEnum.User);
            User Martha = new User("Martha", "Smith", "MS", "111", 600, RoleEnum.User);

            List<Administrator> administrators = new List<Administrator>();

            Administrator John = new Administrator("John", "Johnson", "JJ", "JJJ", CompanyEnum.BEG, RoleEnum.Administrator);
            Administrator Gary = new Administrator("Gary", "Kerry", "GK", "GGG", CompanyEnum.EVN, RoleEnum.Administrator);
            Administrator Sarah = new Administrator("Sarah", "Lee", "SL", "SSS", CompanyEnum.Vodovod, RoleEnum.Administrator);

            List<Invoice> invoces = new List<Invoice>();

            Invoice invoice1 = new Invoice(CompanyEnum.BEG, 300, new DateTime(2021, 04, 29), new DateTime(2021, 03 ,27), false);
            Invoice invoice2 = new Invoice(CompanyEnum.EVN, 200, new DateTime(2021, 03, 27), new DateTime(2021, 02, 25), false);
            Invoice invoice3 = new Invoice(CompanyEnum.Vodovod, 300, new DateTime(202, 03, 25), new DateTime(2021, 02, 28), false);

            Peter.Invoice.Add(invoice1);
            Richard.Invoice.Add(invoice2);
            Martha.Invoice.Add(invoice3);

            users.Add(Peter);
            users.Add(Richard);
            users.Add(Martha);




            try
            {
                Console.WriteLine("Enter your User name");
                string userNameInput = Console.ReadLine();
                Console.WriteLine("Enter your password");
                string passwordInput = Console.ReadLine();

                //User loginUser = users.FirstOrDefault(x => x.Login(userNameInput, passwordInput) != null);
                List<User> loginUser = users.Where(x => x.UserName == userNameInput && x.Password == passwordInput).ToList();
                List<Administrator> loginAdmin = administrators.Where(x => x.UserName == userNameInput && x.Password == passwordInput).ToList();

                if (loginUser == null)
                {
                    throw new Exception("Invalid User name");
                }
                else if (loginUser != null || loginAdmin != null)
                {
                    if (loginUser.Any(x => x.Role == RoleEnum.User))
                    {
                        Console.WriteLine("Please select option 1 if you want to see all your invoices.\n Please select option 2 if you want to check your balance.");
                        Console.WriteLine(new string('-', 60));
                        int option = int.Parse(Console.ReadLine());

                        if (option == 1)
                        {
                            foreach (var user in users)
                            {
                                if(loginUser.Contains(user)) { 
                                string date = DateTime.Now.ToString("MM/dd/yyyy");
                                //Console.WriteLine(date);
                                Console.WriteLine($"Hello {user.FirstName} {user.LastName}");

                                foreach (var item in user.Invoice)
                                {
                                    Console.WriteLine($"your invoice has been issued on {item.InvoiceIssued.Date} the amount owed is {item.Amount} and it's due to {item.DueDate.Date}");
                                        //string dueDate = user.Invoice.Select(x => x.DueDate).ToString();

                                        if (item.DueDate.Date.ToString().Length > date.Length)
                                        {
                                            Console.WriteLine(new string('-', 60));
                                            Console.WriteLine($"Dear {user.FirstName} {user.LastName} you are late with your invoice payment.For every day you miss you need to pay a fine of 10$");
                                            Console.WriteLine(new string('-', 60));
                                            IncreaseInvoice(invoces);
                                        }
                                        else if (item.DueDate.Date.ToString().Length < date.Length)
                                        {
                                            Console.WriteLine(new string('-', 60));
                                            Console.WriteLine($"Dear {user.FirstName} {user.LastName} your invoices have been paid");
                                            Console.WriteLine(new string('-', 60));
                                        }

                                    }


                                }
                            }
                        }
                        if (option == 2)
                        {
                            BalanceChecking(users);
                            Console.WriteLine("Please select option 1 if you want to increase your balance.\n If you want to exit please input 2.");
                            int option2 = int.Parse(Console.ReadLine());

                            if (option2 == 1)
                            {
                                IncreaseBalance(users);
                            }
                            else if (option2 == 2)
                            {
                                return;
                            }
                        }
                    }
                    else if (loginAdmin.Any(x => x.Role == RoleEnum.Administrator))
                    {
                        Console.WriteLine("Enter the name of the company you work at.");
                        string nameOfCompany = Console.ReadLine();

                        string names = Enum.GetNames(typeof(CompanyEnum)).ToString();

                        if (nameOfCompany == names)
                        {
                            if (nameOfCompany == "BEG")
                            {
                                AdminPanelForBEG(invoces);
                            }
                            if (nameOfCompany == "EVN")
                            {
                                AdminPanelForEVN(invoces);
                            }
                            if (nameOfCompany == "Vodovod")
                            {
                                AdminPanelForVodovod(invoces);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void BalanceChecking(List<User> users)
        {
            foreach (var user in users)
            {
                Console.WriteLine(new string('-', 60));
                Console.WriteLine($"Your balance is {user.Balance}");
                Console.WriteLine(new string('-', 60));
            }
        }

        public static void IncreaseBalance(List<User> users)
        {
            Console.WriteLine("Please enter the amount you wish to deposit.");
            int inputDeposit = int.Parse(Console.ReadLine());
            int deposit;

            foreach (var user in users)
            {
                Console.WriteLine(new string('-', 60));
                Console.WriteLine($"You have deposited ${inputDeposit} into your account!");
                Console.WriteLine(new string('-', 60));
                deposit = user.Balance + inputDeposit;
                Console.WriteLine($"You have ${deposit} in your account!");
                Console.WriteLine(new string('-', 60));
            }
        }

        public static void IncreaseInvoice(List<Invoice> invoces)
        {
            int newInvoice;
            foreach (var user in invoces)
            {
                newInvoice = user.Amount + 10;
                //string trying = newInvoice.ToString();
                //user.Amount.;
                Console.WriteLine(new string('-', 60));
                Console.WriteLine($"Your invoice now is {newInvoice}$");
                Console.WriteLine(new string('-', 60));
            }
        }

        public static void AdminPanelForBEG(List<Invoice> invoices)
        {
            Console.WriteLine(new string('-', 60));
            string payedStatus = invoices.Select(x => x.InvoiceStatus == true).ToString();
            Console.WriteLine($"Here is a list of all the paid Invoices: {payedStatus}");
            Console.WriteLine(new string('-', 60));
            string notPayedStatus = invoices.Select(x => x.InvoiceStatus == false).ToString();
            Console.WriteLine($"Here is a list of all the paid unpaid Invoices: {notPayedStatus}");
            Console.WriteLine(new string('-', 60));
        }

        public static void AdminPanelForEVN(List<Invoice> invoices)
        {
            Console.WriteLine(new string('-', 60));
            string payedStatus = invoices.Select(x => x.InvoiceStatus == true).ToString();
            Console.WriteLine($"Here is a list of all the paid Invoices: {payedStatus}");
            Console.WriteLine(new string('-', 60));
            string notPayedStatus = invoices.Select(x => x.InvoiceStatus == false).ToString();
            Console.WriteLine($"Here is a list of all the paid unpaid Invoices: {notPayedStatus}");
            Console.WriteLine(new string('-', 60));
        }

        public static void AdminPanelForVodovod(List<Invoice> invoices)
        {
            Console.WriteLine(new string('-', 60));
            string payedStatus = invoices.Select(x => x.InvoiceStatus == true).ToString();
            Console.WriteLine($"Here is a list of all the paid Invoices: {payedStatus}");
            Console.WriteLine(new string('-', 60));
            string notPayedStatus = invoices.Select(x => x.InvoiceStatus == false).ToString();
            Console.WriteLine($"Here is a list of all the paid unpaid Invoices: {notPayedStatus}");
            Console.WriteLine(new string('-', 60));






            Console.ReadLine();
        }
    }
}
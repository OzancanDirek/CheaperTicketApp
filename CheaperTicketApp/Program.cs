using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheaperTicketApp
{
    internal class Program
    {
        public static void seatChoose()
        {
            int rows = 3;
            int columns = 4;

            char[,] cinemaSeats = new char[rows, columns];

            Random random = new Random();

            // O for the empty chair and create saloon
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    cinemaSeats[i, j] = 'O';
                }
            }
            // Occupied part randomly 
            int numOccupiedSeats = random.Next(1, rows * columns); // between 1 and total seats occupied code

            for (int i = 0; i < numOccupiedSeats; i++)
            {
                int randomRow = random.Next(0, rows);
                int randomColumn = random.Next(0, columns);

                // Check the seats are occupied or not
                if (cinemaSeats[randomRow, randomColumn] != 'X')
                {
                    cinemaSeats[randomRow, randomColumn] = 'X';
                }
                else
                {
                    // If the seat is already occupied choose another seat
                    i--;
                }
            }

            // Printed part for cinema saloon
            Console.WriteLine("Cinema Saloon:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(cinemaSeats[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Choose your seat (row and column):");
            string[] seatInput = Console.ReadLine().Split(' ');
            int selectedRow = Convert.ToInt32(seatInput[0]);
            int selectedColumn = Convert.ToInt32(seatInput[1]);

            if (cinemaSeats[selectedRow, selectedColumn] == 'X')
            {
                Console.WriteLine("This seat is already taken. Please choose another seat.");
            }
            else
            {
                cinemaSeats[selectedRow, selectedColumn] = 'X';
                Console.WriteLine();
                Console.WriteLine("*************************************************");
                Console.WriteLine("New Cinema Saloon is printed...");

                Console.WriteLine("Updated Cinema Saloon:");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write(cinemaSeats[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Congratulations, tickets have been purchased");
                Console.WriteLine("*************************************************");
            }
        }

        public static void avm()
        {
            int[] ticketPrices = { 120, 100, 110, 130, 150, 140, 200, 210 };
            string[] avmNames = { "Hilltown Avm", "Metrogarden Avm", "Meydan Avm", "Buyaka Avm", "Emaar Avm", "Metropol Avm", "Capitol Avm", "Optimum Avm" };
            Console.WriteLine("Welcome to Cheaper Ticket App...");
            Console.WriteLine();
            Console.WriteLine("Please choose the AVM where you want to watch movies:");
            Console.WriteLine("" +
                " \nHilltown Avm: 0 " +
                " \nMetrogarden Avm: 1" +
                " \nMeydan Avm: 2" +
                " \nBuyaka Avm: 3" +
                " \nEmaar Avm: 4 " +
                " \nMetropol Avm: 5" +
                " \nCapitol Avm: 6" +
                " \nOptimum Avm: 7");
            int choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 0:
                    Console.WriteLine("Your choose is Hilltown Avm");
                    Console.WriteLine("Ticket price is: 120$ ");
                    Console.WriteLine("*************************************************");
                    Console.WriteLine();
                    Cinema.Found();
                    Console.WriteLine("Cheapest App found a more affordable ticket for you :) \nIf you want to see enter: 1 \nDo not change enter: 0 ");
                    Console.WriteLine();
                    int affordableTicket = Convert.ToInt32(Console.ReadLine());
                    if (affordableTicket == 1)
                    {
                        Cinema.Found();

                        Console.WriteLine();

                        Console.WriteLine("That list according to 1 ticket price.");
                        Console.WriteLine("\nMetrogarden Avm: 100$" +
                            "\nMeydan Avm: 110$");
                        Console.WriteLine("\nFor Metrogarden Avm: 1  \nFor Meydan Avm: 2 \nFor do not change: 3 ");
                        int change = Convert.ToInt32(Console.ReadLine());

                        if (change == 1)
                        {
                            Console.WriteLine();
                            Console.WriteLine("*************************************************");
                            Console.WriteLine("Congratulations, your selection has been replaced by Metrogarden Avm...");
                            seatChoose();
                        }
                        else if (change == 2)
                        {
                            Console.WriteLine();
                            Console.WriteLine("*************************************************");
                            Console.WriteLine("Congratulations, your selection has been replaced by Meydan Avm...");
                            seatChoose();
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("*************************************************");
                            Console.WriteLine("Congratulations, your selection has been replaced by Hilltown Avm...");
                            seatChoose();
                        }
                    }
                    else if (affordableTicket == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("*************************************************");
                        Console.WriteLine("You chose not to change your selection.");
                        Console.WriteLine("Proceeding to seat selection...");
                        seatChoose();
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("*************************************************");
                        Console.WriteLine("Invalid choice.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
                case 1:
                    Console.WriteLine("Your choose is Metrogarden Avm. Today cheapest tickets are in this Avm...");

                    Console.WriteLine("Ticket price is: 100$ ");
                    Console.WriteLine("*************************************************");
                    Console.WriteLine();
                    seatChoose();
                    break;
                case 2:
                    Console.WriteLine("Your choose is Meydan Avm...");
                    Console.WriteLine("Ticket price is: 110$ ");
                    Console.WriteLine("*************************************************");
                    Console.WriteLine();
                    Cinema.Found();
                    Console.WriteLine("Cheapest App found a more affordable ticket for you :) \nIf you want to see enter: 1 \nDo not change enter: 0 ");
                    Console.WriteLine();
                    int affordableTicket2 = Convert.ToInt32(Console.ReadLine());
                    if (affordableTicket2 == 1)
                    {
                        Console.WriteLine("*************************************************");
                        Console.WriteLine();
                        Console.WriteLine("Please enter a number for your selection");
                        Console.WriteLine("Metrogarden Avm Ticket Price is: 100$ \nFor Metrogarden Avm: 1 \nFor do not change: 2");
                        int cheaperTicket = Convert.ToInt32(Console.ReadLine());
                        if (cheaperTicket == 1)
                        {
                            Console.WriteLine();
                            Console.WriteLine("*************************************************");

                            Console.WriteLine("Congratulations, your selection has been replaced by Metrogarden Avm...");
                            seatChoose();

                        }
                        else if (cheaperTicket == 2)
                        {
                            Console.WriteLine();
                            Console.WriteLine("*************************************************");

                            Console.WriteLine("You don't want to do any change in your selection...");
                            seatChoose();

                        }
                        else
                        {
                            Console.WriteLine("Invalid number please try again...");
                        }
                        break;
                    }
                    else if (affordableTicket2 == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("*************************************************");
                        Console.WriteLine("You choose not to change your selection.");
                        Console.WriteLine("Proceeding to seat selection...");
                        seatChoose();
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice.");
                    }
                    break;

                case 3:
                    Console.WriteLine("Your choose is Buyaka Avm...");
                    Console.WriteLine("Ticket price is: 130$");
                    Console.WriteLine("*************************************************");
                    Console.WriteLine();
                    Cinema.Found();
                    Console.WriteLine("Cheapest App found a more affordable ticket for you :) \nIf you want to see enter: 1 \nDo not change enter: 0 ");
                    Console.WriteLine();
                    int affordableTicket3 = Convert.ToInt32(Console.ReadLine());
                    if (affordableTicket3 == 1)
                    {
                        Console.WriteLine("" +
                            " \nMetrogarden ticket price: 100$ " +
                            " \nHilltown ticket price: 120$ " +
                            " \nMeydan ticket price: 110$ ");
                        Console.WriteLine("*************************************************");
                        Console.WriteLine();
                        Console.WriteLine("Please enter a number for your selection");
                        Console.WriteLine("\nMetrogarden Avm: 1 \nHilltown Avm: 2 \nMeydan Avm:3 \nDo not change: 4");
                        int cheaperTicket3 = Convert.ToInt32(Console.ReadLine());
                        if (cheaperTicket3 == 1)
                        {
                            Console.WriteLine();
                            Console.WriteLine("*************************************************");
                            Console.WriteLine("Congratulations, your selection has been replaced by Metrogarden Avm...");
                            seatChoose();
                        }
                        else if (cheaperTicket3 == 2)
                        {
                            Console.WriteLine();
                            Console.WriteLine("*************************************************");
                            Console.WriteLine("Congratulations, your selection has been replaced by Hilltown Avm...");
                            seatChoose();
                        }
                        else if (cheaperTicket3 == 3)
                        {
                            Console.WriteLine();
                            Console.WriteLine("*************************************************");
                            Console.WriteLine("Congratulations, your selection has been replaced by Meydan Avm...");
                            seatChoose();
                        }
                        else if (cheaperTicket3 == 4)
                        {
                            Console.WriteLine();
                            Console.WriteLine("*************************************************");
                            Console.WriteLine("You don't want to do any change in your selection");
                            seatChoose();
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("*************************************************");
                            Console.WriteLine("Invalid number please try again...");
                        }
                    }
                    else if (affordableTicket3 == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("*************************************************");
                        Console.WriteLine("You choose not to change your selection.");
                        Console.WriteLine("Proceeding to seat selection...");
                        seatChoose();
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice.");
                    }
                    break;
                case 4:
                    Console.WriteLine("Your choose is Emaar Avm...");
                    Console.WriteLine("Ticket price is: 150$");
                    Console.WriteLine("*************************************************");
                    Console.WriteLine();
                    Cinema.Found();
                    Console.WriteLine("Cheapest App found a more affordable ticket for you :) \nIf you want to see enter: 1 \nDo not change enter: 0 ");
                    Console.WriteLine();
                    int affordableTicket4 = Convert.ToInt32(Console.ReadLine());
                    if (affordableTicket4 == 1)
                    {
                        Console.WriteLine("Metrogarden ticket price: 100 " +
                            " \nHilltown ticket price: 120$ " +
                            " \nMeydan ticket price: 110$" +
                            "\nBuyaka ticket price: 130$" +
                            "\nMetropol Ticket price: 140$");
                        Console.WriteLine("*************************************************");
                        Console.WriteLine();
                        Console.WriteLine("Please enter a number for your selection");
                        Console.WriteLine("\nMetrogarden Avm: 1 \nHilltown Avm: 2 \nMeydan Avm:3 \nBuyaka Avm: 4 \nMetropol Avm: 5 \nDo not change:6");
                        int cheaperTicket5 = Convert.ToInt32(Console.ReadLine());

                        if (cheaperTicket5 == 1)
                        {
                            Console.WriteLine();
                            Console.WriteLine("*************************************************");
                            Console.WriteLine("Congratulations, your selection has been replaced by Metrogarden Avm...");
                            seatChoose();

                        }
                        else if (cheaperTicket5 == 2)
                        {
                            Console.WriteLine();
                            Console.WriteLine("*************************************************");
                            Console.WriteLine("Congratulations, your selection has been replaced by Hilltown Avm...");
                            seatChoose();
                        }
                        else if (cheaperTicket5 == 3)
                        {
                            Console.WriteLine();
                            Console.WriteLine("*************************************************");
                            Console.WriteLine("Congratulations, your selection has been replaced by Meydan Avm...");
                            seatChoose();
                        }
                        else if (cheaperTicket5 == 4)
                        {
                            Console.WriteLine();
                            Console.WriteLine("*************************************************");
                            Console.WriteLine("Congratulations, your selection has been replaced by Buyaka Avm...");
                            seatChoose();
                        }
                        else if (cheaperTicket5 == 5)
                        {
                            Console.WriteLine();
                            Console.WriteLine("*************************************************");
                            Console.WriteLine("Congratulations, your selection has been replaced by Metropol Avm...");
                            seatChoose();
                        }
                        else if (cheaperTicket5 == 6)
                        {
                            Console.WriteLine();
                            Console.WriteLine("*************************************************");
                            Console.WriteLine("You don't want to do any change in your selection");
                            seatChoose();
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("*************************************************");
                            Console.WriteLine("Invalid Number please try again...");
                        }
                    }
                    else if (affordableTicket4 == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("*************************************************");
                        Console.WriteLine("You choose not to change your selection.");
                        Console.WriteLine("Proceeding to seat selection...");
                        seatChoose();
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("*************************************************");
                        Console.WriteLine("Invalid choice.");
                    }
                    break;
                case 5:
                    Console.WriteLine("Your choose is Metropol Avm...");
                    Console.WriteLine("Ticket price is: 140$");
                    Console.WriteLine("*************************************************");
                    Console.WriteLine();
                    Cinema.Found();
                    Console.WriteLine("Cheapest App found a more affordable ticket for you :) \nIf you want to see enter: 1 \nDo not change enter: 0 ");
                    Console.WriteLine();
                    int affordableTicket5 = Convert.ToInt32(Console.ReadLine());
                    if (affordableTicket5 == 1)
                    {
                        Console.WriteLine("\nMetrogarden ticket price: 100$ " +
                                                " \nHilltown ticket price: 120$ " +
                                                " \nMeydan ticket price: 110$" +
                                                "\nBuyaka ticket price: 130$");
                        Console.WriteLine("*************************************************");
                        Console.WriteLine();
                        Console.WriteLine("Please enter a number for your selection");
                        Console.WriteLine("\nMetrogarden Avm: 1 \nHilltown Avm: 2 \nMeydan Avm:3 \nBuyaka Avm: 4 \nDo not change: 5");
                        int cheaperTicket6 = Convert.ToInt32(Console.ReadLine());

                        if (cheaperTicket6 == 1)
                        {
                            Console.WriteLine();
                            Console.WriteLine("*************************************************");
                            Console.WriteLine("Congratulations, your selection has been replaced by Metrogarden Avm...");
                            seatChoose();

                        }
                        else if (cheaperTicket6 == 2)
                        {
                            Console.WriteLine();
                            Console.WriteLine("*************************************************");
                            Console.WriteLine("Congratulations, your selection has been replaced by Hilltown Avm...");
                            seatChoose();


                        }
                        else if (cheaperTicket6 == 3)
                        {
                            Console.WriteLine();
                            Console.WriteLine("*************************************************");
                            Console.WriteLine("Congratulations, your selection has been replaced by Meydan Avm...");
                            seatChoose();

                        }
                        else if (cheaperTicket6 == 4)
                        {
                            Console.WriteLine();
                            Console.WriteLine("*************************************************");
                            Console.WriteLine("Congratulations, your selection has been replaced by Buyaka Avm...");
                            seatChoose();


                        }
                        else if (cheaperTicket6 == 5)
                        {
                            Console.WriteLine();
                            Console.WriteLine("*************************************************");
                            Console.WriteLine("You don't want to do any change in your selection");
                            seatChoose();


                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("*************************************************");
                            Console.WriteLine("Invalid number please try again...");
                        }
                    }
                    else if (affordableTicket5 == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("*************************************************");
                        Console.WriteLine("You choose not to change your selection.");
                        Console.WriteLine("Proceeding to seat selection...");
                        seatChoose();
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("*************************************************");
                        Console.WriteLine("Invalid choice.");
                    }
                    break;
                case 6:
                    Console.WriteLine("Your choose is Capitol Avm...");
                    Console.WriteLine("Ticket price is: 200$");
                    Console.WriteLine("*************************************************");
                    Console.WriteLine();
                    Cinema.Found();
                    Console.WriteLine("Cheapest App found a more affordable ticket for you :) \nIf you want to see enter: 1 \nDo not change enter: 0 ");
                    Console.WriteLine();
                    int affordableTicket6 = Convert.ToInt32(Console.ReadLine());
                    if (affordableTicket6 == 1)
                    {
                        Console.WriteLine();
                        Console.WriteLine("\nMetrogarden ticket price: 100$ " +
                                                " \nHilltown ticket price: 120$ " +
                                                " \nMeydan ticket price: 110$" +
                                                "\nBuyaka ticket price: 130$" +
                                                "\nMetropol ticket price: 140$" +
                                                "\nEmaar ticket price: 150$");
                        Console.WriteLine("*************************************************");
                        Console.WriteLine();
                        Console.WriteLine("Please enter a number for your selection");
                        Console.WriteLine("\nMetrogarden Avm: 1   \nHilltown Avm: 2 \nMeydan Avm:3   \nBuyaka Avm: 4 \nMetropol Avm: 5 \nEmaar Avm: 6 \nDo not change: 7");
                        int cheaperTicket7 = Convert.ToInt32(Console.ReadLine());
                        if (cheaperTicket7 == 1)
                        {
                            Console.WriteLine();
                            Console.WriteLine("*************************************************");
                            Console.WriteLine("Congratulations, your selection has been replaced by Metrogarden Avm...");
                            seatChoose();
                        }
                        else if (cheaperTicket7 == 2)
                        {
                            Console.WriteLine();
                            Console.WriteLine("*************************************************");
                            Console.WriteLine("Congratulations, your selection has been replaced by Hilltown Avm...");
                            seatChoose();
                        }
                        else if (cheaperTicket7 == 3)
                        {
                            Console.WriteLine();
                            Console.WriteLine("*************************************************");
                            Console.WriteLine("Congratulations, your selection has been replaced by Meydan Avm...");
                            seatChoose();
                        }
                        else if (cheaperTicket7 == 4)
                        {
                            Console.WriteLine();
                            Console.WriteLine("*************************************************");
                            Console.WriteLine("Congratulations, your selection has been replaced by Buyaka Avm...");
                            seatChoose();
                        }
                        else if (cheaperTicket7 == 5)
                        {
                            Console.WriteLine();
                            Console.WriteLine("*************************************************");
                            Console.WriteLine("Congratulations, your selection has been replaced by Metropol Avm...");
                            seatChoose();
                        }
                        else if (cheaperTicket7 == 6)
                        {
                            Console.WriteLine();
                            Console.WriteLine("*************************************************");
                            Console.WriteLine("Congratulations, your selection has been replaced by Emaar Avm...");
                            seatChoose();
                        }
                        else if (cheaperTicket7 == 7)
                        {
                            Console.WriteLine();
                            Console.WriteLine("*************************************************");
                            Console.WriteLine("You dont want to do any change in your selection");
                            seatChoose();
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("*************************************************");
                            Console.WriteLine("Invalid number please try again...");
                        }
                    }
                    else if (affordableTicket6 == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("*************************************************");
                        Console.WriteLine("You choose not to change your selection.");
                        Console.WriteLine("Proceeding to seat selection...");
                        seatChoose();
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("*************************************************");
                        Console.WriteLine("Invalid choice.");

                    }
                    break;
                case 7:
                    Console.WriteLine("Your choose is Optimum Avm...");
                    Console.WriteLine("Ticket price is: 210$");
                    Console.WriteLine("*************************************************");
                    Console.WriteLine();
                    Cinema.Found();

                    Console.WriteLine("Cheapest App found a more affordable ticket for you :) \nIf you want to see enter: 1 \nDo not change enter: 0 ");
                    Console.WriteLine();
                    int affordableTicket7 = Convert.ToInt32(Console.ReadLine());
                    if (affordableTicket7 == 1)
                    {
                        Console.WriteLine("Metrogarden ticket price: 100$ " +
                                            " \nHilltown ticket price: 120$ " +
                                            " \nMeydan ticket price: 110$" +
                                            "\nBuyaka ticket price: 130$" +
                                            "\nMetropol ticket price: 140$" +
                                            "\nEmaar ticket price: 150$" +
                                            "\nCapitol ticket price: 200$");
                        Console.WriteLine("*************************************************");
                        Console.WriteLine();
                        Console.WriteLine("Please enter a number for your selection");
                        Console.WriteLine("\nMetrogarden Avm: 1 \nHilltown Avm: 2 \nMeydan Avm:3 \nBuyaka Avm: 4 \nMetropol Avm: 5 \nEmaar Avm: 6 " +
                            "\nCapitol Avm: 7 \nDo not change: 8");
                        int cheaperTicket8 = Convert.ToInt32(Console.ReadLine());
                        if (cheaperTicket8 == 1)
                        {
                            Console.WriteLine();
                            Console.WriteLine("*************************************************");
                            Console.WriteLine("Congratulations, your selection has been replaced by Metrogarden Avm...");
                            seatChoose();
                        }
                        else if (cheaperTicket8 == 2)
                        {
                            Console.WriteLine();
                            Console.WriteLine("*************************************************");
                            Console.WriteLine("Congratulations, your selection has been replaced by Hilltown Avm...");
                            seatChoose();
                        }
                        else if (cheaperTicket8 == 3)
                        {
                            Console.WriteLine();
                            Console.WriteLine("*************************************************");
                            Console.WriteLine("Congratulations, your selection has been replaced by Meydan Avm...");
                            seatChoose();
                        }
                        else if (cheaperTicket8 == 4)
                        {
                            Console.WriteLine();
                            Console.WriteLine("*************************************************");
                            Console.WriteLine("Congratulations, your selection has been replaced by Buyaka Avm...");
                            seatChoose();
                        }
                        else if (cheaperTicket8 == 5)
                        {
                            Console.WriteLine();
                            Console.WriteLine("*************************************************");
                            Console.WriteLine("Congratulations, your selection has been replaced by Metropol Avm...");
                            seatChoose();
                        }
                        else if (cheaperTicket8 == 6)
                        {
                            Console.WriteLine();
                            Console.WriteLine("*************************************************");
                            Console.WriteLine("Congratulations, your selection has been replaced by Emaar Avm...");
                            seatChoose();
                        }
                        else if (cheaperTicket8 == 7)
                        {
                            Console.WriteLine();
                            Console.WriteLine("*************************************************");
                            Console.WriteLine("Congratulations, your selection has been replaced by Capitol Avm...");
                            seatChoose();
                        }
                        else if (cheaperTicket8 == 8)
                        {
                            Console.WriteLine();
                            Console.WriteLine("*************************************************");
                            Console.WriteLine("You don't want to do any change in your selection");
                            seatChoose();
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("*************************************************");
                            Console.WriteLine("Invalid number please try again...");
                        }
                    }
                    else if (affordableTicket7 == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("*************************************************");
                        Console.WriteLine("You choose not to change your selection.");
                        Console.WriteLine("Proceeding to seat selection...");
                        seatChoose();
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("*************************************************");
                        Console.WriteLine("Invalid choice.");
                    }
                    break;
            }
        }
        static void Main(string[] args)
        {
            Cinema cinema = new Cinema();
            cinema.Started();

            Console.WriteLine("Please enter your name and surname:");
            string nameSurname = Console.ReadLine();

            Console.WriteLine("Please enter your phone number:");
            string phone = Console.ReadLine();

            Console.WriteLine("Please enter your email address:");
            string email = Console.ReadLine();

            Ticket ticket = new Ticket(nameSurname, phone, email);//get from the user's input

            avm();

            Console.WriteLine("Ticket Informations Printed...");
            Console.WriteLine();

            ticket.Print();

            Console.ReadLine();
        }

        public class Ticket
        {
            public string NameSurname { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }
            public string TicketNumber { get; set; }
            public DateTime BuyingTime { get; set; }

            //constructor
            public Ticket(string nameSurname, string phone, string email)
            {
                NameSurname = nameSurname;
                Phone = phone;
                Email = email;
                TicketNumber = GenerateTicketNumber();
                BuyingTime = DateTime.Now;
            }
            private string GenerateTicketNumber()
            {
                Random random = new Random();
                int ticketNumber = random.Next(1000, 10000);
                return "PNR-" + ticketNumber;
            }

            public void Print()
            {
                Console.WriteLine("*************************************************");
                Console.WriteLine("Name and Surname: " + NameSurname);
                Console.WriteLine("Phone: " + Phone);
                Console.WriteLine("Email: " + Email);
                Console.WriteLine("Purchased Ticket Number: " + TicketNumber);
                Console.WriteLine("Purchased Ticket Time: " + BuyingTime);
                Console.WriteLine("*************************************************");
            }
        }
    }
}


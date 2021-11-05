using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Owoda.Models
{
    public class OwodaApp
    {
        private uint _todayEarnings = 0;
        private uint _dailyTicketsSold = 0;
        private uint _monthlyTicketsSold = 0;

        public uint TodayEarnings { get { return _todayEarnings; } }
        public uint DailyTicketSold { get { return _dailyTicketsSold; } }
        public uint MonthlyTicketSold { get { return _monthlyTicketsSold; } }
        private double BossShare { get { return Math.Round((0.65 * _todayEarnings), 2); } }
        private double MemberShare { get { return Math.Round((0.35 * _todayEarnings), 2); } }

        public void InitializeApp()
        {
            Console.WriteLine("1 to buy ticket");
            Console.WriteLine("2 to get summary");

            string response = Console.ReadLine();

            if (response == "1")
            {
                Console.WriteLine(ProcessTicketOrder());
            }
            else if (response == "2")
            {
                Console.WriteLine(GenerateSalesSummary());
            }
            else
            {
                Console.WriteLine("Unknown command! Please try again.");
                InitializeFollowUp();
            }
        }

        public string ProcessTicketOrder()
        {
            Console.WriteLine("Select ticket type");
            Console.WriteLine("1 for Daily");
            Console.WriteLine("2 for Monthly");

            string ticketChoice = Console.ReadLine();

            ComputeTicketSale(ticketChoice);

            InitializeFollowUp();

            return "";
        }

        public void ComputeTicketSale(string choice)
        {
            if (choice == "1")
            {
                _todayEarnings += 200;
                _dailyTicketsSold += 1;

                Console.WriteLine("Ticket bought successfully!");
                Console.WriteLine($"Ticket ID: {GenerateTicketID()}-D");
                Console.WriteLine("Ticket Type: Daily");
                Console.WriteLine("Ticket Price: N200");
            }
            else if (choice == "2")
            {
                _todayEarnings += 3100;
                _monthlyTicketsSold += 1;

                Console.WriteLine("Ticket bought successfully!");
                Console.WriteLine($"Ticket ID: {GenerateTicketID()}-M");
                Console.WriteLine("Ticket Type: Monthly");
                Console.WriteLine("Ticket Price: N3100 (N100 daily)");
            }
        }

        public string GenerateSalesSummary()
        {
            Console.WriteLine("TODAY SALES SUMMARY");
            Console.WriteLine($"Total Sales: {TodayEarnings}");
            Console.WriteLine($"Daily tickets sold: { DailyTicketSold}");
            Console.WriteLine($"Monthly tickets sold: { _monthlyTicketsSold}");
            Console.WriteLine($"Remittance: {BossShare}");

            InitializeFollowUp();

            return "";
        }

        public int GenerateTicketID()
        {
            Random random = new Random();
            return random.Next();
        }

        public void InitializeFollowUp()
        {
            Console.WriteLine("Pick a follow-up action");
            Console.WriteLine("0 to return to menu");

            string followUp = Console.ReadLine();

            if (followUp == "0")
            {
                InitializeApp();
            }
        }
    }
}

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
        private double MemberShare { get { return return Math.Round((0.35 * _todayEarnings), 2); } }

        public void ProcessTicketOrder()
        {
            Console.WriteLine("Welcome to the Owoda app. Kinly select ticket type");
            Console.WriteLine($"Reply 1 for Daily");
            Console.WriteLine($"Reply 2 for Monthly");

            public uint ticketChoice = Console.ReadLine();

            ComputeTicketSale(ticketChoice);

            Console.WriteLine("Ticked issued successfully");
        }

        public void ComputeTicketSale(uint choice)
        {
            if(choice == 1) {
                _todayEarnings += 200;
                _dailyTicketsSold += 1;
            } else if(choice == 2) {
                _todayEarnings += 3100;
                _monthlyTicketsSold += 1;
            }
        }

        public string GenerateSalesSummary()
        {
            Console.WriteLine("TODAY SALES SUMMARY");
            Console.WriteLine($"Total Sales: {TodayEarnings} \n Daily: {DailyTicketSold} \n Monthly: {_monthlyTicketsSold}");
            Console.WriteLine($"Your share: {MemberShare}");
            Console.WriteLine($"Boss's share: {BossShare}");
            return "";
        }
    }

    public class OwodaTicket {
        private Random _random = new Random();

        public string TicketId { get { return _random.Next(); } }
    }
}

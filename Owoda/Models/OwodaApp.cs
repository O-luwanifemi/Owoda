using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Owoda.Models
{
    public class OwodaApp
    {
        private double _bossShare = 0;
        private double _memberShare = 0;
        private uint _totalEarnings = 0;
        private uint _dailyTicketsSold = 0;
        private uint _monthlyTicketsSold = 0;

        public double BossShare { get { return _bossShare; } }
        public double MemberShare { get { return _memberShare; } }
        public uint TotalEarnings { get { return _totalEarnings; } }
        public uint DailyTicketSold { get { return _dailyTicketsSold; } }
        public uint MonthlyTicketSold { get { return _monthlyTicketsSold; } }

        public void ComputeTicketSale()
        {
            _totalEarnings = 25;
            _dailyTicketsSold = 20;
            _monthlyTicketsSold = 5;
        }

        public void ComputeShare()
        {
            _bossShare = 8.75;
            _memberShare = 16.25;
        }

        public string ShowSalesSummary()
        {
            ComputeTicketSale();
            ComputeShare();

            Console.WriteLine("SALES SUMMARY");
            Console.WriteLine($"Total Sales: {TotalEarnings} \n Daily: {DailyTicketSold} \n Monthly: {_monthlyTicketsSold}");
            Console.WriteLine($"Your share: {MemberShare}");
            Console.WriteLine($"Boss's share: {BossShare}");
            return "";
        }
    }
}

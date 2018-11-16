using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    class ProgramUI
    {
        OutingRepository _contentOuting = new OutingRepository();
        List<Outing> listOfOutings = new List<Outing>();

        public void Run()
        {
            RunMainMenu();
        }

        private void RunMainMenu()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Hello welcome to Komodo Outings. Please choose an action:" +
                    "\n1. Display All Outings" +
                    "\n2. Add Outings" +
                    "\n3. Cost of all Outings" +
                    "\n4. Cost by Outing Type" +
                    "\n5. Exit");

                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        DisplayOutings();
                        break;
                    case 2:
                        AddOutings();
                        break;
                    case 3:
                        OutingsCost();
                        break;
                    case 4:
                        TypeCost();
                        break;
                    case 5:
                        isRunning = false;
                        Console.WriteLine("Exit complete.");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("invalid response");
                        Console.ReadLine();
                        break;
                }
            }
        }

        private void DisplayOutings()
        {
            List<Outing> outingList = _contentOuting.GetOutingList();
            foreach (Outing content in outingList)
            {
                Console.WriteLine(content.EventType);
                Console.WriteLine(content.Date);
                Console.WriteLine(content.EventCost);
                Console.WriteLine(content.PersonCost);
                Console.WriteLine(content.PeopleAttended);
            }
        }

        private void AddOutings()
        {
            Console.WriteLine("what is the event type?");
            var type = Console.ReadLine();

            Console.WriteLine("how many people attended the event?");
            var number = int.Parse(Console.ReadLine());

            Console.WriteLine("what is the date of the event?");
            var date = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("what is the individual cost?");
            var personCost = decimal.Parse(Console.ReadLine());

            Console.WriteLine("what is the total event cost?");
            var eventCost = decimal.Parse(Console.ReadLine());
            Outing newOuting = new Outing()
            {
                EventType = type,
                PeopleAttended = number,
                Date = date,
                PersonCost = personCost,
                EventCost = eventCost,
            };
            _contentOuting.AddEventsToOuting(newOuting);
        }

        private void OutingsCost()
        {
            List<Outing> outingList = _contentOuting.GetOutingList();
            decimal total = 0;
            foreach (Outing content in outingList)
            {
                total = content.EventCost + total;
            }

            Console.WriteLine($"your total event cost is {total}");
        }

        private decimal TypeCost()
        {
            List<Outing> outingList = _contentOuting.GetOutingList();
            decimal balance = 0;
            Console.WriteLine("what event type would you like to see the total cost for?");
            string userInput = Console.ReadLine();

            foreach (Outing content in outingList)
            {
               if (content.EventType == userInput)
                {
                    balance += content.EventCost;
                }
            }
            return balance;
        }

    }
}

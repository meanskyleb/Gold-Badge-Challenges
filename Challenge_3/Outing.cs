using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    class Outing
    {
        public string EventType { get; set; }
        public int PeopleAttended { get; set; }
        public DateTime Date { get; set; }
        public decimal PersonCost { get; set; }
        public decimal EventCost { get; set; }

        public Outing(string eventType, int peopleAttended, DateTime date, decimal personCost, decimal eventCost)
        {
            EventType = eventType;
            PeopleAttended = peopleAttended;
            Date = date;
            PersonCost = personCost;
            EventCost = eventCost;
        }

        public Outing()
        {

        }
    }
}

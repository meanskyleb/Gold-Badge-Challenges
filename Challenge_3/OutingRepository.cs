using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    class OutingRepository
    {
        List<Outing> _listOfOutings = new List<Outing>();

        public void AddEventsToOuting(Outing content)
        {
            _listOfOutings.Add(content);
        }

        public List<Outing> GetOutingList()
        {
            return _listOfOutings;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    class ClaimRepository
    {
        List<Claim> _listOfClaim = new List<Claim>();

        public void AddIncidentsToList(Claim content)
        {
            _listOfClaim.Add(content);        
        }

        public List<Claim> GetClaimsList()
        {
            return _listOfClaim;
        }

        public void RemoveIncidentsFromList(Claim content)
        {
            _listOfClaim.Remove(content);
        }
    }
}

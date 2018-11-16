using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_4
{
    class BadgeRepository
    {
        Dictionary<int, List<string>> _badgeRepo = new Dictionary<int, List<string>>();

        public void AddBadgeIDToList(Badge badge)
        {
            _badgeRepo.Add(badge.BadgeID, badge.DoorNames);
        }

        public void UpdateBadgeID(Badge badge)
        {
            _badgeRepo[badge.BadgeID] = badge.DoorNames;
        }
        public void RemoveBadgeIDFromList(int badge)
        {
            _badgeRepo.Remove(badge);
        }

        public Dictionary<int, List<string>> GetDictionary()
        {
            return _badgeRepo;
        }

    }
}

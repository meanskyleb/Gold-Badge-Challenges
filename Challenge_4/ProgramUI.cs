using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_4
{
    class ProgramUI
    {
        BadgeRepository _badgeRepo = new BadgeRepository();
        List<string> doors = new List<string>();
        Dictionary<int, List<string>> _dict;
       
            private void RunMainMenu()
            {

            
        
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Welcome to Komodo Insurance, please choose an action:" +
                    "\n1. Create a new badge" +
                    "\n2. Update doors on Badge" +
                    "\n3. Delete doors on badge" +
                    "\n4. Show All Badges" +
                    "\n5. Exit");

                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        CreateBadge();
                        break;
                    case 2:
                        UpdateDoors();
                        break;
                    case 3:
                        DeleteBadge();
                        break;
                    case 4:
                        ShowBadges();
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

        private void CreateBadge()
        {
            List<string> doors = new List<string>();

            Console.WriteLine("what number do you want your badge id to be?");
            var id = int.Parse(Console.ReadLine());


            Console.WriteLine("would you like to add door access to this badge? (y/n)");
            string answer = Console.ReadLine().ToLower();
            while (answer.Contains("y"))
            {
                var door = Console.ReadLine();
                doors.Add(door);
                Console.ReadLine();

            }

            Badge badge = new Badge(id, doors);
            _badgeRepo.AddBadgeIDToList(badge);
        }

        private void UpdateDoors()
        {
            Dictionary<int, List<string>> _dict;
            _dict = _badgeRepo.GetDictionary();

            Console.WriteLine("what is the badge number you would like to update?");
            var id = int.Parse(Console.ReadLine());

            foreach (var badge in _dict)
            {
                bool isRunning = true;
                while (isRunning)
                {
                    if (badge.Key == id)
                    {
                        Console.WriteLine("please enter the door access:");
                        string input = Console.ReadLine();
                        doors.Add(input);

                        Console.WriteLine("Would you like to add more? (y/n)");
                        if (Console.ReadLine() == "y")
                        {
                            isRunning = true;
                        }
                        else
                        {
                            isRunning = false;
                        }
                    }
                }
            }
        }

        private void DeleteBadge()
        {
            ShowBadges();
            Console.WriteLine("what badge number would you like to delete?");
            var key = int.Parse(Console.ReadLine());
            _badgeRepo.RemoveBadgeIDFromList(key);

            Console.WriteLine("updated badge list:");
            ShowBadges();
            Console.ReadLine();
        }

        private void ShowBadges()
        {
            Console.WriteLine($"{"Badge",-8} {"DoorNames"}");
            foreach (KeyValuePair<int, List<string>> key in _badgeRepo.GetDictionary())
            {
                Console.WriteLine($"{key.Key,-8} {key.Value}");
            }

            Console.ReadLine();
        }
    }
}

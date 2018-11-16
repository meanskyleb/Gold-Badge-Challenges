using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    class ProgramUI
    {
        ClaimRepository _contentClaim = new ClaimRepository();

        public void Run()
        {
            RunClaimMenu();
        }

        private void RunClaimMenu()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Choose a menu item:" +
                    "\n1. View Claims" +
                    "\n2. Take care of next claim" +
                    "\n3. Enter new claim" +
                    "\n4. Exit");

                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        ViewClaims();
                        break;
                    case 2:
                        NextClaim();
                        break;
                    case 3:
                        NewClaim();
                        break;
                    case 4:
                        isRunning = false;
                        Console.WriteLine("thank you come again");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("invalid response");
                        Console.ReadLine();
                        break;
                }
            }


        }
    }
}

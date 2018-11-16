using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    class CafeRepository
    {
        List<Menu> _listOfMenu = new List<Menu>();

        public void AddMealsToMenu(Menu content)
        {
            _listOfMenu.Add(content);
        }

        public List<Menu> GetMenuList()
        {
            return _listOfMenu;
        }

        public void RemoveMealsFromMenu(Menu content)
        {
            _listOfMenu.Remove(content);
        }
    }
}

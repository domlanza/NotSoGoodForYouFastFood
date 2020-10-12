using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotSoGoodForYou
{
    class MenuInfo
    {

        private string[] hiddenNames = {"Hot Dog", "Hamburger", "French Fries", "BaconBurger",
            "Large Soda", "Cheese Steak", "Large Milkshake", "Bar-B-Que Ribs"};

        private decimal[] hiddenPrices = { 1.50m, 3.00m, 2.50m, 5.75m, 3.00m, 7.50m, 4.00m, 8.95m };


        //parameterless constructor
        public MenuInfo() {


        }
        
        // key is the key to the string array containing the name we want
        public string getMenuItemName(int key) {

            return hiddenNames[key];
        }

        // key is the key to the Decimal array containing the price we want
        public Decimal getMenuItemPrice(int key) {

            return hiddenPrices[key];
        }


    }
}

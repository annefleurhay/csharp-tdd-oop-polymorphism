using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Basket
    {
        //List<Game> games = new List<Game>();
        //List<Drink> drinks = new List<Drink>();
        //List<Book> books = new List<Book>();

        private List<IItem> items = new List<IItem>();

        public void add(IItem item)
        {
            items.Add(item);
        }

       
        

        public int getTotal()
        {
            int total = 0;

            foreach (var item in items)
            {
                total += item.Price;
            }

            return total;
        }

        public bool isInBasket(string name)
        {
           return items.Any(item => item.Name == name);
        }
    }
}

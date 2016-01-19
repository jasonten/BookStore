using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HarryPotterShoppingCar
{
    public class HarryPotterShoppingCar
    {
        public HarryPotterShoppingCar()
        {
            var booklists = new List<Product>()
            {
             new  Product(){ BookName = "HarryPotter1",BookCount = 5}
               , new Product(){ BookName = "HarryPotter2", BookCount = 1 }
               , new Product(){ BookName = "HarryPotter3", BookCount = 3 }
               , new Product(){ BookName = "HarryPotter4", BookCount = 4 }
               , new Product(){ BookName = "HarryPotter5", BookCount = 2 }
            };

            int price = 100;

            double Total = ShoppingCar(booklists, price);
        }

        public double ShoppingCar(List<Product> booklists, int price)
        {
            double Total = 0;
            int MaxCount = 0;
            MaxCount = booklists.Max(x => x.BookCount);

            while (MaxCount > 0)
            {
                int booksCount = 0;
                for (int books = 0; books < booklists.Count; books++)
                {
                    if (booklists[books].BookCount > 0)
                    {
                        booksCount += 1;
                        booklists[books].BookCount -= 1;
                    }
                }
                if (booksCount > 0)
                {
                    switch (booksCount)
                    {
                        case 2:
                            Total += booksCount * price * 0.95;
                            break;

                        case 3:
                            Total += booksCount * price * 0.9;
                            break;

                        case 4:
                            Total += booksCount * price * 0.8;
                            break;

                        case 5:
                            Total += booksCount * price * 0.75;
                            break;

                        default:
                            Total += price;
                            break;
                    }
                }
                MaxCount -= 1;
            }
            return Total;
        }
    }
    public class Product
    {
        public string BookName { get; set; }
        public int BookCount { get; set; }
    }
}

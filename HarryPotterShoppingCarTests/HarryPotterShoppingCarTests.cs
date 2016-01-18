using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace HarryPotterShoppingCar.Tests
{
    [TestClass()]
    public class HarryPotterShoppingCarTests
    {
        [TestMethod()]
        public void HarryPotterShoppingCarTest_buy_BookName_1_BookCount_1_Total_100()
        {

            List<BookList> BookLists = new List<BookList>()
            {
             new  BookList(){ BookName = "HarryPotter1",BookCount = 1}
            };
            int price = 100;

            var Total = 100;

            //act
            var actual = BookLists[0].BookCount * price;

            //assert
            Assert.AreEqual(Total, actual);
        }

        [TestMethod()]
        public void HarryPotterShoppingCarTests_buy_Book1_5_Book2_1_Book3_4_Book4_4_Book5_2_Total_1335()
        {
             var target = new HarryPotterShoppingCar();
            List<BookList> BookLists = new List<BookList>()
            {
             new  BookList(){ BookName = "HarryPotter1",BookCount = 5}
             , new  BookList(){ BookName = "HarryPotter2",BookCount = 1}
             , new  BookList(){ BookName = "HarryPotter3",BookCount = 4}
             ,  new  BookList(){ BookName = "HarryPotter4",BookCount = 4}
             , new  BookList(){ BookName = "HarryPotter5",BookCount = 2}
            };
            int price = 100;

            var Total = 1335;

            var actual = target.ShoppingCar(BookLists, price);

            Assert.AreEqual(Total, actual);
        }
    }
}